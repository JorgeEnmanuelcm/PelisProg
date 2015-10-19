--create database PeliculasDb


use PeliculasDb;

create table Datos(
PeliculasId int identity(1,1),
Titulo varchar(40),
Descripcion varchar(100),
Ano int,
IMDB int,
Calificacion int,
CategoriaId int
);

create table Generos(
	GeneroId int identity(1,1),
	Descripcion varchar(100)
);

create table Estudios(
	EstudioId int identity(1,1),
	NombreEstudio varchar(40),
);

create table Actores(
	ActorId int identity(1,1),
	NombreActor varchar(40),
);

select *from Datos;

select *from Generos;

select *from Actores;

delete from Datos where PeliculasId=1;






