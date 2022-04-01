# Animal Shelter API

---

## 🌐 About the Project

### 📖 Description

C# API application designed for an animal shelter to make details regarding specific pets available to users (name, description, group (dog/cat)). Users can return pets based on group information or pet category.

### 🦠 Known Bugs

- No known bugs

### 🛠 Built With

- [Visual Studio Code](https://code.visualstudio.com/)
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
- [MySQL 8.0.20 for Linux](https://dev.mysql.com/)
- [Entity Framework Core 2.2.6](https://docs.microsoft.com/en-us/ef/core/)
- [Swagger - NSwag 13.3.0](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)
- [Postman](postman.com)

---

## 🏁 Getting Started

### 📋 Prerequisites

#### Install .NET Core

- On macOS Mojave or later
  - [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
- On Windows 10 x64 or later
  - [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script

Enter the command `dotnet tool install -g dotnet-script` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench

[Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman

(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

1. Code Editor Download:
   - Option 1: [Atom](https://nodejs.org/en/)
   - Option 2: [VisualStudio Code](https://www.npmjs.com/)
2. Click the download most applicable to your OS and system.
3. Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
4. Optionally, create a [GitHub Account](https://github.com)

### ⚙️ Setup and Use

#### Cloning

1. Click 'Code' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
2. Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
3. Clone the repository to your desktop: `$ git clone https://github.com/RileyShimp/AnimalShelter.Solution`
4. Run the command `cd AnimalShelter.Solution` to enter into the project directory.
5. View or Edit:
   - Code Editor - Run the command `atom .` or `code .` to open the project in Atom or VisualStudio Code respectively for review and editing.
   - Text Editor - Open by double clicking on any of the files to open in a text editor.

#### Download

1. Click 'Code' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
2. Click 'Download ZIP' and unextract.
3. Open by double clicking on any of the files to open in a text editor.

#### AppSettings

1. Create a new file in the message-board-api/MessageBoard directory named `appsettings.json`
2. Add in the following code snippet to the new appsettings.json file:

```
{
  "Logging": {
      "LogLevel": {
      "Default": "Warning"
      }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=YourPassword;"
  }
}
```

3. Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

#### Database

1. Navigate to AnimalShelter.Solution/AnimalShelter directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/AnimalShelter.Solution/AnimalShelter`).
2. Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
3. (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

#### Launch the API

1. Navigate to AnimalShelter.Solution/AnimalShelter directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/AnimalShelter.Solution/AnimalShelter`).
2. Run the command `dotnet run` to have access to the API in Postman or browser.

---
