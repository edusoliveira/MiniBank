# 🏦 MiniBank — API de Conta Digital

> Projeto de estudo em **C# e .NET**, construído do zero para aprender desenvolvimento backend aplicando boas práticas de engenharia de software. Este repositório documenta minha evolução como desenvolvedor — cada commit representa um passo do aprendizado.

![Status](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)
![Linguagem](https://img.shields.io/badge/C%23-.NET-blue)
![Licença](https://img.shields.io/badge/licença-MIT-green)

---

## 📖 Sobre o projeto

O **MiniBank** simula o núcleo de um sistema bancário digital — o motor por trás de um app de banco. O objetivo não é a interface bonita, mas o **backend confiável**: onde o dinheiro se move com segurança, o saldo nunca fica inconsistente e nada quebra.

Escolhi o domínio financeiro de propósito. É um dos contextos mais exigentes da programação: obriga a lidar com validação rigorosa, consistência de dados, tratamento de erros e testes — exatamente os problemas que sistemas reais de fintechs enfrentam todos os dias.

Este projeto está sendo desenvolvido **por fases**, acompanhando meus estudos de C#. Cada fase adiciona uma camada de profissionalismo ao código.

---

## 🎯 Funcionalidades

### ✅ Já implementado
- Menu interativo no terminal
- Criação de contas (titular e saldo)
- Modelagem orientada a objetos (classe `Conta`)

### 🚧 Em desenvolvimento
- Operações de depósito e saque com validação
- Múltiplas contas e consulta de saldo
- Transferência entre contas
- Histórico de transações (extrato)

### 🔮 Planejado
- Migração para **API REST** com ASP.NET Core
- Persistência com **Entity Framework Core + PostgreSQL**
- Autenticação com **JWT**
- **Testes automatizados** com xUnit
- Containerização com **Docker** e deploy em nuvem

---

## 🛠️ Tecnologias

| Categoria | Ferramentas |
|-----------|-------------|
| Linguagem | C# |
| Framework | .NET |
| Conceitos | Programação Orientada a Objetos, Clean Code |
| Versionamento | Git, GitHub |
| **Planejado** | ASP.NET Core, PostgreSQL, EF Core, xUnit, Docker |

---

## 🗺️ Roadmap de aprendizado

O projeto evolui em fases, cada uma consolidando um novo conjunto de conceitos:

- [x] **Fase 1 —** Console App: lógica, menu e fundamentos de C#
- [x] **Fase 2 —** Orientação a Objetos: classes, atributos e métodos
- [ ] **Fase 3 —** Coleções e LINQ: múltiplas contas e consultas
- [ ] **Fase 4 —** Exceções e validação: tornar o sistema à prova de erros
- [ ] **Fase 5 —** Persistência: banco de dados com EF Core
- [ ] **Fase 6 —** API REST com ASP.NET Core
- [ ] **Fase 7 —** Segurança e autenticação (JWT)
- [ ] **Fase 8 —** Testes automatizados
- [ ] **Fase 9 —** Docker e deploy em nuvem

---

## 💡 Decisões técnicas

Algumas escolhas que fiz e o porquê — porque entender o *motivo* importa mais que o código em si:

- **`decimal` em vez de `double` para valores monetários.** Tipos de ponto flutuante (`double`, `float`) têm erros de arredondamento inaceitáveis para dinheiro. O `decimal` garante precisão financeira.
- **Delegação de responsabilidade.** As operações de uma conta ficam dentro da própria classe `Conta` — a conta é responsável pelo próprio saldo. Isso segue o princípio de responsabilidade única (SRP).
- **Evolução incremental.** Em vez de começar complexo, o projeto começa simples e ganha camadas. Isso reflete como sistemas reais crescem e mantém o código sempre compreensível.

---

## 🚀 Como executar

```bash
# Clone o repositório
git clone https://github.com/edusoliveira/MiniBank.git

# Entre na pasta do projeto
cd MiniBank/MiniBank

# Execute
dotnet run
```

**Pré-requisitos:** [.NET SDK](https://dotnet.microsoft.com/download) instalado.

---

## 👤 Autor

**Eduardo Oliveira**
Estagiário de Inovação e IA na Influency.me | Desenvolvedor .NET em formação

[![LinkedIn](https://img.shields.io/badge/LinkedIn-e--oliveira1-blue)](https://linkedin.com/in/e-oliveira1)
[![GitHub](https://img.shields.io/badge/GitHub-edusoliveira-black)](https://github.com/edusoliveira)

---

> 📚 Este projeto faz parte da minha jornada de aprendizado em desenvolvimento .NET.
> O histórico de commits conta a história — do primeiro `Hello World` até uma API completa.