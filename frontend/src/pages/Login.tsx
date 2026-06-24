import { useState } from "react";
import { useAuth } from "../auth/useAuth";
import "./Login.css";
import { useNavigate } from "react-router-dom";

export default function Login() {
  const { login } = useAuth();
  const navigate = useNavigate();
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  async function handleSubmit(e: React.FormEvent) {
    e.preventDefault();
    await login(email, password);
    navigate("/dashboard");
  }

  return (
    <div className="login-container">
    <div className="login-box">
      <h2 className="login-title">Asset Monitor AI</h2>

      <form className="login-form" onSubmit={handleSubmit}>

        <input
          className="login-input"
          placeholder="Email"
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />

        <input
          className="login-input"
          placeholder="Senha"
          type="password"
          value={password}
          onChange={(e) => setPassword(e.target.value)}
        />

        <button className="login-button" type="submit">
          Entrar
        </button>
      </form>

      <div className="login-footer">Sistema de monitoramento de ativos</div>
    </div>
    </div>
  );
}
