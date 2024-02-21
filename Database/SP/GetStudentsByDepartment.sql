CREATE PROCEDURE GetStudentsByDepartment @Department_ID INT
AS
BEGIN
	-- Validate DepartmentID
    IF NOT EXISTS (SELECT 1 FROM Department WHERE DepartmentID = @Department_ID)
    BEGIN
        SELECT 'Invalid DepartmentID'
        RETURN
    END

	-- Get Students Information based on DepartmentID
    SELECT StudentID, FirstName, LastName, Address, Email, PhoneNum
    FROM Student
    WHERE DepartmentID = @Department_ID
END
