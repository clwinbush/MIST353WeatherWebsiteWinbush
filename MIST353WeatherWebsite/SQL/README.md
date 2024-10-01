# Chat GPT Prompts:
1. create a SQL server database for a website that allows users to explore landscaping services for their local climate and weather conditions

2. using sql server, generate data for this table:

CREATE TABLE Users (

    UserID INT IDENTITY(1,1) PRIMARY KEY,

    FirstName NVARCHAR(50) NOT NULL,

    LastName NVARCHAR(50) NOT NULL,

    Email NVARCHAR(100) UNIQUE NOT NULL,

    PhoneNumber NVARCHAR(20),

    LocationID INT,

    FOREIGN KEY (LocationID) REFERENCES Locations(LocationID)

);

with this info:

INSERT INTO Locations (City, State, Country, ZipCode, Latitude, Longitude)

VALUES 

    ('Austin', 'Texas', 'USA', '73301', 30.2672, -97.7431),

    ('Phoenix', 'Arizona', 'USA', '85001', 33.4484, -112.0740),

    ('Miami', 'Florida', 'USA', '33101', 25.7617, -80.1918);

3. In sql server insert data into this table:

CREATE TABLE Plants (

    PlantID INT IDENTITY(1,1) PRIMARY KEY,
    
    PlantName NVARCHAR(100) NOT NULL,
    
    ScientificName NVARCHAR(150),
    
    Description NVARCHAR(500),
    
    ClimateID INT,
    
    FOREIGN KEY (ClimateID) REFERENCES Climates(ClimateID)
    
);
