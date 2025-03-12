# **E-commerce API** 🛒🚀  

## **Project Overview**  
This **E-commerce API**, built with **.NET Core**, provides a backend solution for managing an online store. It includes features for user authentication, product management, shopping cart functionality, order processing, and payments. The API follows **RESTful principles**, supports **JWT authentication**, and implements best practices for scalability and maintainability.  

---

## **Features**  
✅ **User Authentication & Authorization** (JWT-based login & role management)  
✅ **Product Management** (CRUD operations for products & categories)  
✅ **Shopping Cart** (Add, remove, and update items in the cart)  
✅ **Order Processing** (Create and manage customer orders)  
✅ **Payment Integration** (Simulated payment process for testing)  
✅ **Product Reviews** (Users can leave ratings & feedback)  
✅ **Shipping Management** (User addresses for order deliveries)  
✅ **Database Optimization** (Normalized relational database design with EF Core)  

---

## **Tech Stack**  
🔹 **Backend**: .NET Core (ASP.NET Web API)  
🔹 **Database**: SQL Server (with Entity Framework Core)  
🔹 **Authentication**: JWT (JSON Web Token)  
🔹 **Architecture**: Clean Architecture / Repository Pattern  
🔹 **Tools**: Swagger, Postman  

---

## **Setup Instructions**  
1️⃣ **Clone the repository**  
```bash
git clone https://github.com/yourusername/ecommerce-api.git
cd ecommerce-api
```
2️⃣ **Configure the database** (update `appsettings.json` with your SQL Server connection string)  
3️⃣ **Run database migrations**  
```bash
dotnet ef database update
```
4️⃣ **Start the API**  
```bash
dotnet run
```
5️⃣ **Test the endpoints using Swagger** (`https://localhost:5001/swagger`) or Postman  

---

## **Contributing**  
Feel free to contribute by submitting **issues** or **pull requests**! 🎯  
