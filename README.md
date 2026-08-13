# MyFirstApi - ASP.NET Core Web API

A beginner-friendly ASP.NET Core Web API project built using Controllers. This project demonstrates how to create RESTful endpoints with CRUD operations while learning routing, HTTP methods, and controller-based API development.

---

## 📌 Overview

This project was created during my .NET backend learning journey to understand how ASP.NET Core Controllers handle HTTP requests. Unlike Minimal APIs, this project uses the MVC controller approach to organize API logic and expose RESTful endpoints.

---

## 🚀 What I Built

- ASP.NET Core Web API using Controllers
- Weather Forecast API
- CRUD operations
- Controller-based routing
- HTTP methods (GET, POST, PUT, DELETE)
- In-memory data storage

---

## ⚡ Features

- Retrieve weather forecasts
- Add new forecast records
- Update existing forecasts
- Delete forecasts
- RESTful API endpoints
- Controller-based architecture

---

## 🛠 Technologies Used

- C#
- .NET
- ASP.NET Core Web API
- Visual Studio Code

---

## 📂 Project Structure

```
MyFirstApi
│
├── Controllers
│   └── WeatherForecastController.cs
├── Program.cs
└── MyFirstApi.csproj
```

---

## 💻 API Endpoints

| Method | Endpoint | Description |
|---------|----------|-------------|
| GET | `/WeatherForecast` | Retrieve all forecasts |
| POST | `/WeatherForecast` | Create a forecast |
| PUT | `/WeatherForecast/{id}` | Update a forecast |
| DELETE | `/WeatherForecast/{id}` | Delete a forecast |

---

## 🎯 Challenges

While building this project, one of my biggest challenges was understanding how Controllers, routing, and HTTP methods work together. I also learned the difference between controller-based APIs and Minimal APIs, and how requests are mapped to specific controller actions.

---

## 📈 What I Learned

Through this project I learned:

- ASP.NET Core Controller architecture
- REST API fundamentals
- CRUD operations
- Routing and Attribute Routing
- HTTP methods (GET, POST, PUT, DELETE)
- Returning HTTP responses using `Ok()`, `NotFound()`, and `NoContent()`
- Managing temporary data using in-memory collections

This project helped me understand how real backend services organize application logic using controllers.

---

## 🚀 Future Improvements

- Connect with SQL Server
- Use Entity Framework Core
- Add Dependency Injection
- Implement Model Validation
- Enable Swagger/OpenAPI documentation
- Add Authentication & Authorization

---

⭐ This repository is part of my journey toward becoming a Backend .NET Developer.
