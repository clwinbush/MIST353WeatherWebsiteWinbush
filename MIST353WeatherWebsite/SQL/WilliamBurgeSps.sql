USE LandscapingDB
GO

--Find all plants associated with a certain location
create proc spGetPlantsByLocation
@LocationID int
AS
BEGIN
	select p.* 
	from plants as p
	inner join Climates as c on c.ClimateID = p.ClimateID
	inner join WeatherConditions as w on w.ClimateID = c.ClimateID
	inner join Locations as l on l.LocationID = w.LocationID
	where l.LocationID = @LocationID
END
GO

/*
exec spGetPlantsByLocation 1
GO
*/

--Update user info
create proc spUserUpdate
@id int
,@firstname nvarchar(50) = NULL
,@lastname nvarchar(50) =NULL
,@email nvarchar(100) = NULL
,@phonenumber nvarchar(20) =NULL
,@locationid int = NULL
AS
Begin
	update Users
	SET [FirstName] = isnull(@firstname, FirstName),
		[LastName] = isnull(@lastname, LastName),
		[Email] = isnull(@email, Email),
		[PhoneNumber] = isnull(@phonenumber, PhoneNumber),
		[LocationID] = isnull(@locationid, LocationID)
	Where UserID = @id
END
GO

/*
exec spUserUpdate @id = 3, @lastname ='Smith'
GO
*/

/*
exec spUserUpdate @id = 1, @email = 'johndoe@gmail.com'
GO
*/