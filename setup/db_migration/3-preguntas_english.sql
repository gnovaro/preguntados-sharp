-- QUESTIONS ENGLISH
USE preguntados;

--Deshabilitamos el autoicremental temporalmente
SET IDENTITY_INSERT pregunta ON;

-- Preguntas categoria 10 Movies
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (51,2,10,'Which of the following directors directed a Star Wars movie?',202,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (52,2,10,'Which of the following films has the most Oscar awards?',208,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (53,2,10,'Which of the following actors was not a cast member on the Lord of the Rings?',212,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (54,2,10,'What year was Star Wars Episode IV - A New Hope released?',214,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (55,2,10,'Which of the following actresses were in the cast of Alien: The eighth passenger?',217,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (56,2,10,'What is the highest grossing film in the history of cinema?',221,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (57,2,10,'What year was Titanic released on Cinema?',225,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (58,2,10,'What is the name of the second Star Wars movie of the Original Trilogy?',231,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (59,2,10,'What is the famous horror character who lived on Elm Street?',233,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (60,2,10,'What is the name of the famous horror character who lived in Haddonfield?',239,1);

-- Preguntas_opcion (respuestas) categoria 10 Movies
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (51,'Peter Jackson ',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (51,'George Lucas',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (51,'Steven Spielberg ',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (51,'Ridley Scott',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (52,'Aliens',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (52,'The Last Emperor',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (52,'Gravity',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (52,'The Lord of the Rings: The Return of the King',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (53,'Elijah Wood',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (53,'Orlando Bloom',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (53,'Viggo Mortensen',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (53,'Morgan Freeman',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (54,'1976',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (54,'1977',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (54,'1978',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (54,'1987',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (55,'Sigourney Weaver',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (55,'Angelina Jolie',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (55,'Julia Roberts',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (55,'Gwyneth Paltrow',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (56,'Avatar',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (56,'Titanic',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (56,'Star Wars: The awakening of force',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (56,'Avengers: Infinity Wars',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (57,'1997',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (57,'1996',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (57,'1999',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (57,'1995',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (58,'Star Wars: A New Hope',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (58,'Star Wars: The Return of the Jedi',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (58,'Star Wars: The Empire Strikes Back',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (58,'Star Wars: Revenge of the Sith',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (59,'Freddy Krugger',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (59,'Jason Voorhes',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (59,'Michael Myers',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (59,'Chucky',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (60,'Freddy Krugger',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (60,'Jason Voorhes',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (60,'Michael Myers',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (60,'Chucky',0);

-- Preguntas categoria 11 Music
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (61,2,11,'What is The Rolling Stones singer name?',241,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (62,2,11,'What is the name of the first album of the Finnish band of the metal genre Nightwish?',245,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (63,2,11,'What was the first music group created by the musical artist John Lennon?',249,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (64,2,11,'Who composed the famous ballet Swan Lake',253,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (65,2,11,'Who composed The Requiem Mass in D minor, K. 626?',257,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (66,2,11,'Who composed the set of 6 symphonic poems called Ma Vlast?',261,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (67,2,11,'Who is the main guitarist AC / DC?',265,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (68,2,11,'Who founded the Cumbia Villera band "Damas Gratis"?',269,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (69,2,11,'Who is the artist that played the hit "Gangnam Style"',273,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (70,2,11,'What century was the composer Ludwig Van Beethoven born?',277,1);

-- Preguntas_opcion (respuestas) categoria 11 Music
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (61,'Mick jagger',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (61,'Keith Richard',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (61,'Charlie Watts',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (61,'Ron Wood',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (62,'Angels Fall First',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (62,'Wishmaster',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (62,'Endless forms most beautiful',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (62,'Eleven',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (63,'The Quarry Men',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (63,'the Beatles',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (63,'What in',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (63,'U2',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (64,'Piotr Ilyich Tchaikovsky',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (64,'Wolfgang Amadeus Mozart',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (64,'Ludwig van Beethoven',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (64,'Antonio Lucio Vivaldi',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (65,'Wolfgang Amadeus Mozart',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (65,'Ludwig van Beethoven',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (65,'Antonio Lucio Vivaldi',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (65,'Antonín Dvořák',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (66,'Bedřich Smetana',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (66,'Richard Wagner',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (66,'Frederic Chopin',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (66,'Franz Schubert',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (67,'Angus Young',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (67,'Brian Johnson',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (67,'Stevie Young',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (67,'Chris Slade',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (68,'Pablo Lescano',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (68,'Ariel "the Traitor"',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (68,'Gabriel Alza',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (68,'Hugo Gómez',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (69,'PSY',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (69,'Kim Hyun-a',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (69,'SPY',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (69,'Ai Weiwei',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (70,'Century XVIII',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (70,'XVII century',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (70,'Twentieth century',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (70,'Century XVI',0);

-- Preguntas categoria 12 Fictional Characters
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (71,2,12,'What is the name of the famous protagonist of the Anime series One piece?',281,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (72,2,12,'What is Eren transformation from Shingeki no Kyojin anime series?',285,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (73,2,12,'Which of the following series gave life to the character Son Goku?',289,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (74,2,12,'How many times did Krillin die in the Dragon Ball saga?',293,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (75,2,12,'Which of the following nineteenth-century detectives bears his name in the title of his series?',297,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (76,2,12,'What was the race of the fictional hybrid character Blade?',301,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (77,2,12,'What is the town name where Will Bryers (Stranger Things) lived?',305,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (78,2,12,'What is character name portrayed by Leonardo DiCaprio in the movie Titanic?',309,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (79,2,12,'Which of the following is a fictitious Japanese monster?',313,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (80,2,12,'How many were the Ronin that make up the Story of the Loyal samurai of Ako?',317,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (81,2,12,'What was the model of the cyborg "Exterminator" that antagonizes the first movie of the Terminator?',321,1);

-- Preguntas_opcion (respuestas) categoria 12 Fictional Characters
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (71,'Monkey D. Luffy',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (71,'Roronoa Zoro',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (71,'Ichigo Kurosaki',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (71,'Naruto Uzumaki',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (72,'Titan',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (72,'Dinosaur',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (72,'2-headed Monster',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (72,'Black Panther',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (73,'Dragon Ball',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (73,'Knights of the Zodiac',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (73,'Evangelion',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (73,'Zenki',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (74,'6 times',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (74,'5 times',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (74,'3 times',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (74,'10 times',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (75,'Conan',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (75,'Sherlock Holmes',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (75,'Patrick Jane',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (75,'John H. Watson',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (76,'Human and Vampire hybrid',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (76,'Human and Wolf Man hybrid',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (76,'Human and Zombie hybrid',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (76,'Human and Ghoul hybrid',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (77,'Hawkins, Indiana',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (77,'Haddonfield, New Jersey',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (77,'Orlando, Florida',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (77,'Jackson, Missipipi',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (78,'Jack Dawson',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (78,'Billy Zane',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (78,'Forrest Gump',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (78,'Brock Lovett',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (79,'Godzilla',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (79,'Morzilla',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (79,'Balrog',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (79,'Critter',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (80,'47',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (80,'37',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (80,'7',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (80,'27',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (81,'T-800 Cyberdyne 101',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (81,'T-500 Cyberdyne 102',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (81,'T-700 Cyberdyne 100',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (81,'T-600 Cyberdyne 104',0);

-- Preguntas categoria 13 Videogames
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (82,2,13,'What game did Mario appear for the first time?',326,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (83,2,13,'What was the first video game in history?',329,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (84,2,13,'Which video game of the Resident Evil saga does the character Nemesis appear?',333,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (85,2,13,'How many worlds has the Super Mario Bros released in 1985 for the NES console?',337,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (86,2,13,'Who was the creator of the Silent Hill horror series released in 1999 for Playstation?',341,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (87,2,13,'What was the theme of the video game Bloody Roar?',345,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (88,2,13,'Which console premiered the video game Tomb Raider?',349,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (89,2,13,'What company was the developer of the Survival Horror game titled Dino Crisis launched in 1999 for PlayStation 1?',353,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (90,2,13,'What is the monetary unit used in the "The Legend of Zelda" saga?',357,1);

-- Preguntas_opcion (respuestas) categoria 13 Videogames
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (82,'The Legend of Zelda',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (82,'Donkey Kong',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (82,'Dig-dug',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (82,'Super Mario Brothers',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (83,'Pong',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (83,'Tetris',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (83,'Kung fu Master',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (83,'Pacman',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (84,'Resident Evil 3',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (84,'Resident Evil 2',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (84,'Resident Evil 1',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (84,'Resident Evil 4',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (85,'8 worlds',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (85,'5 worlds',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (85,'32 worlds',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (85,'10 worlds',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (86,'Keiichiro Toyama',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (86,'Akira Yamaoka',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (86,'Akira Toriyama',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (86,'Edgard Massachusetts',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (87,'Fight between characters that become beasts',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (87,'Fight between spaceships',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (87,'Resolution of puzzles with somber ambience',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (87,'Fight between pirates on islands',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (88,'Sega Saturn',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (88,'PlayStation 1',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (88,'Playstation 2',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (88,'Nintendo 64',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (89,'Capcom',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (89,'Konami',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (89,'Valve',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (89,'Activision',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (90,'Rupees',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (90,'Zenny',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (90,'Gold',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (90,'Silver',0);

-- Preguntas categoria 14 Books
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (91,2,14,'How many books has the original Harry Potter saga published, including and until "the Deathly Hallows"?',361,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (92,2,14,'What century was the Hogwarts School of Magic and Wizardry of the Harry Potter universe founded?',365,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (93,2,14,'Who was the writer of the book The Lord of the Rings?',369,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (94,2,14,'Who was the writer of the book "The Chronicles of Narnia"?',373,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (95,2,14,'Who devised the fictisio book: The Necronomicon?',377,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (96,2,14,'How was titled the first detective novel written by Agatha Christie?',381,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (97,2,14,'Which of the following books did Edgar Allan Poe write?',385,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (98,2,14,'How many novels did the Portuguese-Japanese writer Ryoki Inoue publish under his more than 20 pseudonyms?',389,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (99,2,14,'Who wrote The neighbors die in the novels?',393,1);
INSERT INTO pregunta(id,idioma_id,categoria_id,descripcion,opcion_id_correcta,usuario_id) VALUES (100,2,14,'Which of the following stories did Julio Cortazar not write?',397,1);

-- Preguntas_opcion (respuestas) categoria 14 Book
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (91,'7 Books',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (91,'6 Books',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (91,'8 Books',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (91,'5 Books',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (92,'X',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (92,'XII',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (92,'XV',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (92,'XVII',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (93,'J. R. R. Tolkien',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (93,'C. S. Lewis',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (93,'William Shakespeare',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (93,'H. P. Lovecraft',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (94,'C. S. Lewis',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (94,'J. R. R. Tolkien',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (94,'Edgar Allan Poe',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (94,'Stephen King',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (95,'H. P. Lovecraft',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (95,'J. R. R. Tolkien',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (95,'C. S. Lewis',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (95,'Arthur Conan Doyle',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (96,'The mysterious case of Styles',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (96,'Murder in the East Express',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (96,'Ten little blacks',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (96,'The murder of Roger Ackroyd',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (97,'The Raven+C183',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (97,'Dracula',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (97,'The glow',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (97,'The mystery of Salems Lot',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (98,'More than a thousand',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (98,'More than 100, less than 150',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (98,'More than 300, less than 301',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (98,'More than 20, less than 30',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (99,'Sergio Aguirre',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (99,'Ricardo Piglia',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (99,'Roberto Artl',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (99,'Ernesto Sabato',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (100,'The golden beetle',1);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (100,'Game over',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (100,'The secret weapons',0);
INSERT INTO pregunta_opcion(pregunta_id,descripcion_opcion,correcta) VALUES (100,'All fires the fire',0);


--Habilitamos el autoicremental nuevamente
SET IDENTITY_INSERT pregunta OFF;
