# 🚀 Asset Monitor AI

---

## ⚡ Visão Geral

O **Asset Monitor AI** é uma plataforma SaaS moderna para monitoramento de ativos em tempo real, com foco em escalabilidade, automação e experiência de usuário nível Stripe / Linear.

---

## 🧠 Demonstração (UI Atual)

Projeto em evolução contínua

- Dashboard base
- Usuários (CRUD)
- Equipamentos (CRUD completo no backend + Swagger)
- Login inicial com JWT

---

## 🎯 Funcionalidades

### ✔️ Implementado
- Autenticação JWT (base funcional)
- Estrutura completa de Clean Architecture
- CRUD de usuários
- CRUD de equipamentos (backend completo)
- Validações de domínio (ex: equipamento duplicado por serial)
- Exceptions centralizadas + Middleware global
- Repository Pattern
- Entity Framework Core + PostgreSQL
- Swagger funcional
- Design System inicial no frontend (SaaS UI base)

---

### 🚧 Em desenvolvimento
- Login completo com hash de senha (BCrypt)
- Integração frontend ↔ backend (equipamentos)
- CRUD de clientes (nova entidade)
- Paginação e filtros globais
- Melhorias de UX (loading, empty states, error states)

---

### 🔮 Futuro
- Alertas em tempo real (SignalR)
- Relatórios PDF automáticos
- Assistente IA integrado (OpenAI / Ollama)
- Dashboards analíticos avançados
- Multi-tenant SaaS (estrutura enterprise)
- Auditoria completa (Audit Logs por ação usuário/ativo)

---

## 🧱 Stack

### Backend
- ASP.NET Core 9
- Entity Framework Core
- PostgreSQL (Npgsql)
- JWT Authentication
- Clean Architecture
- Repository Pattern
- Domain-Driven Design (parcial)

### Frontend
- React + TypeScript
- Vite
- React Router DOM
- Axios
- CSS Design System próprio (SaaS UI inspirado em Stripe/Linear)

### Infraestrutura (futuro)
- Docker Compose
- CI/CD (GitHub Actions)
- Deploy cloud

### IA (planejado)
- OpenAI API
- Ollama (local LLM)

---

## 🏛️ Arquitetura

- Clean Architecture
- Domain / Application / Infrastructure / API
- Repository Pattern
- Dependency Injection
- SOLID Principles
- Exceptions centralizadas via Middleware

---

## 🔐 Autenticação

- JWT Token Provider
- Claims:
  - UserId
  - Email
  - Role
- BCrypt (em implementação)
- Configuração via `appsettings.json`

---

## 📊 Roadmap (Sprint baseado)

### 🟦 Sprint 1 — Base ✔
- Estrutura inicial do projeto
- Backend + frontend setup
- Clean Architecture

### 🟦 Sprint 2 — Auth ✔
- JWT implementado
- Estrutura de login
- Segurança base

---

### 🟩 Sprint 3 — Core Backend (FINALIZADA ✔)
- CRUD de usuários
- CRUD de equipamentos
- Validação de serial number único
- Exceptions customizadas
- Middleware global de erros
- Migrations aplicadas
- Banco PostgreSQL integrado
- Swagger funcional

---

### 🟨 Sprint 4 — Integração Frontend (PRÓXIMA)
- Tela de login funcional (JWT real)
- CRUD de equipamentos no frontend
- Integração com API (Axios service layer)
- Tabelas com loading + empty state
- UX mais polido (SaaS feel)

---

### 🟪 Sprint 5 — Evolução de Produto
- CRUD clientes
- Relacionamento User ↔ Equipment ↔ Client
- Filtros e paginação backend
- Melhorias de performance

---

### 🟩 Sprint 6 — Inteligência & Tempo Real (futuro)
- SignalR (real-time updates)
- Audit Logs (histórico completo)
- IA assistant (consultas e insights)
- Relatórios PDF automáticos
- Analytics avançado

---

## 🎨 UI / UX

- Sidebar estilo SaaS (Stripe/Linear inspired)
- Topbar contextual por rota
- Design system com CSS variables
- Foco em consistência e escalabilidade visual
- Base pronta para produto real SaaS

---

## 🖥️ Como rodar

### Backend
```bash
cd src/AssetMonitor.API
dotnet run
```

### Frontend
```bash
cd frontend
npm install
npm run dev
```

📌 Estrutura

AssetMonitorAI
│
├── backend/
│ ├── Domain
│ ├── Application
│ ├── Infrastructure
│ └── API
│
├── frontend/
│ ├── components
│ ├── pages
│ ├── layout
│ ├── services
│ └── styles
