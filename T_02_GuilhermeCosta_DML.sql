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
INSERT INTO Usuarios(Nome,Email,IdPermissao) VALUES('Helena','Helena@gmail.com',2)


INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('Matrix','Um jovem programador é atormentado por estranhos pesadelos nos quais sempre está conectado por cabos a um imenso sistema de computadores do futuro','1999-05-21','02:00:00',4,1,1)
																						,('A Maldição Da Residência Hill','The Haunting of Hill House é uma série de televisão de terror sobrenatural americana criada por Mike Flanagan.','2018-10-12','23:59:59',2,2,1)
INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('KingKong','Acompanhe o diretor Carl Denham e sua equipe em uma viagem de Nova York até uma ilha misteriosa para as filmagens de um novo longa','2005-12-16','03:21:00',1,1,4)
INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('ToyStory4','Woody, Buzz Lightyear e o resto da turma embarcam em uma viagem com Bonnie e um novo brinquedo chamado Forky.','2019-07-20','01:40:00',3,1,2)
INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('La Casa de Papel','Um grupo de nove ladrões, liderados por um Professor, prepara o roubo do século na Casa da Moeda da Espanha','2017-05-02','20:45:00',4,2,1)
INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('Voando Alto','Manou cresce acreditando que ele é uma gaivota como seus pais. Ele se esforça para nadar, pescar e voar como eles, mas não parece muito talentoso.','2019-08-01','01:50:00',13,1,3)
INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('Leste Oeste','Ezequiel, um ex-piloto, volta à sua cidade natal após 15 anos para disputar uma última corrida. Ele reencontra Stela, um antigo affair, Angelo, o patriarca da família, e Pedro, um jovem de 16 anos que sonha em ser piloto.','2019-09-02','02:45:00',1,1,2)
INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('La Casa de Papel','Um grupo de nove ladrões, liderados por um Professor, prepara o roubo do século na Casa da Moeda da Espanha, com o objetivo de fabricar o próprio dinheiro em quantidades incalculáveis e nunca antes vista.','2017-05-02','20:20:00',3,2,1)
INSERT INTO Conteudo(Titulo,Sinopse,DLanc,Duracao,IdCategoria,IdFS,IdPlataforma) VALUES ('Deuses Americanos','Shadow Moon é um ex-vigarista que serve como segurança e companheiro de viagem para o Sr. Wednesday, um homem fraudulento que é, na verdade, um dos velhos deuses, e está na Terra em uma missão: reunir forças para lutar contra as novas entidades.','2017-04-30','21:00:00',16,2,3)
INSERT INTO Categorias(Nome) VALUES ('Comédia')
									,('Documentário')
									,('Drama')
									,('Ficção Científica')

UPDATE Usuarios SET IdPermissao = 1
WHERE Nome = 'Helena';

UPDATE Conteudo SET Titulo = 'Casa de Papel - 3° Temporada'
WHERE IdConteudo = 8;

CREATE PROCEDURE ListarCategorias @Categorias VARCHAR(255)
AS
SELECT * FROM Conteudo Join Categorias ON Conteudo.IdCategoria = Categorias.IdCategoria
WHERE Categorias.Nome = @Categorias;

EXEC ListarCategorias 'Ação';

ALTER TABLE Usuarios ADD Imagem VARCHAR(255);

UPDATE Usuarios SET Imagem = 'https://pbs.twimg.com/profile_images/646013618128089089/f-yUs90Y.jpg'
WHERE IdUsuario = 5;

UPDATE Usuarios SET Imagem = 'https://static.significados.com.br/foto/kqqdap2_sm.jpg'
WHERE IdUsuario = 6;

UPDATE Usuarios SET Imagem = 'https://i.ytimg.com/vi/ML1LpAocvx4/hqdefault.jpg'
WHERE IdUsuario = 7;

UPDATE Usuarios SET Imagem = 'https://cdn.midiamax.com.br/elasticbeanstalk-us-west-2-809048387867/uploads/2017/02/arquivos_noticias_2017_fev_mucho_macho_serjao_berranteiro-640x430.jpg'
WHERE IdUsuario = 8;

UPDATE Usuarios SET Imagem = 'https://miro.medium.com/fit/c/256/256/1*II0qqGjGA1im-cBZnBjIdQ.jpeg'
WHERE IdUsuario = 9;

CREATE PROCEDURE ListarCategoriasPorId @Categorias INT
AS
SELECT * FROM Conteudo Join Categorias ON Conteudo.IdCategoria = Categorias.IdCategoria
WHERE Categorias.IdCategoria = @Categorias ;

EXEC ListarCategoriasPorId 1;

CREATE VIEW vPlataforma AS
SELECT IdPlataforma, Titulo, IdCategoria from Conteudo

SELECT * FROM vPlataforma;

DELETE FROM Conteudo
WHERE IdConteudo = 9

SELECT * FROM Categorias;
SELECT * FROM Plataforma;
SELECT * FROM Permissao;
SELECT * FROM FS;
SELECT * FROM Conteudo;
SELECT * FROM Usuarios;

DELETE FROM Categorias
WHERE IdCategoria = 12;

