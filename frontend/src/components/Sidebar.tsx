import { NavLink } from "react-router-dom";
import "./sidebar.css";

export default function Sidebar() {
  return (
    <div className="sidebarInner">
      <div className="logo">
        Asset<span>Monitor</span>
      </div>

      <div className="section">
        <span className="sectionTitle">Principal</span>

        <NavLink to="/dashboard" className="link">
          Dashboard
        </NavLink>

        <NavLink to="/users" className="link">
          Usuários
        </NavLink>
      </div>

      <div className="divider" />

      <div className="section">
        <span className="sectionTitle">Sistema</span>

        <div className="link disabled">Configurações</div>
        <div className="link disabled">Logs</div>
      </div>
    </div>
  );
}