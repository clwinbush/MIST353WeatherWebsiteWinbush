-- 1. Create Database
CREATE DATABASE LandscapingDB;
GO

USE LandscapingDB;
GO

-- 2. Create Tables

-- Locations Table
CREATE TABLE Locations (
    LocationID INT IDENTITY(1,1) PRIMARY KEY,
    City NVARCHAR(100) NOT NULL,
    State NVARCHAR(100) NOT NULL,
    Country NVARCHAR(100) NOT NULL,
    ZipCode NVARCHAR(20),
    Latitude DECIMAL(9,6),
    Longitude DECIMAL(9,6)
);
GO

-- Climates Table
CREATE TABLE Climates (
    ClimateID INT IDENTITY(1,1) PRIMARY KEY,
    ClimateName NVARCHAR(100) UNIQUE NOT NULL,
    Description NVARCHAR(255)
);
GO

-- Users Table
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    PhoneNumber NVARCHAR(20),
    LocationID INT,
    FOREIGN KEY (LocationID) REFERENCES Locations(LocationID)
);
GO

-- WeatherConditions Table
CREATE TABLE WeatherConditions (
    WeatherConditionID INT IDENTITY(1,1) PRIMARY KEY,
    LocationID INT NOT NULL,
    ClimateID INT NOT NULL,
    AverageTemperature DECIMAL(5,2),
    AverageRainfall DECIMAL(5,2),
    HumidityLevel DECIMAL(5,2),
    LastUpdated DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (LocationID) REFERENCES Locations(LocationID),
    FOREIGN KEY (ClimateID) REFERENCES Climates(ClimateID)
);
GO

-- LandscapingServices Table
CREATE TABLE LandscapingServices (
    ServiceID INT IDENTITY(1,1) PRIMARY KEY,
    ServiceName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(500),
    Category NVARCHAR(100),
    PriceRange NVARCHAR(50)
);
GO

-- ServiceSuitability Table
CREATE TABLE ServiceSuitability (
    ServiceSuitabilityID INT IDENTITY(1,1) PRIMARY KEY,
    ServiceID INT NOT NULL,
    ClimateID INT NOT NULL,
    SuitabilityDescription NVARCHAR(255),
    FOREIGN KEY (ServiceID) REFERENCES LandscapingServices(ServiceID),
    FOREIGN KEY (ClimateID) REFERENCES Climates(ClimateID)
);
GO

-- ServiceProviders Table
CREATE TABLE ServiceProviders (
    ProviderID INT IDENTITY(1,1) PRIMARY KEY,
    CompanyName NVARCHAR(150) NOT NULL,
    ContactPerson NVARCHAR(100),
    Email NVARCHAR(100) UNIQUE NOT NULL,
    PhoneNumber NVARCHAR(20),
    Website NVARCHAR(255),
    LocationID INT,
    CreatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (LocationID) REFERENCES Locations(LocationID)
);
GO

-- Plants Table (Optional)
CREATE TABLE Plants (
    PlantID INT IDENTITY(1,1) PRIMARY KEY,
    PlantName NVARCHAR(100) NOT NULL,
    ScientificName NVARCHAR(150),
    Description NVARCHAR(500),
    ClimateID INT,
    FOREIGN KEY (ClimateID) REFERENCES Climates(ClimateID)
);
GO
