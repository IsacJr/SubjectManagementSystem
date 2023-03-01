# Sistema de Gerenciamento de Disciplinas na Modalidade de Sala de Aula Aberta

O Sistema SAA tem o intuito de dar um maior apoio ao processo de Sala de Aula Aberta, facilitando a integração e articulação de alunos, professores e gestores do governo e da ATI em busca de uma prática conjunta mais efetiva e transparente.

## Começando

As orientações a seguir permitirão a montagem de um ambiente necessário para a execução do código em ambiente de desenvolvimento.

### Pré-requisitos

- [.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet)
- [.NET Entity Framework CLI Tool](https://docs.microsoft.com/pt-br/ef/core/cli/dotnet)
- [Angular 13](https://angular.io/cli)
- [PostgreSQL](https://www.postgresql.org/)
- [Git](https://git-scm.com/book/pt-br/v2/Come%C3%A7ando-Instalando-o-Git)
- [Docker](https://www.docker.com)
- [Docker Compose](https://docs.docker.com/compose/)

### Clonando o Repositório

Para ter uma cópia disponível desse projeto, utilize o comando:

```
git clone https://github.com/IsacJr/SubjectManagementSystem.git
```

> Caso apresente erro ao executar o comando "git", verificar se o mesmo se encontra instalado na máquina através do comando: git --version.

#### Banco de Dados

Para a criação do banco de dados é necessário seguir os seguintes passos abaixos:

1.  Criação de um banco de dados chamado "SubjectManagementSystem".
    > **Dica:** Pode ser utilizado uma ferramenta visual para auxiliar como o PGAdmin ou o DBeaver.
2.  Atualizar os valores de acesso ao banco de dados (User Id e Password) pelos valores utilizados no seu banco de dados Postgres. O arquivo esta localizado em SubjectManagementSystem/backend/SubjectManagementSystem.API/appsettings.json
3.  Executar dentro da pasta "backend" do projeto o seguinte comando abaixo para a criação das tabelas:
    `dotnet ef database update --project SubjectManagementSystem.Repository --startup-project SubjectManagementSystem.API --context ApplicationDbContext`
    4.Após a criação do banco de dados é só popular as principais entidades do sistema como "tb_user".

#### Executando

O projeto esta configurado para rodar em containers docker, e orquestrado pelo docker compose. Portando certifique-se de possuir tanto o docker quanto o docker compose no seu ambiente e execute o seguinte comando na pasta raíz do projeto:

```
docker-compose up
```

## Conclusão

Se todos os passos foram seguidos com sucesso agora é possível acessar o sistema em modo de desenvolvimento através do endereço: http://localhost:8888
