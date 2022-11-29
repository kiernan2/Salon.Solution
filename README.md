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

1. Open terminal cd to Appropriate directory enter "git clone (This URL)"
2. Enter "Dotnet Restore" and "Dotnet Build"
3. Import the database from the provided file (open Mysql Workbench, Navigate data import/restore, Select import from self-contained file, target the file "Kiernan_Beattie.sql")
4. Create a appropriate appsettings.jason With a connection string IE
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=salon;uid=root;pwd=<YOUR-PASSWORD-HERE>;"
    }
}
5. Connect to MySQL
6. Open a terminal and cd to "(Wherever you put the file)/HairSalon"
7. Enter dotnet run


MIT

## Contact Information
Kiernan1994@gmail.com