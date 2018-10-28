--Se crea el procedimiento para el alta de usuarios, con un parametro id de salida
ALTER PROCEDURE usuario_alta
(
	 @nombre varchar(50),
	 @email varchar(254),
	 @idioma_id int,
	 @fechanac date = null,
	 @contrasena varchar(80),
	 @id bigint output
)
AS
BEGIN
	INSERT INTO usuario(nombre, email,idioma_id, fecha_nac,contrasena)
	VALUES (@nombre, @email,@idioma_id,@fechanac,HASHBYTES('SHA2_256',CONCAT(@contrasena,'3$B4')))
	set @id = SCOPE_IDENTITY()
END;

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


--Se crea el procedimiento para el alta de una opcion , y obtener su id(me importa saber el id, para pasarselo a pregunta)
CREATE PROCEDURE opcion_alta
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


--se crea un procedimiento para el alta de denuncia
CREATE PROCEDURE denuncia_alta
(
@p_usuario_id bigint,
@p_pregunta_id bigint,
@p_descripcion varchar(255),
@p_fecha datetime
)
AS
BEGIN
INSERT INTO denuncia(usuario_id, pregunta_id, descripcion, fecha)
VALUES(@p_usuario_id, @p_pregunta_id, @p_descripcion, @p_fecha)
END
