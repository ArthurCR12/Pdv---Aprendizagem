using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdv.Telas.Cadastros
{
    public partial class frmCadClientes : Form
    {

        Conexao con = new Conexao(); // aqui eu chamo a Classe Conexao
        string sql;
        MySqlCommand cmd;

        int modoSalvar = 0;
        int cli_FJ = 0;
        int cli_status;
        int id_excluir = -1;
        string cpfcnpj;
        string id_cli;
        
        


        public frmCadClientes()
        {
            InitializeComponent();
        }

        private void frmCadClientes_Load(object sender, EventArgs e)
        {
            CarregarInadiplente();
            CarregarGrid();
            FormatarGrid();
        }

        private void CarregarGrid()  // Montar o Grid no Sistema
        {
            con.AbrirConexao();
            sql = "SELECT * FROM clientes ORDER BY id_cli asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt; // aqui chama a grid do form
            con.FecharConexao();

        }

        private void FormatarGrid()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "Valor em Aberto";
            grid.Columns[3].HeaderText = "Telefone";
            grid.Columns[5].HeaderText = "Indiplente";
            grid.Columns[6].HeaderText = "Endereço";
            grid.Columns[12].HeaderText = "Limite de Credito";

            grid.Columns[0].Visible = true;
            grid.Columns[4].Visible = false;
            grid.Columns[7].Visible = false;
            grid.Columns[8].Visible = false;
            grid.Columns[9].Visible = false;
            grid.Columns[10].Visible = false;
            grid.Columns[11].Visible = false;
            grid.Columns[12].Visible = true;
            grid.Columns[13].Visible = false;
            grid.Columns[14].Visible = false;
            grid.Columns[15].Visible = false;
            grid.Columns[16].Visible = false;

            grid.Columns[0].Width = 30;
            grid.Columns[1].Width = 150;
            grid.Columns[2].Width = 70;
            grid.Columns[3].Width = 90;
            grid.Columns[5].Width = 90;
            grid.Columns[6].Width = 170;

            grid.MultiSelect = false;


           

        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                LimparCampos();

                id_excluir = (int)grid.CurrentRow.Cells[0].Value;
                id_cli = grid.CurrentRow.Cells[0].Value.ToString();  // aqui ta passando o id para depois ser usado em outros lugares                                
                lbvalorAberto.Visible = true;
                lbvalorAberto.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();  // Aqui seleciona a row e exibi ela no txt
                txtTel.Text = grid.CurrentRow.Cells[3].Value.ToString();
                txtNasc.Text = grid.CurrentRow.Cells[4].Value.ToString();
                comboInadiplente.Text = grid.CurrentRow.Cells[5].Value.ToString();
                txtRua.Text = grid.CurrentRow.Cells[6].Value.ToString();
                txtBairro.Text = grid.CurrentRow.Cells[7].Value.ToString();
                txtNum.Text = grid.CurrentRow.Cells[8].Value.ToString();
                txtMunicipio.Text = grid.CurrentRow.Cells[9].Value.ToString();
                txtUF.Text = grid.CurrentRow.Cells[10].Value.ToString();
                txtCep.Text = grid.CurrentRow.Cells[11].Value.ToString();
                txtLimiteCredito.Text = grid.CurrentRow.Cells[12].Value.ToString();
                if (grid.CurrentRow.Cells[13].Value.ToString() == "1")
                {
                    rbtnFisica.Checked = true;
                    cli_FJ = 1;
                }
                else if (grid.CurrentRow.Cells[13].Value.ToString() == "2")
                {
                    rbtnJurudica.Checked = true;
                    cli_FJ = 2;
                }
                if (grid.CurrentRow.Cells[14].Value.ToString().Length > 14)
                {
                    txtCnpj.Text = grid.CurrentRow.Cells[14].Value.ToString();
                }
                else
                {
                    txtCPF.Text = grid.CurrentRow.Cells[14].Value.ToString();
                }
                if (grid.CurrentRow.Cells[15].Value.ToString() == "1")
                {
                    rbtnDesbloquado.Checked = true;
                    cli_status = 1;
                }
                else if (grid.CurrentRow.Cells[15].Value.ToString() == "2")
                {
                    rbtnBloqueado.Checked = true;
                    cli_status = 2;
                }
                txtEmail.Text = grid.CurrentRow.Cells[16].Value.ToString();

                

            }
            else
            {
                return;
            }
        }

        private void CarregarInadiplente()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM util ORDER BY inadiplente ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboInadiplente.DataSource = dt;
            comboInadiplente.DisplayMember = "inadiplente"; // aqui carrega ele pela a tabela estabelecida no bd
            con.FecharConexao();
        }

        private void LimparCampos()
        {
            txtNome.Clear(); txtTel.Clear(); txtNasc.Clear(); txtRua.Clear(); txtBairro.Clear();
            txtNum.Clear(); txtMunicipio.Clear(); txtUF.Clear(); txtCep.Clear(); txtLimiteCredito.Clear(); txtCPF.Clear(); txtCnpj.Clear();
            txtEmail.Clear(); rbtnFisica.Checked = true; rbtnDesbloquado.Checked = true;
            txtCnpj.SendToBack();
        }

        private void ModoEdicao()
        {
            btnNovo.Enabled = false; btnEditar.Enabled = false; btnExcluir.Enabled = false; txtPesquisar.Enabled = false; btnPesquisar.Enabled = false; grid.Enabled = false;
            btnSalvar.Enabled = true; btnCancelar.Enabled = true; btnFechar.Enabled = true;                   
        }

        private void ModoNormal()
        {
            btnNovo.Enabled = true; btnEditar.Enabled = true; btnExcluir.Enabled = true; grid.Enabled = true; txtPesquisar.Enabled = true; btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false; btnCancelar.Enabled=false;
        }

        private void HabilitarCampos()
        {
            painel.Enabled = true;           
        }

        private void DesabilitarCampos()
        {
            painel.Enabled = false;
        }

        private void BuscarNome()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM clientes WHERE cli_nome LIKE @cli_nome ORDER BY cli_nome asc"; // LIKE, busca por nome parecido
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cli_nome", txtPesquisar.Text + "%"); // "%" - operador LIKE, busca nome parecido
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
        }

        private void RadioButtons()
        {
            // radioButtons
            if (rbtnFisica.Checked)
            {
                cli_FJ = 1;               
            }
            else if (rbtnJurudica.Checked)
            {
                cli_FJ = 2;
            }
            if (rbtnBloqueado.Checked)
            {
                cli_status = 2;

            }
            else if (rbtnDesbloquado.Checked)
            {
                cli_status = 1;
            }

        }

        private void SalvarInformacoes()
        {

            // Tratando Campos
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("É necessario Informar um Nome !", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtNome.Focus();
                return;
            }

            // Radio Buttons
            RadioButtons();
            // ---

            // Tratando CPF CNPJ
            // Tratando As Mascaras
            if (txtCPF.Enabled)
            {
                cpfcnpj = txtCPF.Text; 
                string mCpf = txtCPF.Text;
                string smCpf = mCpf.Replace(" ", "").Replace(".", "").Replace("-", "").Replace(",", "");
                cpfcnpj = smCpf;
            }
            else
            {
                cpfcnpj = txtCnpj.Text;
                string mCnpj = txtCnpj.Text;
                string smCnpj = mCnpj.Replace(" ", "").Replace(",", "").Replace(".", "").Replace("-", "").Replace("/", "");
                cpfcnpj = smCnpj;
            }

            
           
            string mTel = txtTel.Text;
            string smTel = mTel.Replace(" ", "").Replace(")", "").Replace("(", "").Replace("-", "");

            string mNasc = txtNasc.Text;
            string smNasc = mNasc.Replace(" ", "").Replace("/", "");

            string mCep = txtCep.Text;
            string smCep = mCep.Replace("-", "").Replace(" ", "");

            // ----

            con.AbrirConexao();

            sql = "INSERT INTO clientes(cli_nome, cli_tel, cli_nasc, cli_inadiplente, cli_rua, cli_bairro," +
                " cli_num, cli_municipio, cli_uf, cli_cep, cli_limitecredito, cli_fisicajuridica, cli_cpfcnpj, cli_status," +
                " cli_email) VALUES(@cli_nome, @cli_tel, @cli_nasc, @cli_inadiplente, @cli_rua, @cli_bairro, @cli_num," +
                " @cli_municipio, @cli_uf, @cli_cep, @cli_limitecredito, @cli_fisicajuridica, @cli_cpfcnpj, @cli_status, @cli_email)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@cli_nome", txtNome.Text);           
            cmd.Parameters.AddWithValue("@cli_tel", smTel);
            cmd.Parameters.AddWithValue("@cli_nasc", smNasc);
            cmd.Parameters.AddWithValue("@cli_inadiplente", comboInadiplente.Text);
            cmd.Parameters.AddWithValue("@cli_rua", txtRua.Text);
            cmd.Parameters.AddWithValue("@cli_bairro", txtBairro.Text);
            
            // esse try serve pra definir um valor padrao ja que ele ele converte mas se o txt estiver vazio ele da erro
            try
            {
                int cliNum;
                if (int.TryParse(txtNum.Text, out cliNum)) // Verifica se o valor em txtNum.Text pode ser convertido para um int
                {
                    
                    cmd.Parameters.AddWithValue("@cli_num", cliNum); // Adiciona o valor do parâmetro ao SqlCommand
                                                                     // Resto do código para executar o SqlCommand
                }
                else
                {
                    // Tratar o caso em que o valor em txtNum.Text não é um número válido
                    // Caso o valor em txtNum.Text não seja um número válido, atribuir um valor padrão
                    int valorPadrao = 0; // Defina o valor padrão desejado
                    
                    cmd.Parameters.AddWithValue("@cli_num", valorPadrao);
                    // Resto do código para executar o SqlCommand
                }
            
            }
            catch (Exception ex)
            {
                // Tratar exceções geradas durante a execução do SqlCommand ou conversão de valor
                MessageBox.Show(ex.Message);
            }
            
            cmd.Parameters.AddWithValue("@cli_municipio", txtMunicipio.Text);
            cmd.Parameters.AddWithValue("@cli_uf", txtUF.Text);
            cmd.Parameters.AddWithValue("@cli_cep", smCep);
            try
            {
                decimal cliLimite;
                if (decimal.TryParse(txtNum.Text, out cliLimite)) // Verifica se o valor em txtNum.Text pode ser convertido para um int
                {

                    cmd.Parameters.AddWithValue("@cli_limitecredito", cliLimite); // Adiciona o valor do parâmetro ao SqlCommand
                                                                     // Resto do código para executar o SqlCommand
                }
                else
                {
                    // Tratar o caso em que o valor em txtNum.Text não é um número válido
                    // Caso o valor em txtNum.Text não seja um número válido, atribuir um valor padrão
                    decimal valorPadrao = 100; // Defina o valor padrão desejado

                    cmd.Parameters.AddWithValue("@cli_limitecredito", valorPadrao);
                    // Resto do código para executar o SqlCommand
                }

            }
            catch (Exception ex)
            {
                // Tratar exceções geradas durante a execução do SqlCommand ou conversão de valor
                MessageBox.Show(ex.Message);
            }
            cmd.Parameters.AddWithValue("@cli_fisicajuridica", cli_FJ);
            cmd.Parameters.AddWithValue("@cli_cpfcnpj", cpfcnpj);
            cmd.Parameters.AddWithValue("@cli_status", cli_status);
            cmd.Parameters.AddWithValue("@cli_email", txtEmail.Text);
            


            cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("O Cliente " + txtNome.Text + " Cadastrado com Sucesso !", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            CarregarGrid();
            cli_status = 0;
            cli_FJ = 0;
            modoSalvar = 0;
            DesabilitarCampos();
            ModoNormal();
        }

        private void AlterarInformacoes()
        {

            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("É necessário informar um Nome !", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = null; // aqui pra limpar o campo
                txtNome.Focus(); // aqui para focar no campo
                return; // é preciso colocar o return, para não avançar na programação
            }

            // Radio Buttons
            RadioButtons();

            // Tratando CPF CNPJ
            // Tratando As Mascaras
            if (txtCPF.Enabled)
            {               
                string mCpf = txtCPF.Text;
                string smCpf = mCpf.Replace(" ", "").Replace(".", "").Replace("-", "").Replace(",", "");
                cpfcnpj = smCpf;
            }
            if (txtCnpj.Enabled)
            {              
                string mCnpj = txtCnpj.Text;
                string smCnpj = mCnpj.Replace(" ", "").Replace(",", "").Replace(".", "").Replace("-", "").Replace("/", "");
                cpfcnpj = smCnpj;
            }



            string mTel = txtTel.Text;
            string smTel = mTel.Replace(" ", "").Replace(")", "").Replace("(", "").Replace("-", "");

            string mNasc = txtNasc.Text;
            string smNasc = mNasc.Replace(" ", "").Replace("/", "");

            string mCep = txtCep.Text;
            string smCep = mCep.Replace("-", "").Replace(" ", "");

            // ----
          
            con.AbrirConexao();

                sql = "UPDATE clientes SET cli_nome = @cli_nome, cli_tel = @cli_tel, cli_nasc = @cli_nasc, cli_inadiplente = @cli_inadiplente, cli_rua = @cli_rua" +
                ", cli_bairro = @cli_bairro, cli_num = @cli_num, cli_municipio = @cli_municipio, cli_uf = @cli_uf, cli_cep = @cli_cep, cli_limitecredito = @cli_limitecredito" +
                ", cli_fisicajuridica = @cli_fisicajuridica, cli_cpfcnpj = @cli_cpfcnpj, cli_status = @cli_status, cli_email = @cli_email WHERE id_cli = @id_cli";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id_cli", id_cli);
            cmd.Parameters.AddWithValue("@cli_nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@cli_tel", smTel);
            cmd.Parameters.AddWithValue("@cli_nasc", smNasc);
            cmd.Parameters.AddWithValue("@cli_inadiplente", comboInadiplente.Text);
            cmd.Parameters.AddWithValue("@cli_rua", txtRua.Text);
            cmd.Parameters.AddWithValue("@cli_bairro", txtBairro.Text);

            // esse try serve pra definir um valor padrao ja que ele ele converte mas se o txt estiver vazio ele da erro
            try
            {
                int cliNum;
                if (int.TryParse(txtNum.Text, out cliNum)) // Verifica se o valor em txtNum.Text pode ser convertido para um int
                {

                    cmd.Parameters.AddWithValue("@cli_num", cliNum); // Adiciona o valor do parâmetro ao SqlCommand
                                                                     // Resto do código para executar o SqlCommand
                }
                else
                {
                    // Tratar o caso em que o valor em txtNum.Text não é um número válido
                    // Caso o valor em txtNum.Text não seja um número válido, atribuir um valor padrão
                    int valorPadraoNum = 0; // Defina o valor padrão desejado

                    cmd.Parameters.AddWithValue("@cli_num", valorPadraoNum);
                    // Resto do código para executar o SqlCommand
                }

            }
            catch (Exception ex)
            {
                // Tratar exceções geradas durante a execução do SqlCommand ou conversão de valor
                MessageBox.Show(ex.Message);
            }

            cmd.Parameters.AddWithValue("@cli_municipio", txtMunicipio.Text);
            cmd.Parameters.AddWithValue("@cli_uf", txtUF.Text);
            cmd.Parameters.AddWithValue("@cli_cep", smCep);
            try
            {
                decimal cliLimite;
                if (decimal.TryParse(txtLimiteCredito.Text, out cliLimite)) // Verifica se o valor em txtNum.Text pode ser convertido para um int
                {

                    cmd.Parameters.AddWithValue("@cli_limitecredito", cliLimite); // Adiciona o valor do parâmetro ao SqlCommand
                                                                                  // Resto do código para executar o SqlCommand
                }
                else
                {
                    // Tratar o caso em que o valor em txtNum.Text não é um número válido
                    // Caso o valor em txtNum.Text não seja um número válido, atribuir um valor padrão
                    decimal valorPadraoLimite = 100; // Defina o valor padrão desejado

                    cmd.Parameters.AddWithValue("@cli_limitecredito", valorPadraoLimite);
                    // Resto do código para executar o SqlCommand
                }

            }
            catch (Exception ex)
            {
                // Tratar exceções geradas durante a execução do SqlCommand ou conversão de valor
                MessageBox.Show(ex.Message);
            }
            cmd.Parameters.AddWithValue("@cli_fisicajuridica", cli_FJ);
            cmd.Parameters.AddWithValue("@cli_cpfcnpj", cpfcnpj);
            cmd.Parameters.AddWithValue("@cli_status", cli_status);
            cmd.Parameters.AddWithValue("@cli_email", txtEmail.Text);




            cmd.ExecuteNonQuery();
            con.FecharConexao();         

        
            CarregarGrid();
            cli_status = 0;
            cli_FJ = 0;
            modoSalvar = 0;
            DesabilitarCampos();
            ModoNormal();

            MessageBox.Show(txtNome.Text + " Editado com Sucesso !", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void rbtnFisica_CheckedChanged(object sender, EventArgs e)
        {
            txtCPF.BringToFront();
            txtCPF.Enabled = true;
            txtCnpj.Enabled = false;
            txtCnpj.Clear();
        }

        private void rbtnJurudica_CheckedChanged(object sender, EventArgs e)
        {
            txtCnpj.BringToFront();
            txtCnpj.Enabled = true; 
            txtCPF.Enabled = false;
            txtCPF.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            modoSalvar = 10;
            HabilitarCampos();
            ModoEdicao();
            LimparCampos();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (modoSalvar == 10)
            {
                SalvarInformacoes();
            }
            else if (modoSalvar == 20)
            {
                AlterarInformacoes();   
            }
            else
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id_excluir <= -1)
            {
                MessageBox.Show("É necessario Selecionar um Cliente Para a Editar !", "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                modoSalvar = 20;
                HabilitarCampos();
                ModoEdicao();
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            ModoNormal();
            LimparCampos();
            
        }

        private void lbvalorAberto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            if (id_excluir <= -1)
            {
                MessageBox.Show("É necessario selecionar um Cliente Para a Exclusão !", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var resposta = MessageBox.Show("Deseja realmente excluir este Cliente ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "DELETE FROM clientes WHERE id_cli = @id_cli";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id_cli", id_cli);

                    cmd.ExecuteNonQuery();
                    con.FecharConexao();
                    CarregarGrid();

                    MessageBox.Show("Cliente Excluido com Sucesso !", "Exclusão Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {                   
                    return;
                }
                
                
            }
        }

        private void frmCadClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var resposta = MessageBox.Show("Deseja Realmente Sair ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resposta == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    return;
                }

            }
        }
    } 
}   
