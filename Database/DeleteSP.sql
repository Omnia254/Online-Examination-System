-- Stored Procedure for deleting from Answer table
-- This procedure deletes answers from the Answer table based on the provided ExamID, StudentID, and QuestionID.
-- Parameters:
--   @ExamID - The ID of the exam.
--   @StudentID - The ID of the student.
--   @QuestionID - The ID of the question.
CREATE PROCEDURE DeleteAnswer
    @ExamID INT = NULL,
    @StudentID INT = NULL,
    @QuestionID INT = NULL
AS
BEGIN
    -- Declare variables
    DECLARE @SQL NVARCHAR(1000)

    -- Initialize dynamic SQL statement
    SET @SQL = 'DELETE FROM Answer WHERE 1=1'

    -- Check if ExamID parameter is provided
    IF @ExamID IS NOT NULL
        SET @SQL = @SQL + ' AND ExamID = ' + CAST(@ExamID AS NVARCHAR(10))

    -- Check if StudentID parameter is provided
    IF @StudentID IS NOT NULL
        SET @SQL = @SQL + ' AND StudentID = ' + CAST(@StudentID AS NVARCHAR(10))

    -- Check if QuestionID parameter is provided
    IF @QuestionID IS NOT NULL
        SET @SQL = @SQL + ' AND QuestionID = ' + CAST(@QuestionID AS NVARCHAR(10))

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL
END

-- Stored Procedure for deleting from ExamQuestion table
-- This procedure deletes records from the ExamQuestion table based on ExamID and QuestionID.
-- Parameters:
--   @ExamID - The ID of the exam.
--   @QuestionID - The ID of the question.
CREATE PROCEDURE DeleteExamQuestion
    @ExamID INT,
    @QuestionID INT
AS
BEGIN
    -- Declare variables
    DECLARE @SQL NVARCHAR(1000)

    -- Initialize dynamic SQL statement
    SET @SQL = 'DELETE FROM ExamQuestion WHERE 1=1'

    -- Check if ExamID parameter is provided
    IF @ExamID IS NOT NULL
        SET @SQL = @SQL + ' AND ExamID = ' + CAST(@ExamID AS NVARCHAR(10))

    -- Check if QuestionID parameter is provided
    IF @QuestionID IS NOT NULL
        SET @SQL = @SQL + ' AND QuestionID = ' + CAST(@QuestionID AS NVARCHAR(10))

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL
END

-- Stored Procedure for deleting from Grades table
-- This procedure deletes records from the Grades table based on StudentID and CourseID.
-- Parameters:
--   @StudentID - The ID of the student.
--   @CourseID - The ID of the course.
CREATE PROCEDURE DeleteGrades
    @StudentID INT,
    @CourseID INT
AS
BEGIN
    -- Declare variables
    DECLARE @SQL NVARCHAR(1000)

    -- Initialize dynamic SQL statement
    SET @SQL = 'DELETE FROM Grades WHERE 1=1'

    -- Check if StudentID parameter is provided
    IF @StudentID IS NOT NULL
        SET @SQL = @SQL + ' AND StudentID = ' + CAST(@StudentID AS NVARCHAR(10))

    -- Check if CourseID parameter is provided
    IF @CourseID IS NOT NULL
        SET @SQL = @SQL + ' AND CourseID = ' + CAST(@CourseID AS NVARCHAR(10))

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL
END

-- Stored Procedure for deleting from Course table
-- This procedure deletes a course from the Course table based on the provided CourseID.
-- Parameters:
--   @CourseID - The ID of the course to be deleted.
CREATE PROCEDURE DeleteCourse
    @CourseID INT
AS
BEGIN
    -- Declare variables
    DECLARE @SQL NVARCHAR(1000)

    -- Initialize dynamic SQL statement
    SET @SQL = 'DELETE FROM Course WHERE 1=1'

    -- Check if CourseID parameter is provided
    IF @CourseID IS NOT NULL
        SET @SQL = @SQL + ' AND CourseID = ' + CAST(@CourseID AS NVARCHAR(10))

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL
END

-- Stored Procedure for deleting from Topic table
-- This procedure deletes a topic from the Topic table based on the provided TopicID.
-- Parameters:
--   @TopicID - The ID of the topic to be deleted.
CREATE PROCEDURE DeleteTopic
    @TopicID INT
AS
BEGIN
    -- Declare variables
    DECLARE @SQL NVARCHAR(1000)

    -- Initialize dynamic SQL statement
    SET @SQL = 'DELETE FROM Topic WHERE 1=1'

    -- Check if TopicID parameter is provided
    IF @TopicID IS NOT NULL
        SET @SQL = @SQL + ' AND TopicID = ' + CAST(@TopicID AS NVARCHAR(10))

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL
END

-- Stored Procedure for deleting from StudentExam table
-- This procedure deletes records from the StudentExam table based on ExamID and StudentID.
-- Parameters:
--   @ExamID - The ID of the exam.
--   @StudentID - The ID of the student.
CREATE PROCEDURE DeleteStudentExam
    @ExamID INT,
    @StudentID INT
AS
BEGIN
    -- Declare variables
    DECLARE @SQL NVARCHAR(1000)

    -- Initialize dynamic SQL statement
    SET @SQL = 'DELETE FROM StudentExam WHERE 1=1'

    -- Check if ExamID parameter is provided
    IF @ExamID IS NOT NULL
        SET @SQL = @SQL + ' AND ExamID = ' + CAST(@ExamID AS NVARCHAR(10))

    -- Check if StudentID parameter is provided
    IF @StudentID IS NOT NULL
        SET @SQL = @SQL + ' AND StudentID = ' + CAST(@StudentID AS NVARCHAR(10))

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL
END

-- Stored Procedure for deleting from Exam table
-- This procedure deletes an exam from the Exam table based on the provided ExamID.
-- Parameters:
--   @ExamID - The ID of the exam to be deleted.
CREATE PROCEDURE DeleteExam
    @ExamID INT
AS
BEGIN
    -- Declare variables
    DECLARE @SQL NVARCHAR(1000)

    -- Initialize dynamic SQL statement
    SET @SQL = 'DELETE FROM Exam WHERE 1=1'

    -- Check if ExamID parameter is provided
    IF @ExamID IS NOT NULL
        SET @SQL = @SQL + ' AND ExamID = ' + CAST(@ExamID AS NVARCHAR(10))

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL
END
-- Stored Procedure for deleting from Choice table
-- This procedure deletes a choice from the Choice table based on the provided ChoiceID.
-- Parameters:
--   @ChoiceID - The ID of the choice to be deleted.
CREATE PROCEDURE DeleteChoice
    @ChoiceID INT
AS
BEGIN
    -- Declare variables
    DECLARE @SQL NVARCHAR(1000)

    -- Initialize dynamic SQL statement
    SET @SQL = 'DELETE FROM Choice WHERE 1=1'

    -- Check if ChoiceID parameter is provided
    IF @ChoiceID IS NOT NULL
        SET @SQL = @SQL + ' AND ChoiceID = ' + CAST(@ChoiceID AS NVARCHAR(10))

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL
END
-- Stored Procedure for deleting from Question table
-- This procedure deletes a question from the Question table based on the provided QuestionID.
-- Parameters:
--   @QuestionID - The ID of the question to be deleted.
CREATE PROCEDURE DeleteQuestion
    @QuestionID INT
AS
BEGIN
    -- Declare variables
    DECLARE @SQL NVARCHAR(1000)

    -- Initialize dynamic SQL statement
    SET @SQL = 'DELETE FROM Question WHERE 1=1'

    -- Check if QuestionID parameter is provided
    IF @QuestionID IS NOT NULL
        SET @SQL = @SQL + ' AND QuestionID = ' + CAST(@QuestionID AS NVARCHAR(10))

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL
END

-- Stored Procedure for deleting from Instructor table
-- This procedure deletes an instructor from the Instructor table based on the provided InstructorID.
-- Parameters:
--   @InstructorID - The ID of the instructor to be deleted.
CREATE PROCEDURE DeleteInstructor
    @InstructorID INT
AS
BEGIN
    -- Declare variables
    DECLARE @SQL NVARCHAR(1000)

    -- Initialize dynamic SQL statement
    SET @SQL = 'DELETE FROM Instructor WHERE 1=1'

    -- Check if InstructorID parameter is provided
    IF @InstructorID IS NOT NULL
        SET @SQL = @SQL + ' AND InstructorID = ' + CAST(@InstructorID AS NVARCHAR(10))

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL
END

-- Stored Procedure for deleting from Student table
-- This procedure deletes a student from the Student table based on the provided StudentID.
-- Parameters:
--   @StudentID - The ID of the student to be deleted.
CREATE PROCEDURE DeleteStudent
    @StudentID INT
AS
BEGIN
    -- Declare variables
    DECLARE @SQL NVARCHAR(1000)

    -- Initialize dynamic SQL statement
    SET @SQL = 'DELETE FROM Student WHERE 1=1'

    -- Check if StudentID parameter is provided
    IF @StudentID IS NOT NULL
        SET @SQL = @SQL + ' AND StudentID = ' + CAST(@StudentID AS NVARCHAR(10))

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL
END
-- Stored Procedure for deleting from Department table
-- This procedure deletes a department from the Department table based on the provided DepartmentID.
-- Parameters:
--   @DepartmentID - The ID of the department to be deleted.
CREATE PROCEDURE DeleteDepartment
    @DepartmentID INT
AS
BEGIN
    -- Declare variables
    DECLARE @SQL NVARCHAR(1000)

    -- Initialize dynamic SQL statement
    SET @SQL = 'DELETE FROM Department WHERE 1=1'

    -- Check if DepartmentID parameter is provided
    IF @DepartmentID IS NOT NULL
        SET @SQL = @SQL + ' AND DepartmentID = ' + CAST(@DepartmentID AS NVARCHAR(10))

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL
END

-- Stored Procedure for deleting from Teach table
-- This procedure deletes records from the Teach table based on CourseID and InstructorID.
-- Parameters:
--   @CourseID - The ID of the course.
--   @InstructorID - The ID of the instructor.
CREATE PROCEDURE DeleteTeach
    @CourseID INT,
    @InstructorID INT
AS
BEGIN
    -- Declare variables
    DECLARE @SQL NVARCHAR(1000)

    -- Initialize dynamic SQL statement
    SET @SQL = 'DELETE FROM Teach WHERE 1=1'

    -- Check if CourseID parameter is provided
    IF @CourseID IS NOT NULL
        SET @SQL = @SQL + ' AND CourseID = ' + CAST(@CourseID AS NVARCHAR(10))

    -- Check if InstructorID parameter is provided
    IF @InstructorID IS NOT NULL
        SET @SQL = @SQL + ' AND InstructorID = ' + CAST(@InstructorID AS NVARCHAR(10))

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL
END



