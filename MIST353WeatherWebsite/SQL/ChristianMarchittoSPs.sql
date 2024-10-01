USE LandscapingDB
GO

-- Searches for landscaping services based on climate
create or alter proc spServiceByClimate
@ClimateID int
AS
begin
	select l.*, c.ClimateID
	from LandscapingServices as l
	inner join ServiceSuitability as s on l.ServiceID=s.ServiceID
	inner join Climates as c on c.ClimateID=s.ClimateID
	where c.ClimateID = @ClimateID
end
GO
/*
exec spServiceByClimate 1
GO
*/

-- Finds plants that are located in a climate with an avg temp <= a given value
create or alter proc spPlantsInTemp
@AverageTemperature int
AS
begin
	select p.*, w.AverageTemperature
	from Plants as p 
	inner join Climates as c on p.ClimateID=c.ClimateID
	inner join WeatherConditions as w on c.ClimateID=w.ClimateID
	where AverageTemperature <= @AverageTemperature
end
GO
/*
exec spPlantsInTemp 30
GO
*/