-- Use DEPTINSERT stored procedure
EXEC DEPTINSERT  'Human Resources', 1; -- Valid insert
EXEC DEPTINSERT  'Finance Department', 2; -- Valid insert
EXEC DEPTINSERT  'Marketing Department', 3; -- Valid insert

-- Use STUDINSERT stored procedure
EXEC STUDINSERT  1,'John', 'Doe', '123 Main St', 'john.doe@example.com', '555-1234', 1; -- Valid insert
EXEC STUDINSERT  2,'Alice', 'Johnson', '456 Oak St', 'alice@example.com', '555-8765', 2; -- Valid insert
EXEC STUDINSERT  3,'Bob', 'Williams', '789 Pine St', 'bob@example.com', '555-4321', 3; -- Valid insert

-- Example usage of INSINSERT stored procedure
EXEC INSINSERT 'Michael', 'Smith', '2023-01-15', '555-5678', 'michael@example.com', 1;
EXEC INSINSERT 'David', 'Miller', '2023-02-28', '555-9999', 'david@example.com', 2; -- Valid insert
EXEC INSINSERT 'Grace', 'Lee', '2023-03-15', '555-1234', 'grace@example.com', 3; -- Valid insert

-- Insert into Logins
INSERT INTO Logins
VALUES ('michael@example.com',777)
INSERT INTO Logins 
VALUES ('alice@example.com',123)
-- Use TOPICInsert stored procedure
EXEC TOPICInsert 1,'Geography'; -- Valid insert
EXEC TOPICInsert 2, 'Mathematics'; -- Valid insert
EXEC TOPICInsert 3, 'Literature'; -- Valid insert

-- Use COURSEINSERT stored procedure
EXEC COURSEINSERT 1,'Introduction to HR Management', 1; -- Valid insert
EXEC COURSEINSERT 2, 'Introduction to Algebra', 2; -- Valid insert
EXEC COURSEINSERT 3, 'Shakespearean Literature', 3; -- Valid insert

-- Use QUESTIONInsert stored procedure
EXEC QUESTIONInsert 'Who is the author of the play "Hamlet"?', 'MCQ', 'Easy', 3;
EXEC QUESTIONInsert 'In which play does the character Othello appear?', 'MCQ', 'Medium', 3;
EXEC QUESTIONInsert 'Which play is known as "The Scottish Play"?', 'MCQ', 'Medium', 3;


-- Example usage
EXEC CHOICEInsert  'William Shakespeare', 1, 3; 
EXEC CHOICEInsert 'John Milton', 0, 3;
EXEC CHOICEInsert 'Charles Dickens', 0, 3;
