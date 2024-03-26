CREATE PROCEDURE GetTopicsByCourse @Course_ID INT
AS
BEGIN
    -- Validate CourseID
    IF NOT EXISTS (SELECT 1 FROM Course WHERE CourseID = @Course_ID)
    BEGIN
        SELECT 'Invalid CourseID'
        RETURN
    END

    -- Get topics based on CourseID
    SELECT T.TopicID, T.TopicTitle
    FROM Topic T, Course C
    WHERE T.TopicID = C.CourseID AND CourseID = @Course_ID
END