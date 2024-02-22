CREATE PROCEDURE GetStudentGrades
    @StudentID INT
AS
BEGIN
    SELECT
        C.CourseName,
        G.Score
    FROM
        Student S
		-- joins to connect student and course and grades
        INNER JOIN Grades G ON S.StudentID = G.StudentID
		INNER JOIN Exam E ON E.ExamID=G.ExamID
        INNER JOIN Course C ON E.CourseID = C.CourseID
    WHERE
        S.StudentID = @StudentID;
END;
