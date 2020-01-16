using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClientesEnt
    {
        private int id;
        private string nome;
        private string email;
        private string rg;
        private string cpf;
        private string fone1;   
        private string fone2;
        private string rua;
        private string numero;
        private string bairro;
        private string complemento;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Fone1 { get => fone1; set => fone1 = value; }
        public string Fone2 { get => fone2; set => fone2 = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
    }
}
