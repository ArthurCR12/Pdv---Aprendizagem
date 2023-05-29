using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdv.Telas.Cadastros
{
    public partial class frmCadForn : Form
    {

        Conexao con = new Conexao(); // aqui eu chamo a Classe Conexao
        string sql;
        MySqlCommand cmd;

        int id_Excluir = -1;
        int modoSalvar = 0;
        string id_forn;


        public frmCadForn()
        {
            InitializeComponent();
        }

        private void frmCadForn_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormatarGrid();
        }

        private void CarregarGrid()  // Montar o Grid no Sistema
        {
            con.AbrirConexao();
            sql = "SELECT * FROM fornecedores ORDER BY id_forn asc";
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
            grid.Columns[1].HeaderText = "Fantasia";
            grid.Columns[2].HeaderText = "Razão";
            grid.Columns[3].HeaderText = "Telefone";
            grid.Columns[4].HeaderText = "E-Mail";

            grid.Columns[0].Width = 30;

            grid.MultiSelect = false;
            
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                LimparCampos();

                id_Excluir = (int)grid.CurrentRow.Cells[0].Value;
                id_forn = grid.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txtRazao.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txtTel.Text = grid.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = grid.CurrentRow.Cells[4].Value.ToString();

            }
            else
            {
                return;
            }


        }

        private void LimparCampos()
        {
            txtNome.Clear(); txtRazao.Clear(); txtTel.Clear(); txtEmail.Clear();
        }

        private void ModoEdicao()
        {
            btnNovo.Enabled = false; btnEditar.Enabled = false; btnExcluir.Enabled = false; txtPesquisar.Enabled = false; btnPesquisar.Enabled = false; grid.Enabled = false;
            btnSalvar.Enabled = true; btnCancelar.Enabled = true; btnFechar.Enabled = true;
        }

        private void ModoNormal()
        {
            btnNovo.Enabled = true; btnEditar.Enabled = true; btnExcluir.Enabled = true; grid.Enabled = true; txtPesquisar.Enabled = true; btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false; btnCancelar.Enabled = false;
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
            sql = "SELECT * FROM fornecedor WHERE nomef LIKE @nomef ORDER BY nomef asc"; // LIKE, busca por nome parecido
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nomef", txtPesquisar.Text + "%"); // "%" - operador LIKE, busca nome parecido
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();
        }

        private void SalvarInformacoes()
        {
            modoSalvar = 10;

            // Tratando Campos
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("É necessario Informar um Nome Fantasia", "Cadastro de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtNome.Focus();
                return;
            }

            // Tratando Maks
            string mTel = txtTel.Text;
            string smTel = mTel.Replace(" ", "").Replace(")", "").Replace("(", "").Replace("-", "");


            con.AbrirConexao();
            sql = "INSERT INTO fornecedores(forn_nomef, forn_nomer, forn_tel, forn_email) VALUES(@forn_nomef, @forn_nomer, @forn_tel, @forn_email)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@forn_nomef", txtNome.Text);
            cmd.Parameters.AddWithValue("@forn_nomer", txtRazao.Text);
            cmd.Parameters.AddWithValue("@forn_tel", smTel);
            cmd.Parameters.AddWithValue("@forn_email", txtEmail.Text);

            cmd.ExecuteNonQuery();
            con.FecharConexao();           

            CarregarGrid();

            MessageBox.Show("Cadastro Realizado com Sucesso !", "Cadastro de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            LimparCampos();
            ModoNormal();

        }

        private void AlterarInformacoes()
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("É necessário informar um Nome !", "Cadastro de Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = null; // aqui pra limpar o campo
                txtNome.Focus(); // aqui para focar no campo
                return; // é preciso colocar o return, para não avançar na programação
            }

            // tratando Masks
            string mTel = txtTel.Text;
            string smTel = mTel.Replace(" ", "").Replace(")", "").Replace("(", "").Replace("-", "");

            con.AbrirConexao();

            sql = "UPDATE fornecedores SET forn_nomef = @forn_nomef, forn_nomer = @forn_nomer, forn_tel = @forn_tel, forn_email = @forn_email WHERE id_forn = @id_forn";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id_forn", id_forn);
            cmd.Parameters.AddWithValue("@forn_nomef", txtNome.Text);
            cmd.Parameters.AddWithValue("@forn_nomer", txtRazao.Text);
            cmd.Parameters.AddWithValue("@forn_tel", smTel);
            cmd.Parameters.AddWithValue("@forn_email", txtEmail.Text);

            cmd.ExecuteNonQuery();
            con.FecharConexao();


            CarregarGrid();
            DesabilitarCampos();
            ModoNormal();
            modoSalvar = 0;
            
            MessageBox.Show("Cadastro Alterado com Sucesso !", "Cadastro de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                MessageBox.Show("Erro!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id_Excluir <= -1)
            {
                MessageBox.Show("É necessario Selecionar um Fornecedor Para a Editar !", "Cadastro de Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                modoSalvar = 20;
                HabilitarCampos();
                ModoEdicao();
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (id_Excluir <= -1)
            {
                MessageBox.Show("É nessario selecionar um Fornecedor para à Exclusão", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var resposta = MessageBox.Show("Deseja realmente excluir este Fornecedor ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "DELETE FROM fornecedores WHERE id_forn = @id_forn";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id_forn", id_forn);

                    cmd.ExecuteNonQuery();
                    con.FecharConexao();
                    CarregarGrid();

                    MessageBox.Show("Fornecedor Excluido com Sucesso !", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                }
                else
                {
                    return;
                }

                CarregarGrid();

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            ModoNormal();
            LimparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void frmCadForn_KeyDown(object sender, KeyEventArgs e)
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
