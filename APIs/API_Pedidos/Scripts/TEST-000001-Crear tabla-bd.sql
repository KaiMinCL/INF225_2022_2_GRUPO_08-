DECLARE @TABLE VARCHAR(100) = 'table'
DECLARE @COLUMN VARCHAR(100) = 'column'
DECLARE @DESCRIPCION VARCHAR(100) = 'MS_Description'
DECLARE @CurrentUser sysname
select @CurrentUser = schema_name()

CREATE TABLE Tiendas(
    ID_Tienda INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	Nombre varchar(100) NOT NULL,
    Instagram varchar(100),
)

CREATE TABLE Clientes(
    ID_Cliente INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	Nombre varchar(100) NOT NULL,
    RUT varchar(30),
    Contrasena varchar(100) NOT NULL,
)

CREATE TABLE STAFF(
    ID_Staff INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	Nombre varchar(100) NOT NULL,
    Usuario varchar(30),
    Contrasena varchar(100) NOT NULL,
    ID_Tienda INT FOREIGN KEY REFERENCES Tiendas(ID_Tienda)
)

CREATE TABLE Compras(
    ID_Compra INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	Valor INT NOT NULL,
    ID_Cliente INT FOREIGN KEY REFERENCES Clientes(ID_Cliente)
)

CREATE TABLE Pedidos(
    ID_Pedido INT IDENTITY(0,1) PRIMARY KEY NOT NULL,
	Valor INT NOT NULL,
    ID_Tienda INT FOREIGN KEY REFERENCES Tiendas(ID_Tienda)
)

CREATE TABLE ProductosEnPedido(
	ID_Pedido INT FOREIGN KEY REFERENCES Pedidos(ID_Pedido),
	ID_Producto INT,
    PRIMARY KEY (ID_Producto,ID_Insumo)
)