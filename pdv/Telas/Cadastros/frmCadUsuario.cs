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
    public partial class frmCadUsuario : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;

        string id_User;
        int modo_Salvar = 0;
        int id_Excluir = -1;

        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormatarGrid();
        }

        private void CarregarGrid()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM user ORDER BY id_user ASC";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid.DataSource = dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormatarGrid()
        {
            grid.Columns[0].HeaderText = "";
            grid.Columns[1].HeaderText = "";
            grid.Columns[2].HeaderText = "";


            grid.Columns[0].Visible = false;
            grid.Columns[2].Visible = false;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_Excluir = (int)grid.CurrentRow.Cells[0].Value;
                id_User = grid.CurrentRow.Cells[0].Value.ToString();
                txtUser.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txtSenha.Text = grid.CurrentRow.Cells[2].Value.ToString();
                
            }
            else { return; }
        }

        private void HabilitarCampos()
        {
            panel1.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            panel1.Enabled = false;
        }

        private void ModoNormal()
        {
            btnNovo.Enabled = true; btnEditar.Enabled = true; btnExcluir.Enabled = true; grid.Enabled = true;
            btnSalvar.Enabled = false; btnCancelar.Enabled = false;
        }

        private void ModoEdicao()
        {
            btnNovo.Enabled = false; btnEditar.Enabled = false; btnExcluir.Enabled = false; grid.Enabled = false;
            btnSalvar.Enabled = true; btnCancelar.Enabled = true;
        }

        private void LimparCampos()
        {
            txtUser.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }

        private void SalvarInfo()
        {
            try
            {
                if (txtUser.Text.ToString().Trim() == "" || txtSenha.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("É necessario Informar os Campos !", "Cadastro De Usuários", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtUser.Focus();
                }
                con.AbrirConexao();
                sql = "INSERT INTO user (user_name, user_password) VALUES (@user_name, @user_password)";
                cmd = new MySqlCommand(sql,con.con);
                cmd.Parameters.AddWithValue("@user_name", txtUser.Text);
                cmd.Parameters.AddWithValue("@user_password", txtSenha.Text);
                cmd.ExecuteNonQuery();

                con.FecharConexao();

                CarregarGrid();
                modo_Salvar = 0;
                DesabilitarCampos();
                ModoNormal();

                MessageBox.Show(txtUser.Text + " Cadastrado com Sucesso !", "Cadastro de Usuários", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }   
        }

        private void AlterarInfo()
        {
            try
            {
                if (txtUser.Text.ToString().Trim() == "" || txtSenha.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("É necessario Informar os Campos !", "Cadastro De Usuários", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtUser.Focus();
                }

                con.AbrirConexao();
                sql = "UPDATE user SET user_name = @user_name, user_password = @user_password WHERE id_user = @id_User";
                cmd = new MySqlCommand (sql,con.con);
                cmd.Parameters.AddWithValue("id_User", id_User);
                cmd.Parameters.AddWithValue("user_name", txtUser.Text);
                cmd.Parameters.AddWithValue("user_password", txtSenha.Text);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                CarregarGrid();
                modo_Salvar = 0;
                DesabilitarCampos();
                ModoNormal();

                MessageBox.Show(txtUser.Text + " Alterado com Sucesso !", "Cadastro de Usuários", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);                
            }
        }        

        private void btnNovo_Click(object sender, EventArgs e)
        {
            modo_Salvar = 10; HabilitarCampos(); ModoEdicao();  LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (modo_Salvar == 10) { SalvarInfo(); } else if (modo_Salvar == 20) { AlterarInfo(); } else { MessageBox.Show("ERRO !"); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(id_Excluir <= -1) { MessageBox.Show("É necessario Selecionar um Usuário Para a Editar !", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else { ModoEdicao(); HabilitarCampos(); modo_Salvar = 20; }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (id_Excluir <= -1) { MessageBox.Show("É necessario Selecionar um Usuário para a Exclusão !", "Exclusão", MessageBoxButtons.OK); } 
            else
            {
                var resposta = MessageBox.Show("Deseja Realmente Excluir esse Usuário ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resposta != DialogResult.Yes) { return; }
                else
                {
                    con.AbrirConexao();
                    sql = "DELETE FROM user WHERE id_user = @id_User";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("id_user", id_User);
                    cmd.ExecuteNonQuery();
                    con.FecharConexao();

                    CarregarGrid();
                    MessageBox.Show("Usuário Excluido com Sucesso !", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            LimparCampos();
            ModoNormal();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var respota = MessageBox.Show("Deseja Realmente Sair ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respota != DialogResult.Yes) { return; } else { this.Close(); }
            }
        }

    }

}
