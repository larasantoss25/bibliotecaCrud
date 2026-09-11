# 📚 Sistema de Gestão de Biblioteca (bibliotecaCrud)

Este projeto é uma aplicação web completa no padrão MVC para gerenciamento de biblioteca, permitindo o controle de autores, livros, usuários e empréstimos de acervo. Ele foi desenvolvido com foco em praticar conceitos fundamentais de desenvolvimento back-end e front-end com a plataforma .NET, incluindo arquitetura MVC, mapeamento relacional, validação de dados e interface responsiva.

---

## 🚀 Tecnologias Utilizadas

### 🔧 Back-end
* **C#**
* **.NET 8.0 / ASP.NET Core MVC**
* **Entity Framework Core** (Mapeamento de Entidades e Relacionamentos)
* **Data Annotations** (Validação de Modelos)

### 🎨 Front-end
* **HTML5 / Razor Views (`.cshtml`)**
* **CSS3 Customizado** (Paleta moderna de tons marinho, verde sálvia e dourado)
* **Bootstrap 5**
* **Bootstrap Icons** (Ícones dinâmicos de interface)
* **JavaScript / jQuery**

---

## 📌 Funcionalidades

* 📚 **Gerenciamento de Livros:** Cadastro, listagem, edição e remoção de livros vinculados aos seus respectivos autores.
* ✍️ **Gerenciamento de Autores:** Controle completo do cadastro de autores com nacionalidade.
* 👥 **Gerenciamento de Usuários:** Cadastro de leitores/usuários com dados de contato (E-mail e Telefone).
* 🔄 **Controle de Empréstimos:** Registro de empréstimos com cálculo automático de data prevista de devolução (14 dias), controle de devolução real e acompanhamento de status ativo/inativo.
* 🔍 **Filtro e Busca Dinâmica:** Pesquisa rápida de acervo por título ou autor.
* 🏷️ **Indicadores de Status Visual:** Sinalização visual por badges de empréstimos em dia, atrasados ou concluídos.

---

## 🔄 Estrutura de Rotas e Ações (Controllers)

A aplicação segue o padrão arquitetural **ASP.NET Core MVC**, dividindo o fluxo de requisições por Controllers dedicados:

| Controller | Ação | Método HTTP | Descrição |
| :--- | :--- | :--- | :--- |
| **Livro** | `Index` | GET | Lista todos os livros cadastrados no acervo |
| **Livro** | `Create` | GET / POST | Exibe formulário e cadastra um novo livro |
| **Livro** | `Edit` | GET / POST | Atualiza informações de um livro existente por ID |
| **Livro** | `Delete` | GET / POST | Remove um livro do sistema |
| **Autor** | `Index` | GET | Lista todos os autores cadastrados |
| **Autor** | `Create` | GET / POST | Cadastra um novo autor |
| **Usuario** | `Index` | GET | Lista os leitores/usuários cadastrados |
| **Emprestimo**| `Index` | GET | Painel de controle e monitoramento de empréstimos |
| **Emprestimo**| `Create` | GET / POST | Registra a saída de um livro para um usuário |

---

## 📡 Regras de Negócio e Validações

A aplicação faz o uso de **Data Annotations** para garantir a integridade dos dados e regras de negócio no back-end:

* **Validações Obrigatórias:** Verificação de preenchimento para campos como `Nome` do Autor/Usuário e `Título` do Livro (`[Required]`).
* **Relacionamentos de Chave Estrangeira:** Vinculação forte através de `[ForeignKey]` entre `Livro` → `Autor` e `Emprestimo` → `Livro` / `Usuario`.
* **Cálculo de Prazos:** Definição automática da data do empréstimo (`DateTime.Now`) e previsão de devolução configurada por padrão em 14 dias (`AddDays(14)`).

---

## 🗄️ Modelo de Dados (Entidades)

O sistema possui quatro entidades principais interligadas:

1. **`Autor`**: Representa os autores das obras (`IdAutor`, `Nome`, `Nacionalidade`).
2. **`Livro`**: Representa os livros disponíveis no acervo (`IdLivro`, `Titulo`, `AnoPublicacao`, `AutorId`).
3. **`Usuario`**: Representa o leitor cadastrado no sistema (`IdUsuario`, `Nome`, `Email`, `Telefone`).
4. **`Emprestimo`**: Registra a movimentação do acervo (`IdEmprestimo`, `LivroId`, `UsuarioId`, `DataEmprestimo`, `DataDevolucaoPrevista`, `DataDevolucaoReal`, `StatusAtivo`).

---

## 💡 Objetivo do Projeto

Este projeto foi desenvolvido com o objetivo de:
* Praticar o desenvolvimento Web Fullstack utilizando o ecossistema **.NET / ASP.NET Core MVC**.
* Compreender o padrão de arquitetura **Model-View-Controller (MVC)** e a separação de responsabilidades.
* Trabalhar com relacionamentos entre entidades e validações via **Data Annotations**.
* Construir uma interface atraente, responsiva e focada na experiência do usuário (UX/UI) com **Bootstrap 5** e CSS customizado.

---

## ▶️ Como Executar

1. **Clone o repositório:**
   ```bash
   git clone [https://github.com/larasantoss25/bibliotecaCrud.git](https://github.com/larasantoss25/bibliotecaCrud.git)
