-- 1. Crear base de datos
CREATE DATABASE ProductManagementDB;
GO


-- 2. Crear tabla Productos
USE ProductManagementDB;
GO

CREATE TABLE Productos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Precio DECIMAL(18,2) NOT NULL,
    Stock INT NOT NULL
);
GO

-- 3. Insertar datos de prueba

USE ProductManagementDB;
GO
INSERT INTO Productos (Nombre, Precio, Stock)
VALUES 
('Mouse Gamer', 45000, 10),
('Teclado Mecánico', 120000, 5),
('Monitor 24 pulgadas', 750000, 3),
('Audífonos', 85000, 15);
GO