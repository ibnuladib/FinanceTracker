
# Personal Finance Manager

## Overview

The Finance Management Application is a Windows Forms (.NET) project designed to help users manage their personal finances effectively. It provides a user-friendly interface for tracking income and expenses, viewing transactions, updating existing records, and visualizing financial data over time.

## Techonoly Used
#### C#, .NET, SQL

## Usage
To run the project:
1. Create a new database.
2. Copy the queries from the .sql file from the SQL folder and execute them to create a clone of the database.
3. Search the project (using Ctrl+F) and edit the connectionString to change it to your local database.
4. Build and run the solution in Visual Studio.
5. The main dashboard will load, allowing you to manage transactions, view reports, and more.
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


