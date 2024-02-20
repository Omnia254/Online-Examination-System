CREATE PROC UPDATEDEPARTMENT 
@COL1DATA INT,
@COL2DATA NVARCHAR(50),
@COL3DATA INT
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX) = 'UPDATE Department SET '
    DECLARE @SetValues NVARCHAR(MAX) = ''
    DECLARE @WhereClause NVARCHAR(MAX) = ' WHERE DepartmentID = ' + CAST(@COL1DATA AS NVARCHAR(10))
    
    IF @COL1DATA IS NULL
    BEGIN
        SELECT 'CANT UPDATE WITHOUT PK VALUE' AS ErrorMsg
        RETURN
    END
    
    IF NOT EXISTS(SELECT DepartmentID FROM Department WHERE DepartmentID = @COL1DATA)
    BEGIN
        SELECT 'PK VALUE DOES NOT EXIST' AS ErrorMsg
        RETURN
    END 
    
    IF @COL2DATA IS NOT NULL 
        SET @SetValues = @SetValues + ', DapartmentName = ''' + @COL2DATA + ''''
    
    IF @COL3DATA IS NOT NULL 
	BEGIN
		IF NOT EXISTS (SELECT InstructorID FROM Instructor WHERE InstructorID=@COL3DATA)
		BEGIN
			SELECT'NO SUCH FK EXISTS' AS ErrorMsg
			RETURN
		END
        SET @SetValues = @SetValues + ', ManagerID = ' + CAST(@COL3DATA AS NVARCHAR(10))
    END
    IF LEN(@SetValues) = 0
    BEGIN
        SELECT 'NO VALUES TO UPDATE' AS ErrorMsg
        RETURN
    END
    
    SET @SetValues = STUFF(@SetValues, 1, 2, '') -- Removing leading comma and space
    
    SET @SQL = @SQL + @SetValues + @WhereClause
    
    EXEC sp_executesql @SQL
END


CREATE PROC UPDATESTUDENT 
@StudentId INT,
@FirstName NVARCHAR(30),
@LastName NVARCHAR(30),
@Address NVARCHAR(30),
@Email NVARCHAR(30),
@PhoneNum NVARCHAR(30),
@DepartmentID INT
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX) = 'UPDATE Student SET '
    DECLARE @SetValues NVARCHAR(MAX) = ''
    DECLARE @WhereClause NVARCHAR(MAX) = ' WHERE StudentId = ' + CAST(@StudentId AS NVARCHAR(10))
    
    IF @StudentId IS NULL
    BEGIN
        SELECT 'CANT UPDATE WITHOUT PK VALUE' AS ErrorMsg
        RETURN
    END
    
    IF NOT EXISTS(SELECT StudentId FROM Student WHERE StudentId = @StudentId)
    BEGIN
        SELECT 'PK VALUE DOES NOT EXIST' AS ErrorMsg
        RETURN
    END 
    
    IF @FirstName IS NOT NULL 
        SET @SetValues = @SetValues + ', FirstName = ''' + @FirstName + ''''
    
    IF @LastName IS NOT NULL 
        SET @SetValues = @SetValues + ', LastName = ''' + @LastName + ''''
    
    IF @Address IS NOT NULL 
        SET @SetValues = @SetValues + ', Address = ''' + @Address + ''''
    
    IF @Email IS NOT NULL 
        SET @SetValues = @SetValues + ', Email = ''' + @Email + ''''
    
    IF @PhoneNum IS NOT NULL 
        SET @SetValues = @SetValues + ', PhoneNum = ''' + @PhoneNum + ''''
    
    IF @DepartmentID IS NOT NULL
	BEGIN
		IF NOT EXISTS (SELECT DepartmentID FROM Department WHERE DepartmentID=@DepartmentID)
		BEGIN
			SELECT'NO SUCH FK EXISTS' AS ErrorMsg
			RETURN
		END
        SET @SetValues = @SetValues + ', DepartmentID = ' + CAST(@DepartmentID AS NVARCHAR(10))
    END
    IF LEN(@SetValues) = 0
    BEGIN
        SELECT 'NO VALUES TO UPDATE' AS ErrorMsg
        RETURN
    END
    
    SET @SetValues = STUFF(@SetValues, 1, 2, '') -- Removing leading comma and space
    
    SET @SQL = @SQL + @SetValues + @WhereClause
    
    EXEC sp_executesql @SQL
END
/*
This stored procedure works similarly to the previous one but for the Instructor table.
It checks for the existence of the primary key, ensures that foreign key constraints are maintained,
and constructs the dynamic SQL for updating the record accordingly.
*/
CREATE PROC UPDATEINSTRUCTOR 
@InstructorID INT,
@FirstName NVARCHAR(20),
@LastName NVARCHAR(20),
@HireDate DATE,
@PhoneNumber NVARCHAR(11),
@Email NVARCHAR(30),
@DepartmentID INT
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX) = 'UPDATE Instructor SET '
    DECLARE @SetValues NVARCHAR(MAX) = ''
    DECLARE @WhereClause NVARCHAR(MAX) = ' WHERE InstructorID = ' + CAST(@InstructorID AS NVARCHAR(10))
    
    IF @InstructorID IS NULL
    BEGIN
        SELECT 'CANT UPDATE WITHOUT PK VALUE' AS ErrorMsg
        RETURN
    END
    
    IF NOT EXISTS(SELECT InstructorID FROM Instructor WHERE InstructorID = @InstructorID)
    BEGIN
        SELECT 'PK VALUE DOES NOT EXIST' AS ErrorMsg
        RETURN
    END 
    
    IF @FirstName IS NOT NULL 
        SET @SetValues = @SetValues + ', FirstName = ''' + @FirstName + ''''
    
    IF @LastName IS NOT NULL 
        SET @SetValues = @SetValues + ', LastName = ''' + @LastName + ''''
    
    IF @HireDate IS NOT NULL 
        SET @SetValues = @SetValues + ', HireDate = ''' + CONVERT(NVARCHAR(10), @HireDate, 120) + ''''
    
    IF @PhoneNumber IS NOT NULL 
        SET @SetValues = @SetValues + ', PhoneNumber = ''' + @PhoneNumber + ''''
    
    IF @Email IS NOT NULL 
        SET @SetValues = @SetValues + ', Email = ''' + @Email + ''''
    
    IF @DepartmentID IS NOT NULL
	BEGIN
		IF NOT EXISTS (SELECT DepartmentID FROM Department WHERE DepartmentID=@DepartmentID)
		BEGIN
			SELECT 'NO SUCH FK EXISTS' AS ErrorMsg
			RETURN
		END
        SET @SetValues = @SetValues + ', DepartmentID = ' + CAST(@DepartmentID AS NVARCHAR(10))
    END
    IF LEN(@SetValues) = 0
    BEGIN
        SELECT 'NO VALUES TO UPDATE' AS ErrorMsg
        RETURN
    END
    
    SET @SetValues = STUFF(@SetValues, 1, 2, '') -- Removing leading comma and space
    
    SET @SQL = @SQL + @SetValues + @WhereClause
    
    EXEC sp_executesql @SQL
END
/*
This stored procedure will allow you to update records in the Question table based on the provided parameters.
It checks for the existence of the primary key, constructs the dynamic SQL for updating the record,
and ensures that only non-null values are updated.
*/
CREATE PROC UPDATEQUESTION 
@QuestionID INT,
@QuestionText NVARCHAR(500),
@QuestionType NVARCHAR(20),
@Complexity NVARCHAR(20),
@CourseID INT
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX) = 'UPDATE Question SET '
    DECLARE @SetValues NVARCHAR(MAX) = ''
    DECLARE @WhereClause NVARCHAR(MAX) = ' WHERE QuestionID = ' + CAST(@QuestionID AS NVARCHAR(10))
    
    IF @QuestionID IS NULL
    BEGIN
        SELECT 'CANT UPDATE WITHOUT PK VALUE' AS ErrorMsg
        RETURN
    END
    
    IF NOT EXISTS(SELECT QuestionID FROM Question WHERE QuestionID = @QuestionID)
    BEGIN
        SELECT 'PK VALUE DOES NOT EXIST' AS ErrorMsg
        RETURN
    END 
    
    IF @QuestionText IS NOT NULL 
        SET @SetValues = @SetValues + ', QuestionText = ''' + @QuestionText + ''''
    
    IF @QuestionType IS NOT NULL 
        SET @SetValues = @SetValues + ', QuestionType = ''' + @QuestionType + ''''
    
    IF @Complexity IS NOT NULL 
        SET @SetValues = @SetValues + ', Complexity = ''' + @Complexity + ''''
    
    IF @CourseID IS NOT NULL
    BEGIN
        IF NOT EXISTS (SELECT CourseID FROM Course WHERE CourseID=@CourseID)
        BEGIN
            SELECT 'NO SUCH FK EXISTS' AS ErrorMsg
            RETURN
        END
        SET @SetValues = @SetValues + ', CourseID = ' + CAST(@CourseID AS NVARCHAR(10))
    END
    
    IF LEN(@SetValues) = 0
    BEGIN
        SELECT 'NO VALUES TO UPDATE' AS ErrorMsg
        RETURN
    END
    
    SET @SetValues = STUFF(@SetValues, 1, 2, '') -- Removing leading comma and space
    
    SET @SQL = @SQL + @SetValues + @WhereClause
    
    EXEC sp_executesql @SQL
END


/*
This stored procedure checks for the existence of the primary key,
ensures that foreign key constraints are maintained
constructs the dynamic SQL for updating the record, 
and ensures that only non-null values are updated
*/
CREATE PROC UPDATECHOICE 
@ChoiceID INT,
@ChoiceText NVARCHAR(200),
@IsCorrect BIT,
@QuestionID INT
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX) = 'UPDATE Choice SET '
    DECLARE @SetValues NVARCHAR(MAX) = ''
    DECLARE @WhereClause NVARCHAR(MAX) = ' WHERE ChoiceID = ' + CAST(@ChoiceID AS NVARCHAR(10))
    
    IF @ChoiceID IS NULL
    BEGIN
        SELECT 'CANT UPDATE WITHOUT PK VALUE' AS ErrorMsg
        RETURN
    END
    
    IF NOT EXISTS(SELECT ChoiceID FROM Choice WHERE ChoiceID = @ChoiceID)
    BEGIN
        SELECT 'PK VALUE DOES NOT EXIST' AS ErrorMsg
        RETURN
    END 
    
    IF @ChoiceText IS NOT NULL 
        SET @SetValues = @SetValues + ', ChoiceText = ''' + @ChoiceText + ''''
    
    IF @IsCorrect IS NOT NULL 
        SET @SetValues = @SetValues + ', IsCorrect = ' + CAST(@IsCorrect AS NVARCHAR(1))
    
    IF @QuestionID IS NOT NULL 
    BEGIN
        IF NOT EXISTS (SELECT QuestionID FROM Question WHERE QuestionID=@QuestionID)
        BEGIN
            SELECT 'NO SUCH FK EXISTS' AS ErrorMsg
            RETURN
        END
        SET @SetValues = @SetValues + ', QuestionID = ' + CAST(@QuestionID AS NVARCHAR(10))
    END
    
    IF LEN(@SetValues) = 0
    BEGIN
        SELECT 'NO VALUES TO UPDATE' AS ErrorMsg
        RETURN
    END
    
    SET @SetValues = STUFF(@SetValues, 1, 2, '') -- Removing leading comma and space
    
    SET @SQL = @SQL + @SetValues + @WhereClause
    
    EXEC sp_executesql @SQL
END

/*
This stored procedure allows updating records in the Topic table based on the provided parameters.
It checks for the existence of the primary key, constructs the dynamic SQL for updating the record,
and ensures that only non-null values are updated.
*/
CREATE PROC UPDATETOPIC 
@TopicID INT,
@TopicTitle NVARCHAR(100)
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX) = 'UPDATE Topic SET '
    DECLARE @SetValues NVARCHAR(MAX) = ''
    DECLARE @WhereClause NVARCHAR(MAX) = ' WHERE TopicID = ' + CAST(@TopicID AS NVARCHAR(10))
    
    IF @TopicID IS NULL
    BEGIN
        SELECT 'CANT UPDATE WITHOUT PK VALUE' AS ErrorMsg
        RETURN
    END
    
    IF NOT EXISTS(SELECT TopicID FROM Topic WHERE TopicID = @TopicID)
    BEGIN
        SELECT 'PK VALUE DOES NOT EXIST' AS ErrorMsg
        RETURN
    END 
    
    IF @TopicTitle IS NOT NULL 
        SET @SetValues = @SetValues + ', TopicTitle = ''' + @TopicTitle + ''''
    
    IF LEN(@SetValues) = 0
    BEGIN
        SELECT 'NO VALUES TO UPDATE' AS ErrorMsg
        RETURN
    END
    
    SET @SetValues = STUFF(@SetValues, 1, 2, '') -- Removing leading comma and space
    
    SET @SQL = @SQL + @SetValues + @WhereClause
    
    EXEC sp_executesql @SQL
END
/*
This stored procedure checks for the existence of the primary key,
ensures that foreign key constraints are maintained,
and constructs the dynamic SQL for updating the record accordingly.
and ensures that only non-null values are updated
*/
CREATE PROC UPDATECOURSE 
@CourseID INT,
@CourseName NVARCHAR(50),
@TopicID INT
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX) = 'UPDATE Course SET '
    DECLARE @SetValues NVARCHAR(MAX) = ''
    DECLARE @WhereClause NVARCHAR(MAX) = ' WHERE CourseID = ' + CAST(@CourseID AS NVARCHAR(10))
    
    IF @CourseID IS NULL
    BEGIN
        SELECT 'CANT UPDATE WITHOUT PK VALUE' AS ErrorMsg
        RETURN
    END
    
    IF NOT EXISTS(SELECT CourseID FROM Course WHERE CourseID = @CourseID)
    BEGIN
        SELECT 'PK VALUE DOES NOT EXIST' AS ErrorMsg
        RETURN
    END 
    
    IF @CourseName IS NOT NULL 
        SET @SetValues = @SetValues + ', CourseName = ''' + @CourseName + ''''
    
    IF @TopicID IS NOT NULL 
    BEGIN
        IF NOT EXISTS (SELECT TopicID FROM Topic WHERE TopicID = @TopicID)
        BEGIN
            SELECT 'NO SUCH FK EXISTS' AS ErrorMsg
            RETURN
        END
        SET @SetValues = @SetValues + ', TopicID = ' + CAST(@TopicID AS NVARCHAR(10))
    END
    
    IF LEN(@SetValues) = 0
    BEGIN
        SELECT 'NO VALUES TO UPDATE' AS ErrorMsg
        RETURN
    END
    
    SET @SetValues = STUFF(@SetValues, 1, 2, '') -- Removing leading comma and space
    
    SET @SQL = @SQL + @SetValues + @WhereClause
    
    EXEC sp_executesql @SQL
END
/*
This stored procedure checks for the existence of the primary key values (StudentID and CourseID),
ensures that the required parameters are not null, constructs the dynamic SQL for updating the record,
and ensures that only non-null values are updated.
*/
CREATE PROC UPDATEGRADE 
@StudentID INT,
@ExamID INT,
@Score INT
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX) = 'UPDATE Grades SET '
    DECLARE @SetValues NVARCHAR(MAX) = ''
    DECLARE @WhereClause NVARCHAR(MAX) = ' WHERE StudentID = ' + CAST(@StudentID AS NVARCHAR(10)) + ' AND ExamID = ' + CAST(@ExamID AS NVARCHAR(10))
    
    IF @StudentID IS NULL OR @ExamID IS NULL
    BEGIN
        SELECT 'CANT UPDATE WITHOUT PK VALUES' AS ErrorMsg
        RETURN
    END
    
    IF NOT EXISTS(SELECT * FROM Grades WHERE StudentID = @StudentID AND ExamID= @ExamID)
    BEGIN
        SELECT 'PK VALUES DO NOT EXIST' AS ErrorMsg
        RETURN
    END 
    
    IF @Score IS NOT NULL 
        SET @SetValues = @SetValues + ', Score = ' + CAST(@Score AS NVARCHAR(10))
    
    IF LEN(@SetValues) = 0
    BEGIN
        SELECT 'NO VALUES TO UPDATE' AS ErrorMsg
        RETURN
    END
    
    SET @SetValues = STUFF(@SetValues, 1, 2, '') -- Removing leading comma and space
    
    SET @SQL = @SQL + @SetValues + @WhereClause
    
    EXEC sp_executesql @SQL
END

