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
                    cn.Parameters.Add("numero", SqlDbType.VarChar).Value = objTabela.Numero;
                    cn.Parameters.Add("valor", SqlDbType.VarChar).Value = objTabela.Valor;
                    cn.Parameters.Add("recebemosde", SqlDbType.VarChar).Value = objTabela.Recebemosde;
                    cn.Parameters.Add("importanciade1", SqlDbType.Int).Value = objTabela.Importancia1;
                    cn.Parameters.Add("importanciade2", SqlDbType.Int).Value = objTabela.Importancia2;
                    cn.Parameters.Add("referente1", SqlDbType.Int).Value = objTabela.Referentea1;
                    cn.Parameters.Add("referente2", SqlDbType.Int).Value = objTabela.Referentea2;
                    cn.Parameters.Add("emitente", SqlDbType.Int).Value = objTabela.Emitente;
                    cn.Parameters.Add("cnpj", SqlDbType.Int).Value = objTabela.Cnpj;
                    cn.Parameters.Add("data", SqlDbType.DateTime).Value = objTabela.Data;
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
                cn.CommandText = "SELECT * FROM Recibo WHERE numero like @numero";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Numero + "%";
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
                        dado.Numero = Convert.ToString(dr["numero"]);
                        dado.Valor = Convert.ToString(dr["valor"]);
                        dado.Recebemosde = Convert.ToString(dr["recebemosde"]);
                        dado.Importancia1 = Convert.ToString(dr["importancia1"]);
                        dado.Importancia2 = Convert.ToString(dr["importancia2"]);
                        dado.Referentea1 = Convert.ToString(dr["referentea1"]);
                        dado.Referentea2 = Convert.ToString(dr["referentea2"]);
                        dado.Emitente = Convert.ToString(dr["emitente"]);
                        dado.Cnpj = Convert.ToString(dr["cnpj"]);
                        dado.Data = Convert.ToDateTime(dr["data"]);
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
                cn.CommandText = "UPDATE Recibo SET numero = @numero, valor = @valor, recebemosde = @recebemosde, " +
                    "importancia1 = @importancia1, importancia2 = @importancia2, referentea1 = @referentea1, " +
                    "referentea2 = @referentea2, emitente = @emitente, cnpj = @cnpj, data = @data " + "WHERE id = @id";
                cn.Parameters.Add("numero", SqlDbType.VarChar).Value = objTabela.Numero;
                cn.Parameters.Add("valor", SqlDbType.VarChar).Value = objTabela.Valor;
                cn.Parameters.Add("recebemosde", SqlDbType.VarChar).Value = objTabela.Recebemosde;
                cn.Parameters.Add("importancia1", SqlDbType.VarChar).Value = objTabela.Importancia1;
                cn.Parameters.Add("importancia2", SqlDbType.VarChar).Value = objTabela.Importancia2;
                cn.Parameters.Add("referentea1", SqlDbType.VarChar).Value = objTabela.Referentea1;
                cn.Parameters.Add("referentea2", SqlDbType.VarChar).Value = objTabela.Referentea2;
                cn.Parameters.Add("emitente", SqlDbType.VarChar).Value = objTabela.Emitente;
                cn.Parameters.Add("cnpj", SqlDbType.VarChar).Value = objTabela.Cnpj;
                cn.Parameters.Add("data", SqlDbType.DateTime).Value = objTabela.Data;
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

        public List<ReciboEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Recibo ORDER BY numero ASC";
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
                        dado.Numero= Convert.ToString(dr["numero"]);
                        dado.Valor = Convert.ToString(dr["valor"]);
                        dado.Recebemosde = Convert.ToString(dr["redebemosde"]);
                        dado.Importancia1 = Convert.ToString(dr["importancia1"]);
                        dado.Importancia2 = Convert.ToString(dr["importancia2"]);
                        dado.Referentea1 = Convert.ToString(dr["referente1"]);
                        dado.Referentea2 = Convert.ToString(dr["referente2"]);
                        dado.Emitente = Convert.ToString(dr["emitente"]);
                        dado.Cnpj= Convert.ToString(dr["cnpj"]);
                        dado.Data = Convert.ToDateTime(dr["data"]);
                        lista.Add(dado);
                    }
                }
                
                return lista;
            }
        }

    }
}
