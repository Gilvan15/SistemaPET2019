using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPet.subForms
{
    public partial class frmRecibo : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        Bitmap memoryImage;
        string pasta_aplicacao = "";

        public frmRecibo()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";
        }

        public frmRecibo(string valor, string numero, string Nome)
        {
            InitializeComponent();
            textValorRecibo.Text = valor;
            textNumeroRecibo.Text = numero;
            textNome.Text = Nome;
            hiderButtons();
        }

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0, 800.0F, 600.0F);
        }

        private void frmRecibo_Load(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            int dia = DateTime.Now.Day;
            int ano = DateTime.Now.Year;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
            string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));
            string data = diasemana + ", " + dia + " de " + mes + " de " + ano + "." ;
            lbldata.Text = data;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            sound1();
            Form frmrec = new frmRecibo(textValorRecibo.Text, textNumeroRecibo.Text, textNome.Text);
            frmrec.TopMost = true;
            frmrec.Show();
        }

       private void hiderButtons() 
       {
            btnSalvar.Visible = false;
            btnPrepararImpressao.Visible = false;
            btnFecharRecibo.Visible = true;
            btnImprimir.Visible = true;
       }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            sound1();
            btnImprimir.Visible = false;
            btnFecharRecibo.Visible = false;
            CaptureScreen();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.Print();
            btnImprimir.Visible = true;
            btnFecharRecibo.Visible = true;
        }
        private void btnFecharRecibo_Click(object sender, EventArgs e)
        {
            sound1();
            Close();
        }

        public void sound1()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\click.wav");
            player.Play();
        }
        public void sound2()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\limpar.wav");
            player.Play();
        }
        public void sound3()
        {
            SoundPlayer player = new SoundPlayer(pasta_aplicacao + "wavs\\aviso.wav");
            player.Play();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            sound1();
        }
    }
}