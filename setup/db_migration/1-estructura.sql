/**
 * Preguntados ESTRUCTURA SQL
 * ESBA
 * GRUPO 1: Novaro, Sumi, Guido, Rodriguez
 * @version: 1.0.4
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
	id bigint NOT NULL IDENTITY(1,1),
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

/**
 * Insertamos un usuario por defecto Admin 
 * Con la contraseña: 4dm1n% con el salt '3$B4' 
  * Concatenado al final del password y hasheado el resultado de la concatenacion en sha256
*/
INSERT INTO usuario(id,nombre,email,idioma_id,contrasena) 
VALUES(1,'Admin','grupo1@esba.com.ar',1,HASHBYTES('SHA2_256',CONCAT_WS('','4dm1n%','3$B4')));

--habilitamos el autoicremental nuevamente
SET IDENTITY_INSERT usuario OFF;

-- Creamos tabla categoria
CREATE TABLE categoria
(
	id int NOT NULL IDENTITY(1,1),
	idioma_id int NOT NULL,
	nombre varchar(50) NOT NULL,
	estado smallint NOT NULL DEFAULT 1
);

-- Creamos LA PK sobre la columna id
ALTER TABLE categoria ADD CONSTRAINT PK_categoria PRIMARY KEY (id); 

--Deshabilitamos el autoicremental temporalmente
SET IDENTITY_INSERT categoria ON;

-- Categorias Español
INSERT INTO categoria(id,idioma_id,nombre) VALUES(1,1,'Películas');
INSERT INTO categoria(id,idioma_id,nombre) VALUES(2,1,'Música');
INSERT INTO categoria(id,idioma_id,nombre) VALUES(3,1,'Personajes de ficción');
INSERT INTO categoria(id,idioma_id,nombre) VALUES(4,1,'Video Juegos');
INSERT INTO categoria(id,idioma_id,nombre) VALUES(5,1,'Libros');

-- Categorias Ingles
INSERT INTO categoria(id,idioma_id,nombre) VALUES(10,2,'Movies');
INSERT INTO categoria(id,idioma_id,nombre) VALUES(11,2,'Music');
INSERT INTO categoria(id,idioma_id,nombre) VALUES(12,2,'Fictional characters');
INSERT INTO categoria(id,idioma_id,nombre) VALUES(13,2,'Videogames');
INSERT INTO categoria(id,idioma_id,nombre) VALUES(14,2,'Books');

--habilitamos el autoicremental nuevamente
SET IDENTITY_INSERT categoria OFF;

-- Creamos la tabla pregunta
CREATE TABLE pregunta
(
	id bigint NOT NULL IDENTITY(1,1),
	idioma_id int NOT NULL,
	categoria_id int NOT NULL,
	descripcion varchar(100) NOT NULL,
	opcion_id_correcta bigint NOT NULL,
	votos_positivos bigint NOT NULL default 0,
	votos_negativos bigint NOT NULL default 0,
	usuario_id bigint NOT NULL, --CREADOR pregunta
	denunciada smallint NOT NULL DEFAULT 0,
	estado smallint NOT NULL DEFAULT 1
);

-- Creamos LA PK sobre la columna id
ALTER TABLE pregunta ADD CONSTRAINT PK_pregunta PRIMARY KEY (id); 

-- Creamos tabla
CREATE TABLE pregunta_opcion
(
	id bigint NOT NULL IDENTITY(1,1),
	pregunta_id bigint NOT NULL,
	descripcion_opcion varchar(80),
	correcta smallint default 0
);

-- Creamos LA PK sobre la columna id
ALTER TABLE pregunta_opcion ADD CONSTRAINT PK_pregunta_opcion PRIMARY KEY (id); 

-- Creamos tabla respuesta
CREATE TABLE respuesta
(
	id bigint NOT NULL IDENTITY(1,1),
	usuario_id bigint NOT NULL,
	pregunta_id bigint  NOT NULL,
	pregunta_opcion_id int  NOT NULL,
	correctamente smallint
);

-- Creamos LA PK sobre la columna id
ALTER TABLE respuesta ADD CONSTRAINT PK_respuesta PRIMARY KEY (id);
																	   
-- Creamos Foreign Key FK_pregunta_categoria
ALTER TABLE pregunta ADD CONSTRAINT FK_pregunta_categoria FOREIGN KEY
(categoria_id) REFERENCES dbo.categoria
(id) ON UPDATE  NO ACTION 
 ON DELETE  NO ACTION; 

-- Creamos Foreign key FK_pregunta_idioma
ALTER TABLE pregunta ADD CONSTRAINT FK_pregunta_idioma FOREIGN KEY
(idioma_id) REFERENCES dbo.idioma
(id) ON UPDATE  NO ACTION 
ON DELETE  NO ACTION;
																	   
