using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;

namespace Model
{
    public class ReciboModel
    {
        public static int Inseir(ReciboEnt objTabela)
        {
            return new UsuarioDAO().Inserir(objTabela);
        }

        public List<ReciboEnt> Lista()
        {
            return new UsuarioDAO().Lista();
        }

        public DataTable ListaJonn()
        {
            return new UsuarioDAO().ListaJonn();
        }



        public static int Excluir(ReciboEnt objTabela)
        {
            return new UsuarioDAO().Excluir(objTabela);
        }

        public static int Editar(ReciboEnt objTabela)
        {
            return new UsuarioDAO().Editar(objTabela);
        }
        public List<ReciboEnt> Buscar(ReciboEnt objTabela)
        {
            return new UsuarioDAO().Buscar(objTabela);
        }

        
    }
}
