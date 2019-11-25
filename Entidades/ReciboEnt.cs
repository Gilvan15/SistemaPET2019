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
        private string valor;
        private string recebemosde;
        private string importancia1;
        private string importancia2;
        private string referentea1;
        private string referentea2;
        private string emitente;
        private string cnpj;
        private DateTime data;

        public int Id { get => id; set => id = value; }
        public string Valor { get => valor; set => valor = value; }
        public string Recebemosde { get => recebemosde; set => recebemosde = value; }
        public string Importancia1 { get => importancia1; set => importancia1 = value; }
        public string Importancia2 { get => importancia2; set => importancia2 = value; }
        public string Referentea1 { get => referentea1; set => referentea1 = value; }
        public string Referentea2 { get => referentea2; set => referentea2 = value; }
        public string Emitente { get => emitente; set => emitente = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
