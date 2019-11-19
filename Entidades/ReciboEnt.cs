using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReciboEnt
    {
        private int id;
        private string Numero;
        private double Valor;
        private string nome;
        private string importancia;
        private string referente;
        private string atendente;
        private DateTime data_emissao;

        public int Id { get => id; set => id = value; }
        public string Numero1 { get => Numero; set => Numero = value; }
        public double Valor1 { get => Valor; set => Valor = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Importancia { get => importancia; set => importancia = value; }
        public string Referente { get => referente; set => referente = value; }
        public string Atendente { get => atendente; set => atendente = value; }
        public DateTime Data_emissao { get => data_emissao; set => data_emissao = value; }
    }
}
