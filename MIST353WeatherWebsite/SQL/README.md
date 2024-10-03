# Stored Procedures by Creator
## Chase Winbush
1. spCreatePlant: adds new entry to the Plants table with given info
2. spDeletePlant: deletes entry from the Plants table with given ID
## Chrisian Marchitto
1. spServiceByClimate: finds landscaping services in given climate
2. spPlantsInTemp: finds plants that are located in a climate with an average temperture less than or equal to the one given
## Maxson Lantz
1. spCreateUser: adds entry to Users table with given info
2. spDeleteUser: deletes entry from Users table with given ID
## William Burge
1. spGetPlantByLocation: finds all plants in given location
2. spUserUpdate: changes info in Users table
   
# Chat GPT Prompts
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
4. turn the following into parameters for sql server: UserID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    PhoneNumber NVARCHAR(20),
    LocationID INT,
    FOREIGN KEY (LocationID) REFERENCES Locations(LocationID)

    CREATE PROCEDURE AddUser
    @FirstName NVARCHAR(50) NOT NULL,
    @LastName NVARCHAR(50) NOT NULL,
    @Email NVARCHAR(100) NOT NULL,
    @PhoneNumber NVARCHAR(20) = NULL,
    @LocationID INT = NULL
AS
BEGIN
    INSERT INTO Users (FirstName, LastName, Email, PhoneNumber, LocationID)
    VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @LocationID);
END

