-- Crear la base de datos
CREATE DATABASE Tienda;

-- Usar la base de datos
USE Tienda;

-- Crear la tabla Producto
CREATE TABLE Producto (
    IdProducto INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Descripcion NVARCHAR(255),
    Precio DECIMAL(10, 2) NOT NULL,
    Stock INT NOT NULL,
    FechaIngreso DATE DEFAULT GETDATE(),

);

INSERT INTO Producto (Nombre, Descripcion, Precio, Stock, FechaIngreso) VALUES
('Laptop Gamer', 'Laptop con procesador i7 y tarjeta gráfica RTX 3060', 1500.00, 10, '2025-05-01'),
('Mouse inalámbrico', 'Mouse Bluetooth con batería recargable', 25.50, 50, '2025-04-20'),
('Teclado mecánico', 'Teclado mecánico con retroiluminación RGB', 80.99, 30, '2025-03-15'),
('Monitor 24"', 'Monitor Full HD 24 pulgadas', 200.00, 20, '2025-02-10'),
('Impresora láser', 'Impresora láser monocromática', 120.75, 15, '2025-01-05'),
('Disco Duro SSD 1TB', 'Disco sólido de estado 1TB, SATA', 110.00, 40, '2025-04-25'),
('Memoria RAM 16GB', 'Memoria DDR4 16GB 3200MHz', 75.00, 25, '2025-03-30'),
('Cámara web HD', 'Cámara para videollamadas HD', 45.00, 35, '2025-04-15'),
('Auriculares Gaming', 'Auriculares con micrófono y sonido envolvente', 65.99, 18, '2025-05-10'),
('Tablet 10"', 'Tablet con pantalla de 10 pulgadas y 64GB almacenamiento', 250.00, 12, '2025-02-28');
