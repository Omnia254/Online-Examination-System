-- Inserting topics into the Topic table
INSERT INTO [Topic] ([TopicTitle])
VALUES
('Geography'),
('Astronomy'),
('Literature');

-- Inserting courses for the questions into the Course table
INSERT INTO [Course] ([CourseName], [TopicID])
VALUES
('Geography Course',1),
('Astronomy Course',2),
('Literature Course',3);

