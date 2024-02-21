Create PROCEDURE ExamCorrection
    @ExId INT,
    @StId INT,
    @CID INT
AS
BEGIN
    BEGIN TRY
        -- Validation on StId
        IF NOT EXISTS (SELECT S.StudentId FROM Student S WHERE S.StudentId = @StId)
        BEGIN
            SELECT 'Student does not exist'
            RETURN
        END

        -- Validation on ExId
        IF NOT EXISTS (SELECT E.ExamID FROM Exam E WHERE E.ExamID = @ExId)
        BEGIN
            SELECT 'Exam does not exist'
            RETURN
        END

        -- Validation on CId
        IF NOT EXISTS (SELECT CourseID FROM Course WHERE CourseID = @CID)
        BEGIN
            SELECT 'Course does not exist'
            RETURN
        END

        -- Declare variable to store the score of the student
        DECLARE @TotalScore INT = 0

        -- Calculate the total score for the student
        SELECT @TotalScore += (
                SELECT  COUNT( DISTINCT Answer)
                FROM Exam E
                    JOIN ExamQuestion EQ ON E.ExamID = EQ.ExamID
                    JOIN Question Q ON EQ.QuestionID = Q.QuestionID
                    JOIN Choice C ON EQ.QuestionID = C.QuestionID
                    JOIN Answer A ON C.ChoiceID = A.Answer AND A.StudentID = @StId
                WHERE E.ExamID = @ExId AND C.IsCorrect = 1
            )

        SELECT @TotalScore

        -- Update or insert the score into the Grades table
      IF EXISTS (SELECT 1 FROM Grades WHERE ExamID = @ExId AND StudentID = @StId)
        BEGIN
            UPDATE Grades
            SET Score = @TotalScore
            WHERE ExamID = @ExId AND StudentID = @StId
        END
        ELSE
        BEGIN
            INSERT INTO Grades (ExamID, StudentID, Score)
            VALUES (@ExId, @StId, @TotalScore)
        END
    END TRY
    BEGIN CATCH
        SELECT 'Error' + ERROR_MESSAGE()
    END CATCH
END