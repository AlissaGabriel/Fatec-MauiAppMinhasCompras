# Minhas Compras - .NET MAUI

## Sobre o Projeto

Este aplicativo foi desenvolvido utilizando .NET MAUI com o objetivo de criar uma lista de compras com armazenamento local utilizando SQLite.

O usuário pode:

* Adicionar produtos
* Editar produtos
* Remover produtos
* Pesquisar produtos
* Calcular o valor total das compras

Todas as informações são armazenadas localmente no dispositivo utilizando banco de dados SQLite.

---

## Funcionalidades do Aplicativo

### Cadastro de Produtos

O usuário pode cadastrar:

* Nome do produto
* Quantidade
* Preço

### Listagem de Produtos

O aplicativo exibe:

* ID do produto
* Descrição
* Quantidade
* Preço
* Valor total

### Pesquisa de Produtos

O sistema permite buscar produtos pelo nome utilizando uma barra de pesquisa.

### Edição e Remoção

* Ao tocar em um item, é possível editar suas informações
* Produtos podem ser removidos da lista utilizando o menu de contexto

### Soma Total das Compras

O aplicativo calcula automaticamente o valor total de todos os produtos cadastrados.

---

## Conteúdos Aprendidos

Durante o desenvolvimento deste projeto foram aprendidos os seguintes conceitos:

### Interface gráfica com XAML

Uso de componentes como:

* ListView
* SearchBar
* ToolbarItem
* Grid
* Label
* Entry
* MenuItem
* Border
* StackLayout

### Programação em C#

* Programação orientada a objetos
* Criação de classes e propriedades
* Encapsulamento
* Coleções (`List` e `ObservableCollection`)
* Manipulação de eventos
* Estruturas condicionais
* Tratamento de exceções (`try/catch`)
* Expressões Lambda
* LINQ (`Sum`)

### Banco de Dados SQLite

O projeto também utilizou:

* SQLiteAsyncConnection
* Criação de tabelas
* Inserção de dados
* Atualização de registros
* Exclusão de dados
* Consultas SQL
* Pesquisa com `LIKE`

### Desenvolvimento Mobile com .NET MAUI

* Navegação entre telas
* Data Binding
* Atualização dinâmica da interface
* Persistência de dados local
* Pull To Refresh

---

## Estrutura do Projeto

### Models

* `Produto.cs`

Responsável pelas propriedades e regras dos produtos cadastrados.

### Helpers

* `SQLiteDatabaseHelper.cs`

Responsável pelas operações no banco de dados SQLite:

* Inserção
* Atualização
* Remoção
* Consulta
* Pesquisa

### Views

* `CadastroProduto.xaml`
* `ListaProdutos.xaml`

Responsáveis pela interface gráfica do aplicativo.

---

## Banco de Dados

O aplicativo utiliza um banco SQLite local chamado:

`banco_sqlite_compras.db3`

Os dados ficam armazenados no dispositivo do usuário.

---

## Cálculo do Valor Total

O valor total de cada produto é calculado utilizando:

Total = Quantidade * Preço

O aplicativo também calcula a soma total de todos os produtos cadastrados.

---

## Recursos Implementados

* Cadastro de produtos
* Edição de produtos
* Exclusão de produtos
* Pesquisa em tempo real
* Banco de dados SQLite
* Atualização automática da lista
* Cálculo total das compras
* Interface organizada e responsiva

---

## Como Executar o Projeto

1. Clone o repositório
2. Abra o projeto no Visual Studio 2026
3. Restaure os pacotes necessários
4. Execute o projeto em um emulador Android ou Windows

---

## Estrutura dos Arquivos

* `Models/` → Classes de dados
* `Helpers/` → Comunicação com banco SQLite
* `Views/` → Interfaces gráficas
* `App.xaml.cs` → Configuração geral da aplicação

---

Projeto desenvolvido para a disciplina de Programação para Dispositivos Móveis II com .NET MAUI.
