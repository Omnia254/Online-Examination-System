-- Create a new database named "ExaminationSystem"
CREATE DATABASE ExaminationSystem;

-- Switch to the newly created database for further operations
USE ExaminationSystem;

--Table to store Login info
CREATE TABLE [Logins](
	[Email] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	PRIMARY KEY ([Email])
	);

-- Table to store information about academic departments
CREATE TABLE [Department] (
  [DepartmentID] INT IDENTITY(1,1),
  [DepartmentName] NVARCHAR(50) NOT NULL,  -- Name of the department
  [ManagerID] INT,  -- ID of the department manager
  PRIMARY KEY ([DepartmentID])
);

-- Table to store information about students
CREATE TABLE [Student] (
  [StudentId] INT IDENTITY(1,1),
  [FirstName] NVARCHAR(30) NOT NULL,
  [LastName] NVARCHAR(30) NOT NULL,
  [Address] NVARCHAR(30),
  [Email] NVARCHAR(30) NOT NULL,
  [PhoneNum] NVARCHAR(30) NOT NULL,
  [DepartmentID] INT NOT NULL,  -- ID of the department the student belongs to
  FOREIGN KEY (DepartmentID) REFERENCES Department([DepartmentID]),
  PRIMARY KEY ([StudentId])
);

-- Table to store information about instructors
CREATE TABLE [Instructor] (
  [InstructorID] INT IDENTITY(1,1),
  [FirstName] NVARCHAR(20) NOT NULL,
  [LastName] NVARCHAR(20) NOT NULL,
  [HireDate] DATE NOT NULL,
  [PhoneNumber] NVARCHAR(11) NOT NULL,
  [Email] NVARCHAR(30) NOT NULL,
  [DepartmentID] INT NOT NULL,  -- ID of the department the instructor belongs to
  FOREIGN KEY (DepartmentID) REFERENCES Department([DepartmentID]),
  PRIMARY KEY ([InstructorID])
);

-- Table to store information about academic topics
CREATE TABLE [Topic] (
  [TopicID] INT IDENTITY(1,1) NOT NULL,
  [TopicTitle] NVARCHAR(100) NOT NULL,  -- Title of the academic topic
  PRIMARY KEY ([TopicID])
);

-- Table to store information about courses
CREATE TABLE [Course] (
  [CourseID] INT IDENTITY(1,1),
  [CourseName] NVARCHAR(50) NOT NULL,
  [TopicID] INT NOT NULL,  -- ID of the academic topic the course belongs to
  FOREIGN KEY ([TopicID]) REFERENCES [Topic]([TopicID]),
  PRIMARY KEY ([CourseID])
);

-- Table to store information about exam questions
CREATE TABLE [Question] (
  [QuestionID] INT IDENTITY(1,1),
  [QuestionText] NVARCHAR(500) NOT NULL,
  [QuestionType] NVARCHAR(20) NOT NULL CHECK ([QuestionType] IN ('T/F', 'MCQ')),
  [Complexity] NVARCHAR(20) NOT NULL CHECK ([Complexity] IN ('Easy', 'Medium', 'Hard')),
  [CourseID] INT NOT NULL,  -- ID of the course the question belongs to
  PRIMARY KEY ([QuestionID]),
  FOREIGN KEY ([CourseID]) REFERENCES Course([CourseID])
);

-- Table to store choices for multiple-choice questions
CREATE TABLE [Choice] (
  [ChoiceID] INT IDENTITY(1,1),
  [ChoiceText] NVARCHAR(200) NOT NULL,
  [IsCorrect] BIT NOT NULL,
  [QuestionID] INT NOT NULL,  -- ID of the question the choice belongs to
  FOREIGN KEY ([QuestionID]) REFERENCES [Question]([QuestionID]),
  PRIMARY KEY ([ChoiceID])
);

-- Table to store information about exams
CREATE TABLE [Exam] (
  [ExamID] INT IDENTITY(1,1),
  [ExamDate] DATETIME NOT NULL,
  [InstructorID] INT NOT NULL,  -- ID of the instructor conducting the exam
  [CourseID] INT NOT NULL,  -- ID of the course the exam belongs to
  FOREIGN KEY ([InstructorID]) REFERENCES [Instructor]([InstructorID]),
  FOREIGN KEY ([CourseID]) REFERENCES Course([CourseID]),
  PRIMARY KEY ([ExamID])
);

-- Table to store grades for exams
CREATE TABLE [Grades] (
  [ExamID] INT,
  [StudentID] INT,
  [Score] INT NOT NULL,
  FOREIGN KEY ([StudentID]) REFERENCES [Student]([StudentID]),
  FOREIGN KEY ([ExamID]) REFERENCES [Exam]([ExamID]),
  PRIMARY KEY ([ExamID])
);

-- Table to store enrollments of students in courses
CREATE TABLE [Enroll] (
  [StudentID] INT,
  [CourseID] INT,
  FOREIGN KEY ([StudentID]) REFERENCES [Student]([StudentID]),
  FOREIGN KEY ([CourseID]) REFERENCES [Course]([CourseID]),
  PRIMARY KEY ([StudentID], [CourseID])
);

-- Table to store information about instructors teaching courses
CREATE TABLE [Teach] (
  [CourseID] INT,
  [InstructorID] INT,
  FOREIGN KEY ([CourseID]) REFERENCES [Course]([CourseID]),
  FOREIGN KEY ([InstructorID]) REFERENCES [Instructor]([InstructorID]),
  PRIMARY KEY ([CourseID], [InstructorID])
);

-- Table to associate exam questions with exams
CREATE TABLE [ExamQuestion] (
  [ExamID] INT,
  [QuestionID] INT,
  FOREIGN KEY ([ExamID]) REFERENCES [Exam]([ExamID]),
  FOREIGN KEY ([QuestionID]) REFERENCES [Question]([QuestionID]),
  PRIMARY KEY ([ExamID], [QuestionID])
);

-- Table to store answers given by students in exams
CREATE TABLE [Answer] (
  [ExamID] INT,
  [StudentID] INT,
  [QuestionID] INT,
  [Answer] INT,  -- ID of the chosen choice for the question
  PRIMARY KEY ([ExamID], [QuestionID]),
  FOREIGN KEY ([ExamID]) REFERENCES [Exam]([ExamID]),
  FOREIGN KEY ([QuestionID]) REFERENCES [Question]([QuestionID]),
  FOREIGN KEY ([StudentID]) REFERENCES [Student]([StudentID]),
  FOREIGN KEY ([Answer]) REFERENCES [Choice]([ChoiceID])
);
