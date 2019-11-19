using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;

namespace Model
{
    public class PessoaFisicaModel
    {
        public static int Inseir(PessoaFisicaEnt objTabela)
        {
            return new PessoaFisicaDAO().Inserir(objTabela);
        }

        public List<PessoaFisicaEnt> Lista()
        {
            return new PessoaFisicaDAO().Lista();
        }

        public static int Excluir(PessoaFisicaEnt objTabela)
        {
            return new PessoaFisicaDAO().Excluir(objTabela);
        }

        public static int Editar(PessoaFisicaEnt objTabela)
        {
            return new PessoaFisicaDAO().Editar(objTabela);
        }
        public List<PessoaFisicaEnt> Buscar(PessoaFisicaEnt objTabela)
        {
            return new PessoaFisicaDAO().Buscar(objTabela);
        }
        public List<PessoaFisicaEnt> BuscarById(int id)
        {
            return new PessoaFisicaDAO().BuscarById(id);
        }
    }
}
