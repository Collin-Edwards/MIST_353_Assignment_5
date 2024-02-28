CREATE PROCEDURE GetAirportDelays
    @AirportID INT
AS
BEGIN
    SELECT 
    delayid,
		timestamp, 
		delayduration,
		delayreason
    FROM
        airportdelays
    WHERE
        airportid = @AirportID;
END;

GO


CREATE PROCEDURE UpdateUserProfile
  @UserID INT,
  @NewPasswordHash NVARCHAR(255),
  @NewEmail NVARCHAR(100),
	@ChangeDODstatus BIT
AS
BEGIN
    UPDATE users
    SET
    passwordhash = @NewPasswordHash, 
    email = @NewEmail, 
		isdoduser = @ChangeDODstatus
    WHERE
        userid = @UserID;
END;
GO
