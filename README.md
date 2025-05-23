# 📝 To-Do List Web Application (ASP.NET MVC)

A simple and functional To-Do List web application built using **ASP.NET MVC**, **Entity Framework**, and **SQL Server (LocalDB)**. It allows users to **create, read, update, and delete tasks** with pagination and search functionality.

---

## 🚀 Features

- ✅ Create, Edit, and Delete tasks
- 🔍 Search tasks by title or description
- 📄 View task details
- 📅 Track created and updated timestamps
- 📃 Pagination using `X.PagedList`
- 🖥️ Built with MVC architecture using ASP.NET Framework

---

## 🛠️ Technologies Used

- [C#](https://github.com/skrakib/csharp-learning-roadmap.git)
- [ASP.NET MVC](https://roadmap.sh/aspnet-core)
- [Entity Framework](https://www.tutorialspoint.com/entity_framework/index.htm)
- SQL Server LocalDB
- Bootstrap
- HTML/CSS
- X.PagedList

---

## 📂 Project Structure

<pre> ``` TodoListMVC/ ├── Controllers/ │ └── TaskItemsController.cs ├── Models/ │ └── TaskItem.cs ├── Views/ │ ├── TaskItems/ │ │ ├── Index.cshtml │ │ ├── Create.cshtml │ │ ├── Edit.cshtml │ │ ├── Delete.cshtml │ │ └── Details.cshtml │ └── Shared/ ├── wwwroot/ ├── appsettings.json ├── Program.cs ├── Startup.cs └── TodoListMVC.csproj ``` </pre>

-----------------------------------------------------------------------------------------------------------------------------

## ⚙️ Getting Started

### Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- .NET Framework (if using .NET Core, adjust accordingly)
- SQL Server (LocalDB)

- 
### Setup Instructions

1. **Clone the repository:**
   ```bash
   git clone https://github.com/skrakib/TodoListMVC.git
   cd TodoListMVC

2. **Open the project in Visual Studio.**

3. **Restore NuGet Packages:**
		 ``Go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution > Restore``

4. **Update the database (if using EF Code First):**	
		Open Package Manager Console
		Run:
			Update-Database

**5. Run the project:**

	Press F5 or click the green "Start" button.

# **Sample Tasks**

| Title         | Description        | Status   | Created At          |
| ------------- | ------------------ | -------- | ------------------- |
| Learn MVC     | Study ASP.NET MVC  | Current  | 2025-05-22 10:00 AM |
| Complete ToDo | Build full project | Finished | 2025-05-21 04:15 PM |
