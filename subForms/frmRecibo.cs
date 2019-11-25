using Entidades;
using Model;
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
using Bunifu.Framework.UI;
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
        private string opc = "";
        string valor;
        ReciboEnt objTabela = new ReciboEnt();
        public frmRecibo()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";
        }

        public frmRecibo(string valor, string numero, string Nome, string import1,
            string import2, string refer1, string refer2, string emitent, string cnpj)
        {
            InitializeComponent();
            textValorRecibo.Text = valor;
            textNumeroRecibo.Text = numero;
            textRecebemosde.Text = Nome;
            textImportanciade1.Text = import1;
            textImportanciade2.Text = import2;
            textReferentea1.Text = refer1;
            textReferentea2.Text = refer2;
            textEmitente.Text = emitent;
            textCnpj.Text = emitent;
            //DesabilitarCampos();
            apenasLeitura();
            //HabilitarCampos();
            this.Size = new Size(880, 650);
            panel2.Visible = false;
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

        private void apenasLeitura() 
        {

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is TextBox)
                {
                    
                    ((TextBox)ctrl).ReadOnly = true;
                }

                if (ctrl is BunifuMaterialTextbox)
                {
                    ((BunifuMaterialTextbox)ctrl).Enabled = false;
                }
            }
        }

        private void printDocument1_PrintPage(System.Object sender,
               System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0, 800.0F, 600.0F);
        }

        private void frmRecibo_Load(object sender, EventArgs e)
        {

            //btnSalvar.Enabled = false;
            CarregarGrid();
            DesabilitarCampos();
            atualizaData();
        }

        private void atualizaData() 
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            int dia = DateTime.Now.Day;
            int ano = DateTime.Now.Year;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
            string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));
            string data = diasemana + ", " + dia + " de " + mes + " de " + ano + ".";
            lbldata.Text = data;
        }
        

       private void hiderButtons() 
       {
            btnNovo.Visible = false;
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

        private void HabilitarCampos()
        {
            textNumeroRecibo.Enabled = true;
            textValorRecibo.Enabled = true;
            textRecebemosde.Enabled = true;
            textImportanciade1.Enabled = true;
            textImportanciade2.Enabled = true;
            textReferentea1.Enabled = true;
            textReferentea2.Enabled = true;
            textEmitente.Enabled = true;
            textCnpj.Enabled = true;
       }

        private void DesabilitarCampos()
        {
            /*
            textNumeroRecibo.Enabled = false;
            textValorRecibo.Enabled = false;
            textRecebemosde.Enabled = false;
            textImportanciade1.Enabled = false;
            textImportanciade2.Enabled = false;
            textReferentea1.Enabled = false;
            textReferentea2.Enabled = false;
            textEmitente.Enabled = false;
            textCnpj.Enabled = false;
            textAssinatura.Enabled = false;
            */

            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is TextBox)
                {

                    ((TextBox)ctrl).Enabled = false;
                }

                if (ctrl is BunifuMaterialTextbox)
                {
                    ((BunifuMaterialTextbox)ctrl).Enabled = false;
                }
            }

        }
        private void LimparCampos()
        {
            textNumeroRecibo.Text = null;
            textValorRecibo.Text = null;
            textRecebemosde.Text = null;
            textImportanciade1.Text = null;
            textImportanciade2.Text = null;
            textReferentea1.Text = null;
            textReferentea2.Text = null;
            textPesquisar.Text = null;
            //textEmitente.Text = null;
            //textCnpj.Text = null;
        }

        private void CarregarGrid()
        {
            try
            {
                List<ReciboEnt> lista = new List<ReciboEnt>();
                lista = new ReciboModel().Lista();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = lista;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "VALOR";
                dataGridView1.Columns[2].HeaderText = "RECEBEMOSDE";
                dataGridView1.Columns[3].HeaderText = "IMPORTÂNCIA";
                dataGridView1.Columns[4].HeaderText = "IMPORTÂNCIA...";
                dataGridView1.Columns[5].HeaderText = "REFERENTE";
                dataGridView1.Columns[6].HeaderText = "REFERENTE...";
                dataGridView1.Columns[7].HeaderText = "EMITENTE";
                dataGridView1.Columns[8].HeaderText = "CNPJ";
                dataGridView1.Columns[9].HeaderText = "DATA/HORA";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Carregar DataGrid: " + ex.Message);
            }
        }


        private void btnFecharRecibo_Click(object sender, EventArgs e)
        {
            sound1();
            this.Close();
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

        private void btnPrepararImpressao_Click(object sender, EventArgs e)
        {
            sound1();

            if (textNumeroRecibo.Text == string.Empty) 
            {
                sound3();
                MessageBox.Show("Salve primeiro o registro para preparar a impressão ok!", "AVISO!", MessageBoxButtons.OK);
                return;
            }

            Form frmrec = new frmRecibo(textValorRecibo.Text, textNumeroRecibo.Text, 
                textRecebemosde.Text, textImportanciade1.Text, textImportanciade2.Text, 
                textReferentea1.Text, textReferentea2.Text, textEmitente.Text, textCnpj.Text);
            frmrec.TopMost = true;
            frmrec.Show();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            sound1();
            opc = "Salvar";
            HabilitarCampos();
            atualizaData();
            LimparCampos();
            //textValorRecibo.Text = Convert.ToDouble(textValorRecibo.Text).ToString("C");
            textValorRecibo.Focus();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            sound1();
            if (opc == "") {return;}

            switch (opc)
            {
                case "Salvar":
                    try
                    {
                        DialogResult result1 = MessageBox.Show("Confima salvação do registro?", "Aviso!", MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {
                            
                            objTabela.Valor = textValorRecibo.Text;
                            objTabela.Recebemosde = textRecebemosde.Text;
                            objTabela.Importancia1 = textImportanciade1.Text;
                            objTabela.Importancia2 = textImportanciade2.Text;
                            objTabela.Referentea1 = textReferentea1.Text;
                            objTabela.Referentea2 = textReferentea2.Text;
                            objTabela.Emitente = textEmitente.Text;
                            objTabela.Cnpj = textCnpj.Text;
                            objTabela.Data = DateTime.Now;

                            int x = ReciboModel.Inseir(objTabela);

                            if (x > 0)
                            {
                                MessageBox.Show("Registro cadastrado com sucesso!", "Aviso!", MessageBoxButtons.OK);
                                LimparCampos();
                                DesabilitarCampos();
                                CarregarGrid();
                                btnSalvar.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Error ao Tentar cadastrar Usuário!", "Aviso!", MessageBoxButtons.OK);
                            }
                        }
                        else { return; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um error tentar salvar Registro:" + ex.Message);
                    }
                    break;

                case "Editar":
                    try
                    {
                        DialogResult result2 = MessageBox.Show("Confima a Edição do registro?", "Aviso!", MessageBoxButtons.YesNo);
                        if (result2 == DialogResult.Yes)
                        {
                            objTabela.Id = Convert.ToInt32(textNumeroRecibo.Text);
                            objTabela.Valor = textValorRecibo.Text;
                            objTabela.Recebemosde = textRecebemosde.Text;
                            objTabela.Importancia1 = textImportanciade1.Text;
                            objTabela.Importancia2 = textImportanciade2.Text;
                            objTabela.Referentea1 = textReferentea1.Text;
                            objTabela.Referentea2 = textReferentea2.Text;
                            objTabela.Emitente = textEmitente.Text;
                            objTabela.Cnpj = textCnpj.Text;
                            

                            int x = ReciboModel.Editar(objTabela);

                            if (x > 0)
                            {
                                MessageBox.Show("Registro Editado com sucesso!", "Aviso!", MessageBoxButtons.OK);
                                LimparCampos();
                                DesabilitarCampos();
                                CarregarGrid();
                                btnSalvar.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Error ao Tentar Editar o Registro", "Aviso!", MessageBoxButtons.OK);
                                btnSalvar.Enabled = false;
                            }
                        }
                        else { return; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Editar ERROR: " + ex.Message);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            sound1();
            if (textNumeroRecibo.Text == "")
            {
                sound3();
                MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                return;
            }
            opc = "Editar";
            HabilitarCampos();
            textValorRecibo.Focus();
            btnSalvar.Enabled = true;
        }
        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            sound1();
            try
            {
                if (textNumeroRecibo.Text == Convert.ToString(null) || textRecebemosde.Text == "")
                {
                    sound3();
                    MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                    return;
                }
                DialogResult result1 = MessageBox.Show("Confima a Exclusão do registro?", "Aviso!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    objTabela.Id = Convert.ToInt32(textNumeroRecibo.Text);
                    int x = ReciboModel.Excluir(objTabela);

                    if (x > 0)
                    {
                        sound2();
                        LimparCampos();
                        DesabilitarCampos();
                        CarregarGrid();
                        MessageBox.Show(string.Format("Registro  excluído com sucesso!"));
                    }
                    else
                    {
                        MessageBox.Show("Error ao Tentar Excluir o Registro");
                    }
                }
                else { return; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um error ao excluir o registro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sound2();
            LimparCampos();
            DesabilitarCampos();
            btnSalvar.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            sound1();
            if (pictureBox1.Visible == false)
            {
                pictureBox1.Visible = true;
                textPesquisar.Visible = true;
                textPesquisar.Text = null;
                textPesquisar.Focus();
            }
            else
            {
                pictureBox1.Visible = false;
                textPesquisar.Visible = false;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textNumeroRecibo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textValorRecibo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textRecebemosde.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textImportanciade1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textImportanciade2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textReferentea1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textReferentea2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textEmitente.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textCnpj.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                lbldata.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error DataGrid: " + ex.Message);
            }
        }
        private void Moeda(ref TextBox txt)
        {
            //procedure para formatar textbox em formato moeda c/2 casas decimais
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception c)
            {
                //MessageBox.Show(c.Message);
            }
        }



        private void textPesquisar_OnValueChanged(object sender, EventArgs e)
        {
            if (textPesquisar.Text == "")
            {
                CarregarGrid();
                return;
            }
            else
            {
                try
                {
                    objTabela.Recebemosde = textPesquisar.Text;
                    List<ReciboEnt> lista = new List<ReciboEnt>();
                    lista = new ReciboModel().Buscar(objTabela);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = lista;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao Listar Dados: " + ex.Message);
                }
            }
        }

        private void textValorRecibo_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                Moeda(ref textValorRecibo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void textValorRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                //valor =   Convert.ToDouble(textValorRecibo.Text).ToString("C");
                //textValorRecibo.Text = valor;
                textRecebemosde.Focus();
            }
        }

        private void textRecebemosde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textImportanciade1.Focus();
            }
        }

        private void textImportanciade1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textImportanciade2.Focus();
            }
        }

        private void textReferentea1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textReferentea2.Focus();
            }

        }

        private void textImportanciade2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textReferentea1.Focus();
            }

        }

        private void textReferentea2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSalvar.Focus();
            }
        }
    }
}