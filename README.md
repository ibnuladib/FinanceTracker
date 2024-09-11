
# Personal Finance Manager

## Overview

The Finance Management Application is a Windows Forms (.NET) project designed to help users manage their personal finances effectively. It provides a user-friendly interface for tracking income and expenses, viewing transactions, updating existing records, and visualizing financial data over time.

## Techonoly Used
#### C#, .NET, SQL

## To Run the Project:

1. **Create a New Database:**
   - Open SQL Server Management Studio or your preferred SQL database management tool.
   - Create a new database for the project.

2. **Execute Database Queries:**
   - Navigate to the `SQL` folder in your project directory.
   - Open the `.sql` file located in that folder.
   - Copy the queries from the `.sql` file and execute them in your new database to set up the schema and initial data.

3. **Update Connection String:**
   - Open the project in Visual Studio.
   - Use `Ctrl+F` to search for `connectionString` within the project files.
     ```csharp
     private readonly string connectionString = "Server=(localdb)\\login;Database=FinanceTracker;Trusted_Connection=True;";
   - Update this to:
     ```csharp
     private readonly string connectionString = "Server=<YOUR DATABASE SERVER/SOURCE>;Database=<DATABASENAME>;Trusted_Connection=True;";

4. **Build and Run the Solution:**
   - In Visual Studio, build the solution by selecting `Build` -> `Build Solution` from the top menu.
   - Run the project by selecting `Debug` -> `Start Debugging` or by pressing `F5`.

5. **Access the Main Dashboard:**
   - Once the project is running, the main dashboard will appear.
   - From the dashboard, you can manage transactions, view reports, and utilize other features of the application.

## Features
#### Robust UI:
Clean, Sleek, Easy to Use and Functional graphical interface for any user to use. The Dashboard displays the important information and buttons without it feeling clunky.
#### Transaction Management:
Add, view, update, and delete transactions.
Manage income and expense entries.
Categorize transactions for better organization.
#### Search Functionality:
Search transactions based on multiple criteria such as TransactionId, CategoryName, TransactionType, and Comments.
#### Category Management:
Add new category or delete previous category, cascade deletion is enabled meaning all transactions associated with the category is deleted too. 
#### Data Visualization:
Graphical representation of net transactions over time. Pie Chart to visualize the categories where expenses come from the most.
#### Net Transactions Calculation:
Calculate and display net income or expense for a selected period.
Real-time update of net transactions when new data is added.

## Schema Diagram
![image](https://github.com/user-attachments/assets/ceb68113-24ff-4447-87b0-a0b57c123bc9)


