using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;

namespace Model
{
    public class ClienteModel
    {
        public static int Inseir(ClientesEnt objTabela)
        {
            return new ClientesDAO().Inserir(objTabela);
        }

        public List<ClientesEnt> Lista()
        {
            return new ClientesDAO().Lista();
        }

        public static int Excluir(ClientesEnt objTabela)
        {
            return new ClientesDAO().Excluir(objTabela);
        }

        public static int Editar(ClientesEnt objTabela)
        {
            return new ClientesDAO().Editar(objTabela);
        }
        public List<ClientesEnt> Buscar(ClientesEnt objTabela)
        {
            return new ClientesDAO().Buscar(objTabela);
        }
        public List<ClientesEnt> BuscarById(int id)
        {
            return new ClientesDAO().BuscarById(id);
        }
    }
}
