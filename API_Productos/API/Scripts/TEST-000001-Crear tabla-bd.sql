DECLARE @TABLE VARCHAR(100) = 'table'
DECLARE @COLUMN VARCHAR(100) = 'column'
DECLARE @DESCRIPCION VARCHAR(100) = 'MS_Description'
DECLARE @CurrentUser sysname
select @CurrentUser = schema_name()

CREATE TABLE Productos(
	CodigoProducto varchar(100) NOT NULL,
	Nombre varchar(100) NOT NULL,
   Tipo varchar(20) NOT NULL
)

ALTER TABLE Productos
ADD CONSTRAINT PK_Productos
PRIMARY KEY (CodigoProducto)

ALTER TABLE Productos
ADD Disponibilidad INT NOT NULL 
CONSTRAINT D_Productos_Disponible
DEFAULT (1)

execute sp_addextendedproperty @DESCRIPCION, 
   'Tabla que alamcena los tipos de Productos',
   'user', @CurrentUser, @TABLE, 'Productos'
