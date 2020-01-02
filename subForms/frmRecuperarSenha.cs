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
using System.Net;
using System.Net.Mail;

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
                return;
            }

            MailMessage mail = new MailMessage();

            string Textemail =  textEmail.Text;

            try
            {

                mail.From = new MailAddress("gilvanx10@gmail.com");
                mail.To.Add(Textemail); // para
                mail.Subject = "Teste de envio de email"; // assunto
                mail.Body = "Testando recuparção de senha..."; // mensagem

                using (var smtp = new SmtpClient("smtp.gmail.com"))
                {
                    smtp.EnableSsl = true; // GMail requer SSL
                    smtp.Port = 587;       // porta para SSL
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
                    smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

                    // seu usuário e senha para autenticação
                    smtp.Credentials = new NetworkCredential("gilvanx10@gmail.com", "ramona10101515");
                    // envia o e-mail
                    smtp.Send(mail);

                    MessageBox.Show("Email Enviado com sucesso!, senha Enviada para Email informado! ", "Aviso!!!", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de envio:", ex.Message);
            }
            // em caso de anexos
            //mail.Attachments.Add(new Attachment(@"C:\teste.txt"));

        }

        public static bool ValidarEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {return true;} else {return false;}
        }
    }



}
