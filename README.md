# 🛒 API CRUD - ASP.NET MVC

![Badge](https://img.shields.io/badge/Status-Completo-green) ![Badge](https://img.shields.io/badge/Framework-ASP.NET%20MVC-blue) ![Badge](https://img.shields.io/badge/Database-SQL%20Server-orange)

Este projeto é uma aplicação **ASP.NET MVC** que implementa um **CRUD** para gerenciar Clientes, Produtos e Vendas. A aplicação permite criar, listar, editar e excluir registros, além de integrar com uma API externa para carregar dados.

---

## 🚀 **Funcionalidades**
✅ **Clientes**
- Criar um novo cliente
- Listar clientes
- Editar informações de um cliente
- Excluir um cliente

✅ **Produtos**
- Criar um novo produto
- Listar produtos
- Editar um produto existente
- Excluir um produto

✅ **Vendas**
- Registrar uma nova venda
- Listar vendas (filtrando por cliente ou produto)
- Editar uma venda existente
- Excluir uma venda

✅ **Outros Recursos**
- 🎨 Interface responsiva com **Bootstrap**
- 🔗 Integração com APIs externas para carregar dados
- 💾 Persistência no banco de dados (SQL Server)
- ⚙️ Uso de **Entity Framework Core** para manipulação dos dados

---

## 📂 **Estrutura do Projeto**

```bash
📦 ApiCrud
│-- 📁 Controllers/
│   ├── ClienteController.cs
│   ├── ProdutoController.cs
│   ├── VendaController.cs
│
│-- 📁 Entities/
│   ├── Cliente.cs
│   ├── Produto.cs
│   ├── Venda.cs
│
│-- 📁 Models/
│   ├── ClienteViewModel.cs
│   ├── ProdutoViewModel.cs
│   ├── VendaViewModel.cs
│
│-- 📁 Persistence/
│   ├── ApplicationDbContext.cs
│   ├── ClienteRepository.cs
│   ├── ProdutoRepository.cs
│   ├── VendaRepository.cs
│
│-- 📁 Services/
│   ├── ClienteService.cs
│   ├── ProdutoService.cs
│   ├── VendaService.cs
│
│-- 📁 Views/
│   ├── 📁 Cliente/
│   ├── 📁 Produto/
│   ├── 📁 Venda/
│
│-- 📁 wwwroot/
│   ├── 📁 css/
│   ├── 📁 js/
│   ├── 📁 lib/
│
│-- appsettings.json
│-- Program.cs
│-- Startup.cs
```

## 🔧 **Tecnologias Utilizadas**
- ✔️ **ASP.NET MVC** - Framework principal da aplicação
- ✔️ **Entity Framework Core** - ORM para gerenciar o banco de dados
- ✔️ **SQL Server** - Banco de dados para armazenar os dados da aplicação
- ✔️ **Bootstrap 5** - Para estilização e layout responsivo
- ✔️ **jQuery** - Para manipulação de eventos e interações no front-end
- ✔️ **C#** - Linguagem principal do back-end

---

## ⚙️ **Como Executar o Projeto**
### 🔹 **1. Clonar o Repositório**
```sh
git clone https://github.com/seu-usuario/ApiCrud.git
cd ApiCrud
 ```

### 🔹 **2. Configurar o Banco de Dados**
- Abra o arquivo `appsettings.json` e configure a **string de conexão** com seu banco SQL Server.
- Execute as **migrations** e aplique as migrações no banco:
```sh
dotnet ef database update
```

### 🔹 **3. Executar a Aplicação**
- No **Visual Studio**, selecione IIS Express e clique em **Run (F5)**.
- Ou execute no terminal:
 ```sh
dotnet run
```
- Acesse no navegador:
  ```sh
  http://localhost:5000
  ```

  ---

## 📌 **Endpoints Principais**

### **Clientes**
- `GET /api/clientes` → Lista todos os clientes
- `POST /api/clientes` → Cria um novo cliente
- `PUT /api/clientes/{id}` → Atualiza um cliente
- `DELETE /api/clientes/{id}` → Exclui um cliente

### **Produtos**
- `GET /api/produtos` → Lista todos os produtos
- `POST /api/produtos` → Cria um novo produto
- `PUT /api/produtos/{id}` → Atualiza um produto
- `DELETE /api/produtos/{id}` → Exclui um produto

### **Vendas**
- `GET /api/vendas` → Lista todas as vendas
- `POST /api/vendas` → Registra uma nova venda
- `PUT /api/vendas/{id}` → Atualiza uma venda
- `DELETE /api/vendas/{id}` → Exclui uma venda
 ## 📢 **Contribuição**
 1. **Fork** o repositório
 2. Crie uma branch (git checkout -b feature/minha-feature)
 3. Faça um commit (git commit -m 'Adicionando nova funcionalidade')
 4. Faça um push (git push origin feature/minha-feature)
 5. Abra um **Pull Request**

## 📜 **Licença**
Este projeto é de uso livre e está sob a licença **MIT**.
