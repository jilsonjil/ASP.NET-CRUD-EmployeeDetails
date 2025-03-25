# Employee CRUD API

This project is a simple Employee Management API built with **ASP.NET Core** and **Entity Framework Core**. It implements basic **CRUD** (Create, Read, Update, Delete) operations for managing employee records in a database.

---

## Features

- **Create Employee**: Add a new employee to the database.
- **Read Employee(s)**: Retrieve details of a specific employee or a list of all employees.
- **Update Employee**: Modify details of an existing employee.
- **Delete Employee**: Remove an employee from the database.

---

## Tech Stack

- **ASP.NET Core**: For building the Web API.
- **Entity Framework Core**: For data access and interacting with the database.
- **SQL Server**: Database management system for storing employee data.
- **C#**: Programming language used for the development of the backend.

---

## API Endpoints

### 1. **GET /api/employee**
   - Retrieve all employees.
   - **Response**: List of all employees in the system.

### 2. **GET /api/employee/{id}**
   - Retrieve a specific employee by ID.
   - **Response**: Details of the employee with the given ID.

### 3. **POST /api/employee**
   - Create a new employee.
   - **Body**: JSON object with employee details (e.g., first name, last name, email, etc.).
   - **Response**: The created employee.

### 4. **PUT /api/employee/{id}**
   - Update an existing employee's details.
   - **Body**: JSON object with updated employee details.
   - **Response**: No content if the update is successful.

### 5. **DELETE /api/employee/{id}**
   - Delete an employee by ID.
   - **Response**: No content if the deletion is successful.

---


