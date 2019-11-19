using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FotoEnt
    {
        private int id;
        private byte[] fotoant1;
        private byte[] fotoant2;
        private byte[] fotoant3;
        private byte[] fotodep1;
        private byte[] fotodep2;
        private byte[] fotodep3;
        private DateTime data_foto;
        private int id_animal;

        public int Id { get => id; set => id = value; }
        public byte[] Fotoant1 { get => fotoant1; set => fotoant1 = value; }
        public byte[] Fotoant2 { get => fotoant2; set => fotoant2 = value; }
        public byte[] Fotoant3 { get => fotoant3; set => fotoant3 = value; }
        public byte[] Fotodep1 { get => fotodep1; set => fotodep1 = value; }
        public byte[] Fotodep2 { get => fotodep2; set => fotodep2 = value; }
        public byte[] Fotodep3 { get => fotodep3; set => fotodep3 = value; }
        public DateTime Data_foto { get => data_foto; set => data_foto = value; }
        public int Id_animal { get => id_animal; set => id_animal = value; }
    }
}
