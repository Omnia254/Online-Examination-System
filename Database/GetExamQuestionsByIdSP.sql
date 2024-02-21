--GetExamQuestionsById
CREATE PROCEDURE GetExamQuestionsById
    @ExamID INT
AS
BEGIN
    SELECT DISTINCT
        EQ.ExamID,
        Q.QuestionID,
        Q.QuestionText
    FROM ExamQuestion EQ
    JOIN Question Q ON EQ.QuestionID = Q.QuestionID
    WHERE EQ.ExamID = @ExamID;
END;

DECLARE @ExamID INT = 4;
EXEC GetExamQuestionsById @ExamID;

--GetTextOnly

alter PROCEDURE GetExamQuestionsTextById
    @ExamID INT
AS
BEGIN
    SELECT DISTINCT
	 Q.QuestionID,
        Q.QuestionText
    FROM ExamQuestion EQ
    JOIN Question Q ON EQ.QuestionID = Q.QuestionID
    WHERE EQ.ExamID = @ExamID;
END;

DECLARE @ExamID INT = 4;
EXEC GetExamQuestionsTextById @ExamID;







