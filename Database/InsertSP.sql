CREATE PROC INSERTCOURSE
@COL2DATA NVARCHAR(50),
@COL3DATA INT
AS
BEGIN

    -- Insert the values
    INSERT INTO Course ( CourseName, TopicID)
    VALUES ( @COL2DATA, @COL3DATA);


END
GO

Create PROC InsertTOPIC 
@COL2DATA NVARCHAR(100)
AS
BEGIN

   -- Insert the values
    INSERT INTO Topic (TopicTitle)
    VALUES ( @COL2DATA);

END


CREATE PROCEDURE GetEnrolledStudentCourses
	@StudentID INT
AS
BEGIN
	SELECT C.CourseID, C.CourseName,C.TopicID
	FROM Course C, Enroll E
	WHERE C.CourseID = E.CourseID AND StudentID = @StudentID
END



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





