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

        string pasta_aplicacao = "";
        public frmRecuperarSenha()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";

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
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\click.wav");
            player.Play();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (ValidarEmail(textEmail.Text) == false)
            {
                MessageBox.Show("Email com formato incorreto!","Aviso!!!", MessageBoxButtons.OK);
            }
        }

        public static bool ValidarEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {return true;} else {return false;}
        }
    }



}
