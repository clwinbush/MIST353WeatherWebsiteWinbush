use LandscapingDB
go

-- add new user
create or alter proc spCreateUser
    @FirstName NVARCHAR(50) =NULL,
    @LastName NVARCHAR(50) =NULL,
    @Email NVARCHAR(100) =NULL,
    @PhoneNumber NVARCHAR(20) = NULL,
    @LocationID INT = NULL
AS
BEGIN
    INSERT INTO Users (FirstName, LastName, Email, PhoneNumber, LocationID)
    VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @LocationID);
END
go

/*
exec spCreateUser Ted, Kord, [bluebeetle2@kord.com], [555-5555], 1
go
*/

-- delete user
create or alter proc spDeleteUser
	@UserID int
AS
begin
DELETE FROM Users where USERID=@UserID;
end
go

/*
exec spDeleteUser 12
go
*/

