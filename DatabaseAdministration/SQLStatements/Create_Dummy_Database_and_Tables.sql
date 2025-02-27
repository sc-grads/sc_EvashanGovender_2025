USE PracticeDB;

-- Customers Table
CREATE TABLE Customers (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    Phone VARCHAR(15),
    City VARCHAR(50)
);

-- Products Table
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10,2),
    StockQuantity INT,
    Supplier VARCHAR(50)
);

-- Orders Table
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    CustomerID INT,
    ProductID INT,
    OrderDate DATE,
    Quantity INT,
    TotalAmount DECIMAL(10,2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- Insert Data into the Customers table
INSERT INTO Customers (FirstName, LastName, Email, Phone, City) VALUES
('John', 'Doe', 'john.doe@email.com', '123-456-7890', 'New York'),
('Jane', 'Smith', 'jane.smith@email.com', '987-654-3210', 'Los Angeles');

-- Insert Data into the Products table

INSERT INTO Products (ProductName, Category, Price, StockQuantity, Supplier) VALUES
('Laptop', 'Electronics', 800.00, 10, 'TechSupplier'),
('Phone', 'Electronics', 500.00, 20, 'GadgetCo');

-- Insert Data into the Orders table

INSERT INTO Orders (CustomerID, ProductID, OrderDate, Quantity, TotalAmount) VALUES
(1, 1, '2024-02-01', 1, 800.00),
(2, 2, '2024-02-02', 2, 1000.00);
