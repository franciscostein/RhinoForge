# RhinoForge.API

[![.NET 8](https://img.shields.io/badge/.NET-8-blue.svg)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![C# 12](https://img.shields.io/badge/C%23-12-purple.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12)
[![Docker](https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white)](https://www.docker.com/)
[![PostgreSQL](https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white)](https://www.postgresql.org/)
[![Made with Love by Leandro Francisco da Costa](https://img.shields.io/badge/Made%20with%20Love%20by-Leandro%20Francisco%20da%20Costa-ff69b4)](https://github.com/yourusername) 

---

**RhinoForge.API**: A state-of-the-art .NET 8 REST API meticulously crafted to serve as a robust backend for managing a comprehensive inventory of **European heavy-duty, off-road, and military trucks**. This project is a senior developer's study case, designed to showcase advanced skills in building high-performance, maintainable, and scalable enterprise-grade solutions.

---

## 🎯 Project Overview

Inspired by platforms like Planet-Trucks.com and my passion for powerful, resilient European machinery (MAN, Mercedes-Benz, Scania, Volvo, etc.), RhinoForge.API aims to be the definitive backend for a specialized truck dealership or marketplace. It focuses on the unique attributes and operational demands of commercial, military, and off-road vehicles.

The project emphasizes adopting the **latest and best practices** in the .NET ecosystem, providing a tangible example of modern architectural patterns, efficient data handling, and robust API design.

## ✨ Key Features

* **Comprehensive Vehicle Management:** CRUD operations for detailed truck, semi-trailer, and heavy equipment listings.
    * Specific attributes for engine, axle configuration (e.g., 8x8, 6x4), bodywork type (Tipper, Chassis, Military), mileage, etc.
    * Image management integration (cloud storage ready).
* **Advanced Search & Filtering:** Powerful, performant search capabilities by various criteria (make, model, year, price, bodywork, location, features) with full-text search.
* **User & Seller Management:** Secure user authentication (JWT) and role-based authorization (buyers, sellers, administrators). Seller profile management.
* **Inquiry System:** API endpoints for potential buyers to contact sellers.
* **Favorites & Saved Searches:** Personalization features for authenticated users.
* **API Versioning:** Future-proof API design with clear versioning strategy.
* **Health Checks:** Endpoints for monitoring API and dependency health.

## 🚀 Technology Stack & Best Practices

This project leverages the most current and recommended technologies and patterns in the .NET world:

* **Framework:** ASP.NET Core 8.0
* **Language:** C# 12 (utilizing latest language features)
* **Architecture:**
    * **Clean Architecture / Vertical Slice Architecture:** For modularity, testability, and separation of concerns.
    * **Minimal APIs:** Where appropriate for lean endpoint definitions.
* **Data Access:**
    * **ORM:** Entity Framework Core 8.0
    * **Database:** PostgreSQL (with potential for advanced features like JSONB for flexible data structures)
* **Advanced Search:** Elasticsearch (with NEST client) for high-performance, scalable full-text and filtered queries.
* **Caching:** Distributed Caching with Redis for performance optimization.
* **Asynchronous Processing:** MassTransit / RabbitMQ for reliable handling of background tasks (e.g., image processing, notifications, data synchronization).
* **Authentication & Authorization:** JWT Bearer Tokens with ASP.NET Core Identity and Policy-Based Authorization.
* **Validation:** FluentValidation for robust request data validation.
* **Logging:** Structured Logging with Serilog (to console, files, and potentially cloud monitoring like Application Insights).
* **API Documentation:** Swagger/OpenAPI (Swashbuckle.AspNetCore) for interactive documentation.
* **Containerization:** Docker for consistent development environments and deployment.
* **Testing:** Comprehensive Unit and Integration Tests (xUnit.net, Moq).
* **CI/CD:** Designed for seamless integration with GitHub Actions or Azure DevOps Pipelines.

## 🛠️ Getting Started

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/your-username/RhinoForge.API.git](https://github.com/your-username/RhinoForge.API.git)
    cd RhinoForge.API
    ```
2.  **Set up Docker (Recommended):**
    Ensure Docker Desktop is running. This project includes `docker-compose.yml` for easily spinning up PostgreSQL, Redis, and RabbitMQ.
    ```bash
    docker-compose up -d
    ```
3.  **Database Migration:**
    Apply EF Core migrations to set up your database schema.
    ```bash
    dotnet ef database update --project YourProject.Infrastructure
    ```
4.  **Run the API:**
    ```bash
    dotnet run --project YourProject.API
    ```
    (Replace `YourProject.Infrastructure` and `YourProject.API` with your actual project names inside the solution if different)
5.  **Access Swagger UI:**
    Once running, navigate to `https://localhost:7001/swagger` (or your configured port) in your browser to explore the API endpoints interactively.

## 📈 Future Enhancements

* Geospatial search capabilities for location-based truck listings.
* Real-time notifications using SignalR.
* Integration with external vehicle history report services.
* Dedicated Admin Dashboard (could be a separate client application).

## 🤝 Contributing

While primarily a personal study case, feedback and suggestions are welcome. Feel free to open issues or discussions on the repository.

## 👤 Author

**Leandro Francisco da Costa**
* [GitHub Profile](https://github.com/yourusername) - (Replace `yourusername` with your actual GitHub username)
* [LinkedIn Profile](https://www.linkedin.com/in/yourlinkedinprofile) - (Optional: Add your LinkedIn profile URL)

---
