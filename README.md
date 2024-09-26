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

## 📂 Project Structure

The project follows a modular structure separating business logic, data access, and web interfaces:

```plaintext
Blogger/
├── Blogger.Business/           # Business logic layer
│   ├── Services/               # Business services for blogs, categories, users, comments, etc.
│   ├── Validations/            # Validators for data transfer objects (DTOs)
│
├── Blogger.Data/               # Data access layer (repositories, DbContext)
│
├── Blogger.WEB/                # Web application layer (ASP.NET Core MVC)
│   ├── Controllers/            # Controllers handling HTTP requests
│   ├── Views/                  # Razor Views for UI rendering
│   ├── Services/               # API service clients for communication
│   ├── ViewComponents/         # Reusable components for dynamic content in views
│   └── Utilities/Extensions/   # Extension methods and utilities for controllers
│
└── Blogger.Common/             # Shared utilities, constants, and helpers
