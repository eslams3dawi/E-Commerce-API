### **TechZone E-Commerce API ⚡🛒**  
TechZone E-Commerce API is a powerful backend solution built with **.NET Core** for managing an online store specializing in **electronics and tech products**. It provides robust features such as **user authentication, product management, shopping cart functionality, order processing, and secure payments**.  

This API follows **RESTful principles**, supports **JWT authentication**, and is designed with best practices for **scalability, security, and maintainability**.  

---

## **Key Features**  
✅ **User Authentication & Authorization** – Secure login using **JWT-based authentication** and role-based access control.  
✅ **Product Management** – Add, update, and manage a catalog of **electronic devices, accessories, and gadgets**.  
✅ **Shopping Cart & Orders** – Enable users to **add products to the cart, place orders, and track them in real-time**.  
✅ **Payments Integration** – Support for **multiple payment gateways** for seamless transactions.  
✅ **Efficient API Design** – Optimized for performance, following **clean architecture** principles.  

---

## **Database Design & Normalization**  
- **ERD (Entity-Relationship Diagram):** The database is designed using **a well-structured ERD** that defines the relationships between entities such as **Users, Products, Orders, Payments, and Categories**.  
- **Normalization:** The database follows **Normalization rules** (up to **3NF**) to **eliminate redundancy**, ensure **data integrity**, and improve **query performance**.  
- **Mapping:** Proper **Entity Mapping** is implemented using **EF Core**, ensuring optimized **table relationships, foreign keys, and constraints** for smooth database operations.

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
