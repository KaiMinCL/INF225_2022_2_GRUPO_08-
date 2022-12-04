DECLARE @TABLE VARCHAR(100) = 'table'
DECLARE @COLUMN VARCHAR(100) = 'column'
DECLARE @DESCRIPCION VARCHAR(100) = 'MS_Description'
DECLARE @CurrentUser sysname
select @CurrentUser = schema_name()

CREATE TABLE Pedidos(
    id varchar(100) PRIMARY KEY,
	name varchar(100) NOT NULL,
    date varchar(100) NOT NULL,
    description varchar(100) NOT NULL
)