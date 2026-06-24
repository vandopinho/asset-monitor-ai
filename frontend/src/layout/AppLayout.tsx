import Sidebar from "../components/Sidebar";
import Topbar from "../components/Topbar";
import { Outlet } from "react-router-dom";
import "./layout.css";

export default function AppLayout() {
  return (
    <div className="appShell">
      <aside className="sidebar">
        <Sidebar />
      </aside>

      <div className="appMain">
        <Topbar />

        <main className="appContent">
          <Outlet />
        </main>
      </div>
    </div>
  );
}