CREATE DATABASE RegistroPersona
GO
USE RegistroPersona
GO
CREATE TABLE Personas
(
	Id int primary key identity(1,1),
	Nombre varchar(30),
	Telefono varchar(13),
	Cedula varchar(13),
	Direccion varchar(max)
);