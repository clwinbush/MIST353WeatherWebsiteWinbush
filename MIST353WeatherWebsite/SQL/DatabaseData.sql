use LandscapingDB
go

-- Insert into Climates
INSERT INTO Climates (ClimateName, Description)
VALUES 
('Temperate', 'Moderate temperatures with four distinct seasons.'),
('Arid', 'Dry climate with minimal rainfall.'),
('Tropical', 'Hot and humid climate with significant rainfall.');
GO

-- Insert into Locations
INSERT INTO Locations (City, State, Country, ZipCode, Latitude, Longitude)
VALUES 
('Austin', 'Texas', 'USA', '73301', 30.2672, -97.7431),
('Phoenix', 'Arizona', 'USA', '85001', 33.4484, -112.0740),
('Miami', 'Florida', 'USA', '33101', 25.7617, -80.1918);
GO

-- Insert into WeatherConditions
INSERT INTO WeatherConditions (LocationID, ClimateID, AverageTemperature, AverageRainfall, HumidityLevel)
VALUES 
(1, 1, 20.5, 30.0, 60.0),
(2, 2, 25.0, 5.0, 30.0),
(3, 3, 28.0, 60.0, 70.0);
GO

-- Insert into LandscapingServices
INSERT INTO LandscapingServices (ServiceName, Description, Category, PriceRange)
VALUES 
('Lawn Mowing', 'Regular mowing of the lawn.', 'Maintenance', '$20-$50'),
('Irrigation Installation', 'Setup of irrigation systems.', 'Installation', '$500-$2000'),
('Garden Design', 'Custom garden planning and design.', 'Design', '$300-$1500');
GO

-- Insert into ServiceSuitability
INSERT INTO ServiceSuitability (ServiceID, ClimateID, SuitabilityDescription)
VALUES 
(1, 1, 'Suitable for temperate climates with regular rainfall.'),
(1, 2, 'Requires drought-resistant grass varieties.'),
(1, 3, 'Use heat-tolerant grass species.'),
(2, 2, 'Essential for arid climates to conserve water.'),
(3, 1, 'Designs that incorporate seasonal plants.');
GO

-- Insert into ServiceProviders
INSERT INTO ServiceProviders (CompanyName, ContactPerson, Email, PhoneNumber, Website, LocationID)
VALUES 
('GreenThumb Landscaping', 'John Doe', 'contact@greenthumb.com', '555-1234', 'http://greenthumb.com', 1),
('Desert Oasis Services', 'Jane Smith', 'info@desertoasis.com', '555-5678', 'http://desertoasis.com', 2),
('Tropical Gardens Inc.', 'Carlos Ruiz', 'support@tropicalgardens.com', '555-8765', 'http://tropicalgardens.com', 3);
GO

-- Insert sample data into Plants table
INSERT INTO Plants (PlantName, ScientificName, Description, ClimateID)
VALUES 
('Lavender', 'Lavandula angustifolia', 'A fragrant flowering plant used in gardens and essential oils.', 1), -- Temperate
('Cactus', 'Cactaceae', 'Succulent plants adapted to arid environments.', 2), -- Arid
('Hosta', 'Hosta spp.', 'Shade-tolerant plants with large leaves, often used in ornamental gardens.', 1), -- Temperate
('Banana Tree', 'Musa acuminata', 'A fast-growing tropical plant known for its large, broad leaves and edible fruit.', 3); -- Tropical
GO

-- Insert sample data into Users table
INSERT INTO Users (FirstName, LastName, Email, PhoneNumber, LocationID)
VALUES 
('John', 'Doe', 'john.doe@example.com', '555-1234', 1), -- Austin, Texas
('Jane', 'Smith', 'jane.smith@example.com', '555-5678', 2), -- Phoenix, Arizona
('Alice', 'Johnson', 'alice.johnson@example.com', '555-9101', 3), -- Miami, Florida
('Bob', 'Brown', 'bob.brown@example.com', '555-1122', 1), -- Austin, Texas
('Emily', 'Davis', 'emily.davis@example.com', '555-1314', 2), -- Phoenix, Arizona
('Michael', 'Wilson', 'michael.wilson@example.com', '555-1516', 3); -- Miami, Florida
GO