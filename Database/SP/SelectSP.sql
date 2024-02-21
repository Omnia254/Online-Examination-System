-- Stored Procedure for selecting from the Answer table
CREATE PROCEDURE SelectALLAnswer
AS
BEGIN
    SELECT * FROM Answer;
END

-- Stored Procedure for selecting from the ExamQuestion table
CREATE PROCEDURE SelectALLExamQuestion
AS
BEGIN
    SELECT ExamID, QuestionID FROM ExamQuestion;
END

-- Stored Procedure for selecting from the Grades table
CREATE PROCEDURE SelectALLGrades
AS
BEGIN
    SELECT * FROM Grades;
END

-- Stored Procedure for selecting from the Course table
CREATE PROCEDURE SelectALLCourse
AS
BEGIN
    SELECT * FROM Course;
END

-- Stored Procedure for selecting from the Topic table
CREATE PROCEDURE SelectALLTopic
AS
BEGIN
    SELECT * FROM Topic;
END

-- Stored Procedure for selecting from the StudentExam table
CREATE PROCEDURE SelectALLStudentExam
AS
BEGIN
    SELECT * FROM StudentExam;
END

-- Stored Procedure for selecting from the Exam table
CREATE PROCEDURE SelectALLExam
AS
BEGIN
    SELECT * FROM Exam;
END

-- Stored Procedure for selecting from the Choice table
CREATE PROCEDURE SelectALLChoice
AS
BEGIN
    SELECT * FROM Choice;
END

-- Stored Procedure for selecting from the Question table
CREATE PROCEDURE SelectALLQuestion
AS
BEGIN
    SELECT * FROM Question;
END

-- Stored Procedure for selecting from the Instructor table
CREATE PROCEDURE SelectALLInstructor
AS
BEGIN
    SELECT * FROM Instructor;
END

-- Stored Procedure for selecting from the Student table
CREATE PROCEDURE SelectALLStudent
AS
BEGIN
    SELECT * FROM Student;
END

-- Stored Procedure for selecting from the Department table
CREATE PROCEDURE SelectALLDepartment
AS
BEGIN
    SELECT * FROM Department;
END

-- Stored Procedure for selecting from the Teach table
CREATE PROCEDURE SelectALLTeach
AS
BEGIN
    SELECT * FROM Teach;
END



-- Stored Procedure for selecting dynamic data from the Answer table
CREATE PROCEDURE SelectAnswer
    @ExamID INT = NULL,
    @StudentID INT = NULL,
    @QuestionID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT * FROM Answer WHERE 1=1'

    IF @ExamID IS NOT NULL
        SET @SQL = @SQL + ' AND ExamID = ' + CAST(@ExamID AS NVARCHAR(10))

    IF @StudentID IS NOT NULL
        SET @SQL = @SQL + ' AND StudentID = ' + CAST(@StudentID AS NVARCHAR(10))

    IF @QuestionID IS NOT NULL
        SET @SQL = @SQL + ' AND QuestionID = ' + CAST(@QuestionID AS NVARCHAR(10))

    EXEC sp_executesql @SQL
END

-- Stored Procedure for selecting dynamic data from the ExamQuestion table
CREATE PROCEDURE SelectExamQuestion
    @ExamID INT = NULL,
    @QuestionID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT * FROM ExamQuestion WHERE 1=1'

    IF @ExamID IS NOT NULL
        SET @SQL = @SQL + ' AND ExamID = ' + CAST(@ExamID AS NVARCHAR(10))

    IF @QuestionID IS NOT NULL
        SET @SQL = @SQL + ' AND QuestionID = ' + CAST(@QuestionID AS NVARCHAR(10))

    EXEC sp_executesql @SQL
END

-- Stored Procedure for selecting dynamic data from the Grades table
CREATE PROCEDURE SelectGrades
    @StudentID INT = NULL,
    @CourseID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT * FROM Grades WHERE 1=1'

    IF @StudentID IS NOT NULL
        SET @SQL = @SQL + ' AND StudentID = ' + CAST(@StudentID AS NVARCHAR(10))

    IF @CourseID IS NOT NULL
        SET @SQL = @SQL + ' AND CourseID = ' + CAST(@CourseID AS NVARCHAR(10))

    EXEC sp_executesql @SQL
END

-- Stored Procedure for selecting dynamic data from the Course table
CREATE PROCEDURE SelectCourse
    @CourseID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT * FROM Course WHERE 1=1'

    IF @CourseID IS NOT NULL
        SET @SQL = @SQL + ' AND CourseID = ' + CAST(@CourseID AS NVARCHAR(10))

    EXEC sp_executesql @SQL
END

-- Stored Procedure for selecting dynamic data from the Topic table
CREATE PROCEDURE SelectTopic
    @TopicID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT * FROM Topic WHERE 1=1'

    IF @TopicID IS NOT NULL
        SET @SQL = @SQL + ' AND TopicID = ' + CAST(@TopicID AS NVARCHAR(10))

    EXEC sp_executesql @SQL
END

-- Stored Procedure for selecting dynamic data from the StudentExam table
CREATE PROCEDURE SelectStudentExam
    @ExamID INT = NULL,
    @StudentID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT * FROM StudentExam WHERE 1=1'

    IF @ExamID IS NOT NULL
        SET @SQL = @SQL + ' AND ExamID = ' + CAST(@ExamID AS NVARCHAR(10))

    IF @StudentID IS NOT NULL
        SET @SQL = @SQL + ' AND StudentID = ' + CAST(@StudentID AS NVARCHAR(10))

    EXEC sp_executesql @SQL
END

-- Stored Procedure for selecting dynamic data from the Exam table
CREATE PROCEDURE SelectExam
    @ExamID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT * FROM Exam WHERE 1=1'

    IF @ExamID IS NOT NULL
        SET @SQL = @SQL + ' AND ExamID = ' + CAST(@ExamID AS NVARCHAR(10))

    EXEC sp_executesql @SQL
END

-- Stored Procedure for selecting dynamic data from the Choice table
CREATE PROCEDURE SelectChoice
    @ChoiceID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT * FROM Choice WHERE 1=1'

    IF @ChoiceID IS NOT NULL
        SET @SQL = @SQL + ' AND ChoiceID = ' + CAST(@ChoiceID AS NVARCHAR(10))

    EXEC sp_executesql @SQL
END

-- Stored Procedure for selecting dynamic data from the Question table
CREATE PROCEDURE SelectQuestion
    @QuestionID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT * FROM Question WHERE 1=1'

    IF @QuestionID IS NOT NULL
        SET @SQL = @SQL + ' AND QuestionID = ' + CAST(@QuestionID AS NVARCHAR(10))

    EXEC sp_executesql @SQL
END

-- Stored Procedure for selecting dynamic data from the Instructor table
CREATE PROCEDURE SelectInstructor
    @InstructorID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT * FROM Instructor WHERE 1=1'

    IF @InstructorID IS NOT NULL
        SET @SQL = @SQL + ' AND InstructorID = ' + CAST(@InstructorID AS NVARCHAR(10))

    EXEC sp_executesql @SQL
END

-- Stored Procedure for selecting dynamic data from the Student table
CREATE PROCEDURE SelectStudent
    @StudentID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT * FROM Student WHERE 1=1'

    IF @StudentID IS NOT NULL
        SET @SQL = @SQL + ' AND StudentID = ' + CAST(@StudentID AS NVARCHAR(10))

    EXEC sp_executesql @SQL
END

-- Stored Procedure for selecting dynamic data from the Department table
CREATE PROCEDURE SelectDepartment
    @DepartmentID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT * FROM Department WHERE 1=1'

    IF @DepartmentID IS NOT NULL
        SET @SQL = @SQL + ' AND DepartmentID = ' + CAST(@DepartmentID AS NVARCHAR(10))

    EXEC sp_executesql @SQL
END

-- Stored Procedure for selecting dynamic data from the Teach table
CREATE PROCEDURE SelectTeach
    @CourseID INT = NULL,
    @InstructorID INT = NULL
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX)

    SET @SQL = 'SELECT * FROM Teach WHERE 1=1'

    IF @CourseID IS NOT NULL
        SET @SQL = @SQL + ' AND CourseID = ' + CAST(@CourseID AS NVARCHAR(10))

    IF @InstructorID IS NOT NULL
        SET @SQL = @SQL + ' AND InstructorID = ' + CAST(@InstructorID AS NVARCHAR(10))

    EXEC sp_executesql @SQL
END
