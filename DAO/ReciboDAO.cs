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
                    cn.CommandText = "INSERT INTO Recibo ([valor], [recebemosde], [importanciade1], " +
                        "[importanciade2], [referentea1], [referentea2], [emitente], [cnpj], [data]) " +
                        "VALUES (@valor, @recebemosde, @importanciade1, @importanciade2, " +
                        "@referentea1, @referentea2, @emitente, @cnpj, @data)";

                    cn.Parameters.Add("valor", SqlDbType.VarChar).Value = objTabela.Valor;
                    cn.Parameters.Add("recebemosde", SqlDbType.VarChar).Value = objTabela.Recebemosde;
                    cn.Parameters.Add("importanciade1", SqlDbType.VarChar).Value = objTabela.Importancia1;
                    cn.Parameters.Add("importanciade2", SqlDbType.VarChar).Value = objTabela.Importancia2;
                    cn.Parameters.Add("referentea1", SqlDbType.VarChar).Value = objTabela.Referentea1;
                    cn.Parameters.Add("referentea2", SqlDbType.VarChar).Value = objTabela.Referentea2;
                    cn.Parameters.Add("emitente", SqlDbType.VarChar).Value = objTabela.Emitente;
                    cn.Parameters.Add("cnpj", SqlDbType.VarChar).Value = objTabela.Cnpj;
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
                cn.CommandText = "SELECT * FROM Recibo WHERE recebemosde like @recebemosde";
                cn.Parameters.Add("recebemosde", SqlDbType.VarChar).Value = objTabela.Recebemosde + "%";
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
                        dado.Valor = Convert.ToString(dr["valor"]);
                        dado.Recebemosde = Convert.ToString(dr["recebemosde"]);
                        dado.Importancia1 = Convert.ToString(dr["importanciade1"]);
                        dado.Importancia2 = Convert.ToString(dr["importanciade2"]);
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
                cn.CommandText = "UPDATE Recibo SET  valor = @valor, recebemosde = @recebemosde, " +
                    "importanciade1 = @importanciade1, importanciade2 = @importanciade2, referentea1 = @referentea1, " +
                    "referentea2 = @referentea2, emitente = @emitente, cnpj = @cnpj " + "WHERE id = @id";
                cn.Parameters.Add("valor", SqlDbType.VarChar).Value = objTabela.Valor;
                cn.Parameters.Add("recebemosde", SqlDbType.VarChar).Value = objTabela.Recebemosde;
                cn.Parameters.Add("importanciade1", SqlDbType.VarChar).Value = objTabela.Importancia1;
                cn.Parameters.Add("importanciade2", SqlDbType.VarChar).Value = objTabela.Importancia2;
                cn.Parameters.Add("referentea1", SqlDbType.VarChar).Value = objTabela.Referentea1;
                cn.Parameters.Add("referentea2", SqlDbType.VarChar).Value = objTabela.Referentea2;
                cn.Parameters.Add("emitente", SqlDbType.VarChar).Value = objTabela.Emitente;
                cn.Parameters.Add("cnpj", SqlDbType.VarChar).Value = objTabela.Cnpj;
                //cn.Parameters.Add("data", SqlDbType.DateTime).Value = objTabela.Data;
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
                cn.CommandText = "SELECT * FROM Recibo ORDER BY id ASC";
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
                        dado.Valor = Convert.ToString(dr["valor"]);
                        dado.Recebemosde = Convert.ToString(dr["recebemosde"]);
                        dado.Importancia1 = Convert.ToString(dr["importanciade1"]);
                        dado.Importancia2 = Convert.ToString(dr["importanciade2"]);
                        dado.Referentea1 = Convert.ToString(dr["referentea1"]);
                        dado.Referentea2 = Convert.ToString(dr["referentea2"]);
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
