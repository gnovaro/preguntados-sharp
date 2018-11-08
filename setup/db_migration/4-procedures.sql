USE preguntados;

--Se crea el procedimiento para el alta de usuarios, con un parametro id de salida
CREATE PROCEDURE usuario_alta
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
	@idioma_id int,
	@categoria_id int,
	@descripcion varchar(100),
	@usuario_id bigint,
	@id bigint output
)
AS
BEGIN
	INSERT INTO pregunta(idioma_id,categoria_id,descripcion,opcion_id_correcta, usuario_id)
	VALUES(@idioma_id, @categoria_id, @descripcion, NULL, @usuario_id)
	SET @id = SCOPE_IDENTITY()
END;


--Se crea el procedimiento para el alta de una opcion , y obtener su id(me importa saber el id, para pasarselo a pregunta)
CREATE PROCEDURE opcion_alta
(
	@pregunta_id bigint,
	@descripcion_opcion varchar(80),
	@correcta smallint,
	@id bigint output
)
AS
BEGIN
	INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta)
	VALUES(@pregunta_id, @descripcion_opcion, @correcta)
	SET @id = SCOPE_IDENTITY()
END;


--Se crea un procedimiento para setear el id de la opcion correcta dentro de la pregunta
CREATE PROCEDURE pregunta_setOpcionCorrecta
(
	@id bigint,
	@opcion_id_correcta bigint
)
AS
BEGIN
	UPDATE pregunta
	SET opcion_id_correcta = @opcion_id_correcta
	WHERE id = @id
END;


--se crea un procedimiento para el alta de una respuesta
CREATE PROCEDURE respuesta_alta
(
	@usuario_id bigint,
	@pregunta_id bigint,
	@pregunta_opcion_id bigint,
	@correctamente smallint
)
AS
BEGIN
	INSERT INTO respuesta(usuario_id, pregunta_id, pregunta_opcion_id, correctamente)
	VALUES(@usuario_id, @pregunta_id, @pregunta_opcion_id, @correctamente)
END;


--se crea un procedimiento para el alta de denuncia
CREATE PROCEDURE denuncia_alta
(
	@usuario_id bigint,
	@pregunta_id bigint,
	@descripcion varchar(255),
	@fecha datetime
)
AS
BEGIN
	INSERT INTO denuncia(usuario_id, pregunta_id, descripcion, fecha)
	VALUES(@usuario_id, @pregunta_id, @descripcion, @fecha)
END;

ALTER PROCEDURE ingreso
(
	@email VARCHAR(254),
	@contrasena VARCHAR(50)
)
AS
BEGIN
	SET NOCOUNT ON
	SET @contrasena = HASHBYTES('SHA2_256',CONCAT(@contrasena,'3$B4'))
	SELECT * FROM usuario WHERE email = @email AND contrasena = @contrasena
END;


 EXECUTE ingreso @email = 'gnovaro@gmail.com', @contrasena='123456'
 
 --Se crea procedimiento para guardar los puntos del usuario
 CREATE PROCEDURE usuario_guardarPuntos
(
	@id bigint,
	@puntos int
)
AS
BEGIN
	UPDATE usuario
	SET puntos = @puntos
	WHERE id = @id
END;

--Se crea el procedimiento para guardar los votos positivos de la pregunta
 CREATE PROCEDURE pregunta_guardarVotoPositivo
(
	@id bigint,
	@positivo bigint
)
AS
BEGIN
	UPDATE pregunta
	SET votos_positivos = @positivo
	WHERE id = @id
END;

--Se crea el procedimiento para guardar los votos negativos de la pregunta
CREATE PROCEDURE pregunta_guardarVotoNegativo
(
	@id bigint,
	@negativo bigint
)
AS
BEGIN
	UPDATE pregunta
	SET votos_negativos = @negativo
	WHERE id = @id
END;