-- PREGUNTAS ESPAÑOL
USE preguntados;
--Deshabilitamos el autoicremental temporalmente
SET IDENTITY_INSERT pregunta ON;

-- Preguntas categoria 1 peliculas
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion, opcion_id_correcta,usuario_id) 
VALUES(1,1,1,'¿Cúal de los siguientes directores dirigio Star Wars?',2,1);

INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta) 
VALUES(1,'Peter Jackson',0);
INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta) 
VALUES(1,'George Lucas',1);
INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta) 
VALUES(1,'Steven Spielberg',0);
INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta) 
VALUES(1,'Ridley Scott',0);

-- Preguntas categoria 4 Video Juegos
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion, opcion_id_correcta,usuario_id) 
VALUES(2,1,4,'¿En qué juego apareció Mario por primera vez?',6,1);

INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta) 
VALUES(2,'The Legend of Zelda',0);
INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta) 
VALUES(2,'Donkey Kong',1);
INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta) 
VALUES(2,'Dig-dug',0);
INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta) 
VALUES(2,'Super Mario Brothers',0);

SET IDENTITY_INSERT pregunta OFF;
