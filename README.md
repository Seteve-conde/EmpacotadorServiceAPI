# Como Executar este Projeto

## ✅ Pré-requisitos

Docker Desktop instalado (inclui Docker Compose).

Git instalado (opcional, para clonar o repositório).

🚀 Passo 1: Obter o Código Fonte

Você pode obter o código de duas maneiras:

Via Git:

bash
Copiar
Editar

git clone https://github.com/Seteve-conde/EmpacotadorServiceAPI.git

cd seu-repositorio
Ou baixando manualmente:

Acesse o repositório no GitHub.

Clique em "Code" > "Download ZIP".

Extraia o conteúdo em uma pasta local.

## 🚀 Passo 2: Executar os Containers

Na raiz do projeto (onde está o arquivo docker-compose.yml), execute:

bash
Copiar
Editar
docker-compose up --build
Esse comando irá:
✅ Construir as imagens necessárias.
✅ Criar e iniciar dois containers:

Um para o SQL Server.

Outro para a API do microserviço.

✅ Executar automaticamente as migrations, criando o banco de dados e suas tabelas.

## 🚀 Passo 3: Acessar a API

Após a inicialização, a API estará disponível para testes via Swagger no endereço:

bash
Copiar
Editar
http://localhost:8080/swagger
Aqui você poderá testar todos os endpoints expostos pela aplicação.

⚠️ Atenção: Como a API usa segurança JWT, siga estes passos:

Faça login usando:

Usuário: user

Senha: 123456

Copie o token JWT que será retornado.

No topo da interface do Swagger, clique em "Authorize" e cole o token.

Obs.: Não é necessário colocar "Bearer" antes, apenas cole o token.

## 🚀 Passo 4: Encerrar os Containers

Para parar e remover os containers, execute:

bash
Copiar
Editar
docker-compose down
ℹ️ Observações Importantes:

Não é necessário ter o SQL Server instalado localmente, pois o banco roda em um container.

A API já está configurada para conectar automaticamente ao SQL Server do container.

Todo o ambiente foi projetado para ser simples e portátil, facilitando a execução em qualquer máquina que atenda aos pré-requisitos.
