# Blogger Web Application

**Blogger** is a modern and feature-rich web application designed to manage blog posts, categories, tags, and user comments. It includes a user authentication system, role-based access control, and email notifications. Built using ASP.NET Core MVC and .NET 6, this project provides a scalable, secure, and high-performance blogging platform.

## 🚀 Features

- 📝 **Blog Management**: Full CRUD (Create, Read, Update, Delete) functionality for blog posts.
- 📂 **Category and Tag Management**: Organize posts into categories and apply tags for easy navigation.
- 💬 **Comment System**: Allows users to post, edit, and manage comments on blog posts.
- 👤 **User Authentication**: Secure user authentication system with role-based access control (RBAC).
- 🔐 **Role Management**: Different access levels for Admins, Editors, and regular Users.
- 📧 **Email Integration**: Send email notifications for important events like user registration and password recovery.
- 🛠️ **RESTful API**: API endpoints for interacting with various entities (e.g., blogs, users, comments).
- 🌐 **Razor Pages**: Dynamic UI rendering using Razor View Engine.

## 🛠️ Technologies

The Blogger project is built with the following technologies:

- **ASP.NET Core MVC**: Utilizes Model-View-Controller architecture for separating concerns.
- **.NET 6**: Leverages the latest version of .NET for optimal performance and cross-platform support.
- **Entity Framework Core**: For database operations and object-relational mapping (ORM).
- **FluentValidation**: Validation of data transfer objects (DTOs) and models.
- **Razor Pages**: For generating dynamic web content.
- **RESTful API**: Provides REST API endpoints for managing blog posts, users, and comments.
- **Email Sender Service**: Integrated email service to send notifications.
- **Authentication & Authorization**: Role-based security with JWT support for API security.

## 🔧 Installation

### Prerequisites

- .NET 6 SDK
- SQL Server (or another supported database system by Entity Framework Core)
- A code editor such as Visual Studio or Visual Studio Code

### Steps to Run Locally

1. **Clone the repository**:

    ```bash
    git clone https://github.com/your-username/Blogger.git
    ```

2. **Navigate to the project directory**:

    ```bash
    cd Blogger
    ```

3. **Restore project dependencies**:

    ```bash
    dotnet restore
    ```

4. **Apply database migrations**:

    If using Entity Framework Core, ensure your database is up to date:

    ```bash
    dotnet ef database update
    ```

5. **Build the project**:

    ```bash
    dotnet build
    ```

6. **Run the application**:

    ```bash
    dotnet run
    ```

7. Open a browser and navigate to [http://localhost:5000](http://localhost:5000) to access the Blogger web application.

## 🗄️ Database Configuration

Update the `appsettings.json` file in the **Blogger.WEB** project to configure your database connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=your_server;Database=BloggerDB;User Id=your_user;Password=your_password;"
}
