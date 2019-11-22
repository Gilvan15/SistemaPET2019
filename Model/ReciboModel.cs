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
            return new ReciboDAO().Inserir(objTabela);
        }

        public List<ReciboEnt> Lista()
        {
            return new ReciboDAO().Lista();
        }

        public static int Excluir(ReciboEnt objTabela)
        {
            return new ReciboDAO().Excluir(objTabela);
        }

        public static int Editar(ReciboEnt objTabela)
        {
            return new ReciboDAO().Editar(objTabela);
        }
        public List<ReciboEnt> Buscar(ReciboEnt objTabela)
        {
            return new ReciboDAO().Buscar(objTabela);
        }
        
    }
}
