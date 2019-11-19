using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AnimalEnt
    {
        private int id;
        private string especie;
        private string raca;
        private string nome;
        private string proprietario;
        private string telefone;
        private string email;
        private string cuidados_esp;
        private string alergico;
        private byte[] foto;

        public int Id { get => id; set => id = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Raca { get => raca; set => raca = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Proprietario { get => proprietario; set => proprietario = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Cuidados_esp { get => cuidados_esp; set => cuidados_esp = value; }
        public string Alergico { get => alergico; set => alergico = value; }
        public byte[] Foto { get => foto; set => foto = value; }
    }
}
