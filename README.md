# Trabalhando com ASP.NET Minimals APIs

### 1. Criando uma Rota para Validação em Memória
Adicione uma rota de exemplo para validação em memória, que pode ser usada para testar a estrutura da API.

### 2. Configurando o Projeto com Entity Framework e Tabela de Administradores
Configure o Entity Framework Core no projeto e crie uma tabela de "Administradores" para armazenar dados de login.

### 3. Criando Seed para Cadastrar Administrador Padrão
Implemente uma função de seed para inserir um administrador padrão no banco de dados durante a inicialização.

### 4. Validando Administrador com Login e Senha no Banco de Dados
Crie uma funcionalidade que valide o administrador utilizando login e senha armazenados no banco de dados.

### 5. Configurando Modelo de Veículos
Defina o modelo de dados para os veículos que serão gerenciados pela aplicação.

### 6. Configurando Swagger na Aplicação
Configure o Swagger para documentação automática da API, facilitando o desenvolvimento e testes.

### 7. Criando Rota de Home Respondendo por JSON
Implemente uma rota /home que retorne uma resposta em JSON, indicando que a API está operacional.

### 8. Criando o CRUD para Veículos
Desenvolva as operações CRUD (Create, Read, Update, Delete) para o gerenciamento de veículos.

### 9. Criando Validação ao Cadastrar e Atualizar Veículo
Adicione validações ao criar e atualizar veículos, garantindo que os dados sejam consistentes.

### 10. Criando Endpoints para Administrador
Implemente endpoints para as operações de gerenciamento dos administradores da aplicação.

### 11. Configurando Token JWT no Projeto
Configure a autenticação via token JWT para proteger os endpoints da API.

### 12. Configurando Swagger para a Passagem de Token JWT
Ajuste o Swagger para aceitar tokens JWT nas requisições, permitindo a simulação de endpoints protegidos.

### 13. Criando Autorização com Perfil Adm e Editor
Implemente autorização para diferentes perfis de usuários (Admin e Editor) na aplicação.

### 14. Refatorando o Projeto Criando SLN e Projeto de Test
Crie uma solução (.sln) e adicione um projeto de testes para melhor organização do código e facilidade de manutenção.

### 15. Criando Teste de Unidade para os Modelos Administrador e Veículo
Desenvolva testes de unidade para validar o comportamento dos modelos "Administrador" e "Veículo".

### 16. Testes de Persistência
Implemente testes de persistência para garantir que os dados sejam salvos corretamente no banco de dados.

### 17. Criando Testes de Request
Desenvolva testes de request para validar os endpoints da API.

### Banco de Dados Utilizado
Este projeto utiliza o MySQL como banco de dados, com o pacote Pomelo.EntityFrameworkCore.MySql para integração com o Entity Framework Core.

### Versões utilizadas
- .NET 7.0
- Microsoft.AspNetCore.Authentication.JwtBearer Version 7.0.14
- Microsoft.EntityFrameworkCore Version 7.0.14
- Pomelo.EntityFrameworkCore.MySql Version 7.0.0
- Swashbuckle.AspNetCore Version 6.7.1

## Autor

Desenvolvido por **Wagner Braz Nogueira**.
