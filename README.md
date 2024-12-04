# MIST353WeatherWebsite

## Description
Our website is one in whih users can find plants which are suitable for their climate. They an list themselves as a user of and save their info for future use on the website. In addition there is a climate map for those whoo are unsure of what climate type they live in. People can add in plants they know are suitable to a certain type of climate to the website and add locations which are not already avalible to the website.

## Deployment Guide
(guide written assuming user has Microsoft Visual Studio)
1. CLick code button in top right of GitHub
2. Select the option from the dropdown menu which says open with cisual studio
3. Click Open on the popup this will bring up
4. in the top center of visual studio click the https button
<!--done to make markdown stop the list-->
If all steps were followed correctly the website should be opened

## APIs Description
### Maxson Lantz
#### API 1
The purpose of my first api is to add a user to the database with the inputs of first name, last name, phone number, email adress, and location id

#### API 2
 the purpose of my second api is to delete a user from the databse gien their user id

### Chase Winbush
#### API 1
The Purpose of my First API is to add a plant to the database.
The inputs are Plant Name, Scientific Name, Description, and CLimate ID.
The outputs are a new plant.
#### API 2
The Purpose of my Second API is to delete a plant to the database.
The input is PLantID
The output deletes a plant.

### Will Burge
#### API 1
My first API is a put called UpdateUser. It can be used to change any or all aspects of a user that is already in the database including first name, last name, and contact information.

#### API 2
My second API is a get called GetAllPlantsByLocation. It allows the user to type in a location Id, which is a foreign key to the plant table, and then displays all off the plants native to that location.

### Chrisitan Marchitto
#### API 1
My first API is PlantsInTemp. The user inputs an average temperature and the api outputs all of the plants that are less than or equal to the given temperature.
#### API 2
My second API is ServiceByClimate. This allows the user to find all of the services that the company provides for a specific climate zone. The user inputs a climate id and the services available will be outputed.

## Developer Info
