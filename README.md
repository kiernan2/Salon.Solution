# Eau Claire's Salon

#### Employee client tracker for Fidgetech

#### By Kiernan Beattie 

## Technologies Used

* C#
* Dotnet
* Html
* Entity

## Description

* Tracks different stylists that have been hired and their clients

## Setup/Installation Requirements

1. Open terminal cd to a Appropriate directory enter `git clone https://github.com/kiernan2/Salon.Solution.git`
2. Enter `dotnet restore` and `dotnet build`
3. Import the database from the provided file (open Mysql Workbench, Navigate data import/restore, Select import from self-contained file, target the file `Kiernan_Beattie.sql`)
4. Create a appropriate appsettings.jason With a connection string IE
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=salon;uid=root;pwd=<YOUR-PASSWORD-HERE>;"
    }
}
5. Open a terminal and cd to `(Wherever you put the file)/Salon.Solution/HairSalon`
6. Enter dotnet run
7. Open browser Go to `http://localhost:5000`


MIT

## Contact Information
Kiernan1994@gmail.com