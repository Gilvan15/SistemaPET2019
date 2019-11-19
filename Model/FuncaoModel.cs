using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;

namespace Model
{
    public class FuncaoModel
    {
        public static int Inseir(FuncaoEnt objTabela)
        {
            return new FuncaoDAO().Inserir(objTabela);
        }

        public List<FuncaoEnt> Lista()
        {
            return new FuncaoDAO().Lista();
        }

        public static int Excluir(FuncaoEnt objTabela)
        {
            return new FuncaoDAO().Excluir(objTabela);
        }

        public static int Editar(FuncaoEnt objTabela)
        {
            return new FuncaoDAO().Editar(objTabela);
        }
        public List<FuncaoEnt> Buscar(FuncaoEnt objTabela)
        {
            return new FuncaoDAO().Buscar(objTabela);
        }
        public List<FuncaoEnt> BuscarPorId(FuncaoEnt objTabela)
        {
            return new FuncaoDAO().BuscarPorId(objTabela);
        }
        
    }
}
