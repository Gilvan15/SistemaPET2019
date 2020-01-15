using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace DAO
{
    public class ClientesDAO
    {
        public int qtd;
        public int Inserir(ClientesEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = DAO.Properties.Settings.Default.banco;
                    SqlCommand cn = new SqlCommand();
                    cn.CommandType = CommandType.Text;
                    con.Open();
                    cn.CommandText = "INSERT INTO Cliente ([nome], [rg], [cpf], [email], [fone1], [fone2], [rua], [numero], [bairro], [complemento], [id_funcao] ) VALUES (@nome, @rg, @cpf, @email, @fone1, @fone2, @rua, @numero, @bairro, @complemento, @id_funcao)";
                    cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                    cn.Parameters.Add("rg", SqlDbType.VarChar).Value = objTabela.Rg;
                    cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = objTabela.Cpf;
                    cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                    cn.Parameters.Add("fone1", SqlDbType.VarChar).Value = objTabela.Fone1;
                    cn.Parameters.Add("fone2", SqlDbType.VarChar).Value = objTabela.Fone2;
                    cn.Parameters.Add("rua", SqlDbType.VarChar).Value = objTabela.Rua;
                    cn.Parameters.Add("numero", SqlDbType.Int).Value = objTabela.Numero;
                    cn.Parameters.Add("bairro", SqlDbType.VarChar).Value = objTabela.Bairro;
                    cn.Parameters.Add("complemento", SqlDbType.VarChar).Value = objTabela.Complemento;
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

        public List<ClientesEnt> Buscar(ClientesEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Cliente WHERE nome like @nome";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<ClientesEnt> lista = new List<ClientesEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ClientesEnt dado = new ClientesEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Rg = Convert.ToString(dr["rg"]);
                        dado.Cpf = Convert.ToString(dr["cpf"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Fone1 = Convert.ToString(dr["fone1"]);
                        dado.Fone2 = Convert.ToString(dr["fone2"]);
                        dado.Rua = Convert.ToString(dr["rua"]);
                        dado.Numero = Convert.ToInt32(dr["numero"]);
                        dado.Bairro = Convert.ToString(dr["bairro"]);
                        dado.Complemento = Convert.ToString(dr["complemento"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

        public List<ClientesEnt> BuscarById(int id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Cliente WHERE id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = id;
                cn.Connection = con;
                SqlDataReader dr;
                List<ClientesEnt> lista = new List<ClientesEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ClientesEnt dado = new ClientesEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Rg = Convert.ToString(dr["rg"]);
                        dado.Cpf = Convert.ToString(dr["cpf"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Fone1 = Convert.ToString(dr["fone1"]);
                        dado.Fone2 = Convert.ToString(dr["fone2"]);
                        dado.Rua = Convert.ToString(dr["rua"]);
                        dado.Numero = Convert.ToInt32(dr["numero"]);
                        dado.Bairro = Convert.ToString(dr["bairro"]);
                        dado.Complemento = Convert.ToString(dr["complemento"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

        public int Editar(ClientesEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Cliente SET nome = @nome, rg = @rg, cpf = @cpf, email = @email, fone1 = @fone1, fone2 = @fone2, rua = @rua, numero = @numero, bairro = @bairro, complemento = @complemento, id_funcao = @id_funcao WHERE id = @id";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("rg", SqlDbType.VarChar).Value = objTabela.Rg;
                cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = objTabela.Cpf;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                cn.Parameters.Add("fone1", SqlDbType.VarChar).Value = objTabela.Fone1;
                cn.Parameters.Add("fone2", SqlDbType.VarChar).Value = objTabela.Fone2;
                cn.Parameters.Add("rua", SqlDbType.VarChar).Value = objTabela.Rua;
                cn.Parameters.Add("numero", SqlDbType.Int).Value = objTabela.Numero;
                cn.Parameters.Add("bairro", SqlDbType.VarChar).Value = objTabela.Bairro;
                cn.Parameters.Add("complemento", SqlDbType.VarChar).Value = objTabela.Complemento;
                cn.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id);
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }

        public int Excluir(ClientesEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Cliente WHERE id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }

        public List<ClientesEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Cliente ORDER BY nome ASC";

                cn.Connection = con;
                SqlDataReader dr;
                List<ClientesEnt> lista = new List<ClientesEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ClientesEnt dado = new ClientesEnt();

                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Rg = Convert.ToString(dr["rg"]);
                        dado.Cpf = Convert.ToString(dr["cpf"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Fone1 = Convert.ToString(dr["fone1"]);
                        dado.Fone2 = Convert.ToString(dr["fone2"]);
                        dado.Rua = Convert.ToString(dr["rua"]);
                        dado.Numero = Convert.ToInt32(dr["numero"]);
                        dado.Bairro = Convert.ToString(dr["bairro"]);
                        dado.Complemento = Convert.ToString(dr["complemento"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
    }
}
