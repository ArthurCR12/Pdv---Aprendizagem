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

        int PCadPro = 1; int PCadCli = 1; int PCadForn = 1; int PCadFunc = 1; int PCadUser = 1; int PCadGrupo = 1; int PCadCargo = 1;
        int PAcCompra = 1;



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


            grid.Columns[0].Visible = false; grid.Columns[2].Visible = false; grid.Columns[3].Visible = false; grid.Columns[4].Visible = false; 
            grid.Columns[5].Visible = false; grid.Columns[6].Visible = false; grid.Columns[7].Visible = false; grid.Columns[8].Visible = false;
            grid.Columns[9].Visible = false; grid.Columns[10].Visible = false; 




        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_Excluir = (int)grid.CurrentRow.Cells[0].Value;
                id_User = grid.CurrentRow.Cells[0].Value.ToString();
                txtUser.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txtSenha.Text = grid.CurrentRow.Cells[2].Value.ToString();                
                
                if (grid.CurrentRow.Cells[3].Value.ToString() == "1") { checkBoxCadProd.Checked = true; PCadPro = 1; }
                else { checkBoxCadProd.Checked=false; PCadPro = 0; }

                if (grid.CurrentRow.Cells[4].Value.ToString() == "1") { checkBoxCadCli.Checked = true; PCadCli = 1; } 
                else { checkBoxCadCli.Checked=false; PCadCli = 0; }

                if (grid.CurrentRow.Cells[5].Value.ToString() == "1") { checkBoxCadForn.Checked = true; PCadForn = 1; }
                else { checkBoxCadForn.Checked=false; PCadForn = 0; }

                if (grid.CurrentRow.Cells[6].Value.ToString() == "1") { checkBoxCadFunc.Checked = true; PCadFunc = 1; }
                else { checkBoxCadFunc.Checked=false; PCadFunc = 0; }

                if (grid.CurrentRow.Cells[7].Value.ToString() == "1") { checkBoxCompra.Checked = true; PAcCompra = 1; }
                else { checkBoxCompra.Checked=false; PAcCompra = 0; }

                if (grid.CurrentRow.Cells[8].Value.ToString() == "1") { checkBoxCadUser.Checked = true; PCadUser = 1; }
                else { checkBoxCadUser.Checked =  false; PCadUser = 0; }

                if (grid.CurrentRow.Cells[9].Value.ToString() == "1") { checkBoxCadGrupo.Checked = true; PCadGrupo = 1; }
                else { checkBoxCadGrupo.Checked = false; PCadGrupo = 0; }

                if (grid.CurrentRow.Cells[10].Value.ToString() == "1") { checkBoxCadCargo.Checked = true; PCadCargo = 1; }
                else { checkBoxCadCargo.Checked = false; PCadCargo = 0; }

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
                sql = "INSERT INTO user (user_name, user_password, user_pcadprod, user_pcadcli, user_pcadforn, user_pcadfunc, user_pcompra) " +
                    "VALUES (@user_name, @user_password, @user_pcadprod, @user_pcadcli, @user_pcadforn, @user_pcadfunc, @user_pcompra)";
                cmd = new MySqlCommand(sql,con.con);
                cmd.Parameters.AddWithValue("@user_name", txtUser.Text);
                cmd.Parameters.AddWithValue("@user_password", txtSenha.Text);
                cmd.Parameters.AddWithValue("@user_pcadprod", PCadPro);
                cmd.Parameters.AddWithValue("@user_pcadcli", PCadCli);
                cmd.Parameters.AddWithValue("@user_pcadforn", PCadForn);
                cmd.Parameters.AddWithValue("@user_pcadfunc", PCadFunc);
                cmd.Parameters.AddWithValue("@user_pcompra", PAcCompra);
                cmd.Parameters.AddWithValue("@user_caduser", PCadUser);
                cmd.Parameters.AddWithValue("@user_cadgrupo", PCadGrupo);
                cmd.Parameters.AddWithValue("@user_cadcargo", PCadCargo);
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
                MessageBox.Show(ex.ToString());
                return;
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
                PermissoesCheck();


                con.AbrirConexao();
                sql = "UPDATE user SET user_name = @user_name, user_password = @user_password, user_pcadprod = @user_pcadprod, user_pcadcli = @user_pcadprod" +
                    ", user_pcadforn = @user_pcadforn, user_pcadfunc = @user_pcadfunc,user_pcompra = @user_pcompra, user_pcaduser = @user_pcaduser," +
                    "user_pcadgrupo = @user_pcadgrupo, user_pcadcargo = @user_pcadcargo WHERE id_user = @id_User";
                cmd = new MySqlCommand (sql,con.con);
                cmd.Parameters.AddWithValue("@id_User", id_User);
                cmd.Parameters.AddWithValue("@user_name", txtUser.Text);
                cmd.Parameters.AddWithValue("@user_password", txtSenha.Text);
                cmd.Parameters.AddWithValue("@user_pcadprod", PCadPro);
                cmd.Parameters.AddWithValue("@user_pcadcli", PCadCli);
                cmd.Parameters.AddWithValue("@user_pcadforn",PCadForn);
                cmd.Parameters.AddWithValue("@user_pcadfunc", PCadFunc);
                cmd.Parameters.AddWithValue("@user_pcompra", PAcCompra);
                cmd.Parameters.AddWithValue("@user_pcaduser", PCadUser);
                cmd.Parameters.AddWithValue("@user_pcadgrupo", PCadGrupo);
                cmd.Parameters.AddWithValue("@user_pcadcargo", PCadCargo);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                CarregarGrid();
                FormatarGrid();
                modo_Salvar = 0;
                DesabilitarCampos();
                ModoNormal();

                MessageBox.Show(txtUser.Text + " Alterado com Sucesso !", "Cadastro de Usuários", MessageBoxButtons.OK);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());                
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
            if (txtUser.Text.ToString().Trim() == "ADMIN")
            {
                MessageBox.Show("NÃO É POSSIVEL ALTERAR O USUÁRIO ADMIN!");
                return;
            }
            if (id_Excluir <= -1) { MessageBox.Show("É necessario Selecionar um Usuário Para a Editar !", "Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
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

        #region CheckBox
        private void PermissoesCheck()
        {
            if (checkBoxCadProd.Checked){ PCadPro = 1; }else { PCadPro = 0; }
            if (checkBoxCadCli.Checked) { PCadCli = 1; } else { PCadCli = 0; }
            if(checkBoxCadForn.Checked) { PCadForn = 1; } else { PCadForn = 0; }
            if(checkBoxCadFunc.Checked) { PCadFunc = 1; } else { PCadFunc = 0; }
            if(checkBoxCompra.Checked) { PAcCompra = 1; } else {  PAcCompra = 0; }
            if (checkBoxCadUser.Checked) { PCadUser = 1; } else { PCadUser = 0; }
            if(checkBoxCadGrupo.Checked) { PCadGrupo = 1; } else { PCadGrupo=0; }
            if(checkBoxCadCargo.Checked) { PCadCargo = 1; } else { PCadCargo = 0; }

        }
        #endregion CheckBox



    }

}
