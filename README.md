# Eau Claire's Salon

#### Employee client tracker for Fidgetech

#### By Kiernan Beattie 

## Technologies Used

* C#
* Dotnet
* Html
* Entity
* MySQL

## Description

* Tracks different stylists that have been hired and their clients

## Setup/Installation Requirements

1. Open terminal cd to a Appropriate directory enter `git clone https://github.com/kiernan2/Salon.Solution.git`
2. Enter `dotnet restore` and `dotnet build` in `Same directory/Salon.Solution/HairSalon`
3. Import the database from the provided file:
    1. Open Mysql Workbench,
    2. Navigate data import/restore
    3. Select import from self-contained file
    4. target the file `Kiernan_Beattie.sql`
4. Create a appropriate appsettings.json With a connection string IE
```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=salon;uid=root;pwd=YOUR-PASSWORD-HERE;"
    }
}
```
5. Open a terminal and cd to `(Wherever you put the file)/Salon.Solution/HairSalon`
6. Enter dotnet run
7. Open a browser Go to `http://localhost:5000`


MIT

## Contact Information
Kiernan1994@gmail.com