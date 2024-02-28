CREATE PROCEDURE EnrollStudentInCourse
    @StudentID INT,
    @CourseID INT,
    @EnrollmentStatus NVARCHAR(100) OUTPUT
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1
        FROM Enroll
        WHERE StudentID = @StudentID AND CourseID = @CourseID
    )
    BEGIN
        INSERT INTO Enroll (StudentID, CourseID)
        VALUES (@StudentID, @CourseID);

        SET @EnrollmentStatus = 'Enrollment successful';
    END
    ELSE
    BEGIN
        SET @EnrollmentStatus = 'Student is already enrolled in the course';
    END
END



