using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PessoaFisicaEnt
    {
        private int id;
        private string nome;
        private string rg;
        private string cpf;
        private string email;
        private string telefone1;   
        private string telefone2;
        private string rua;
        private int numero;
        private string bairro;
        private string complemento;
        private int id_funcao;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone1 { get => telefone1; set => telefone1 = value; }
        public string Telefone2 { get => telefone2; set => telefone2 = value; }
        public string Rua { get => rua; set => rua = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public int Id_funcao { get => id_funcao; set => id_funcao = value; }
    }
}
