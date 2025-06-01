Como Executar este Projeto
✅ Pré-requisitos
Docker Desktop instalado (inclui Docker Compose).

Git instalado (opcional, para clonar o repositório).

🚀 Passo 1: Obter o Código Fonte
Você pode obter o código de duas maneiras:

Via Git:

bash
Copiar
Editar
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio
Ou baixando manualmente:

Acesse o repositório no GitHub.

Clique em "Code" > "Download ZIP".

Extraia o conteúdo em uma pasta local.

🚀 Passo 2: Executar os Containers
Na raiz do projeto (onde está localizado o arquivo docker-compose.yml), execute o seguinte comando:

bash
Copiar
Editar

docker-compose up --build

Esse comando irá:

✅ Construir as imagens necessárias.
✅ Criar e iniciar dois containers:

Um para o SQL Server.

Outro para a API do microserviço.

🚀 Passo 3: Acessar a API
Após a inicialização bem-sucedida, a API estará disponível para testes através do Swagger, no seguinte endereço:

bash
Copiar
Editar
http://localhost:8080/swagger
Aqui você poderá testar todos os endpoints expostos pela aplicação.

ATENÇÃO: Como tem segurança JWT faça o login primeiro usando o usuário = user e senha = 123456
agora acesse a Authorization no topo da tela e cole o token que apareceu anteriormente como resultado ao fazer o login.

obs: não precisa colocar Bearer antes só cole o token.

🚀 Passo 4: Encerrar os Containers
Para parar e remover os containers criados, execute o comando:

bash
Copiar
Editar

docker-compose down

ℹ️ Observações Importantes
Não é necessário ter o SQL Server instalado localmente, pois o banco de dados será executado diretamente em um container.

A API já está configurada para conectar-se automaticamente ao container do SQL Server.

Todo o ambiente foi projetado para garantir simplicidade e portabilidade, facilitando a execução em qualquer máquina que atenda aos pré-requisitos.
