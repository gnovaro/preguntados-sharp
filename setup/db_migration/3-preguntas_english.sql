-- question category 10 movies
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion, opcion_id_correcta,usuario_id) 
VALUES(100,2,10,'¿Cúal de los siguientes directores dirigio Star Wars?',2,1);

INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta) 
VALUES(100,'Peter Jackson',0);
INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta) 
VALUES(100,'George Lucas',1);
INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta) 
VALUES(100,'Steven Spielberg',0);
INSERT INTO pregunta_opcion(pregunta_id, descripcion_opcion, correcta) 
VALUES(100,'Ridley Scott',0);

