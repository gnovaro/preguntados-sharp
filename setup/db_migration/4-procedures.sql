--Se crea el procedimiento para el alta de usuarios, con un parametro id de salida
CREATE PROCEDURE usuario_alta
(
 @p_id bigint output,
 @p_nombre varchar(50),
 @p_email varchar(254),
 @p_idioma_id int,
 @p_fechanac date,
 @p_contrasena varchar(80)
)
AS
BEGIN
INSERT INTO usuario(nombre, email,idioma_id, fecha_nac,contrasena)
VALUES (@p_nombre, @p_email,@p_idioma_id,@p_fechanac,HASHBYTES('SHA2_256',CONCAT(@p_contrasena,'3$B4')))
set @p_id = SCOPE_IDENTITY()
END


--Se crea el procedimiento para el alta de una pregunta, con un parametro id de salida(Lo necesito para pasarselo a las opciones)
CREATE PROCEDURE pregunta_alta
(
@p_id bigint output,
@p_idioma_id int,
@p_categoria_id int,
@p_descripcion varchar(100),
@p_usuario_id bigint
)
AS
BEGIN
INSERT INTO pregunta(idioma_id,categoria_id,descripcion,opcion_id_correcta, usuario_id)
VALUES(@p_idioma_id, @p_categoria_id, @p_descripcion, NULL, @p_usuario_id)
SET @p_id = SCOPE_IDENTITY()
END

--Se crea el procedimiento para el alta de una opcion(este procedimiento seria para opciones no correctas,donde no me importa saber su id)
CREATE PROCEDURE opcion_alta
(
@p_pregunta_id bigint,
@p_descripcion_opcion varchar(80),
@p_correcta smallint
)
AS
BEGIN
INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta)
VALUES(@p_pregunta_id, @p_descripcion_opcion, @p_correcta)
END

--Se crea el procedimiento para el alta de una opcion correcta, y obtener su id(Aca si me importa saber el id, para pasarselo a pregunta)
CREATE PROCEDURE opcion_correcta_alta
(
@p_id bigint output,
@p_pregunta_id bigint,
@p_descripcion_opcion varchar(80),
@p_correcta smallint
)
AS
BEGIN
INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta)
VALUES(@p_pregunta_id, @p_descripcion_opcion, @p_correcta)
SET @p_id = SCOPE_IDENTITY()
END


--Se crea un procedimiento para setear el id de la opcion correcta dentro de la pregunta
CREATE PROCEDURE pregunta_setOpcionCorrecta
(
@p_id bigint,
@p_opcion_id_correcta bigint
)
AS
BEGIN
UPDATE pregunta
SET opcion_id_correcta = @p_opcion_id_correcta
WHERE id = @p_id
END


--se crea un procedimiento para el alta de una respuesta
CREATE PROCEDURE respuesta_alta
(
@p_usuario_id bigint,
@p_pregunta_id bigint,
@p_pregunta_opcion_id bigint,
@p_correctamente smallint
)
AS
BEGIN
INSERT INTO respuesta(usuario_id, pregunta_id, pregunta_opcion_id, correctamente)
VALUES(@p_usuario_id, @p_pregunta_id, @p_pregunta_opcion_id, @p_correctamente)
END