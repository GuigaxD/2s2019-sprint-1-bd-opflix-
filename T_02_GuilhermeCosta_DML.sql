USE T_Opflix;

INSERT INTO Plataforma (Nome) VALUES ('Netflix')
												 ,('Xilften')
												 ,('Amazon')
												 ,('HBO')

INSERT INTO Categorias (Nome) VALUES ('Romance')
									,('Terror')
									,('Ação')
									,('Suspense')

INSERT INTO Permissao(Nome) VALUES	('ADM')
									,('Cliente')
						
INSERT INTO FS(Qual) VALUES ('Filme')
									,('Série')



INSERT INTO Usuarios(Nome,Email,IdPermissao) VALUES ('Pedro','Pedro@gmail.com',1)
														,('José','Jose@gmail.com',2)
														,('Joaquim','Joaquim@gmail.com',1)
														,('Colibri','Colibri@gmail.com',2)

INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('Matrix','Um jovem programador é atormentado por estranhos pesadelos nos quais sempre está conectado por cabos a um imenso sistema de computadores do futuro','1999-05-21','02:00:00',4,1,1)
																						,('A Maldição Da Residência Hill','The Haunting of Hill House é uma série de televisão de terror sobrenatural americana criada por Mike Flanagan.','2018-10-12','23:59:59',2,2,1)
INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('KingKong','Acompanhe o diretor Carl Denham e sua equipe em uma viagem de Nova York até uma ilha misteriosa para as filmagens de um novo longa','2005-12-16','03:21:00',1,1,4)
INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('ToyStory4','Woody, Buzz Lightyear e o resto da turma embarcam em uma viagem com Bonnie e um novo brinquedo chamado Forky.','2019-07-20','01:40:00',3,1,2)
INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('La Casa de Papel','Um grupo de nove ladrões, liderados por um Professor, prepara o roubo do século na Casa da Moeda da Espanha','2017-05-02','20:45:00',4,2,1)
INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('Voando Alto','Manou cresce acreditando que ele é uma gaivota como seus pais. Ele se esforça para nadar, pescar e voar como eles, mas não parece muito talentoso.','2019-08-01','01:50:00',13,1,3)
INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('Leste Oeste','Ezequiel, um ex-piloto, volta à sua cidade natal após 15 anos para disputar uma última corrida. Ele reencontra Stela, um antigo affair, Angelo, o patriarca da família, e Pedro, um jovem de 16 anos que sonha em ser piloto.','2019-09-02','02:45:00',1,1,2)

INSERT INTO Categorias(Nome) VALUES ('Comédia')
									,('Documentário')
									,('Drama')
									,('Ficção Científica')


SELECT * FROM Categorias;
SELECT * FROM Plataforma;
SELECT * FROM Permissao;
SELECT * FROM FS;
SELECT * FROM Conteudo;

DELETE FROM Categorias
WHERE IdCategoria = 12;
