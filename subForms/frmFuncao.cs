using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Entidades;
using Model;

namespace SistemaPet.subForms
{
    public partial class frmFuncao : Form
    {
        FuncaoEnt objTabela = new FuncaoEnt();
        string pasta_aplicacao = "";

        private string opc = "";
        public frmFuncao()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";
        }
        private void InicarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    HabilitarCampos();
                    LimparCampos();
                    textDescricao.Focus();
                    break;

                case "Salvar":
                    try
                    {
                        objTabela.Descricao = textDescricao.Text;
                        

                        int x = FuncaoModel.Inseir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show("Registro cadastrado com sucesso!", "Aviso!", MessageBoxButtons.OK);
                            DesabilitarCampos();
                            CarregarGrid();
                        }
                        else
                        {
                            MessageBox.Show("Error ao Tentar cadastrar Registro!", "Aviso!", MessageBoxButtons.OK);
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

                        if (textCod.Text == "")
                        {
                            sound3();
                            MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                            return;
                        }

                        DialogResult result1 = MessageBox.Show("Confima exclusão do registro?", "Aviso!", MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {

                            objTabela.Id = Convert.ToInt32(textCod.Text);
                            int x = FuncaoModel.Excluir(objTabela);



                            if (x > 0)
                            {
                                MessageBox.Show(string.Format("Registro  excluído com sucesso!"));
                                DesabilitarCampos();
                                CarregarGrid();
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
                            objTabela.Descricao = textDescricao.Text;
                            

                            int x = FuncaoModel.Editar(objTabela);

                            if (x > 0)
                            {
                                MessageBox.Show("Registro Editado com sucesso!", "Aviso!", MessageBoxButtons.OK);
                                DesabilitarCampos();
                                CarregarGrid();
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
                        objTabela.Descricao = textPesquisar.Text;
                        List<FuncaoEnt> lista = new List<FuncaoEnt>();
                        lista = new FuncaoModel().Buscar(objTabela);
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
        private void HabilitarCampos()
        {
            textCod.Enabled = true;
            textDescricao.Enabled = true;
            
        }

        private void DesabilitarCampos()
        {
            LimparCampos();
            textCod.Enabled = false;
            textDescricao.Enabled = false;
        }
        private void LimparCampos()
        {
            textCod.Text = null;
            textDescricao.Text = null;
            textPesquisar.Text = null;
        }
        private void CarregarGrid()
        {
            try
            {
                List<FuncaoEnt> lista = new List<FuncaoEnt>();
                lista = new FuncaoModel().Lista();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = lista;
                
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "DESCRIÇÃO";
                dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Carregar DataGrid: " + ex.Message);
            }

        }

        private void frmFuncao_Load(object sender, EventArgs e)
        {
            //this.funcaoTableAdapter.Fill(this.dbpetsepetsDataSet.Funcao);
            CarregarGrid();
            DesabilitarCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            sound1();
            switch (opc)
            {
                case "Salvar":
                    try
                    {
                        DialogResult result1 = MessageBox.Show("Confima salvação do registro?", "Aviso!", MessageBoxButtons.YesNo);
                        if (result1 == DialogResult.Yes)
                        {
                            objTabela.Descricao = textDescricao.Text;

                            int x = FuncaoModel.Inseir(objTabela);

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
                            objTabela.Id = Convert.ToInt32(textCod.Text);
                            objTabela.Descricao = textDescricao.Text;
                            
                            int x = FuncaoModel.Editar(objTabela);

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
        private void btnNovo_Click(object sender, EventArgs e)
        {
            sound1();
            opc = "Salvar";
            HabilitarCampos();
            LimparCampos();
            textDescricao.Focus();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            sound1();
            if (textCod.Text == "")
            {
                sound3();
                MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                return;
            }
            opc = "Editar";
            HabilitarCampos();
            textDescricao.Focus();
            btnSalvar.Enabled = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            sound1();
            try
            {
                if (textCod.Text == Convert.ToString(null) || textDescricao.Text == "")
                {
                    sound3();
                    MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                    return;
                }

                DialogResult result1 = MessageBox.Show("Confima a Exclusão do registro?", "Aviso!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    objTabela.Id = Convert.ToInt32(textCod.Text);
                    int x = FuncaoModel.Excluir(objTabela);

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
                sound3();
                
                MessageBox.Show("Registro vinculado a outra tabela!", "Exclusão Negada!", MessageBoxButtons.OK);
            }
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
        }

        private void textPesquisar_OnValueChanged(object sender, EventArgs e)
        {
            if (textPesquisar.Text == "")
            {
                CarregarGrid();
                return;
            }
            opc = "Buscar";
            InicarOpc();
        }

        private void textDescricao_OnValueChanged(object sender, EventArgs e)
        {
            if (textDescricao.Text == "")
            {
                btnSalvar.Enabled = false;

            }
            else 
            {
                btnSalvar.Enabled = true;
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

        private void textDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSalvar.Focus();
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //HabilitarCampos();
                textCod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textDescricao.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error DataGrid: " + ex.Message);
            }
        }
    }
}