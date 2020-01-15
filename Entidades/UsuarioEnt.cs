using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class UsuarioEnt
    {
        private int id;
        private string nome;
        private string email;
        private string username;
        private string senha;
        private int id_funcao;
        

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Id_funcao { get => id_funcao; set => id_funcao = value; }
        
    }
}
