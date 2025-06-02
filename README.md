# 🚀 Quick SignalR Chat API (signal-r)

A simple real-time chat API built with:

* .NET 8 WebAPI
* SignalR (real-time WebSocket communication)
* JWT Authentication
* SQLite Database (Entity Framework Core)
* Modular & Portfolio Friendly Architecture

---

## 📦 Packages Used

| Package                                             | Description                                           |
| --------------------------------------------------- | ----------------------------------------------------- |
| `Microsoft.AspNetCore.SignalR`                      | Real-time WebSocket communication                     |
| `Microsoft.AspNetCore.Authentication.JwtBearer`     | JWT authentication middleware                         |
| `Microsoft.EntityFrameworkCore.Sqlite`              | SQLite database provider                              |
| `Microsoft.EntityFrameworkCore.Tools`               | EF Core CLI tools for migrations                      |
| `Microsoft.AspNetCore.Identity.EntityFrameworkCore` | User identity management (optional - can be expanded) |
| `Swashbuckle.AspNetCore`                            | Swagger/OpenAPI documentation                         |
| `System.IdentityModel.Tokens.Jwt`                   | Token creation and validation                         |

---

## 🔂 Project Structure

```
/SignalRApi
  /Controllers       -- API Controllers
  /Hubs              -- SignalR Hubs
  /Models            -- DTOs, Entities
  /Data              -- EF Core DbContext
  /Services          -- Business Logic (Auth, Chat etc.)
  /Helpers           -- JWT Helper, Utility classes
  /Repositories      -- Repositories (expandable)
  /Middleware        -- Custom middleware
  Program.cs
  appsettings.json
```

---

## 🔑 Features

* User Registration & Login
* JWT Token Authentication
* Secure SignalR Hub with JWT
* SQLite lightweight database
* Modular directory structure
* CORS enabled for frontend integration
* Swagger UI enabled for easy API testing

---

## 💻 To Run

```bash
# Create initial migration
dotnet ef migrations add InitialCreate

# Apply database migration
dotnet ef database update

# Run API
dotnet run
```

Swagger will be available at:

```
https://localhost:{port}/swagger
```

---

## 💻 React Client (Coming Soon)

This API will be integrated with a ReactJS client for full real-time chat.

---

## ⚠ Notes

* This is intended as a portfolio project showcasing modern .NET backend architecture.
* Fully extendable for production.

---

## 📌 Author

Built by Shiraz Ahmed ⚡
