import { useEffect, useState } from "react";
import {
  getUsers,
  createUser,
  deleteUser,
} from "../services/userService";
import "./users.css";

export default function Users() {
  const [users, setUsers] = useState<any[]>([]);
  const [open, setOpen] = useState(false);

  const [name, setName] = useState("");
  const [email, setEmail] = useState("");

  async function load() {
    const data = await getUsers();
    setUsers(data);
  }

  useEffect(() => {
    load();
  }, []);

  async function handleCreate() {
    await createUser({ name, email });
    setOpen(false);
    setName("");
    setEmail("");
    load();
  }

  async function handleDelete(id: string) {
    await deleteUser(id);
    setUsers((prev) => prev.filter((u) => u.id !== id));
  }

  return (
    <div className="users">
      <div className="header">
        <h1>Usuários</h1>

        <button onClick={() => setOpen(true)}>
          + Novo usuário
        </button>
      </div>

      <div className="table">
        <div className="row head">
          <span>Nome</span>
          <span>Email</span>
          <span>Ações</span>
        </div>

        {users.map((u) => (
          <div className="row" key={u.id}>
            <span>{u.name}</span>
            <span>{u.email}</span>

            <div className="actions">
              <button className="edit">Editar</button>
              <button className="danger" onClick={() => handleDelete(u.id)}>
                Excluir
              </button>
            </div>
          </div>
        ))}
      </div>

      {open && (
        <div className="modal">
          <div className="box">
            <h2>Novo usuário</h2>

            <input
              placeholder="Nome"
              value={name}
              onChange={(e) => setName(e.target.value)}
            />

            <input
              placeholder="Email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            />

            <div className="actions">
              <button onClick={() => setOpen(false)}>Cancelar</button>
              <button onClick={handleCreate}>Criar</button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
}