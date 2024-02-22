CREATE PROCEDURE GetInstructorCoursesAndStudents
    @InstructorID INT
AS
BEGIN
	IF NOT EXISTS(SELECT InstructorID FROM Instructor WHERE InstructorID = @InstructorID)
	  BEGIN
	     SELECT 'This instructor is not exists'
	  END
    -- Query to retrieve courses taught by the specified instructor and the number of students per course
    SELECT
        C.CourseName,
        COUNT(S.StudentID) AS NumberOfStudents
    FROM
        Instructor I
		JOIN Teach T ON I.InstructorID=T.InstructorID
        JOIN Course C ON C.CourseID = T.CourseID
		JOIN Enroll E ON C.CourseID=E.CourseID
		JOIN Student S ON S.StudentId=E.StudentID
    WHERE
        I.InstructorID = @InstructorID
    GROUP BY
        C.CourseName, C.CourseID;
END;