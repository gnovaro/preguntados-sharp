/*
	Preguntados ESTRUCTURA SQL
	GRUPO 1
*/
CREATE DATABASE preguntados;

CREATE TABLE idioma
(
	id int,
	nombre varchar(50),
);

INSERT INTO idioma (id,nombre) VALUES(1,'Español');
INSERT INTO idioma (id,nombre) VALUES(2,'Ingles');

CREATE TABLE usuario
(
	id int,
	nombre varchar(50),
	email varchar(254),
	fecha_nac date,
	idoma_id int,
	puntos int DEFAULT 0,
	contrasena varchar(80)
);

CREATE TABLE categoria
(
	id int,
	nombre varchar(50),
	idioma_id int
);

-- Categorias Español
INSERT INTO categoria(id,nombre,idioma_id) VALUES(1,'Películas',1);
INSERT INTO categoria(id,nombre,idioma_id) VALUES(2,'Música',1);
INSERT INTO categoria(id,nombre,idioma_id) VALUES(3,'Personajes de ficción',1);
INSERT INTO categoria(id,nombre,idioma_id) VALUES(4,'Video Juegos',1);
INSERT INTO categoria(id,nombre,idioma_id) VALUES(5,'Libros',1);

-- Categorias Ingles
INSERT INTO categoria(id,nombre,idioma_id) VALUES(10,'Movies',2);
INSERT INTO categoria(id,nombre,idioma_id) VALUES(11,'Music',2);
INSERT INTO categoria(id,nombre,idioma_id) VALUES(12,'Fictional characters',2);
INSERT INTO categoria(id,nombre,idioma_id) VALUES(13,'Videogames',1);
INSERT INTO categoria(id,nombre,idioma_id) VALUES(14,'Books',1);

CREATE TABLE pregunta
(
	id int,
	idioma_id int,
	categoria_id int,
	descripcion varchar(100),
	opcion_id_correcta int,
	votos_positivos int default 0,
	votos_negativos int default 0,
	usuario_id int, --CREADOR pregunta
	denunciada smallint DEFAULT 0,
	estado int DEFAULT 1	
);

CREATE TABLE pregunta_opcion
(
	id INT,
	pregunta_id INT,
	descripcion_opcion varchar(50),
	correcta smallint default 0
);

CREATE TABLE respuesta
(
	id int,
	usuario_id int,
	pregunta_id int,
	pregunta_opcion_id int,
	correctamente smallint
);

