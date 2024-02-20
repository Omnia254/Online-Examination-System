-- Inserting exam data for 'Geography' course
DECLARE @ExamIDGeography INT;

INSERT INTO [Exam] ([ExamDate], [InstructorID], [CourseID])
VALUES (GETDATE(), 6, 1); 

SET @ExamIDGeography = SCOPE_IDENTITY();

-- Associating questions with the exam in the ExamQuestion table
INSERT INTO [ExamQuestion] ([ExamID], [QuestionID])
VALUES
(@ExamIDGeography, 1),
(@ExamIDGeography, 2),
(@ExamIDGeography, 3),
(@ExamIDGeography, 4),
(@ExamIDGeography, 5),
(@ExamIDGeography, 6),
(@ExamIDGeography, 7),
(@ExamIDGeography, 8),
(@ExamIDGeography, 9),
(@ExamIDGeography, 10);

-- Inserting exam data for 'Astronomy' course
DECLARE @ExamIDAstronomy INT;

INSERT INTO [Exam] ([ExamDate], [InstructorID], [CourseID])
VALUES (GETDATE(), 3, 2);

SET @ExamIDAstronomy = SCOPE_IDENTITY();

-- Associating questions with the exam in the ExamQuestion table
INSERT INTO [ExamQuestion] ([ExamID], [QuestionID])
VALUES
(@ExamIDAstronomy, 11),
(@ExamIDAstronomy, 12),
(@ExamIDAstronomy, 13),
(@ExamIDAstronomy, 14),
(@ExamIDAstronomy, 15),
(@ExamIDAstronomy, 16),
(@ExamIDAstronomy, 17),
(@ExamIDAstronomy, 18),
(@ExamIDAstronomy, 19),
(@ExamIDAstronomy, 20);

-- Inserting exam data for 'Literature' course
DECLARE @ExamIDLiterature INT;

INSERT INTO [Exam] ([ExamDate], [InstructorID], [CourseID])
VALUES (GETDATE(), 4, 3);

SET @ExamIDLiterature = SCOPE_IDENTITY();

-- Associating questions with the exam in the ExamQuestion table
INSERT INTO [ExamQuestion] ([ExamID], [QuestionID])
VALUES
(@ExamIDLiterature, 21),
(@ExamIDLiterature, 22),
(@ExamIDLiterature, 23),
(@ExamIDLiterature, 24),
(@ExamIDLiterature, 25),
(@ExamIDLiterature, 26),
(@ExamIDLiterature, 27),
(@ExamIDLiterature, 28),
(@ExamIDLiterature, 29),
(@ExamIDLiterature, 30);
