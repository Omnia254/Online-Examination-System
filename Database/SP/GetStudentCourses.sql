<<<<<<< HEAD
CREATE PROCEDURE GetStudentCourses
    @StudentID INT
AS
BEGIN
    SELECT
        C.CourseName,
        C.CourseID
    FROM
        Student S
		-- joins to connect student and course and grades
        INNER JOIN Enroll E ON S.StudentId=E.StudentID
		INNER JOIN Course C ON C.CourseID=E.CourseID
    WHERE
        S.StudentID = @StudentID;
END;
=======
CREATE PROCEDURE GetStudentCourses
    @StudentID INT
AS
BEGIN
    SELECT
        C.CourseName,
        C.CourseID
    FROM
        Student S
		-- joins to connect student and course and grades
        INNER JOIN Enroll E ON S.StudentId=E.StudentID
		INNER JOIN Course C ON C.CourseID=E.CourseID
    WHERE
        S.StudentID = @StudentID;
END;
>>>>>>> 79e27462d310e8e001baf81a5e76ccf20c9f653a
