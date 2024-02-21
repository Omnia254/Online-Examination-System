CREATE PROC ExamGeneration @CID INT ,@numOfTF INT ,@numOfMCQ INT,@examComplexity NVARCHAR(20),@InstID INT
AS
  BEGIN
 
     IF NOT EXISTS(SELECT CourseID FROM Course WHERE CourseID = @CID)
	  BEGIN
	     SELECT 'COURSEID NOT FOUND'
		 RETURN
	  END
	 IF NOT EXISTS(SELECT InstructorID FROM Instructor WHERE InstructorID=@InstID)
	 BEGIN
		SELECT 'Instrucor not registered'
		RETURN
	 END
	 IF (@numOfTF + @numOfMCQ != 10)
	  BEGIN
	    SELECT 'NUMBER OF QUESTIONS MUST BE 10'
		RETURN
	  END
	 
	 BEGIN TRY
	 IF @numOfTF>( SELECT  COUNT(*)
				   FROM Question 
				   WHERE QuestionType = 'T/F' AND Complexity = @examComplexity AND CourseID = @CID)
					BEGIN
						SELECT 'NO ENOUGH T/F QUESTION EXIST'
						RETURN
					END
			IF @numOfMCQ>(SELECT COUNT(*)
			   FROM Question 
			   WHERE QuestionType = 'MCQ' AND Complexity = @examComplexity AND CourseID = @CID)
					BEGIN
						SELECT 'NO ENOUGH MCQ QUESTIONS EXIST'
						RETURN
					END
	  BEGIN TRANSACTION
		   
		   DECLARE @exId INT
	       INSERT INTO Exam(ExamDate,InstructorID,CourseID)
		   VALUES(GETDATE(),@InstID,@CID);
		   
		   SET @exId = SCOPE_IDENTITY();
		   IF @numOfTF>0 
		   BEGIN
			   INSERT INTO ExamQuestion(ExamID,QuestionID)
			   SELECT  @exId , QuestionID
			   FROM Question 
			   WHERE QuestionType = 'T/F' AND Complexity = @examComplexity AND CourseID = @CID
			   ORDER BY NEWID()
			   OFFSET 0 ROWS  
			   FETCH NEXT (@numOfTF) ROWS ONLY; 
		   END
		   IF @numOfMCQ>0 
		   BEGIN
			   INSERT INTO ExamQuestion(ExamID,QuestionID)
			   SELECT @exId , QuestionID
			   FROM Question 
			   WHERE QuestionType = 'MCQ' AND Complexity = @examComplexity AND CourseID = @CID
			   ORDER BY NEWID()
			   OFFSET 0 ROWS  
			   FETCH NEXT (@numOfMCQ) ROWS ONLY; 
		   END
	 COMMIT
	 END TRY
	 BEGIN CATCH

	 ROLLBACK
	 END CATCH
END