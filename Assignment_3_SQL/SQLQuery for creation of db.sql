CREATE DATABASE skyopsdb;
GO

USE skyopsdb;
GO

-- creating the users table
CREATE TABLE users (
    userid INT PRIMARY KEY IDENTITY(1,1), -- unique identifier for each user, auto-increments via the "identity" keyword like we learned in class
    username NVARCHAR(50) NOT NULL, -- user's chosen username, must be unique, not enforced here
    passwordhash NVARCHAR(255) NOT NULL, 
    email NVARCHAR(100), 
    isdoduser BIT NOT NULL -- flag to identify DOD users for possible enhanced access
);
GO

-- creating the airports table
CREATE TABLE airports (
    airportid INT PRIMARY KEY IDENTITY(1,1), -- unique identifier for each airport, again auto- increments
    name NVARCHAR(100) NOT NULL, 
    location NVARCHAR(100) NOT NULL, 
    icaocode NVARCHAR(4) NOT NULL, 
    ismilitary BIT NOT NULL -- flag to identify if the airport is military or civilian
);
GO

-- creating the weatherconditions table
CREATE TABLE weatherconditions (
    conditionid INT PRIMARY KEY IDENTITY(1,1), -- unique identifier for each weather condition record, again like all above... auto increments
    airportid INT NOT NULL FOREIGN KEY REFERENCES airports(airportid), -- links weather to a specific airport
    timestamp DATETIME NOT NULL, -- the date and time the weather condition was recorded
    temperature FLOAT NOT NULL, 
    windspeed FLOAT NOT NULL, 
    winddirection NVARCHAR(3), 
    visibility FLOAT, -- visibility in kilometers or miles
    conditiondescription NVARCHAR(255) -- textual description of the weather condition, e.g., clear, rainy
);
GO

-- creating the airportdelays table
CREATE TABLE airportdelays (
    delayid INT PRIMARY KEY IDENTITY(1,1), -- unique identifier for each delay record. auto increments yet again
    airportid INT NOT NULL FOREIGN KEY REFERENCES airports(airportid), -- links delay to a specific airport
    timestamp DATETIME NOT NULL, -- the date and time the delay was recorded
    delayduration INT NOT NULL, -- duration of the delay in minutes
    delayreason NVARCHAR(255) -- reason for the delay
);
GO
