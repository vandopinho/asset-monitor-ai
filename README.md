🚀 Asset Monitor AI










⚡ Visão Geral

O Asset Monitor AI é uma plataforma SaaS moderna para monitoramento de ativos em tempo real, com foco em escalabilidade, automação e experiência de usuário nível Stripe / Linear.

🧠 Demonstração (UI Atual)

Projeto em evolução contínua

Dashboard

Usuários

Login

🎯 Funcionalidades
✔️ Implementado
Autenticação JWT (base)
Layout SaaS (Sidebar + Topbar estilo Stripe/Linear)
Dashboard com KPIs iniciais
CRUD de usuários (frontend)
Design System próprio com CSS variables
Estrutura Clean Architecture no backend
🚧 Em desenvolvimento
Login completo com hash de senha (BCrypt)
CRUD de equipamentos
CRUD de clientes
Paginação e filtros
Loading states / skeleton UI
🔮 Futuro
Alertas em tempo real (SignalR)
Relatórios PDF automáticos
Assistente IA integrado
Dashboards analíticos avançados
Multi-tenant SaaS
🧱 Stack
Backend
ASP.NET Core 9
Entity Framework Core
PostgreSQL
JWT Authentication
Clean Architecture
Frontend
React + TypeScript
Vite
React Router DOM
Axios
CSS Design System próprio (SaaS UI)
Infraestrutura (futuro)
Docker Compose
CI/CD (GitHub Actions)
Deploy cloud
IA (planejado)
OpenAI API
Ollama (local LLM)
🏛️ Arquitetura
Clean Architecture
Repository Pattern
Dependency Injection
SOLID Principles
Camadas:
Domain
Application
Infrastructure
API
🔐 Autenticação
JWT Token Provider
Claims:
UserId
Email
Role
Configuração via appsettings.json
📊 Roadmap (Sprint baseado)
🟦 Sprint 1 — Base ✔
Estrutura inicial do projeto
Backend + frontend setup
Clean Architecture
🟦 Sprint 2 — Auth ✔
JWT implementado
Estrutura de login
Segurança base
🟨 Sprint 3 — Core Backend (em andamento)
Login completo
Hash de senha (BCrypt)
CRUD usuários
CRUD equipamentos
🟪 Sprint 4 — Frontend SaaS UI (em andamento)
Layout Stripe/Linear
Dashboard base
Tabela de usuários
UX foundation
🟩 Sprint 5 — Inteligência & Tempo Real (futuro)
SignalR (real-time)
IA assistant
Reports PDF
Analytics avançado
🎨 UI / UX
Sidebar fixa estilo SaaS (Stripe/Linear inspired)
Topbar contextual por rota
Design system com CSS variables
Hierarquia visual limpa e consistente
Base pronta para escala de produto real
🖥️ Como rodar
Backend
cd src/AssetMonitor.API
dotnet run
Frontend
cd frontend
npm install
npm run dev
📌 Estrutura
AssetMonitorAI
│
├── backend/
│   ├── Domain
│   ├── Application
│   ├── Infrastructure
│   └── API
│
├── frontend/
│   ├── components
│   ├── pages
│   ├── layout
│   ├── services
│   └── styles
💼 Recruiter Ready

Este projeto demonstra:

Arquitetura profissional escalável
Frontend SaaS moderno estilo Stripe/Linear
Backend estruturado em Clean Architecture
Separação real de responsabilidades
Base de produto real (não CRUD simples)
🚀 Status Atual
Backend: base + autenticação inicial
Frontend: SaaS UI inicial concluído
Banco: PostgreSQL configurado
Sprint atual: evolução do core backend + refinamento UI
⭐ Objetivo

Evoluir para um SaaS real de mercado, com padrão visual e arquitetural equivalente a:

Stripe
Linear
Datadog
