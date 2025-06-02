# 📦 Como Executar este Projeto

## Arquitetura da Solução

A aplicação foi estruturada com base nos princípios de Clean Architecture e Domain-Driven Design, assegurando separação de responsabilidades e um modelo de domínio expressivo. Foram empregados os padrões Repository e Service para garantir modularidade e facilidade na manutenção. A segurança é reforçada através de autenticação via JWT com criptografia. Além disso, a solução conta com uma camada de testes unitários, promovendo qualidade e confiabilidade.

## ✅ Pré-requisitos

- Docker Desktop instalado (inclui Docker Compose).
- Git instalado (opcional, para clonar o repositório).

---

## 🚀 Passo 1: Obter o Código Fonte

Você pode obter o código de duas maneiras:

### ✔️ Via Git

git clone https://github.com/Seteve-conde/EmpacotadorServiceAPI.git

### ✔️ Ou baixando manualmente

1. Acesse o repositório no GitHub.
2. Clique em "Code" > "Download ZIP".
3. Extraia o conteúdo em uma pasta local.

---

## 🚀 Passo 2: Executar os Containers

Na raiz do projeto (onde está o arquivo `docker-compose.yml`), execute o seguinte comando:

docker-compose up --build

Esse comando irá:

- ✅ Construir as imagens necessárias.
- ✅ Criar e iniciar dois containers:
  - Um para o SQL Server.
  - Outro para a API do microserviço.
- ✅ Executar automaticamente as migrations, criando o banco de dados e suas tabelas.

---

## 🚀 Passo 3: Acessar a API

Após a inicialização, a API estará disponível para testes via Swagger no endereço:

[http://localhost:8080/swagger](http://localhost:8080/swagger)

Aqui você poderá testar todos os endpoints expostos pela aplicação.

### ⚠️ Atenção: Autenticação JWT

Como a API utiliza segurança JWT, siga estes passos:

1. Faça login usando:
   - **Usuário:** `user`
   - **Senha:** `123456`
2. Copie o token JWT que será retornado.
3. No topo da interface do Swagger, clique em "Authorize" e cole o token.
   - **Importante:** Não é necessário colocar "Bearer" antes, apenas cole o token.
     
4. Para testar a rota POST /Pedidos/embalar você pode usar o exemplo de entrada json que foi disponibilizado.
https://drive.google.com/file/d/1iS9ugtvXlvhW8zlotq6MOSOlffz0r0ws/view?usp=sharing
---

## 🚀 Passo 4: Encerrar os Containers

Para parar e remover os containers, execute:

docker-compose down

text

---

## ℹ️ Observações Importantes

- ✅ **Não é necessário ter o SQL Server instalado localmente**, pois o banco roda em um container.
- ✅ A API já está configurada para conectar automaticamente ao SQL Server do container.
- ✅ Todo o ambiente foi projetado para ser simples e portátil, facilitando a execução em qualquer máquina que atenda aos pré-requisitos.
