using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class UsuarioDAO
    {
        public int qtd;
        public int Inserir(UsuarioEnt objTabela)
        {
            
            using (SqlConnection con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = DAO.Properties.Settings.Default.banco;
                    SqlCommand cn = new SqlCommand();
                    cn.CommandType = CommandType.Text;
                    con.Open();
                    cn.CommandText = "INSERT INTO Usuario ([nome], [email], [username], [senha], [id_funcao]) VALUES (@nome, @email, @username, @senha, @id_funcao)";
                    cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                    cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                    cn.Parameters.Add("username", SqlDbType.VarChar).Value = objTabela.Username;
                    cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;
                    cn.Parameters.Add("id_funcao", SqlDbType.Int).Value = objTabela.Id_funcao;
                    cn.Connection = con;
                    qtd = cn.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error DAO: " + ex.Message);
                }

                return qtd;
            }

        }

        public List<UsuarioEnt> Buscar(UsuarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Usuario WHERE nome like @nome";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<UsuarioEnt> lista = new List<UsuarioEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UsuarioEnt dado = new UsuarioEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Username = Convert.ToString(dr["username"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                        dado.Id_funcao = Convert.ToInt32(dr["id_funcao"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }

        }

        public int Editar(UsuarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Usuario SET nome = @nome, email = @email, username = @username, senha = @senha, id_funcao = @id_funcao WHERE id = @id";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                cn.Parameters.Add("username", SqlDbType.VarChar).Value = objTabela.Username;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;
                cn.Parameters.Add("id_funcao", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id_funcao);
                cn.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id);
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }

        }

        public int Excluir(UsuarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM usuario WHERE id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }
        public UsuarioEnt Login(UsuarioEnt obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM usuario WHERE username = @username AND senha = @senha ";
                cn.Connection = con;

                cn.Parameters.Add("username", SqlDbType.VarChar).Value = obj.Username;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = obj.Senha;
                SqlDataReader dr;

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UsuarioEnt dado = new UsuarioEnt();

                        dado.Username = Convert.ToString(dr["username"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                    }
                }
                else
                {
                    obj.Username = null;
                    obj.Senha = null;
                }
                return obj;
            }
        }

        public UsuarioEnt RecoverEmail(UsuarioEnt obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM usuario WHERE email = @email";
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = obj.Email;
                cn.Connection = con;
                SqlDataReader dr;
                List<UsuarioEnt> lista = new List<UsuarioEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UsuarioEnt dado = new UsuarioEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Username = Convert.ToString(dr["username"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                        dado.Id_funcao = Convert.ToInt32(dr["id_funcao"]);
                        lista.Add(dado);
                    }
                    foreach (var item in lista)
                    {
                        obj.Email = item.Email;
                        obj.Username = item.Username;
                        obj.Senha = item.Senha;
                    }
                }
                else
                {
                    obj.Email = null;
                    obj.Username = null;
                    obj.Senha = null;
                }
                return obj;
            }
        }





        public List<UsuarioEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT Usuario.[id], [Nome], [email], [username], [senha], [descricao] FROM Usuario INNER JOIN Funcao ON Usuario.id_funcao = Funcao.id";
                //"SELECT * FROM Usuario ORDER BY nome ASC";


                cn.Connection = con;
                SqlDataReader dr;
                List<UsuarioEnt> lista = new List<UsuarioEnt>();

                dr = cn.ExecuteReader();


                /*if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UsuarioEnt dado = new UsuarioEnt();

                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                        dado.Id_funcao = Convert.ToInt32(dr["id_funcao"]);
                        lista.Add(dado);
                    }
                }
                */
                return lista;
            }
        }

        public DataTable ListaJonn()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                con.Open();
                string query = "SELECT Usuario.[id], [Nome], [email], [username], [senha], [descricao] FROM Usuario INNER JOIN Funcao ON Usuario.id_funcao = Funcao.id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                 return dt;
            }
        }

    }
}
