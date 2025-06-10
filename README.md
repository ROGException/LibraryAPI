# LibraryAPI

A simple Library API for performing CRUD operations. Built with ASP.NET Core, this project allows users to create, read, update, and delete records of books.

## 🚀 Features

- **POST** `/api/books`: Create a new book record (title, author, number of pages)
- **GET** `/api/books`: Retrieve all books in the database
- **GET** `/api/books/{id}`: Retrieve a specific book by ID
- **PUT** `/api/books/{id}`: Update details of a specific book by ID
- **DELETE** `/api/books/{id}`: Delete a specific book by ID

## 🛠️ Technologies Used

- **ASP.NET Core** – Web framework for building the API
- **C#** – Programming language
- **Entity Framework Core** – ORM for interacting with the database
- **SQL Server** – Database used for storing book records
- **Swagger (Swashbuckle)** – For API documentation and testing interface

---

## 📦 Getting Started

### Prerequisites

- [Visual Studio 2022 or later](https://visualstudio.microsoft.com/)
- [.NET SDK 7.0 or later](https://dotnet.microsoft.com/download)
- SQL Server (LocalDB or full instance)

### Steps to Run Locally

1. **Clone the Repository**

   ```bash
   git clone https://github.com/ROGException/LibraryAPI
   cd LibraryAPI

2. **Open the Solution**

Open LibraryAPI.sln in Visual Studio.

3. **Set the Startup Project**

In the Solution Explorer, right-click the API project and select "Set as Startup Project".

4. **Apply Migrations**

Open the `Package Manager` Console in Visual Studio and run:
Update-Database
⚠️ This step is needed if you are using Entity Framework Core with Code-First Migrations.

5. **Set Connection String**

Open `appsettings.json` and replace the placeholder with your actual SQL Server connection string.

6. **Run the Application**

Press F5 or click Start Debugging. The API will launch and Swagger UI should open automatically in your browser (usually at https://localhost:5001/swagger).

🧪 Example JSON for Creating a Book
When using the POST /api/books endpoint, you can use the following request body:

{
  "title": "Clean Code",
  "author": "Robert C. Martin",
  "pages": 464
}

