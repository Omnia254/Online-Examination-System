CREATE PROCEDURE GetExamReport
    @ExamID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        Q.QuestionID,
        Q.QuestionText,
        Q.QuestionType,
        C.ChoiceID,
        C.ChoiceText,
        C.IsCorrect
    FROM 
        Exam E
        INNER JOIN ExamQuestion EQ ON E.ExamID = EQ.ExamID
        INNER JOIN Question Q ON EQ.QuestionID = Q.QuestionID
        INNER JOIN Choice C ON Q.QuestionID = C.QuestionID
    WHERE 
        E.ExamID = @ExamID;

END;

EXEC GetExamReport @ExamID =2 ;
