

CREATE PROCEDURE GetDistinctExamIDs
    @CourseID INT
AS
BEGIN

    -- Check if @CourseID is not null and greater than 0
    IF @CourseID IS NULL OR @CourseID <= 0
    BEGIN
        PRINT 'Error: CourseID parameter must be a positive integer.'
        RETURN
    END

    -- Main query
    SELECT DISTINCT E.ExamID ,E.ExamDate,E.InstructorID,E.CourseID 
    FROM Exam AS E
    INNER JOIN ExamQuestion AS EQ ON E.ExamID = EQ.ExamID
    INNER JOIN Question AS Q ON Q.QuestionID = EQ.QuestionID
    WHERE E.ExamID NOT IN (SELECT ExamId FROM Answer)
    AND E.CourseID = @CourseID
END