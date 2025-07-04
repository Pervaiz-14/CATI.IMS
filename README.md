# **Inventory Management System (IMS)**

## **✈️ Project Overview**

This **Inventory Management System (IMS)** is a robust, full-stack application developed for the **Civil Aviation Authority (CAA)**. Designed to streamline and optimize the tracking, management, and control of various inventory assets within the organization, this system aims to enhance operational efficiency, reduce manual errors, and provide real-time insights into inventory levels.

As a **Full Stack .NET Intern**, I am developing this solution to meet the critical demands of modern inventory oversight in a dynamic aviation environment.

## **✨ Key Features (Anticipated/Planned)**

While specific features will evolve, the core functionalities of this IMS are envisioned to include:

* **Asset Registration & Tracking:** Comprehensive recording and tracking of all inventory items, including unique identifiers, status, and location.  
* **Stock Management:** Updates on stock levels, reorder points, and automated alerts for low stock.  
* **Supplier & Vendor Management:** Centralized database for supplier information and procurement history.  
* **Reporting & Analytics:** Generation of customizable reports for inventory valuation, usage patterns, and historical data.  
* **User Management & Roles:** Secure access control with different user roles and permissions.  
* **Intuitive User Interface:** A modern and responsive interface for seamless user experience.

## **🚀 Technology Stack**

This project leverages the power of Microsoft's cutting-edge technologies to deliver a scalable, secure, and performant application:

* **Backend Framework:** **ASP.NET Core**  
  * Building robust and high-performance APIs for data management and business logic.  
* **Frontend Framework:** **Blazor**  
  * Enabling interactive web UIs with C\# instead of JavaScript, providing a rich user experience.  
* **Object-Relational Mapper (ORM):** **Entity Framework Core**  
  * Facilitating seamless interaction with the database, simplifying data access and manipulation.  
* **Database:** **Microsoft SQL Server (MSSQL)**  
  * Providing a reliable and scalable relational database solution for secure data storage.

## **🛠️ Setup and Installation**

To get a local copy of the project up and running for development or testing, follow these steps:

### **Prerequisites**

* [.NET SDK](https://dotnet.microsoft.com/download) (Latest stable version recommended)  
* [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Express or Developer Edition is sufficient for local development)  
* [Visual Studio](https://visualstudio.microsoft.com/downloads/) (with ASP.NET and web development workloads) or [Visual Studio Code](https://code.visualstudio.com/)

### **Steps**

1. **Clone the repository:**  
   ```sh
   git clone https://github.com/Pervaiz-14/CATI.IMS.git  
   cd CATI.IMS

   
   ```

2. Configure Database:  
   Open `appsettings.json` (or `appsettings.Development.json`) and update the `DefaultConnection` string to point to your local SQL Server instance.  
   Example: `Server=your\_server\_name;Database=IMS\_DB;Trusted\_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;`
3. Run Migrations:  
   Open a terminal in the project root and apply database migrations:
   ```
   dotnet ef database update
   
   ```

5. Run the application:  
   Start the local development server.  
   ```cmd
   dotnet run
   ```

   The application will typically launch on https://localhost:5001 (or a similar port).

## **💡 Usage**

Upon successful setup, navigate to the application URL in your web browser. You will be presented with the login screen. Once authenticated (initial user setup might be required, or refer to internal documentation), you can begin managing inventory items, viewing reports, and performing other system operations.

## **🤝 Contribution**

Contributions are welcome\! If you have suggestions or find issues, please open an issue or submit a pull request.

## **📄 License**

This project is licensed under the MIT License \- see the [LICENSE](https://www.google.com/search?q=LICENSE) file for details.

## **📞 Contact**

For any inquiries or further information, please feel free to reach out:

* **Pervaiz**  
* **GitHub:** [Pervaiz-14](https://www.google.com/search?q=https://github.com/Pervaiz-14)  
* **Email:** Pervaiz.jatoi09@gmail.com

*Developed with passion and precision for the skies of tomorrow.*
