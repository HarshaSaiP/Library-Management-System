# 📚 Library Management System

A desktop-based **Library Management System** built using **C# Windows Forms**. The application provides a simple interface for managing library-related user access and operations, with a focus on a clean and beginner-friendly desktop experience.

---

## ✨ Features

* 🔐 **User Login**

  * Secure login interface
  * Username and password validation
  * Database-based authentication

* 📝 **User Registration**

  * New user registration
  * Input validation
  * Stores user details in the database

* 👋 **Welcome Screen**

  * User-friendly welcome interface
  * Navigation between application modules

* 🗄️ **Database Integration**

  * Connects the application to a database
  * Performs database operations using C#

* 🖥️ **Windows Desktop Application**

  * Built using Windows Forms
  * Simple and intuitive graphical interface

---

## 🛠️ Tech Stack

| Technology               | Purpose                 |
| ------------------------ | ----------------------- |
| **C#**                   | Application development |
| **.NET / Windows Forms** | Desktop GUI             |
| **PostgreSQL**           | Database                |
| **Npgsql**               | PostgreSQL connectivity |
| **Visual Studio**        | Development environment |

---

## 📂 Project Structure

```text
Library-Management-System/
│
├── Properties/
│
├── Login.cs
├── Login.Designer.cs
├── Login.resx
│
├── Register.cs
├── Register.Designer.cs
├── Register.resx
│
├── Welcome.cs
├── Welcome.Designer.cs
├── Welcome.resx
│
├── Program.cs
├── App.config
├── LibraryManagementSystem.csproj
├── packages.config
├── library.ico
└── README.md
```

---

## 🔄 Application Flow

```text
            ┌───────────────┐
            │   Application │
            │     Start     │
            └───────┬───────┘
                    │
                    ▼
            ┌───────────────┐
            │     Login     │
            └───────┬───────┘
                    │
           ┌────────┴────────┐
           │                 │
      Existing User      New User
           │                 │
           ▼                 ▼
      Authenticate       Register
           │                 │
           └────────┬────────┘
                    │
                    ▼
            ┌───────────────┐
            │ Welcome Screen│
            └───────────────┘
```

---

## ⚙️ Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/HarshaSaiP/Library-Management-System.git
```

### 2. Open the Project

Open the project in **Visual Studio**.

Open:

```text
LibraryManagementSystem.csproj
```

### 3. Configure the Database

Create the required PostgreSQL database and table(s).

Update the database connection string in:

```text
App.config
```

Example:

```xml
<connectionStrings>
    <add name="LibraryDB"
         connectionString="Host=localhost;Port=5432;Database=LibraryDB;Username=postgres;Password=your_password"
         providerName="Npgsql" />
</connectionStrings>
```

> Replace `your_password` with your PostgreSQL password.

### 4. Restore Dependencies

Restore the required NuGet packages through Visual Studio.

### 5. Build and Run

Build the project:

```text
Build → Build Solution
```

Then run the application using:

```text
Ctrl + F5
```

or:

```text
F5
```

---

## 🗄️ Database

The application uses **PostgreSQL** for storing user information and handling authentication-related database operations.

A typical user table can contain:

| Column         | Description         |
| -------------- | ------------------- |
| `username`     | User's username     |
| `fullname`     | User's full name    |
| `phone_number` | User's phone number |
| `password`     | User's password     |

> **Security Note:** For a production application, passwords should never be stored as plain text. Password hashing such as BCrypt or Argon2 should be used.

---

## 🎯 Project Objectives

The main objectives of this project are:

* To build a functional desktop application using C#.
* To understand Windows Forms application development.
* To implement database connectivity using PostgreSQL.
* To perform CRUD/database operations from a C# application.
* To implement a basic authentication and registration workflow.
* To practice connecting frontend UI components with backend database operations.

---

## 🚀 Future Improvements

The project can be extended with additional library functionality such as:

* 📖 Add and manage books
* 🔍 Search books
* 📤 Issue books
* 📥 Return books
* 📅 Track issue and return dates
* 💰 Automatic fine calculation
* 👨‍🎓 Student/member management
* 📊 Library statistics and dashboard
* 🔑 Password hashing
* 👥 Admin and user roles
* 📜 Transaction history

---

## 📸 Screenshots

Add screenshots of your application here:

```text
### Login
![Login Screen](screenshots/login.png)

### Registration
![Registration Screen](screenshots/register.png)

### Welcome
![Welcome Screen](screenshots/welcome.png)
```

Create a folder named:

```text
screenshots/
```

and place your screenshots inside it.

---

## 🧠 What I Learned

Through this project, I practiced:

* C# programming
* Windows Forms
* Event-driven programming
* Database connectivity
* PostgreSQL
* SQL queries
* User authentication
* Form navigation
* Input validation
* Git and GitHub

---

## 👨‍💻 Author

**Harsha Sai Polnati**

GitHub: [HarshaSaiP](https://github.com/HarshaSaiP)

---

## ⭐ Support

If you found this project useful, consider giving the repository a ⭐ on GitHub!

---

## 📄 License

This project is intended for educational and learning purposes.
