# _Dr. Sillystringz's Factory_

#### _This application will allow a user to assign Engineers and Machines to each other_

#### By _**Nick Lindau**_

## Technologies Used

* _.NET5.0_
* _C#_
* _Visual Studio Code_
* _ASP NET Core MVC_
* _MySql_
* _MySql Workbench_
* _Entity Framework_
* _Bootstrap_
* _CSS_
* _ASP.NET Razor_

## Description

_This application uses many-to-many relationships to allow multiple machine objects to be added to multiple engineer objects and vice versa. The user will be able to Add, Edit, Reassign, & Remove Engineers and Machines as they see fit and display the current details of any and all Machines and Engineers_

## Setup/Installation Requirements
To run this application you will need the following:
* A code editor. [Visual Studio Code](https://code.visualstudio.com/) is what I use.
* [ASP.NET Core](https://dotnet.microsoft.com/download)
* [MySQL and MySQL Workbench](https://www.mysql.com/)

### 1) Cloning the Project:
* Find the respository at (https://github.com/NickyLind/Factory.Solution)
* Select the green <span style="color:green">'Code'</span> button above the repository and copy the HHTPS link
* In your terminal, find the directory you want to place the [INSERT PROJECT HERE] directory in
* In your terminal, use the git command `git clone https://github.com/NickyLind/Factory.Solution`
* Open in Visual Studio Code or another editor

### 2) Setup a Database for the project:
* Create a file in the root directory of the project (`Factory`), and name it `appsettings.json`.
* In the `appsettings.json` file you will need to add the following code
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=nick_lindau;uid=[USERIDHERE];pwd=[USERPASSWORDHERE];"
  }
}
```
* Replace the [USERIDHERE] & [USERPASSWORDHERE] with the username and password associated with your local MySQL server.
* Navigate to the `Factory` Directory in the terminal
* If you have ran one of my projects before and titled the related database `nick_lindau` you will have to run the command `dotnet ef database drop` to remove the previous database
* Once you are sure you have no previous database schema named `nick_lindau` you will need to run the command `dotnet ef database update` to create a database using all the classes from this application.
* You can verify this was created correctly by refreshing the list of schemas in the MySQL Workbench and the schema titled `nick_lindau` should be there

### 3) Running the project:

* Once the project is successfully cloned and the database is connected to can now run the project
* Navigate to the `Factory` directory and build the project with the command `dotnet build` to ensure there are no compiling errors
* Once the project is succesfully built you may run the command `dotnet run` and navigate to Http://localport:5000 in your browser to access the applications

## Known Bugs

* _None that I have found but please let me know what you find_

## License

_[MIT](https://choosealicense.com/licenses/mit/)_
 _Copyright (c) Nick Lindau 03/19/2021_

## Contact Information

_Nick Lindau @ <nicholaithegreat@gmail.com>_
