-- Create a stored procedure
CREATE PROCEDURE GetExamReportWithModelAnswer
    @ExamNumber INT, -- Input parameter: Exam number to filter the results
    @StudentID INT    -- Input parameter: Student ID to filter the results
AS
BEGIN
    BEGIN TRY
        -- Validate input
        IF @ExamNumber IS NULL OR @StudentID IS NULL
        BEGIN
            -- If either ExamNumber or StudentID is NULL, raise an error and exit
            THROW 50000, 'Exam number and student ID are required.', 1;
            RETURN;
        END

        -- Check if the exam exists
        IF NOT EXISTS (SELECT 1 FROM Exam WHERE ExamID = @ExamNumber)
        BEGIN
            -- If the specified exam does not exist, raise an error and exit
            THROW 50000, 'Invalid exam number.', 1;
            RETURN;
        END

        -- Check if the student exists
        IF NOT EXISTS (SELECT 1 FROM Student WHERE StudentId = @StudentID)
        BEGIN
            -- If the specified student does not exist, raise an error and exit
            THROW 50000, 'Invalid student ID.', 1;
            RETURN;
        END

		IF NOT EXISTS (SELECT 1 FROM Answer WHERE StudentId = @StudentID AND ExamID = @ExamNumber)
        BEGIN
            THROW 50000, 'Student Not Assigned In This Exam!', 1;
            RETURN;
        END

        SELECT 
            Q.QuestionID,              -- ID of the question
            Q.QuestionText,            -- Text of the question
            QCA.ChoiceText AS StudentAnswer,  -- Answer provided by the student
            QC.ChoiceText AS ModelAnswer -- Model answer for the question
        FROM 
            Exam E
        INNER JOIN 
            ExamQuestion EQ ON E.ExamID = EQ.ExamID
        INNER JOIN 
            Question Q ON EQ.QuestionID = Q.QuestionID
        LEFT JOIN 
            Choice QC ON Q.QuestionID = QC.QuestionID AND QC.IsCorrect = 1
		LEFT JOIN 
        Answer A ON E.ExamID = A.ExamID AND Q.QuestionID = A.QuestionID AND A.StudentID = @StudentID
		JOIN
		Choice QCA ON QCA.ChoiceID = A.Answer
        WHERE 
            E.ExamID = @ExamNumber AND (A.StudentID = @StudentID OR A.StudentID IS NULL);
    END TRY
    BEGIN CATCH
        -- If an error occurs, print an error message
        PRINT 'An error occurred: ' + ERROR_MESSAGE();
    END CATCH;
END;