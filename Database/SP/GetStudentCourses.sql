CREATE PROCEDURE GetStudentCourses
    @StudentID INT
AS
BEGIN
    SELECT
        C.*
    FROM
        Student S
		-- joins to connect student and course and grades
        INNER JOIN Enroll E ON S.StudentId=E.StudentID
		INNER JOIN Course C ON C.CourseID=E.CourseID
		INNER JOIN Exam EX ON Ex.CourseID=C.CourseID
		INNER JOIN Grades G ON S.StudentId=G.StudentID and G.ExamID= EX.ExamID
 
    WHERE
        S.StudentID = @StudentID;
END;