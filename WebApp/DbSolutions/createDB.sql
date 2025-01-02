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