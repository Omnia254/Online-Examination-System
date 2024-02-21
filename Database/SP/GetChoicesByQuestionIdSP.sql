CREATE PROCEDURE GetChoicesByQuestionId
    @QuestionID INT
AS
BEGIN
    SELECT
        ChoiceID,
        ChoiceText
    FROM Choice
    WHERE QuestionID = @QuestionID;
END;

DECLARE @QuestionID INT = 1; -- Replace with the desired QuestionID

EXEC GetChoicesByQuestionId @QuestionID;
