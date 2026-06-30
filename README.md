# 🚗 DVLD (Driving & Vehicle License Department) System

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

## 📌 About The Project
DVLD is a fully-featured enterprise-level desktop application designed to manage driving licenses, vehicle registrations, and test appointments. Built robustly with C# and ADO.NET, it simulates a real-world governmental system with complex business rules, application tracking, and test scheduling. **This comprehensive system is fully developed, thoroughly tested, and operational.**

## 🏗️ Architecture & Engineering Practices
This project was built with a strong focus on clean code and scalable architecture. It strictly follows the **3-Tier Architecture**:
* **Presentation Layer (UI):** Thin UI logic with advanced validations using Windows Forms.
* **Business Logic Layer (BLL):** Encapsulates all governmental rules, application lifecycles, and data processing.
* **Data Access Layer (DAL):** Secure and optimized database interactions using ADO.NET.

**Key Technical Highlights:**
* **Defensive Programming:** Implementation of rigorous null-checks, UI state management, and strict validations to prevent runtime crashes.
* **Lazy Loading:** Optimized database queries by loading related objects (e.g., User Details, Detained Info) only when requested.
* **DRY Principle:** Extensive use of User Controls to modularize UI components (e.g., Driver License Filters) and helper methods to eliminate code duplication.

## 🚀 Core Features
* **👤 User & People Management:** Complete management of personnel data and system users with role-based access.
* **📝 Application Processing:** Handling various types of applications (New, Renew, Replace for Damaged/Lost, Release Detained).
* **🚗 License Management:** Issuance of Local and International driving licenses based on age and previous class rules.
* **🗓️ Test Scheduling:** Managing Vision, Written, and Street tests with strict prerequisites and retake policies (including retake fees).
* **🔒 Detain & Release System:** A complete sub-system to detain licenses for violations and release them upon paying fines and application fees.

## 🛠️ Technology Stack
* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Database:** Microsoft SQL Server
* **Data Access:** ADO.NET

## 👨‍💻 Author
**Mohamed Elsharqawy**
Software Engineer passionate about building secure, scalable systems, AI.
