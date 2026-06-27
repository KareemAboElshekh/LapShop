# 💻 LapShop - Advanced E-Commerce Platform for Laptops & Tech Gadgets

<div align="center">
  <img src="https://img.shields.io/badge/.NET%20Core%208.0-512BD4?style=for-the-badge&logo=.net&logoColor=white" alt="Dotnet Core 8" />
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/ASP.NET%20Core%20MVC-512BD4?style=for-the-badge&logo=.net&logoColor=white" alt="ASP.NET Core MVC" />
  <img src="https://img.shields.io/badge/MS%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server" />
  <img src="https://img.shields.io/badge/Entity%20Framework%20Core-512BD4?style=for-the-badge&logo=.net&logoColor=white" alt="EF Core" />
  <img src="https://img.shields.io/badge/Clean%20Architecture-📋-blue?style=for-the-badge" alt="Clean Architecture" />
</div>

---
## Table of Contents

- Overview
- Features
- Architecture
- Technologies
- Project Structure
- Getting Started
- Future Enhancements
- Author

---

## Overview

LapShop is a web application designed to manage e-commerce store operations through a multi-layered clean architecture.

The system is designed to handle:

- Product & Brand Cataloging
- Customer Shopping Carts
- Order Placement & Tracking
- Admin Sales Dashboard
- Role-Based Security

---

## Features

### Authentication & Authorization
- User Registration & Login
- Role-Based Access Control (Admin / Customer)
- Secure Session Management

### Catalog Management
- View Laptops with Technical Specifications
- Filter by Brand, Price, or Category
- Track Stock Availability & Discounts

### Shopping Cart
- Dynamic Cart Actions (Add, Update, Remove)
- Real-Time Price & Total Calculation
- Persistent Cart State

### Order Management
- Checkout & Order Placement
- Invoicing & Purchase Summary
- Order Status Tracking for Administrators

### Admin Dashboard
- Inventory & Stock Controls
- Sales Performance Analysis
- Category & Brand Configuration

---

## Architecture

The application follows a multi-layered architecture to ensure separation of concerns, maintainability, and scalability.

```text
Presentation Layer (Web / MVC)
            │
            ▼
     Core Domain Layer
            │
            ▼
    Data Access Layer
            │
            ▼
   SQL Server Database
