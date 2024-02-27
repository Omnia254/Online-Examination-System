<<<<<<< HEAD
CREATE PROCEDURE GetExamIDbyStudentIDandCourseID
    @StudentID INT,
	@CourseID INT
AS
BEGIN
    SELECT
        E.ExamID
    FROM
        Student S
		INNER JOIN Grades G ON S.StudentId=G.StudentID
		INNER JOIN Exam E ON E.ExamID=G.ExamID
    WHERE
        S.StudentID = @StudentID AND E.CourseID=@CourseID;
END;
=======
CREATE PROCEDURE GetExamIDbyStudentIDandCourseID
    @StudentID INT,
	@CourseID INT
AS
BEGIN
    SELECT
        E.ExamID
    FROM
        Student S
		INNER JOIN Grades G ON S.StudentId=G.StudentID
		INNER JOIN Exam E ON E.ExamID=G.ExamID
    WHERE
        S.StudentID = @StudentID AND E.CourseID=@CourseID;
END;
>>>>>>> 79e27462d310e8e001baf81a5e76ccf20c9f653a
