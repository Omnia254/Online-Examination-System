CREATE PROCEDURE GetEnrolledStudentCourses
	@StudentID INT
AS
BEGIN
	SELECT C.CourseID, C.CourseName,C.TopicID
	FROM Course C, Enroll E
	WHERE C.CourseID = E.CourseID AND StudentID = @StudentID
END