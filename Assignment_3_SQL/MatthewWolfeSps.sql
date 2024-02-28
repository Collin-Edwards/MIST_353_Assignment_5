create or alter proc AddAirport
	@name nvarchar(100),
	@location nvarchar(100),
	@icaocode nvarchar(4),
	@ismilitary bit
	AS
	BEGIN
	INSERT INTO airports (name, location, icaocode, ismilitary)
	VALUES (@name, @location, @icaocode, @ismilitary)
	END;
	GO

	
	create proc GetAirportInformation
	@airportid int	
	AS
	BEGIN
		Select *
		from airports
		where airportid=@airportid
		end;
		GO