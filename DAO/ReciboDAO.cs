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
    public class ReciboDAO
    {
        public int qtd;
        public int Inserir(ReciboEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = DAO.Properties.Settings.Default.banco;
                    SqlCommand cn = new SqlCommand();
                    cn.CommandType = CommandType.Text;
                    con.Open();
                    cn.CommandText = "INSERT INTO Recibo ([numero], [valor], [recebemosde], [importanciade1], [importanciade2], [referentea1], [referentea2], [emitente], [cnpj], [data]) VALUES (@numero, @valor, @recebemosde, @importanciade1, @importanciade2, @referente1, @referente2, @emitente, @cjpj, @data)";
                    cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Numero;
                    cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Valor;
                    cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Recebemosde;
                    cn.Parameters.Add("id_funcao", SqlDbType.Int).Value = objTabela.Importancia1;
                    cn.Parameters.Add("id_funcao", SqlDbType.Int).Value = objTabela.Importancia2;
                    cn.Parameters.Add("id_funcao", SqlDbType.Int).Value = objTabela.Referentea1;
                    cn.Parameters.Add("id_funcao", SqlDbType.Int).Value = objTabela.Referentea2;
                    cn.Parameters.Add("id_funcao", SqlDbType.Int).Value = objTabela.Emitente;
                    cn.Parameters.Add("id_funcao", SqlDbType.Int).Value = objTabela.Cnpj;
                    cn.Parameters.Add("id_funcao", SqlDbType.Int).Value = objTabela.Data;
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

        public List<ReciboEnt> Buscar(ReciboEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Recibo WHERE nome like @nome";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<ReciboEnt> lista = new List<ReciboEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ReciboEnt dado = new ReciboEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                        dado.Id_funcao = Convert.ToInt32(dr["id_funcao"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }

        }

        public int Editar(ReciboEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Recibo SET nome = @nome, email = @email, senha = @senha, id_funcao = @id_funcao WHERE id = @id";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = objTabela.Senha;
                cn.Parameters.Add("id_funcao", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id_funcao);
                cn.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id);
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }

        }

        public int Excluir(ReciboEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Recibo WHERE id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }
        public ReciboEnt Login(ReciboEnt obj)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Recibo WHERE email = @email AND senha = @senha";
                cn.Connection = con;

                cn.Parameters.Add("email", SqlDbType.VarChar).Value = obj.Email;
                cn.Parameters.Add("senha", SqlDbType.VarChar).Value = obj.Senha;
                SqlDataReader dr;

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ReciboEnt dado = new ReciboEnt();

                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                    }
                }
                else
                {
                    obj.Email = null;
                    obj.Senha = null;
                }
                return obj;
            }
        }

        public List<ReciboEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT Recibo.[id], [Nome], [email], [senha], [descricao] FROM Recibo INNER JOIN Funcao ON Recibo.id_funcao = Funcao.id";
                //"SELECT * FROM Recibo ORDER BY nome ASC";


                cn.Connection = con;
                SqlDataReader dr;
                List<ReciboEnt> lista = new List<ReciboEnt>();

                dr = cn.ExecuteReader();


                /*if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ReciboEnt dado = new ReciboEnt();

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
                string query = "SELECT Recibo.[id], [Nome], [email], [senha], [descricao] FROM Recibo INNER JOIN Funcao ON Recibo.id_funcao = Funcao.id";

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
