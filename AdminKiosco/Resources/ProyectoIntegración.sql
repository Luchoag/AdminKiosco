--Eliminamos las tablas si existen
if object_id('Ventas') is not null
ALTER TABLE Ventas
DROP CONSTRAINT FK_Ventas_idProducto;
go
truncate table ventas;
go
drop table Ventas;
go
if object_id('Productos') is not null
ALTER TABLE Productos
DROP CONSTRAINT FK_Productos_idProveedor;
go
truncate table Productos;
go
drop table Productos;
if object_id('Productos') is not null
truncate table Proveedor;
go
drop table Proveedor;
go

--Creamos las tablas Proveedor, Productos y Ventas
create table Proveedor(
idProveedor int identity not null,
Nombre_Proveedor varchar(30),
CUIL varchar(11),
Domicilio varchar(45),
Telefono varchar(11),
Primary Key (idProveedor)
);
go
create table Productos(
idProducto int identity not null,
Nombre_Producto varchar(45),
Precio float,
idProveedor int,
Primary Key (idProducto),
Constraint FK_Productos_idProveedor
Foreign Key (idProveedor) references Proveedor(idProveedor)
);
go
create table Ventas(
Fecha date ,
idProducto int,
Ingresado int,
Vendido int
Primary Key (Fecha, idProducto),
Constraint FK_Ventas_idProducto
Foreign Key (idProducto) references Productos(idProducto)
);
go
insert into Proveedor (Nombre_Proveedor, CUIL, Domicilio, Telefono)
values ('ProveTodo', '3030659420', 'Piedras 549', '46293264');
go
insert into Proveedor (Nombre_Proveedor, CUIL, Domicilio, Telefono)
values ('RapiLleva', '30456123784', 'Lima 123', '42326548');
go
insert into Proveedor (Nombre_Proveedor, CUIL, Domicilio, Telefono)
values ('MaxiProvee', '30303030303', 'Defensa 654', '42546258');
go
insert into Productos (Nombre_Producto, Precio, idProveedor)
values ('Coca-Cola 600', 50, 1);
go
insert into Productos (Nombre_Producto, Precio, idProveedor)
values ('Fanta 600', 45, 1);
go
insert into Productos (Nombre_Producto, Precio, idProveedor)
values ('Agua Villavicencio 2L', 60, 2);
go
insert into Productos (Nombre_Producto, Precio, idProveedor)
values ('Agua Villa del Sur 2L', 55, 2);
go
insert into Productos (Nombre_Producto, Precio, idProveedor)
values ('Alfajor Aguila', 30, 3);
go
insert into Productos (Nombre_Producto, Precio, idProveedor)
values ('Caramelos Sugus', 2, 3);
go
insert into Productos (Nombre_Producto, Precio, idProveedor)
values ('Cigarrillos Marlboro 20', 100, 1);
go
insert into Productos (Nombre_Producto, Precio, idProveedor)
values ('Chocolate Arcor', 40, 3);
go
insert into Productos (Nombre_Producto, Precio, idProveedor)
values ('Helado Sin Parar', 50, 3);
go
insert into Productos (Nombre_Producto, Precio, idProveedor)
values ('Levite Naranja', 25, 1);
go
insert into Ventas (Fecha, idProducto, Ingresado, Vendido)
values ('09-09-2019', 1, 100, 78);
go
insert into Ventas (Fecha, idProducto, Ingresado, Vendido)
values ('09-09-2019', 2, 60, 20);
go
insert into Ventas (Fecha, idProducto, Ingresado, Vendido)
values ('09-09-2019', 3, 200, 120);
go
insert into Ventas (Fecha, idProducto, Ingresado, Vendido)
values ('09-09-2019', 4, 120, 30);
go
insert into Ventas (Fecha, idProducto, Ingresado, Vendido)
values ('09-09-2019', 5, 150, 75);
go
insert into Ventas (Fecha, idProducto, Ingresado, Vendido)
values ('09-09-2019', 6, 200, 160);
go
insert into Ventas (Fecha, idProducto, Ingresado, Vendido)
values ('09-09-2019', 7, 200, 180);
go
insert into Ventas (Fecha, idProducto, Ingresado, Vendido)
values ('09-09-2019', 8, 160, 110);
go
insert into Ventas (Fecha, idProducto, Ingresado, Vendido)
values ('09-09-2019', 9, 50, 12);
go
insert into Ventas (Fecha, idProducto, Ingresado, Vendido)
values ('09-09-2019', 10, 140, 100);
go
--Triggers for Audits
drop table Proveedor_audit;
go
create table Proveedor_audit(
idProveedor int identity not null,
Nombre_Proveedor varchar(30),
CUIL varchar(11),
Domicilio varchar(45),
Telefono varchar(11),
Audit_action varchar(20),
Modified_date datetime,
Modified_by varchar(25)
Primary Key (idProveedor)
);
go
CREATE TRIGGER dbo.LogProveedorAudit
    ON dbo.Proveedor
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Proveedor_audit (Nombre_Proveedor, CUIL, Domicilio, Telefono, audit_action, modified_date, modified_by)
	SELECT i.Nombre_Proveedor, i.CUIL, i.Domicilio, i.Telefono, 'INS', getDate(), SUSER_SNAME()
	FROM inserted i
	UNION ALL
	SELECT  d.Nombre_Proveedor, d.CUIL, d.Domicilio, d.Telefono, 'DEL', getDate(), SUSER_SNAME()
	FROM deleted d
END;
go

drop table Productos_audit;
go
create table Productos_audit(
idProducto int identity not null,
Nombre_Producto varchar(45),
Precio float,
idProveedor int,
Audit_action varchar(20),
Modified_date datetime,
Modified_by varchar(25)
Primary Key (idProducto),
);
go
CREATE TRIGGER dbo.LogProductosAudit
    ON dbo.Productos
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Productos_audit (Nombre_Producto, Precio, idProveedor, audit_action, modified_date, modified_by)
	SELECT i.Nombre_Producto, i.Precio, i.idProveedor, 'INS', getDate(), SUSER_SNAME()
	FROM inserted i
	UNION ALL
	SELECT  d.Nombre_Producto, d.Precio, d.idProveedor, 'DEL', getDate(), SUSER_SNAME()
	FROM deleted d
END;
go

drop table Ventas_audit;
go
create table Ventas_audit(
Fecha date ,
idProducto int,
Ingresado int,
Vendido int,
Audit_action varchar(20),
Modified_date datetime,
Modified_by varchar(25)
Primary Key (Fecha, idProducto),
);
go
CREATE TRIGGER dbo.VentasAudit
    ON dbo.Ventas
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO Ventas_audit (Fecha, idProducto, Ingresado, Vendido, audit_action, modified_date, modified_by)
	SELECT i.Fecha, i.idProducto, i.Ingresado, i.Vendido, 'INS', getDate(), SUSER_SNAME()
	FROM inserted i
	UNION ALL
	SELECT  d.Fecha, d.idProducto, d.ingresado, d.vendido, 'DEL', getDate(), SUSER_SNAME()
	FROM deleted d
END;
go