CREATE PROCEDURE GetExamIDbyStudentIDandCourseID
    @StudentID INT,
	@CourseID INT
AS
BEGIN
    SELECT
        E.*
    FROM
        Student S
		INNER JOIN Grades G ON S.StudentId=G.StudentID
		INNER JOIN Exam E ON E.ExamID=G.ExamID
    WHERE
        S.StudentID = @StudentID AND E.CourseID=@CourseID;
END;