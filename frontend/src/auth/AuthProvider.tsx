import { createContext, useEffect, useState } from "react";
import { login as loginService } from "../services/authService";
import type { AuthContextData, User } from "./types";

export const AuthContext = createContext<AuthContextData>(
  {} as AuthContextData,
);

export function AuthProvider({ children }: { children: React.ReactNode }) {
  const [user, setUser] = useState<User | null>(null);
  const [token, setToken] = useState<string | null>(null);

  useEffect(() => {
    const token = localStorage.getItem("token");
    const user = localStorage.getItem("user");

    if (token && user) {
      setToken(token);
      setUser(JSON.parse(user));
    }
  }, []);

  async function login(email: string, password: string) {
    const data = await loginService({ email, password });

    setUser(data.user);
    setToken(data.token);

    localStorage.setItem("token", data.token);
    localStorage.setItem("user", JSON.stringify(data.user));
  }

  function logout() {
    setUser(null);
    setToken(null);
    localStorage.removeItem("token");
    localStorage.removeItem("user");
  }

  return (
    <AuthContext.Provider value={{ user, token, login, logout }}>
      {children}
    </AuthContext.Provider>
  );
}