-- Inserting data into the Instructor table
INSERT INTO [Instructor] ([FirstName], [LastName], [HireDate], [PhoneNumber], [Email], [DepartmentID])
VALUES
('John', 'Doe', '2020-01-01', '01234567890', 'john.doe@example.com', 1),
('Jane', 'Smith', '2019-02-15', '01134567890', 'jane.smith@example.com', 2),
('Robert', 'Johnson', '2021-05-10', '01034567890', 'robert.johnson@example.com', 3),
('Emily', 'Davis', '2022-03-20', '01534567890', 'emily.davis@example.com', 1),
('Michael', 'Miller', '2021-08-12', '01134767890', 'michael.miller@example.com', 2),
('Sarah', 'Anderson', '2023-01-05', '01234597890', 'sarah.anderson@example.com', 3);



-- Inserting additional data for the Department table (assuming three departments for the example)
INSERT INTO [Department] ([DepartmentName], [ManagerID])
VALUES
('Geography Department', 1),  -- Assuming John Doe is the manager
('Astronomy Department', 2),  -- Assuming Jane Smith is the manager
('Literature Department', 3); -- Assuming Robert Johnson is the manager
