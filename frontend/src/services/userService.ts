import { api } from "../api/api";

export interface CreateUserRequest {
  name: string;
  email: string;
  password?: string;
}

export interface User {
  id: string;
  name: string;
  email: string;
}

export async function getUsers() {
  const response = await api.get<User[]>("/users");
  return response.data;
}

export async function createUser(data: CreateUserRequest) {
  const response = await api.post("/users", data);
  return response.data;
}

export async function deleteUser(id: string) {
  await api.delete(`/users/${id}`);
}