using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Model;
using System.Media;
using System.Data.SqlClient;
using SistemaPet.Properties;

namespace SistemaPet.subForms
{
    public partial class frmUsuario : Form
    {
        UsuarioEnt objTabela = new UsuarioEnt();
        FuncaoEnt objFuncao = new FuncaoEnt();
        string pasta_aplicacao = "";
        int id_funcao;
        private string opc = "";
        public frmUsuario()
        {
            InitializeComponent();
            pasta_aplicacao = Application.StartupPath + @"\";
        }
        
        private void HabilitarCampos() 
        {
            textNome.Enabled = true;
            textEmail.Enabled = true;
            textSenha.Enabled = true;
            textConfSenha.Enabled = true;
            comboFuncao.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            textNome.Enabled = false;
            textEmail.Enabled = false;
            textSenha.Enabled = false;
            textConfSenha.Enabled = false;
            comboFuncao.Enabled = false;
        }
        private void LimparCampos() 
        {
            textCod.Text = null;
            textNome.Text = null;
            textEmail.Text = null;
            textSenha.Text = null;
            textConfSenha.Text = null;
            CheckboxSenha.Checked = false;
            comboFuncao.Text = null;
            textPesquisar.Text = null;
            btnSalvar.Enabled = false;
        }
        private void CarregarCombo()
        {
            List<FuncaoEnt> FuncaoFList = new List<FuncaoEnt>();
            FuncaoFList = new FuncaoModel().Lista();
            
            foreach (var item in FuncaoFList)
            {
                comboFuncao.Items.Add(item.Descricao);
            }
        }
        private void textSenha_OnValueChanged(object sender, EventArgs e)
        {
            textSenha.isPassword = true;
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            CarregarCombo();
            CarregarGrid();
            DesabilitarCampos();
        }
        private void CarregarGrid() 
        {
            try
            {
                DataTable lista;
                lista = new UsuarioModel().ListaJonn();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = lista;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].HeaderText = "NOME";
                dataGridView1.Columns[2].HeaderText = "EMAIL";
                dataGridView1.Columns[3].HeaderText = "SENHA";
                dataGridView1.Columns[4].HeaderText = "FUNÇÃO";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ao Carregar DataGrid: " + ex.Message);
            }
        }
        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            LimparCampos();
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
        private void btnSalvar_Click_2(object sender, EventArgs e)
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
                            objTabela.Nome = textNome.Text;
                            objTabela.Email = textEmail.Text;
                            objTabela.Senha = textSenha.Text;
                            objTabela.Id_funcao = id_funcao;

                            int x = UsuarioModel.Inseir(objTabela);

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
                        else {return;}
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
                            objTabela.Nome = textNome.Text;
                            objTabela.Email = textEmail.Text;
                            objTabela.Senha = textSenha.Text;
                            objTabela.Id_funcao = id_funcao;

                            int x = UsuarioModel.Editar(objTabela);

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
                /*
                                case "BuscarPorId":
                                    try
                                    {
                                        objFuncao.Id = id_funcao;
                                        List<FuncaoEnt> lista = new List<FuncaoEnt>();
                                        lista = new FuncaoModel().BuscarPorId(objFuncao);
                                        foreach (var item in lista)
                                        {
                                            id_funcao = item.Id;
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Error ao Buscar por ID: " + ex.Message);
                                    }
                                    break;
                                    */
                default:
                    break;
            }
        }
        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            sound2();
            LimparCampos();
            DesabilitarCampos();
            btnSalvar.Enabled = false;
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //HabilitarCampos();
                textCod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textEmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textSenha.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboFuncao.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error DataGrid: " + ex.Message);
            }
        }
        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            sound1();
            opc = "Salvar";
            HabilitarCampos();
            LimparCampos();
            textNome.Focus();
        }
        private void btnEditar_Click_1(object sender, EventArgs e)
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
            textNome.Focus();
            btnSalvar.Enabled = true;
        }
        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            sound1();
            try
            {
                if (textCod.Text == Convert.ToString(null) || textNome.Text == "")
                {
                    sound3();
                    MessageBox.Show("Selecione primeiro um Registro!", "Aviso!", MessageBoxButtons.OK);
                    return;
                }

                DialogResult result1 = MessageBox.Show("Confima a Exclusão do registro?", "Aviso!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    objTabela.Id = Convert.ToInt32(textCod.Text);
                    int x = UsuarioModel.Excluir(objTabela);

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

        private void btnPesquisar_Click_1(object sender, EventArgs e)
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

        private void textConfSenha_OnValueChanged(object sender, EventArgs e)
        {
            textConfSenha.isPassword = true;

            if (textSenha.Text == textConfSenha.Text)
            {CheckboxSenha.Checked = true;} else {CheckboxSenha.Checked = false;}

            if (textSenha.Text == textConfSenha.Text && comboFuncao.SelectedIndex != -1)
            { 
                //CheckboxSenha.Checked = true;
                btnSalvar.Enabled = true;
            }
            else 
            { 
                //CheckboxSenha.Checked = false;
                btnSalvar.Enabled = false;
            }
        }

        private void textPesquisar_OnValueChanged_1(object sender, EventArgs e)
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
                    objTabela.Nome = textPesquisar.Text;
                    List<UsuarioEnt> lista = new List<UsuarioEnt>();
                    lista = new UsuarioModel().Buscar(objTabela);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = lista;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao Listar Dados: " + ex.Message);
                }
            }
        }
        private void textSenha_OnValueChanged_1(object sender, EventArgs e)
        {
            textSenha.isPassword = true;
        }
        private void comboFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection())
            {
                if (comboFuncao.Text == "")
                {
                    return;
                }

                if (comboFuncao.SelectedIndex != -1 && opc == "Editar")
                { btnSalvar.Enabled = true; } 

                if (textSenha.Text == textConfSenha.Text && comboFuncao.SelectedIndex != -1 && opc == "Salvar" )
                {btnSalvar.Enabled = true;}

                try
                {

                    con.ConnectionString = Settings.Default.dbpetsepetsConnectionString;
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM Funcao WHERE descricao = '" + comboFuncao.SelectedItem.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        id_funcao = Convert.ToInt32(dr["id"].ToString());
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error ao carregar Registro Funcao:  " + ex.Message);
                }
            }
        }

        private void textNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textEmail.Focus();
            }
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
                textConfSenha.Focus();
            }
        }

        private void textConfSenha_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                comboFuncao.Focus();
            }

        }

        private void comboFuncao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSalvar.Focus();
            }
        }
    }
}
