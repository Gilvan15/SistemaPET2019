using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Model;


namespace SistemaPet.subForms
{
    public partial class frmCliente : Form
    {
        ClientesEnt objTabela = new ClientesEnt();
        private string opc = "";
        string pasta_aplicacao = "";
        
        public frmCliente()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";
        }

        private void DesabilitarCampos()
        {
            LimparCampos();
            textNome.Enabled = false;
            textRg.Enabled = false;
            textCpf.Enabled = false;
            textEmail.Enabled = false;
            textRua.Enabled = false;
            textNumero.Enabled = false;
            textBairro.Enabled = false;
            textComplemento.Enabled = false;
        }
        private void LimparCampos()
        {
            textCod.Text = null;
            textNome.Text = null;
            textEmail.Text = null;
            textRg.Text = null;
            textCpf.Text = null;
            textTelefone1.Text = null;
            textTelefone2.Text = null;
            textRua.Text = null;
            textNumero.Text = null;
            textBairro.Text = null;
            textComplemento.Text = null;
        }

        private void HabilitarCampos()
        {
            textNome.Enabled = true;
            textEmail.Enabled = true;
            textRg.Enabled = true;
            textCpf.Enabled = true;
            textTelefone1.Enabled = true;
            textTelefone2.Enabled = true;
            textRua.Enabled = true;
            textNumero.Enabled = true;
            textBairro.Enabled = true;
            textComplemento.Enabled = true;
        }
        private void ListarGrid()
        {
            try
            {
                List<ClientesEnt> lista = new List<ClientesEnt>();
                lista = new ClienteModel().Lista();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Carregar DataGrid: " + ex.Message);
            }
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
        private void InicarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    HabilitarCampos();
                    LimparCampos();
                    textNome.Focus();
                    break;

                case "Salvar":
                    try
                    {
                        objTabela.Nome = textNome.Text;
                        objTabela.Email = textEmail.Text;
                        objTabela.Rg = textRg.Text;
                        objTabela.Cpf = textCpf.Text;
                        objTabela.Fone1 = textTelefone1.Text;
                        objTabela.Fone2 = textTelefone2.Text;
                        objTabela.Rua = textRua.Text;
                        objTabela.Numero = Convert.ToInt32(textNumero.Text);
                        objTabela.Bairro = textBairro.Text;
                        objTabela.Complemento = textComplemento.Text;

                        int x = ClienteModel.Inseir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show("Registro cadastrado com sucesso!", "Aviso!", MessageBoxButtons.OK);
                            DesabilitarCampos();
                            ListarGrid();
                        }
                        else
                        {
                            MessageBox.Show("Error ao Tentar cadastrar Usuário!", "Aviso!", MessageBoxButtons.OK);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um error tentar salvar Registro:" + ex.Message);

                    }
                    break;

                case "Excluir":
                    try
                    {

                        if (textCod.Text == Convert.ToString(null) || textNome.Text == "")
                        {
                            sound3();
                            MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                            return;
                        }

                        objTabela.Id = Convert.ToInt32(textCod.Text);
                        int x = ClienteModel.Excluir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show("Registro  excluído com suceso!", "Aviso!", MessageBoxButtons.OK);
                            DesabilitarCampos();
                            ListarGrid();
                        }
                        else
                        {
                            MessageBox.Show("Error ao Tentar Excluir o Registro");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao excluir: " + ex.Message);
                    }

                    break;

                case "Editar":

                    if (textCod.Text == "")
                    {
                        sound3();
                        MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                        return;
                    }

                    try
                    {
                        DialogResult result1 = MessageBox.Show("Confima alteração do registro?", "Aviso!", MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {
                            objTabela.Id = Convert.ToInt32(textCod.Text);
                            objTabela.Nome = textNome.Text;
                            objTabela.Rg = textRg.Text;
                            objTabela.Cpf = textCpf.Text;
                            objTabela.Email = textEmail.Text;
                            objTabela.Fone1 = textTelefone1.Text;
                            objTabela.Fone2 = textTelefone2.Text;
                            objTabela.Rua = textRua.Text;
                            objTabela.Numero = Convert.ToInt32(textNumero.Text);
                            objTabela.Bairro = textBairro.Text;
                            objTabela.Complemento = textComplemento.Text;

                            int x = ClienteModel.Editar(objTabela);

                            if (x > 0)
                            {
                                MessageBox.Show("Registro Editado com sucesso!", "Aviso!", MessageBoxButtons.OK);
                                DesabilitarCampos();
                                ListarGrid();
                            }
                            else
                            {
                                MessageBox.Show("Error ao Tentar Editar o Registro", "Aviso!", MessageBoxButtons.OK);
                            }
                        }
                        else { return; }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Editar ERROR: " + ex.Message);

                    }
                    break;

                case "Buscar":

                    try
                    {
                        objTabela.Nome = textPesquisar.Text;
                        List<ClientesEnt> lista = new List<ClientesEnt>();
                        lista = new ClienteModel().Buscar(objTabela);
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = lista;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error ao Listar Dados: " + ex.Message);
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            sound1();
            opc = "Novo";
            InicarOpc();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            sound1();
            opc = "Editar";
            InicarOpc();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            sound1();
            opc = "Excluir";
            InicarOpc();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            sound2();
            LimparCampos();
            DesabilitarCampos();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            sound1();
            opc = "Salvar";
            InicarOpc();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                HabilitarCampos();
                textCod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textEmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textRg.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textCpf.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textTelefone1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textTelefone2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textRua.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textNumero.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBairro.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                textComplemento.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error DataGrid: " + ex.Message);
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbpetsepetsDataSet1.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.dbpetsepetsDataSet1.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'dbpetsepetsDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.dbpetsepetsDataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'dbpetsepetsDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.dbpetsepetsDataSet.Cliente);
            ListarGrid();
            DesabilitarCampos();
        }
    }
}