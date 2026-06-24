import { api } from "../api/api";

export interface LoginRequest {
  email: string;
  password: string;
}

export async function login(request: LoginRequest) {
  const response = await api.post("/auth/login", request);
  return response.data;
}