# 🚀 Asset Monitor AI

Plataforma inteligente de monitoramento de ativos com dashboards, alarmes e assistente de IA.

---

## 📌 Visão Geral

O **Asset Monitor AI** é uma plataforma para monitoramento de ativos em tempo real, com foco em:

- Visualização de dados operacionais
- Controle de equipamentos e clientes
- Geração de relatórios
- Autenticação segura com JWT
- Base preparada para IA e automações futuras

---

## ⚙️ Funcionalidades

- 👤 Gestão de usuários e autenticação
- 🏢 Gestão de clientes
- ⚙️ Gestão de equipamentos
- 📊 Dashboards de monitoramento
- 🚨 Sistema de alarmes (em evolução)
- 📄 Relatórios PDF (em evolução)
- 🔐 Autenticação JWT
- 🤖 Integração futura com IA

---

## 🧱 Stack

### Backend
- ASP.NET Core 9
- Entity Framework Core
- PostgreSQL
- JWT Authentication
- Clean Architecture

### Frontend
- React
- TypeScript
- Material UI

### Infraestrutura
- Docker Compose (futuro)

### Inteligência Artificial
- OpenAI (planejado)
- Ollama (planejado)

---

## 🏛️ Arquitetura

- Clean Architecture
- Repository Pattern
- Dependency Injection
- SOLID Principles
- Camadas bem definidas:
  - Domain
  - Application
  - Infrastructure
  - API

---

## 🔐 Autenticação

O projeto já possui base de autenticação:

- JWT Token Generator implementado
- Configuração via `appsettings.json`
- Claims:
  - UserId
  - Email
  - Role
- Expiração configurável

---

## 📦 Roadmap

### Sprint 1 - Base ✔
- [x] Estrutura do projeto
- [x] Clean Architecture
- [x] Configuração inicial API

### Sprint 2 - Autenticação ✔
- [x] JWT Token Generator
- [x] DTOs de login
- [x] Dependency Injection
- [x] Configuração de segurança base

### Sprint 3 - Core
- [ ] Login endpoint completo
- [ ] Hash de senha (BCrypt)
- [ ] CRUD de usuários
- [ ] CRUD de equipamentos

### Sprint 4 - Dashboards
- [ ] Queries analíticas
- [ ] Gráficos e métricas
- [ ] Integração com frontend

### Sprint 5 - IA & Extras
- [ ] Assistente IA
- [ ] Relatórios PDF
- [ ] Alertas inteligentes
- [ ] SignalR (tempo real)

---

## 🚀 Status Atual

👉 Backend: estrutura base + autenticação JWT iniciada  
👉 Frontend: em desenvolvimento  
👉 Banco: PostgreSQL configurado  
👉 Sprint atual: autenticação base finalizada

---

## 🧪 Como rodar o backend

```bash
cd src/AssetMonitor.API
dotnet run
