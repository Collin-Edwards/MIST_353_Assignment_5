# SkyOps Application README

## Company Vision Statement

SkyOps is dedicated to revolutionizing the way airborne operations and aviation professionals plan their missions by integrating real-time weather updates and airport delay information into a single, user-friendly platform. Our aim is to enhance operational safety and efficiency by providing comprehensive weather briefings and delay insights for drop zones and airports worldwide.

## End-User Actions and Corresponding Data Storage Needs

To support the core functionalities of SkyOps, the following actions by end-users necessitate specific data storage and processing capabilities server-side:

### 1. Registering a New User

- **Action:** Users must be able to register for a new account.
- **Data Needs:** Store user details in `Users` table (Username, PasswordHash, UserType).

### 2. Logging In

- **Action:** Users log in to access the application.
- **Data Needs:** Validate credentials against the `Users` table.

### 3. Viewing Weather Briefings for Drop Zones

- **Action:** Users select a drop zone to view its current weather briefing.
- **Data Needs:** Retrieve and display weather conditions from `WeatherConditions` table based on the selected drop zone.

### 4. Checking Airport Weather Conditions

- **Action:** Users search for an airport to check its current weather conditions.
- **Data Needs:** Fetch and display airport weather data from `WeatherConditions` table using the airport's ID.

### 5. Viewing Airport Delays

- **Action:** Users look up delay information for a specific airport.
- **Data Needs:** Access and present delay durations and reasons from the `Delays` table for the chosen airport.

### 6. Updating Profile Information

- **Action:** Users update their profile details.
- **Data Needs:** Modify user information in the `Users` table, such as password or email.
