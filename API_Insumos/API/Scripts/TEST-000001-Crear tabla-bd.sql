DECLARE @TABLE VARCHAR(100) = 'table'
DECLARE @COLUMN VARCHAR(100) = 'column'
DECLARE @DESCRIPCION VARCHAR(100) = 'MS_Description'
DECLARE @CurrentUser sysname
select @CurrentUser = schema_name()

CREATE TABLE Insumos(
	ID_Insumo varchar(100) NOT NULL,
	Nombre varchar(100) NOT NULL,
   Stock varchar(1000) NOT NULL
)

ALTER TABLE Insumos
ADD CONSTRAINT PK_Insumos
PRIMARY KEY (ID_Insumo)

execute sp_addextendedproperty @DESCRIPCION, 
   'Tabla que alamcena los Insumos',
   'user', @CurrentUser, @TABLE, 'Insumos'
