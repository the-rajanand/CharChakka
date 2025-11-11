# 🚘 CharChakka: Car Showroom Management System

CharChakka is a software solution designed to **simplify and streamline the operations of a car showroom**, increasing productivity and enhancing client happiness. This multi-module system provides a comprehensive solution for managing inventory, sales, and customer relations.

---

## ✨ Features and Modules

The system is divided into three primary user modules, all managed by the **Administrator**:

| Module | Primary Responsibilities | Key Actions |
| :--- | :--- | :--- |
| **Admin** | Core system management; responsible for handling user data. | Manage **Customers** and **Dealers**. |
| **Dealer** | Inventory and sales tracking; manages physical showrooms. | Manage **Cars**, **Showrooms**, and **Sales**. |
| **Customer**| Personal access to information and interaction with the showroom.| View **Cars**, check **Tax** details, and file **Complaints**.|

---

## ⚙️ Project Architecture (Data Design)

The system relies on a robust database structure designed to be efficient and fully normalized.

### Database Schema
The database is comprised of **eight key entities**:
`ADMIN`, `CUSTOMER`, `DEALER`, `SHOWROOM`, `VEHICLE`, `SALES`, `TAX`, and `COMPLAINT`.

### Normalization
All core tables in the database schema, including Admin, Customer, Dealer, Showroom, Tax, Vehicle, Complaints, and Sales, satisfy the requirements for the **First Normal Form (1NF)** and **Second Normal Form (2NF)**.

---

## 🛠️ Development Details

* **Development Environment:** Visual Studio
* **Core Technology:** C# / .NET
* **Methodology:** The project followed a structured development methodology including Requirement Analysis, System Design, Implementation, Testing, Deployment, and Maintenance.

---

## 🚀 Getting Started

Follow these steps to clone and run the CharChakka application on your development machine using **Visual Studio**.

### Prerequisites

* **Visual Studio:** A compatible version (e.g., 2019 or later) is required to open the Solution file (`.sln`).
* **Database:** A compatible SQL database instance (likely **SQL Server** or a similar local database) must be running, and the connection string within the project files (`CharChakka.csproj` or a configuration file) must be updated to point to your local instance.
* **Git:** Installed on your system.

### Setup Instructions

1.  **Clone the Repository**
    Open your terminal or command prompt and clone the project files:
    ```bash
    git clone [https://github.com/the-rajanand/CharChakka.git](https://github.com/the-rajanand/CharChakka-Showroom-Management.git)
    cd CharChakka
    ```

2.  **Open in Visual Studio**
    * Navigate to the root directory of the cloned project.
    * Double-click the **`CharChakka.sln`** file to open the entire solution in Visual Studio.

3.  **Restore Dependencies**
    * Visual Studio should automatically prompt you to **restore any NuGet packages** (dependencies). If not, right-click the solution in the Solution Explorer and select **"Restore NuGet Packages."**

4.  **Configure Database Connection**
    * Locate the database connection string within the project's configuration files (e.g., `App.config`, `Web.config`, or in the C# source files).
    * **Update the connection string** to point to your local database server.
    * **Execute the SQL scripts** to create the necessary tables (`ADMIN`, `DEALER`, `VEHICLE`, etc.) and populate them with initial data, based on the schema diagrams provided in the report.

5.  **Run the Application**
    * Ensure the **`CharChakka`** project is set as the startup project.
    * Press **F5** or click the green **"Start"** button in the Visual Studio toolbar.

---

## 👤 Author

* **Raj Anand**
