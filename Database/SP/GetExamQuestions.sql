CREATE PROCEDURE GetExamQuestions
	@Exam_ID INT,
    @QID1 INT OUT,
    @QID2 INT OUT,
    @QID3 INT OUT,
    @QID4 INT OUT,
    @QID5 INT OUT,
    @QID6 INT OUT,
    @QID7 INT OUT,
    @QID8 INT OUT,
    @QID9 INT OUT,
    @QID10 INT OUT
AS
BEGIN
    WITH RankedQuestions AS (
        SELECT 
			QuestionID,
			ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS RowNum
		FROM ExamQuestion
		WHERE ExamID = @Exam_ID
    )
    SELECT
        @QID1 = MAX(CASE WHEN RowNum = 1 THEN QuestionID END),
        @QID2 = MAX(CASE WHEN RowNum = 2 THEN QuestionID END),
        @QID3 = MAX(CASE WHEN RowNum = 3 THEN QuestionID END),
        @QID4 = MAX(CASE WHEN RowNum = 4 THEN QuestionID END),
        @QID5 = MAX(CASE WHEN RowNum = 5 THEN QuestionID END),
        @QID6 = MAX(CASE WHEN RowNum = 6 THEN QuestionID END),
        @QID7 = MAX(CASE WHEN RowNum = 7 THEN QuestionID END),
        @QID8 = MAX(CASE WHEN RowNum = 8 THEN QuestionID END),
        @QID9 = MAX(CASE WHEN RowNum = 9 THEN QuestionID END),
        @QID10 = MAX(CASE WHEN RowNum = 10 THEN QuestionID END)
    FROM RankedQuestions;
END;