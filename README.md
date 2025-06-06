WebAdvert.API
<br />
A personal project by João Luiz demonstrating a RESTful API built with ASP.NET Core, focusing on advertisement management functionalities.

📁 Project Structure
WebAdvert.API/: Main ASP.NET Core Web API project.

AdvertApi.Models/: Contains domain models used across the application.

🛠️ Technologies Used
ASP.NET Core
C#
Entity Framework Core


🚀 Getting Started
Clone the repository:

git clone https://github.com/JoaoLuizDeveloper/WebAdvert.API.git
cd WebAdvert.API
Set up the database:

Ensure you have a SQL Server instance running.

Update the connection string in appsettings.json to point to your SQL Server instance.

Apply migrations and update the database:
dotnet ef database update
Run the application:

Navigate to the WebAdvert.API project directory.

Run the application:

dotnet run
The API will be available at http://localhost:5000.

📄 License
This project is licensed under the MIT License.
