using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace DAO
{
    public class FuncaoDAO
    {
        public int qtd;
        public int Inserir(FuncaoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = DAO.Properties.Settings.Default.banco;
                    SqlCommand cn = new SqlCommand();
                    cn.CommandType = CommandType.Text;
                    con.Open();
                    cn.CommandText = "INSERT INTO Funcao ([descricao]) VALUES (@descricao)";
                    cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao;
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

        public List<FuncaoEnt> BuscarPorId(FuncaoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Funcao WHERE id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Connection = con;
                SqlDataReader dr;
                List<FuncaoEnt> lista = new List<FuncaoEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        FuncaoEnt dado = new FuncaoEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }






        public List<FuncaoEnt> Buscar(FuncaoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Funcao WHERE descricao like @descricao";
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<FuncaoEnt> lista = new List<FuncaoEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        FuncaoEnt dado = new FuncaoEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }

        public int Editar(FuncaoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Funcao SET descricao = @descricao WHERE id = @id";
                cn.Parameters.Add("descricao", SqlDbType.VarChar).Value = objTabela.Descricao;
                cn.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id);
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }

        }
        public int Excluir(FuncaoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Funcao WHERE id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }

        }

        public List<FuncaoEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Funcao ORDER BY descricao ASC";

                cn.Connection = con;
                SqlDataReader dr;
                List<FuncaoEnt> lista = new List<FuncaoEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        FuncaoEnt dado = new FuncaoEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Descricao = Convert.ToString(dr["descricao"]);
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
    }

}

