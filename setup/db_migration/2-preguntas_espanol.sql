-- PREGUNTAS ESPAÑOL
USE preguntados;
--Deshabilitamos el autoicremental temporalmente
SET IDENTITY_INSERT pregunta ON;

-- Preguntas categoria 1 peliculas

INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (1,1,1,'¿Cuál de Los siguientes directores dirigió una película de Star Wars?',2,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (2,1,1,'¿Cuál de Los siguientes películas tiene mas premios Oscar?',8,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (3,1,1,'¿Cuál de los siguientes actores no trabajaron en el Señor de los Anillos?',12,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (4,1,1,'¿En qué año se estrenó Star Wars: episodio IV - una nueva esperanza?',14,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (5,1,1,'¿Cuál de las siguientes actrices estuvieron en el reparto de Alien: El octavo pasajero?',17,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (6,1,1,'¿Cual es la película mas taquillera en la historia del cine?',21,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (7,1,1,'¿En qué año se estrenó Titanic?',25,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (8,1,1,'¿Cuál es el nombre de la segunda película de Star Wars de la Trilogia Original?',31,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (9,1,1,'¿Cuál es el famoso personaje de terror que vivió en la calle Elm?',33,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (10,1,1,'¿Cuál es el nombre del famoso personaje de terror que vivió en Haddonfield?',39,1);

--pregunta opcion (respuestas) categoria 1 peliculas
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (1,'Peter Jackson',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (1,'George Lucas',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (1,'Steven Spielberg',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (1,'Ridley Scott',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (2,'Aliens',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (2,'El Últimpo Emperador',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (2,'Gravity',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (2,'El Señor de los Anillos: El retorno del rey',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (3,'Elijah Wood',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (3,'Orlando Bloom',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (3,'Viggo Mortensen',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (3,'Morgan Freeman',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (4,'1976',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (4,'1977',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (4,'1978',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (4,'1987',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (5,'Sigourney Weaver',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (5,'Angelina Jolie',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (5,'Julia Roberts',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (5,'Gwyneth Paltrow',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (6,'Avatar',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (6,'Titanic',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (6,'Star Wars: El despertar de la fuerza',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (6,'Avengers: La Guerra del Infinito',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (7,'1997',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (7,'1996',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (7,'1999',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (7,'1995',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (8,'Star Wars: Una Nueva Esperanza',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (8,'Star Wars: El retorno del Jedi',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (8,'Star Wars: El Imperio contraataca',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (8,'Star Wars: La Venganza de los Sith',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (9,'Freddy Krugger',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (9,'Jason Voorhes',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (9,'Michael Myers',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (9,'Chucky',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (10,'Freddy Krugger',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (10,'Jason Voorhes',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (10,'Michael Myers',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (10,'Chucky',0);

-- Preguntas categoria 2 Musica
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (11,1,2,'¿Cómo se llama el cantante de la banda Rolling Stones?',41,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (12,1,2,'¿Cuál es el nombre del primer album de la banda finlandesa del género metal Nightwish?',45,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (13,1,2,'¿Cuál fue el primer grupo de música creado por el artista musical John Lennon',49,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (14,1,2,'¿Quién compuso el lago de los cisnes?',53,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (15,1,2,'¿Quién compuso La Misa de Réquiem en re menor, K. 626?',57,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (16,1,2,'¿Quién compuso el conjunto de 6 poemas sinfonicos llamado Ma Vlast?',61,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (17,1,2,'¿Quién es el principal  guitarrista de la banda AC/DC?',65,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (18,1,2,'¿Quién fundó la banda de cumbia villera Damas Gratis?',69,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (19,1,2,'¿Cuál es el nombre del artista que interpretó el hit "Gangnam Style"',73,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (20,1,2,'¿En que siglo nació el compositor Ludwig Van Beethoven?',77,1);

--pregunta opcion (respuestas) categoria 2 Musica
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (11,'Mick Jagger',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (11,'Keith Richard',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (11,'Charlie Watts',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (11,'Ron Wood',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (12,'Angels Fall First',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (12,'Wishmaster',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (12,'Endless forms most beautiful',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (12,'Once',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (13,'The Quarry Men',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (13,'The Beatles',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (13,'Queen',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (13,'U2',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (14,'Piotr Ilich Chaikovsky',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (14,'Wolfgang Amadeus Mozart',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (14,'Ludwig Van Beethoven',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (14,'Antonio Lucio Vivaldi',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (15,'Wolfgang Amadeus Mozart',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (15,'Ludwig Van Beethoven',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (15,'Antonio Lucio Vivaldi',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (15,'Antonín Dvořák',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (16,'Bedřich Smetana',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (16,'Richard Wagner',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (16,'Frederic Chopin',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (16,'Franz Schubert',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (17,'Angus Young',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (17,'Brian Johnson ',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (17,'Stevie Young ',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (17,'Chris Slade',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (18,'Pablo Lescano ',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (18,'Ariel "el Traidor" ',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (18,'Gabriel Alza',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (18,'Hugo Gómez',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (19,'PSY',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (19,'Kim Hyun-a',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (19,'SPY',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (19,'Ai Weiwei',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (20,'Siglo XVIII',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (20,'Siglo XVII',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (20,'Siglo XX',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (20,'Siglo XVI',0);

-- Preguntas categoria 3 Personajes de Ficcion
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (21,1,3,'¿Cuál es el nombre del famoso protagonista de la serie de Anime One piece?',81,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (22,1,3,'¿En qué se puede transformar el personaje Eren de la serie Shingeki no Kyojin?',85,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (23,1,3,'¿Cuál de las siguientes series le dio vida al personaje Son Goku?',89,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (24,1,3,'¿Cuántas veces murió Krilin en la saga Dragon Ball?',93,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (25,1,3,'¿Cuál de los siguientes detectives del siglo XIX lleva su nombre en el titulo de su serie?',97,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (26,1,3,'¿Cuál era la raza del personaje híbrido de ficción Blade?',101,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (27,1,3,'¿En qué pueblo vivía el protagonista de la serie Stranger Things, Will Bryers?',105,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (28,1,3,'¿Cómo se llama el personaje que interpreta Leonardo DiCaprio en la película Titanic?',109,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (29,1,3,'¿Cuál de los siguientes es un monstruo japonés fictisio?',113,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (30,1,3,'Cuantos eran los Ronin que componen la Leyenda de los leales samurais de Ako?',117,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (31,1,3,'¿Cuál era el modelo del ciborg "Exterminador" que antagoniza la primer película de Terminator?',121,1);

--pregunta opcion (respuestas) categoria 3 Personajes de Ficcion
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (21,'Monkey D. Luffy',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (21,'Roronoa Zoro',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (21,'Kurosaki Ichigo',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (21,'Naruto Uzumaki',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (22,'En un Titan',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (22,'En un Dinosaurio',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (22,'En un Monstruo de 2 cabezas',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (22,'En una Pantera Negra',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (23,'Dragon Ball',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (23,'Caballeros del Zodiaco',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (23,'Evangelion',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (23,'Zenki',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (24,'6 veces',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (24,'5 veces',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (24,'3 veces',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (24,'10 veces',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (25,'Conan',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (25,'Sherlock Holmes',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (25,'Patrick Jane',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (25,'John H. Watson',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (26,'Humano y Vampiro',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (26,'Humano y Hombre Lobo',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (26,'Humano y Zombie',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (26,'Humano y Ghoul',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (27,'Hawkins, Indiana',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (27,'Haddonfield, Nueva Jersey',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (27,'Orlando, Florida',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (27,'Jackson, Misipipi',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (28,'Jack Dawson',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (28,'Billy Zane',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (28,'Forrest Gump',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (28,'Brock Lovett',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (29,'Godzilla',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (29,'Morzilla',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (29,'Balrog',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (29,'Critter',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (30,'47',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (30,'37',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (30,'7',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (30,'27',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (31,'T-800 Cyberdyne 101',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (31,'T-500 Cyberdyne 102',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (31,'T-700 Cyberdyne 100',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (31,'T-600 Cyberdyne 104',0);


-- Preguntas categoria 4 Video Juegos
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (32,1,4,'¿En qué juego apareció Mario por primera vez?',126,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (33,1,4,'¿Cuál fue el primero video-juego de la historia?',129,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (34,1,4,'¿En qué video-juego de la saga Resident Evil hace su aparición el personaje Némesis?',133,1);

-- Preguntas_opcion (respuestas) categoria 4 Video Juegos
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (32,'The Legend of Zelda',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (32,'Donkey Kong',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (32,'Dig-dug',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (32,'Super Mario Brothers',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (33,'Pong',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (33,'Tetris',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (33,'Kung fu Master',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (33,'Pacman',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (34,'Resident Evil 3',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (34,'Resident Evil 2',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (34,'Resident Evil 1',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (34,'Resident Evil 4',0);


SET IDENTITY_INSERT pregunta OFF;
