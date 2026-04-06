**Todo List API**

A simple ASP.NET Core Web API for managing Todo tasks.
This project provides a backend service to create, read, update, and manage tasks efficiently.

Features
Create new tasks
Retrieve all tasks
Update task status
Delete tasks (extendable)
Clean architecture with Models and Services
XML-based storage system
Tech Stack
.NET (ASP.NET Core Web API)
C#
XML File Storage
RESTful API design
Project Structure
Todo-List/
│
├── Controllers/
│   └── WeatherForecastController.cs
│
├── Model/
│   ├── ToDoTask.cs
│   └── TaskStatus.cs
│
├── Service/
│   └── XMLTaskService.cs
│
├── Program.cs
├── appsettings.json
└── Todo List.csproj
Getting Started
1. Clone the repository
git clone https://github.com/thelordcat-me/Todo-List.git
cd Todo-List
2. Run the project

Make sure you have the .NET SDK installed, then run:

dotnet run
