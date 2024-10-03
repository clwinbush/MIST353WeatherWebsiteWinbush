use LandscapingDB
GO

-- add new plant
create or alter proc spCreatePlant
    @PlantID int =NULL,
    @PlantName NVARCHAR(100) =NULL,
    @ScientificName NVARCHAR(150) =NULL,
    @Description NVARCHAR(500) = NULL,
    @ClimateID INT = NULL
AS
BEGIN
    INSERT INTO dbo.Plants (PlantID, PlantName, ScientificName, [Description], ClimateID)
    VALUES (@PlantID, @PlantName, @ScientificName, @Description, @ClimateID);
END
go

--delete plant
create or alter proc spDeletePlant
	@PlantID int
AS
begin
DELETE FROM dbo.Plants where PlantID=@PlantID;
end
go