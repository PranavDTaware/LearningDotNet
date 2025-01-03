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

CREATE TABLE Products (
    Id INT PRIMARY KEY,
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

