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

