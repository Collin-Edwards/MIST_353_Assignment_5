INSERT INTO users (username, passwordhash, email, isdoduser, firstname, lastname) VALUES	-- the reason why it's either 0 or 1 for doduser is because a 1 tells you if they are military with the dod while 0 identifies them as a civilian or not affilated
('johndoe56', 'hashedpassword1', 'john.doe56@example.com', 0, 'John', 'Doe'),
('jane.smith89', 'hashedpassword2', 'jane.smith89@example.net', 1, 'Jane', 'Smith'),
('mark_taylor22', 'hashedpassword3', 'mark.taylor22@example.org', 0, 'Mark', 'Taylor'),
('lisa.white34', 'hashedpassword4', 'lisa.white34@example.co.uk', 1, 'Lisa', 'White'),
('kevin.brown91', 'hashedpassword5', 'kevin.brown91@example.ca', 0, 'Kevin', 'Brown'),
('emma.jones47', 'hashedpassword6', 'emma.jones47@example.au', 1, 'Emma', 'Jones'),
('daniel.moore53', 'hashedpassword7', 'daniel.moore53@example.de', 0, 'Daniel', 'Moore'),
('ashley.davis99', 'hashedpassword8', 'ashley.davis99@example.jp', 1, 'Ashley', 'Davis'),
('michael.martinez88', 'hashedpassword9', 'michael.martinez88@example.mx', 0, 'Michael', 'Martinez'),
('sarah.wilson24', 'hashedpassword10', 'sarah.wilson24@example.br', 1, 'Sarah', 'Wilson');
GO

GO
INSERT INTO airports (name, location, icaocode, ismilitary) VALUES
('Global Airfield', '1234 Runway Ln, Springfield', 'GAFD', 0),
('Metro City Airport', '5678 Jetway Blvd, Metroville', 'MCAI', 1),
('Clear Sky Harbor', '9101 Cloudscape St, Clearwater', 'CSHB', 0),
('Oceanview International', '1112 Seabreeze Ave, Oceantown', 'OVIN', 1),
('High Altitude Airbase', '1314 Mountain Rd, Highland', 'HAAB', 0),
('Riverside Regional', '1516 Riverside Dr, Rivercity', 'RVRG', 1),
('Desert Sands Airport', '1718 Dune Ct, Desertville', 'DSAP', 0),
('Pineforest Airfield', '1920 Pine Rd, Forestville', 'PFAP', 1),
('Coastal Gateway Airport', '2122 Shoreline Dr, Coastcity', 'CGAP', 0),
('Northern Lights Airbase', '2324 Aurora Way, Northtown', 'NLAB', 1);
GO
INSERT INTO weatherconditions (airportid, timestamp, temperature, windspeed, winddirection, visibility, conditiondescription) VALUES
(1, '2024-02-27T14:00:00', 23.5, 5.2, 'NNE', 10.0, 'Clear skies'),
(2, '2024-02-27T14:15:00', -5.0, 20.1, 'SW', 15.0, 'Snowy'),
(3, '2024-02-27T14:30:00', 30.0, 2.0, 'SE', 20.0, 'Sunny'),
(4, '2024-02-27T14:45:00', 18.0, 10.5, 'NW', 25.0, 'Partly cloudy'),
(5, '2024-02-27T15:00:00', 15.0, 0.0, 'S', 5.0, 'Foggy'),
(6, '2024-02-27T15:15:00', 27.0, 3.4, 'E', 30.0, 'Hot and dry'),
(7, '2024-02-27T15:30:00', 22.0, 15.0, 'W', 8.0, 'Rainy'),
(8, '2024-02-27T15:45:00', -2.0, 25.0, 'NE', 2.0, 'Blizzard'),
(9, '2024-02-27T16:00:00', 5.0, 12.3, 'SSE', 12.0, 'Chilly'),
(10, '2024-02-27T16:15:00', 33.0, 8.8, 'NNW', 22.0, 'Very hot');
GO
INSERT INTO airportdelays (airportid, timestamp, delayduration, delayreason) VALUES
(1, '2024-02-27T14:00:00', 30, 'Maintenance'),
(2, '2024-02-27T14:30:00', 45, 'Weather: Snowstorm'),
(3, '2024-02-27T15:00:00', 15, 'Technical Issues'),
(4, '2024-02-27T15:30:00', 60, 'Security Alert'),
(5, '2024-02-27T16:00:00', 20, 'Late Arrival'),
(6, '2024-02-27T16:30:00', 120, 'Air Traffic'),
(7, '2024-02-27T17:00:00', 90, 'Weather: Thunderstorms'),
(8, '2024-02-27T17:30:00', 25, 'Operational Delays'),
(9, '2024-02-27T18:00:00', 50, 'Staffing Shortages'),
(10, '2024-02-27T18:30:00', 35, 'Mechanical Repair');
GO
