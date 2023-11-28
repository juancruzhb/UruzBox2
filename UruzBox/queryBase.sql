use UruzDB

create table Roles (
	Id int not null primary key identity(1,1),
	Nombre varchar (50) not null
)
GO

create table Usuarios (
	Id int not null primary key identity (1,1),
	Nombre Varchar(50) Not null,
	Apellido varchar(50) Not null,
	Usuario varchar (20) not null,
	Contraseña varchar(10) not null,
	Role int not null FOREIGN KEY REFERENCES Roles(Id),
	Activo bit not null)

GO

create table Alumnos (
	Id int not null primary key identity (1,1),
	Nombre Varchar(50) Not null,
	Apellido varchar(50) not null,
	Celular varchar(50) not null,
	Email varchar(50) not null
	)