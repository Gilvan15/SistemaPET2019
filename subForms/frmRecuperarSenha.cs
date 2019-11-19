using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet.subForms
{
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }
        private void Fechar_Click_1(object sender, EventArgs e)
        {
            sound1();
            frmLogin frmLog = new frmLogin();
            this.Close();
            frmLog.Show();
        }

        public void sound1()
        {
            SoundPlayer player = new SoundPlayer(@"C:\Repositorio\SistemaPetShop\wavs\click.wav");
            player.Play();
        }
    }
}
