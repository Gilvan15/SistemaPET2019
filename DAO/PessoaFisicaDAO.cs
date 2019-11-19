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
    public class PessoaFisicaDAO
    {
        public int qtd;
        public int Inserir(PessoaFisicaEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = DAO.Properties.Settings.Default.banco;
                    SqlCommand cn = new SqlCommand();
                    cn.CommandType = CommandType.Text;
                    con.Open();
                    cn.CommandText = "INSERT INTO Pessoa_Fisica ([nome], [rg], [cpf], [email], [telefone1], [telefone2], [rua], [numero], [bairro], [complemento], [id_funcao] ) VALUES (@nome, @rg, @cpf, @email, @telefone1, @telefone2, @rua, @numero, @bairro, @complemento, @id_funcao)";
                    cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                    cn.Parameters.Add("rg", SqlDbType.VarChar).Value = objTabela.Rg;
                    cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = objTabela.Cpf;
                    cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                    cn.Parameters.Add("telefone1", SqlDbType.VarChar).Value = objTabela.Telefone1;
                    cn.Parameters.Add("telefone2", SqlDbType.VarChar).Value = objTabela.Telefone2;
                    cn.Parameters.Add("rua", SqlDbType.VarChar).Value = objTabela.Rua;
                    cn.Parameters.Add("numero", SqlDbType.Int).Value = objTabela.Numero;
                    cn.Parameters.Add("bairro", SqlDbType.VarChar).Value = objTabela.Bairro;
                    cn.Parameters.Add("complemento", SqlDbType.VarChar).Value = objTabela.Complemento;
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

        public List<PessoaFisicaEnt> Buscar(PessoaFisicaEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Pessoa_Fisica WHERE nome like @nome";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<PessoaFisicaEnt> lista = new List<PessoaFisicaEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        PessoaFisicaEnt dado = new PessoaFisicaEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Rg = Convert.ToString(dr["rg"]);
                        dado.Cpf = Convert.ToString(dr["cpf"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Telefone1 = Convert.ToString(dr["telefone1"]);
                        dado.Telefone2 = Convert.ToString(dr["telefone2"]);
                        dado.Rua = Convert.ToString(dr["rua"]);
                        dado.Numero = Convert.ToInt32(dr["numero"]);
                        dado.Bairro = Convert.ToString(dr["bairro"]);
                        dado.Complemento = Convert.ToString(dr["complemento"]);
                        dado.Id_funcao = Convert.ToInt32(dr["id_funcao"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

        public List<PessoaFisicaEnt> BuscarById(int id)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Pessoa_Fisica WHERE id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = id;
                cn.Connection = con;
                SqlDataReader dr;
                List<PessoaFisicaEnt> lista = new List<PessoaFisicaEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        PessoaFisicaEnt dado = new PessoaFisicaEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Rg = Convert.ToString(dr["rg"]);
                        dado.Cpf = Convert.ToString(dr["cpf"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Telefone1 = Convert.ToString(dr["telefone1"]);
                        dado.Telefone2 = Convert.ToString(dr["telefone2"]);
                        dado.Rua = Convert.ToString(dr["rua"]);
                        dado.Numero = Convert.ToInt32(dr["numero"]);
                        dado.Bairro = Convert.ToString(dr["bairro"]);
                        dado.Complemento = Convert.ToString(dr["complemento"]);
                        dado.Id_funcao = Convert.ToInt32(dr["id_funcao"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }

        }


        public int Editar(PessoaFisicaEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Pessoa_Fisica SET nome = @nome, rg = @rg, cpf = @cpf, email = @email, telefone1 = @telefone1, telefone2 = @telefone2, rua = @rua, numero = @numero, bairro = @bairro, complemento = @complemento, id_funcao = @id_funcao WHERE id = @id";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                cn.Parameters.Add("rg", SqlDbType.VarChar).Value = objTabela.Rg;
                cn.Parameters.Add("cpf", SqlDbType.VarChar).Value = objTabela.Cpf;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                cn.Parameters.Add("telefone1", SqlDbType.VarChar).Value = objTabela.Telefone1;
                cn.Parameters.Add("telefone2", SqlDbType.VarChar).Value = objTabela.Telefone2;
                cn.Parameters.Add("rua", SqlDbType.VarChar).Value = objTabela.Rua;
                cn.Parameters.Add("numero", SqlDbType.Int).Value = objTabela.Numero;
                cn.Parameters.Add("bairro", SqlDbType.VarChar).Value = objTabela.Bairro;
                cn.Parameters.Add("complemento", SqlDbType.VarChar).Value = objTabela.Complemento;
                cn.Parameters.Add("id_funcao", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id_funcao);
                cn.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id);
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }

        }

        public int Excluir(PessoaFisicaEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Pessoa_Fisica WHERE id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }

        public List<PessoaFisicaEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Pessoa_Fisica ORDER BY nome ASC";

                cn.Connection = con;
                SqlDataReader dr;
                List<PessoaFisicaEnt> lista = new List<PessoaFisicaEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        PessoaFisicaEnt dado = new PessoaFisicaEnt();

                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Rg = Convert.ToString(dr["rg"]);
                        dado.Cpf = Convert.ToString(dr["cpf"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Telefone1 = Convert.ToString(dr["telefone1"]);
                        dado.Telefone2 = Convert.ToString(dr["telefone2"]);
                        dado.Rua = Convert.ToString(dr["rua"]);
                        dado.Numero = Convert.ToInt32(dr["numero"]);
                        dado.Bairro = Convert.ToString(dr["bairro"]);
                        dado.Complemento = Convert.ToString(dr["complemento"]);
                        dado.Id_funcao = Convert.ToInt32(dr["id_funcao"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
    }
}
