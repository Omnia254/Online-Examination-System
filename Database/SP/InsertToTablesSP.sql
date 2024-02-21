--- DEPTINSERT stored procedure
ALTER PROC DEPTINSERT 
@COL2DATA NVARCHAR(50),
@COL3DATA INT
AS
BEGIN
    -- Initialize the SQL string for the INSERT statement
    DECLARE @SQL NVARCHAR(1000) = 'INSERT INTO Department (DepartmentName';

    -- Check if the ManagerID is provided and exists in the Instructor table
    IF @COL3DATA IS NOT NULL
    BEGIN
        IF NOT EXISTS (SELECT InstructorID FROM Instructor WHERE InstructorID = @COL3DATA)
        BEGIN
            SELECT 'NO SUCH FK EXISTS' AS ErrorMessage;
            RETURN;
        END
        SET @SQL = @SQL + ', ManagerID';
    END
    
    -- Complete the SQL string
    SET @SQL = @SQL + ') VALUES (';

    -- Include DepartmentName column if provided
    IF @COL2DATA IS NOT NULL 
        SET @SQL = @SQL + '''' + @COL2DATA + ''',';
    
    -- Include ManagerID column if provided
    IF @COL3DATA IS NOT NULL
        SET @SQL = @SQL + CAST(@COL3DATA AS NVARCHAR(10)) + ',';
    
    -- Remove the trailing comma
    SET @SQL = LEFT(@SQL, LEN(@SQL) - 1);
    
    -- Complete the SQL string and display it
    SET @SQL = @SQL + ')';
    SELECT @SQL AS SQLStatement;
    
    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL;
END






-- INSINSERT stored procedure
CREATE PROC INSINSERT
@COL2DATA NVARCHAR(20),
@COL3DATA NVARCHAR(20),
@COL4DATA DATE,
@COL5DATA NVARCHAR(11),
@COL6DATA NVARCHAR(30),
@COL7DATA INT
AS
BEGIN
    -- Initialize the SQL string for the INSERT statement
    DECLARE @SQL NVARCHAR(1000) = 'INSERT INTO Instructor (FirstName, LastName, HireDate, PhoneNumber, Email, DepartmentID) VALUES (';

    -- Include FirstName column if provided
    IF @COL2DATA IS NOT NULL 
        SET @SQL = @SQL + '''' + @COL2DATA + ''',';

    -- Include LastName column if provided
    IF @COL3DATA IS NOT NULL 
        SET @SQL = @SQL + '''' + @COL3DATA + ''',';

    -- Include HireDate column if provided
    IF @COL4DATA IS NOT NULL
        SET @SQL = @SQL + '''' + CONVERT(VARCHAR, @COL4DATA, 23) + ''',';

    -- Include PhoneNumber column if provided
    IF @COL5DATA IS NOT NULL
        SET @SQL = @SQL + '''' + @COL5DATA + ''',';

    -- Include Email column if provided
    IF @COL6DATA IS NOT NULL
        SET @SQL = @SQL + '''' + @COL6DATA + ''',';

    -- Include DepartmentID column if provided, and check if the foreign key exists
    IF @COL7DATA IS NOT NULL
    BEGIN
        IF NOT EXISTS (SELECT DepartmentID FROM Department WHERE DepartmentID = @COL7DATA)
        BEGIN
            SELECT 'NO SUCH FK EXISTS' AS ErrorMessage;
            RETURN;
        END
        SET @SQL = @SQL + CAST(@COL7DATA AS NVARCHAR(10)) + ',';
    END

    -- Remove the trailing comma
    SET @SQL = LEFT(@SQL, LEN(@SQL) - 1);

    -- Complete the SQL string and display it
    SET @SQL = @SQL + ')';
    SELECT @SQL AS SQLStatement;

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL;
END



-- STUDINSERT stored procedure
CREATE PROC STUDINSERT 
@COL1DATA INT,
@COL2DATA NVARCHAR(30),
@COL3DATA NVARCHAR(30),
@COL4DATA NVARCHAR(30),
@COL5DATA NVARCHAR(30),
@COL6DATA NVARCHAR(30),
@COL7DATA INT
AS
BEGIN
    -- Initialize the SQL string for the INSERT statement
    DECLARE @SQL NVARCHAR(1000) = 'INSERT INTO Student (FirstName, LastName, Address, Email, PhoneNum, DepartmentID) VALUES (';
    
    -- Include FirstName column if provided
    IF @COL2DATA IS NOT NULL 
        SELECT @SQL = CONCAT(@SQL, '''', @COL2DATA, ''',');
    
    -- Include LastName column if provided
    IF @COL3DATA IS NOT NULL 
        SELECT @SQL = CONCAT(@SQL, '''', @COL3DATA, ''',');
    
    -- Include Address column if provided
    IF @COL4DATA IS NOT NULL
        SELECT @SQL = CONCAT(@SQL, '''', @COL4DATA, ''',');
    
    -- Include Email column if provided
    IF @COL5DATA IS NOT NULL
        SELECT @SQL = CONCAT(@SQL, '''', @COL5DATA, ''',');
    
    -- Include PhoneNum column if provided
    IF @COL6DATA IS NOT NULL
        SELECT @SQL = CONCAT(@SQL, '''', @COL6DATA, ''',');
    
    -- Include DepartmentID column if provided, and check if the foreign key exists
    IF @COL7DATA IS NOT NULL
    BEGIN
        IF NOT EXISTS (SELECT DepartmentID FROM Department WHERE DepartmentID = @COL7DATA)
        BEGIN
            SELECT 'NO SUCH FK EXISTS' AS ErrorMessage;
            RETURN;
        END
        -- Ensure that @COL7DATA is treated as a string in the dynamic SQL
        SELECT @SQL = CONCAT(@SQL, CAST(@COL7DATA AS NVARCHAR(10)), ',');
    END
    
    -- Remove the trailing comma
    SET @SQL = LEFT(@SQL, LEN(@SQL) - 1);
    
    -- Complete the SQL string and display it
    SET @SQL = CONCAT(@SQL, ')');
    
    -- Print the dynamic SQL for inspection
    PRINT @SQL;
    
    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL;
END
------------------------------------

------------------------------------
-- TOPICInsert stored procedure
CREATE PROC TOPICInsert 
@COL1DATA INT,
@COL2DATA NVARCHAR(100)
AS
BEGIN
    -- Enable IDENTITY_INSERT
    SET IDENTITY_INSERT Topic ON;
    -- Initialize the SQL string for the INSERT statement
    DECLARE @SQL NVARCHAR(1000) = 'INSERT INTO Topic (TopicID, TopicTitle) VALUES (';

    -- Check if the primary key value is provided
    IF @COL1DATA IS NULL
    BEGIN
        SELECT 'CANT INSERT WITHOUT PK VALUE' AS ErrorMessage;
        RETURN;
    END

    -- Check if the primary key value already exists in the table
    IF EXISTS (SELECT TopicID FROM Topic WHERE TopicID = @COL1DATA)
    BEGIN
        SELECT 'CANT INSERT THE SAME PK VALUE TWICE' AS ErrorMessage;
        RETURN;
    END
    
    -- Include TopicID value
    SELECT @SQL = CONCAT(@SQL, CAST(@COL1DATA AS NVARCHAR(10)));

    -- Include TopicTitle column if provided
    IF @COL2DATA IS NOT NULL 
        SELECT @SQL = CONCAT(@SQL, ', ''', @COL2DATA, '''');
    
    -- Complete the SQL string and display it
    SELECT @SQL = CONCAT(@SQL, ')');
    SELECT @SQL AS SQLStatement;
    
    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL;
END

------------------------------------
------------------------------------
--INSERT INTO Course (CourseID, CourseName, TopicID) VALUES
CREATE PROC COURSEINSERT
@COL1DATA INT,
@COL2DATA NVARCHAR(50),
@COL3DATA INT
AS
BEGIN
    -- Check if explicit CourseID is provided
    IF @COL1DATA IS NULL
    BEGIN
        SELECT 'CANT INSERT WITHOUT PK VALUE' AS ErrorMessage;
        RETURN;
    END

    -- Check if the explicit CourseID already exists in the table
    IF EXISTS (SELECT CourseID FROM Course WHERE CourseID = @COL1DATA)
    BEGIN
        SELECT 'CANT INSERT THE SAME PK VALUE TWICE' AS ErrorMessage;
        RETURN;
    END 

    -- Enable IDENTITY_INSERT
    SET IDENTITY_INSERT Course ON;

    -- Insert the values
    INSERT INTO Course (CourseID, CourseName, TopicID)
    VALUES (@COL1DATA, @COL2DATA, @COL3DATA);

    -- Disable IDENTITY_INSERT
    SET IDENTITY_INSERT Course OFF;
END
------------------------------------
------------------------------------

-- QUESTIONInsert stored procedure
ALTER PROCEDURE QUESTIONInsert 
    @COL2DATA NVARCHAR(500),
    @COL3DATA NVARCHAR(20),
    @COL4DATA NVARCHAR(20),
    @COL5DATA INT -- Assuming @COL5DATA is CourseID
AS
BEGIN
    -- Initialize the SQL string for the INSERT statement
    DECLARE @SQL NVARCHAR(1000) = 'INSERT INTO Question';

    -- Include columns in the INSERT statement
    IF @COL2DATA IS NOT NULL 
        SELECT @SQL = CONCAT(@SQL, ' (QuestionText');

    IF @COL3DATA IS NOT NULL 
        SELECT @SQL = CONCAT(@SQL, ', QuestionType');

    IF @COL4DATA IS NOT NULL
        SELECT @SQL = CONCAT(@SQL, ', Complexity');

    -- Include CourseID in the INSERT statement
    SELECT @SQL = CONCAT(@SQL, ', CourseID');

    -- Complete the SQL string
    SELECT @SQL = CONCAT(@SQL, ') VALUES (');

    IF @COL2DATA IS NOT NULL 
        SELECT @SQL = CONCAT(@SQL, '''', @COL2DATA, '''');

    IF @COL3DATA IS NOT NULL 
        SELECT @SQL = CONCAT(@SQL, ', ''', @COL3DATA, '''');

    IF @COL4DATA IS NOT NULL 
        SELECT @SQL = CONCAT(@SQL, ', ''', @COL4DATA, '''');

    -- Include CourseID value in the VALUES section
    SELECT @SQL = CONCAT(@SQL, ', ', CAST(@COL5DATA AS NVARCHAR(10)));

    SELECT @SQL = CONCAT(@SQL, ')');
    SELECT @SQL;

    -- Execute the dynamic SQL statement
    EXEC sp_executesql @SQL;
END
----------------------------------------
----------------------------------------
-- CHOICEInsert stored procedure
Alter PROC CHOICEInsert 
    @COL2DATA NVARCHAR(200), -- ChoiceText
    @COL3DATA BIT, -- IsCorrect
    @COL4DATA INT -- QuestionID
AS
BEGIN
    -- Initialize the SQL string for the INSERT statement
    DECLARE @SQL NVARCHAR(1000) = 'INSERT INTO Choice (ChoiceText';

    -- Include IsCorrect column if provided
    IF @COL3DATA IS NOT NULL 
        SELECT @SQL = CONCAT(@SQL, ', IsCorrect');

    -- Include QuestionID column if provided, and check if the foreign key exists
    IF @COL4DATA IS NOT NULL
    BEGIN
        IF NOT EXISTS (SELECT QuestionID FROM Question WHERE QuestionID = @COL4DATA)
        BEGIN
            SELECT 'NO SUCH FK EXISTS' AS ErrorMessage;
            RETURN;
        END
        SELECT @SQL = CONCAT(@SQL, ', QuestionID');
    END

    -- Complete the SQL string and display it
    SELECT @SQL = CONCAT(@SQL, ') VALUES (');

    IF @COL2DATA IS NOT NULL 
        SELECT @SQL = CONCAT(@SQL, '''', @COL2DATA, '''');

    IF @COL3DATA IS NOT NULL 
        SELECT @SQL = CONCAT(@SQL, ', ', CAST(@COL3DATA AS NVARCHAR(10)));

    IF @COL4DATA IS NOT NULL 
        SELECT @SQL = CONCAT(@SQL, ', ', CAST(@COL4DATA AS NVARCHAR(10)));

    SELECT @SQL = CONCAT(@SQL, ')');
    SELECT @SQL;

    -- Execute the dynamic SQL statement
    EXEC(@SQL);
END
------------------------------------------
