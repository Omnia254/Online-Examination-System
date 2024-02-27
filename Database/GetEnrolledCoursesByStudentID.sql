CREATE PROCEDURE GetEnrolledCoursesByStudentID
    @StudentID INT
AS
BEGIN
    SELECT
        C.CourseName
    FROM
        [dbo].[Enroll] E
    INNER JOIN
        [dbo].[Course] C ON E.CourseID = C.CourseID
    WHERE
        E.StudentID = @StudentID;
END

