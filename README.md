# desafio-animes-protech

1. Repositório no Github: [https://github.com/josalopes/desafio-animes-protech]
2. API desenvolvida em .NET Core 8 e utilizando o ORM de persistência EntityFramework Core
3. Por sua facilidade de instalação, foi usado o banco de dados **Sqlite**. Nome do arquivo: **AnimeDb.db** localizado na pasta raiz do startup project (**Api**). A tabela **Animes** já está populada com alguns registros para facilitar as consultas. Os registros foram inseridos em lote através de migrations.
4. Todas as consultas que recuperam múltiplos registros são paginadas usando os query params **PageNumber** e **PageSize**, os quais, se não passados pela requisição terão valores default: PageNumber = 1 e PageSize = 10.
5. A exclusão de um *anime* não o deleta da tabela, apenas deixa marcado como Ativo = false
6. A segurança de acesso à API foi implementada usando-se o Identity Framework e JWT. Todas rotas exigem autenticação, sendo que a rota que cadastra um *anime* exige do usuário o perfil de Administrador. A rota **api/authentication** permite o registro de um novo usuário, e a rota **api/authentication/login** efetua o login de um usuário já existente, devolvendo o seu token, que será usado para obter autorização de acesso aos recursos.
7. Está sendo disponibilizada uma collection do Postman para acessar as rotas, apesar de também usar o Swagger para isso.
8. O valor do secret para a geração do token JWT está sendo recuperado de uma variável de ambiente chamada SECRET, e deverá ser gerada numa janela de terminal, modo administrador, com o comando: **setx SECRET "DesafioProtechSolutionsFranciscoJosafaLopes" /M**. O texto entre aspas para a geração do secret pode ser qulquer um, desde que não muito pequeno, que não gere uma valor menor que 256 bits. Após gerar a variável, pode ser necessário reiniciar o Visual Studio.
9. O arquivo de log está sendo gerado no path **desafio-animes-protech\Api\bin\Debug\net8.0\logs\\{data}_logfile.txt** relativo à pasta onde está a solution.
