export interface User {
  id: string;
  email: string;
  role: string;
}

export interface AuthContextData {
  user: User | null;
  token: string | null;
  login: (email: string, password: string) => Promise<void>;
  logout: () => void;
}