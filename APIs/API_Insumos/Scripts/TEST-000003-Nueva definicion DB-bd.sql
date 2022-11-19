DECLARE @TABLE VARCHAR(100) = 'table'
DECLARE @COLUMN VARCHAR(100) = 'column'
DECLARE @DESCRIPCION VARCHAR(100) = 'MS_Description'
DECLARE @CurrentUser sysname
select @CurrentUser = schema_name()

-- use database
USE [BikeStores]
GO
  
-- drop constraints
DECLARE @DropConstraints NVARCHAR(max) = ''
SELECT @DropConstraints += 'ALTER TABLE ' + QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id)) + '.'
                        +  QUOTENAME(OBJECT_NAME(parent_object_id)) + ' ' + 'DROP CONSTRAINT' + QUOTENAME(name)
FROM sys.foreign_keys
EXECUTE sp_executesql @DropConstraints;
GO
  
-- drop tables
DECLARE @DropTables NVARCHAR(max) = ''
SELECT @DropTables += 'DROP TABLE ' + QUOTENAME(TABLE_SCHEMA) + '.' + QUOTENAME(TABLE_NAME)
FROM INFORMATION_SCHEMA.TABLES
EXECUTE sp_executesql @DropTables;
GO

CREATE TABLE Insumos(
	ID_Insumo INT NOT NULL IDENTITY(0,1) PRIMARY KEY,
	Nombre varchar(100) NOT NULL,
    Stock INT DEFAULT 0 NOT NULL,
    Costo INT,
    Precio INT
)

CREATE TABLE Productos(
	ID_Producto INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	Nombre varchar(100) NOT NULL,
    Stock INT DEFAULT 0 NOT NULL,
    Costo INT,
    Precio INT
)

CREATE TABLE InsumosDeProducto(
	ID_Producto INT FOREIGN KEY REFERENCES Productos(ID_Producto),
	ID_Insumo INT FOREIGN KEY REFERENCES Insumos(ID_Insumo),
    PRIMARY KEY (ID_Producto,ID_Insumo)
)
