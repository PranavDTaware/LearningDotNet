CREATE DATABASE onlineShopping;

USE onlineShopping;

CREATE TABLE customers (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100),
    Contactnumber VARCHAR(15),
    Email VARCHAR(100),
    Location VARCHAR(100),
    Age INT
);

INSERT INTO customers (name, contactnumber, email, location, age)
VALUES 
('Raj Kumar', '9876543210', 'rajkumar@email.com', 'Delhi', 30),
('Priya Sharma', '9988776655', 'priyasharma@email.com', 'Mumbai', 25),
('Anil Gupta', '9123456789', 'anilgupta@email.com', 'Bangalore', 35),
('Meera Patel', '9001122334', 'meerapatel@email.com', 'Ahmedabad', 40),
('Ravi Verma', '9988771122', 'raviverma@email.com', 'Chennai', 28),
('Neha Reddy', '9506060707', 'neha.reddy@email.com', 'Hyderabad', 33),
('Vikram Singh', '9201020304', 'vikramsingh@email.com', 'Kolkata', 22),
('Sanya Desai', '9911223344', 'sanyadesai@email.com', 'Pune', 45);

DROP TABLE Products;
CREATE TABLE Products (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(255) NOT NULL,
    Category VARCHAR(255),
    Description TEXT,
    ImageUrl VARCHAR(255),
    UnitPrice DOUBLE,
    Quantity INT,
    Likes INT
);

INSERT INTO Products (Id, Title, Category, Description, ImageUrl, UnitPrice, Quantity, Likes)
VALUES
(1, 'Carnation', 'Flowers', 'A beautiful carnation, symbolizing a love that endures forever.', '/images/carnation.jpg', 24, 150, 320),
(2, 'Dahlia', 'Flowers', 'A vibrant dahlia, known for its bold colors and striking shape.', '/images/dahlia.jpg', 30, 100, 410),
(3, 'Gerbera', 'Flowers', 'A cheerful gerbera daisy, perfect for brightening up any room.', '/images/gerbera.jpg', 19, 180, 530),
(4, 'Jasmine', 'Flowers', 'Sweetly fragrant jasmine flowers, ideal for aromatic gardens.', '/images/jasmine.jpg', 20, 200, 370),
(5, 'Lily', 'Flowers', 'Elegant lilies, their fragrance adds charm to any bouquet.', '/images/lily.jpg', 30, 120, 460),
(6, 'Rose', 'Flowers', 'A classic rose, symbolizing love and beauty.', '/images/rose.jpg', 25, 130, 600);


CREATE TABLE orders (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    OrderDate DATETIME,
    Status VARCHAR(255),
    TotalAmount DOUBLE
);

INSERT INTO orders (OrderDate, Status, TotalAmount)
VALUES
    ('2025-01-01 10:30:00', 'Pending', 150),
    ('2025-01-02 14:45:00', 'Shipped', 100),
    ('2025-01-03 09:00:00', 'Delivered', 120),
    ('2025-01-04 11:15:00', 'Cancelled', 200),
    ('2025-01-05 13:30:00', 'Pending', 75),
    ('2025-01-06 16:00:00', 'Shipped', 300);
    
CREATE TABLE users (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255) NOT NULL,
    UserName VARCHAR(255) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL UNIQUE,
    PhoneNumber VARCHAR(15),
    Location VARCHAR(255)
);


DROP table FLowers;
CREATE TABLE Flowers (
    ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(255),
    SalePrice DECIMAL(10, 2),
    UnitPrice DECIMAL(10, 2),
    Quantity INT
);

INSERT INTO Flowers (Name, SalePrice, UnitPrice, Quantity) VALUES 
('Rose', 2.50, 1.80, 100),
('Tulip', 1.20, 0.80, 200),
('Orchid', 5.00, 3.80, 50),
('Marigold', 3.00, 3.80, 300);

DROP TABLE payments;
CREATE TABLE payments (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    OrderId INT NOT NULL,
    Amount DOUBLE NOT NULL,
    PaymentDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    PaymentMode ENUM('Credit Card', 'Debit Card', 'PayPal', 'Bank Transfer') NOT NULL,
    payment_status ENUM('Completed', 'Pending', 'Failed') DEFAULT 'Pending',
    FOREIGN KEY (OrderId) REFERENCES orders(Id)
        ON UPDATE CASCADE
        ON DELETE CASCADE
);

INSERT INTO payments (OrderId, Amount, PaymentDate, PaymentMode, Payment_status) 
VALUES
    (1, 100.50,'2025-01-15 10:30:00', 'Credit Card', 'Completed'),
    (2, 250.75,'2025-01-16 14:45:00', 'PayPal', 'Pending'),
    (3, 450.00,'2025-01-17 09:00:00', 'Bank Transfer', 'Failed'),
    (4, 120.00,'2025-01-18 12:30:00', 'Debit Card', 'Completed'),
    (5, 300.00,'2025-01-19 16:15:00', 'Credit Card', 'Pending');




