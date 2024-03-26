Create PROC InsertTOPIC 
@COL2DATA NVARCHAR(100)
AS
BEGIN

   -- Insert the values
    INSERT INTO Topic (TopicTitle)
    VALUES ( @COL2DATA);

END