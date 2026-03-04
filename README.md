# Users API - .NET 8

API REST desenvolvida com **ASP.NET Core Web API** para gerenciamento de usuários.

Projeto criado com foco em aprendizado de arquitetura básica, **Entity Framework Core** e boas práticas iniciais como uso de DTOs e separação de responsabilidades.

---

## 🚀 Tecnologias Utilizadas

- .NET 8  
- ASP.NET Core Web API  
- Entity Framework Core  
- SQL Server  
- Swagger  
- Git  

---

## 📁 Estrutura do Projeto

O projeto está organizado nas seguintes camadas:

- **Controllers** → Responsável pelos endpoints da API  
- **Models** → Entidades do domínio  
- **DTOs** → Objetos de transferência de dados (entrada e saída)  
- **Data** → Contexto do banco de dados  
- **Migrations** → Versionamento do banco  
- **Services** → Estrutura preparada para camada de serviço  

---

## 📌 Funcionalidades Implementadas

CRUD completo de usuários:

- `GET` → Listar todos  
- `GET` por Id  
- `POST` → Criação  
- `PUT` → Atualização completa  
- `PATCH` → Atualização parcial  
- `DELETE` → Remoção  

Outras implementações:

- Separação de DTOs:
  - `UserCreateDto`
  - `UserUpdateDto`
  - `UserSaidaDto`
- Enum de status configurado para retornar como string  
- Campo de senha protegido (não é retornado na resposta)  
- Migrations configuradas e aplicadas  

---

## 🗄️ Modelo de Usuário

A entidade **Usuario** possui os seguintes campos:

- Id  
- Nome  
- Email  
- Senha  
- DataNascimento  
- Status  
- DataCriacao  

---

## ▶️ Como Executar o Projeto

1. Clonar o repositório  
2. Configurar a string de conexão no `appsettings.json`  
3. Executar as migrations (caso necessário)  
4. Rodar o projeto:
dotnet run

A documentação interativa estará disponível via **Swagger** ao iniciar a aplicação.

---

## 🎯 Objetivo do Projeto

Este projeto foi desenvolvido para praticar:

- Construção de APIs REST  
- Integração com banco de dados usando **EF Core**  
- Organização em camadas  
- Uso de DTOs  
- Controle de retorno de dados sensíveis  
- Versionamento com Git  

---

## 📌 Próximos Passos

- Implementação de validações com **DataAnnotations**  
- Criação da camada de **Service**  
- Melhorias nos **status codes**  
- Evolução da arquitetura  
