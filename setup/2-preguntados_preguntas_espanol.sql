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

