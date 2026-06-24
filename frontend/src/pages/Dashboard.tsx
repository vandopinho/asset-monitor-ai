import "./dashboard.css";

export default function Dashboard() {
  return (
    <div className="dashboard">
      <div className="header">
        <h1>Dashboard</h1>
        <p>Visão geral em tempo real do sistema</p>
      </div>

      <div className="grid">
        <div className="card">
          <span>Usuários</span>
          <strong>128</strong>
        </div>

        <div className="card">
          <span>Ativos</span>
          <strong>54</strong>
        </div>

        <div className="card">
          <span>Alertas</span>
          <strong>12</strong>
        </div>
      </div>

      <div className="panel">
        <div className="panelHeader">
          <h2>Atividade recente</h2>
        </div>

        <div className="empty">
          Nenhuma atividade registrada
        </div>
      </div>
    </div>
  );
}