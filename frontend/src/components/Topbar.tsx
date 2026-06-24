import { useLocation } from "react-router-dom";
import "./topbar.css";

export default function Topbar() {
  const { pathname } = useLocation();

  const title =
    pathname === "/dashboard"
      ? "Dashboard"
      : pathname === "/users"
      ? "Usuários"
      : "AssetMonitor";

  return (
    <header className="topbar">
      <div className="title">{title}</div>

      <div className="actions">
        <button className="icon">🔔</button>
        <button className="icon">⚙️</button>
        <div className="avatar">EP</div>
      </div>
    </header>
  );
}