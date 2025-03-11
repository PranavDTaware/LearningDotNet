Drop database office;

create database office;

use office;

CREATE TABLE Users (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(100) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    Username VARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    Role VARCHAR(50) NOT NULL,
    Token VARCHAR(500) NULL
);

CREATE TABLE Roles (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL UNIQUE -- E.g., Admin, User, Manager
);

INSERT INTO Roles (Name) VALUES ('Admin'), ('User'), ('Manager');


-- Insert 6 sample users into the Users table
INSERT INTO Users (FirstName, LastName, Username, Password, Role) 
VALUES 
    ('Ganesh', 'Shinde', 'ganesh', 'password123', 'Admin'),
    ('Ankur', 'Prasad', 'ankur', 'password123', 'Admin'),
    ('Neha', 'Bhor', 'neha', 'password123', 'User'),
    ('Vishwambhar', 'Kapre', 'vishwambhar', 'password123', 'User'),
    ('Pranav', 'Taware', 'pranav', 'password123', 'Manager'),
    ('Ravi', 'Kumar', 'ravi', 'password123', 'Distributor');

select * from Users;