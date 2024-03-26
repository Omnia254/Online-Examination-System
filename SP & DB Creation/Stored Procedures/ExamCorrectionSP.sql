
ALTER PROCEDURE [dbo].[ExamCorrection]
    @ExId INT,
    @StId INT,
    @CID INT,
    @TotalScore INT OUTPUT
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

        -- Declare variable to store the score of the student
        SET @TotalScore = 0

        -- Calculate the total score for the student
        SELECT @TotalScore = (
                SELECT COUNT(DISTINCT Answer)
                FROM Exam E
                    JOIN ExamQuestion EQ ON E.ExamID = EQ.ExamID
                    JOIN Question Q ON EQ.QuestionID = Q.QuestionID
                    JOIN Choice C ON EQ.QuestionID = C.QuestionID
                    JOIN Answer A ON C.ChoiceID = A.Answer AND A.StudentID = @StId
                WHERE E.ExamID = @ExId AND A.ExamID = @ExId AND C.IsCorrect = 1
            )*10

        -- Update or insert the score into the Grades table
      IF EXISTS (SELECT 1 FROM Grades G
                   JOIN Exam E ON G.ExamID = E.ExamID
                   WHERE G.StudentID = @StId AND E.CourseID = @CID AND G.ExamID <> @ExId)
        BEGIN
            UPDATE Grades
			SET Score = @TotalScore,
				ExamID = @ExId
			WHERE StudentID = @StId AND ExamID = (SELECT G.ExamID 
												  FROM Grades G, Exam E
												  WHERE G.ExamID = E.ExamID AND E.CourseID = @CID 
																			AND G.StudentID = @StId)
        END
        ELSE
        BEGIN
            INSERT INTO Grades (ExamID, StudentID, Score)
            VALUES (@ExId, @StId, @TotalScore)
        END

        -- Return the total score
        SELECT @TotalScore AS TotalScore
    END TRY
    BEGIN CATCH
        SELECT 'Error: ' + ERROR_MESSAGE()
    END CATCH
END
---