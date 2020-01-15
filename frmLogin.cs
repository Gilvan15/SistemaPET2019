using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Entidades;
using System.Media;
using System.Runtime.InteropServices;
using SistemaPet.subForms;

namespace SistemaPet
{
    public partial class frmLogin : Form
    {
        

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        string pasta_aplicacao = "";
        public frmLogin()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";

            
                
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            textSenha.isPassword = true;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Fechar o Sistema Pets e Pets?", "Sair", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes) {Application.Exit();} else {  };
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //sound2();
        }

        public void sound1()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\click.wav");
            player.Play();
        }

        public void sound2()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao +"wavs\\camp.wav");
            player.Play();
        }
        public void sound3()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\aviso.wav");
            player.Play();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textSenha.Focus();
            }
        }

        private void textSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogar.Focus();
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textUsername.Text == string.Empty || textSenha.Text == string.Empty)
                {
                    sound3();
                    MessageBox.Show("Preencha o campo vazio!", "Aviso!", MessageBoxButtons.OK);
                    textUsername.Focus();
                    return;
                }

                UsuarioEnt obj = new UsuarioEnt();
                obj.Username = textUsername.Text;
                obj.Senha = textSenha.Text;

                obj = new UsuarioModel().Login(obj);
                

                if (obj.Username == null || obj.Senha == null)
                {
                    sound3();
                    MessageBox.Show("Usuário ou Senha inválidos!", "Aviso!", MessageBoxButtons.OK);
                    return;
                }

                frmPrincipal frmP = new frmPrincipal();
                this.Hide();
                frmP.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro messagem: " + ex.Message);
            }
        }

        private void btnLogar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (textUsername.Text == string.Empty || textSenha.Text == string.Empty)
                {
                    sound3();
                    MessageBox.Show("Preencha o campo vazio!", "Aviso!", MessageBoxButtons.OK);
                    textUsername.Focus();
                    return;
                }

                UsuarioEnt obj = new UsuarioEnt();
                obj.Username = textUsername.Text;
                obj.Senha = textSenha.Text;

                obj = new UsuarioModel().Login(obj);

                if (obj.Username == null || obj.Senha == null)
                {
                    sound3();
                    MessageBox.Show("Usuário ou Senha inválidos!", "Aviso!", MessageBoxButtons.OK);
                    return;
                }

                frmPrincipal frmP = new frmPrincipal();
                this.Hide();
                frmP.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro messagem: " + ex.Message);
            }

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {
            sound1();
            frmRecuperarSenha frmRecp = new frmRecuperarSenha();
            this.Hide();
            frmRecp.ShowDialog();
        }
    }
}
