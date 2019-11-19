using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Entidades;
using System.Data;

namespace Model
{
    public class UsuarioModel
    {

        public static int Inseir(UsuarioEnt objTabela) 
        {
            return new UsuarioDAO().Inserir(objTabela);
        }

        public List<UsuarioEnt> Lista() 
        {
            return new UsuarioDAO().Lista();
        }

        public DataTable ListaJonn()
        {
            return new UsuarioDAO().ListaJonn();
        }



        public static int Excluir(UsuarioEnt objTabela) 
        {
            return new UsuarioDAO().Excluir(objTabela);
        }

        public static int Editar(UsuarioEnt objTabela)
        {
            return new UsuarioDAO().Editar(objTabela);
        }
        public List<UsuarioEnt> Buscar(UsuarioEnt objTabela) 
        {
            return new UsuarioDAO().Buscar(objTabela);
        }

        public UsuarioEnt Login(UsuarioEnt obj) 
        {
            return new UsuarioDAO().Login(obj);
        }

    }
}
