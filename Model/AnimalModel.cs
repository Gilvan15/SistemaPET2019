using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;

namespace Model
{
    public class AnimalModel
    {
        public static int Inseir(AnimalEnt objTabela)
        {
            return new AnimalDAO().Inserir(objTabela);
        }

        public List<AnimalEnt> Lista()
        {
            return new AnimalDAO().Lista();
        }

        public static int Excluir(AnimalEnt objTabela)
        {
            return new AnimalDAO().Excluir(objTabela);
        }

        public static int Editar(AnimalEnt objTabela)
        {
            return new AnimalDAO().Editar(objTabela);
        }
        public List<AnimalEnt> Buscar(AnimalEnt objTabela)
        {
            return new AnimalDAO().Buscar(objTabela);
        }


    }
}
