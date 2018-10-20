/**
 * Preguntados ESTRUCTURA SQL
 * ESBA
 * GRUPO 1: Novaro, Sumi, Guido, Rodriguez
 * @version: 1.0.1
 */
CREATE DATABASE preguntados;

USE preguntados;

-- Creamos tabla idioma
CREATE TABLE idioma
(
	id int NOT NULL IDENTITY (1, 1), -- IDENTITY (1, 1) hace la columna indice autoincrementable
	nombre varchar(50) NOT NULL,
	iso char(2) NOT NULL
);

-- Creamos LA PK sobre la columna id
ALTER TABLE idioma ADD CONSTRAINT PK_idioma PRIMARY KEY (id); 

--habilitamos permitir especificar id
SET IDENTITY_INSERT idioma ON;

-- Insertamos valores de para la tabla idioma por defecto
INSERT INTO idioma (id,nombre,iso) VALUES(1,'Español','es');
INSERT INTO idioma (id,nombre,iso) VALUES(2,'Ingles','en');

-- Volvemos a habilitar el autoincremental
SET IDENTITY_INSERT idioma OFF;

-- Creamos tabla usuario
CREATE TABLE usuario
(
	id int NOT NULL IDENTITY(1,1),
	nombre varchar(50) NOT NULL,
	email varchar(254) NULL,
	fecha_nac date NULL,
	idioma_id int NOT NULL DEFAULT 1,
	puntos int NOT NULL DEFAULT 0,
	contrasena varchar(80) NOT NULL
);

-- Creamos LA PK sobre la columna id
ALTER TABLE usuario ADD CONSTRAINT PK_usuario PRIMARY KEY (id); 

--Deshabilitamos el autoicremental temporalmente
SET IDENTITY_INSERT usuario ON;

-- Insertamos un usuario por defecto Admin con la contraseña: 4dm1n% con el salt '3$B4' contatenado al final del password y hasheado en sha256
INSERT INTO usuario(id,nombre,email,idioma_id,contrasena) 
VALUES(1,'Admin','grupo1@esba.com.ar',1,HASHBYTES('SHA2_256',CONCAT_WS('','4dm1n%','3$B4')));

--habilitamos el autoicremental nuevamente
SET IDENTITY_INSERT usuario OFF;

-- Creamos tabla categoria
CREATE TABLE categoria
(
	id int NOT NULL IDENTITY(1,1),
	nombre varchar(50) NOT NULL,
	idioma_id int NOT NULL
);

-- Creamos LA PK sobre la columna id
ALTER TABLE categoria ADD CONSTRAINT PK_categoria PRIMARY KEY (id); 


--Deshabilitamos el autoicremental temporalmente
SET IDENTITY_INSERT categoria ON;

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

--habilitamos el autoicremental nuevamente
SET IDENTITY_INSERT categoria OFF;


CREATE TABLE pregunta
(
	id int NOT NULL IDENTITY(1,1),
	idioma_id int NOT NULL,
	categoria_id int NOT NULL,
	descripcion varchar(100) NOT NULL,
	opcion_id_correcta int NOT NULL,
	votos_positivos int NOT NULL default 0,
	votos_negativos int NOT NULL default 0,
	usuario_id int NOT NULL, --CREADOR pregunta
	denunciada smallint NOT NULL DEFAULT 0,
	estado smallint NOT NULL DEFAULT 1
);

-- TODO: Revisar el resto

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

