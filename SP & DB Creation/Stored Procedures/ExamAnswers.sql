CREATE PROCEDURE ExamAnswers
    @Exam_ID INT, @Student_ID INT,
    @QID1 INT, @Ans1 INT,
    @QID2 INT, @Ans2 INT,
    @QID3 INT, @Ans3 INT,
    @QID4 INT, @Ans4 INT,
    @QID5 INT, @Ans5 INT,
    @QID6 INT, @Ans6 INT,
    @QID7 INT, @Ans7 INT,
    @QID8 INT, @Ans8 INT,
    @QID9 INT, @Ans9 INT,
    @QID10 INT, @Ans10 INT
AS
BEGIN
	BEGIN TRY
		-- Validate StudentID
		IF NOT EXISTS (SELECT 1 FROM Student WHERE StudentID = @Student_ID)
		BEGIN
			THROW 50000, 'Invalid StudentID!!', 1
			RETURN
		END

		-- Validate ExamID
		IF NOT EXISTS (SELECT 1 FROM Exam WHERE ExamID = @Exam_ID)
		BEGIN
			THROW 50000, 'Invalid ExamID!!', 1
			RETURN
		END

		IF EXISTS (SELECT 1 FROM Answer WHERE ExamID = @Exam_ID)
		BEGIN
			THROW 50000, 'ExamID Repeated!!', 1
			RETURN
		END

		-- Validate all QuestionIDs
		IF (
			NOT EXISTS (SELECT 1 FROM Question WHERE QuestionID = @QID1) OR
			NOT EXISTS (SELECT 1 FROM Question WHERE QuestionID = @QID2) OR
			NOT EXISTS (SELECT 1 FROM Question WHERE QuestionID = @QID3) OR
			NOT EXISTS (SELECT 1 FROM Question WHERE QuestionID = @QID4) OR
			NOT EXISTS (SELECT 1 FROM Question WHERE QuestionID = @QID5) OR
			NOT EXISTS (SELECT 1 FROM Question WHERE QuestionID = @QID6) OR
			NOT EXISTS (SELECT 1 FROM Question WHERE QuestionID = @QID7) OR
			NOT EXISTS (SELECT 1 FROM Question WHERE QuestionID = @QID8) OR
			NOT EXISTS (SELECT 1 FROM Question WHERE QuestionID = @QID9) OR
			NOT EXISTS (SELECT 1 FROM Question WHERE QuestionID = @QID10)
		)
		BEGIN
			THROW 50000, 'Invalid QuestionID', 1
			RETURN
		END

		-- Insert Answers for the specified exam, student, and questions
		INSERT INTO Answer (ExamID, StudentID, QuestionID, Answer)
		VALUES
			(@Exam_ID, @Student_ID, @QID1, @Ans1),
			(@Exam_ID, @Student_ID, @QID2, @Ans2),
			(@Exam_ID, @Student_ID, @QID3, @Ans3),
			(@Exam_ID, @Student_ID, @QID4, @Ans4),
			(@Exam_ID, @Student_ID, @QID5, @Ans5),
			(@Exam_ID, @Student_ID, @QID6, @Ans6),
			(@Exam_ID, @Student_ID, @QID7, @Ans7),
			(@Exam_ID, @Student_ID, @QID8, @Ans8),
			(@Exam_ID, @Student_ID, @QID9, @Ans9),
			(@Exam_ID, @Student_ID, @QID10, @Ans10);
	END TRY
    BEGIN CATCH
        -- If an error occurs, print an error message
        PRINT 'AN ERROR OCCURRED: ' + ERROR_MESSAGE();
    END CATCH;
END;