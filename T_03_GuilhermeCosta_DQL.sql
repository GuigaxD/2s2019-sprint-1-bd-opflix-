USE T_Opflix;

SELECT * FROM Categorias;
SELECT * FROM Conteudo;
SELECT * FROM FS;
SELECT * FROM Permissao;
SELECT * FROM Usuarios;
SELECT * FROM Plataforma;

EXEC ListarCategorias 'A��o';

EXEC ListarCategoriasPorId 1;

SELECT * FROM vPlataforma;

