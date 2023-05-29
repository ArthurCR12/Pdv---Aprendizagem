using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdv.Telas.Cadastros
{
    public partial class frmCadGrupos : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;

        string id_grupo;

        int modoSalvar = 0;
        int id_Excluir = -1;

        public frmCadGrupos()
        {
            InitializeComponent();
        }

        private void frmCadGrupos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormatarGrid();
        }

        private void CarregarGrid()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM tbl_grupo ORDER BY id_grupo asc";
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
            grid.Columns[1].HeaderText = "Descrição";

            grid.Columns[0].Visible = false;
        }
    
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_Excluir = (int)grid.CurrentRow.Cells[0].Value;
                id_grupo = grid.CurrentRow.Cells[0].Value.ToString();
                txtGrupo.Text = grid.CurrentRow.Cells[1].Value.ToString();
            }
            else { return; }
        }

        private void HabilitarCampos()
        {
            txtGrupo.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtGrupo.Enabled = false;
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
            txtGrupo.Clear();
        }
        private void SalvarInformacoes()
        {
            try
            {
                con.AbrirConexao();
                sql = "INSERT INTO tbl_grupo (grupo_descricao) VALUES (@grupo_descricao)";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@grupo_descricao", txtGrupo.Text);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                CarregarGrid();
                modoSalvar = 0;
                DesabilitarCampos();
                ModoNormal();

                MessageBox.Show("Grupo Cadastrado com Sucesso !", "Cadastro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (txtGrupo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("É necessario Informar um Grupo !", "Cadastro De Grupos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtGrupo.Focus(); return;
            }            
                       
        }
        private void AlterarInformacoes()
        {
            try
            {
                if (txtGrupo.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Não é possivel deixar a Descrição em Branco !");
                }
                con.AbrirConexao();
                sql = "UPDATE tbl_grupo SET grupo_descricao = @grupo_descricao WHERE id_grupo = @id_grupo";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id_grupo", id_grupo);
                cmd.Parameters.AddWithValue("@grupo_descricao", txtGrupo.Text);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                CarregarGrid();
                modoSalvar = 0;
                DesabilitarCampos();
                ModoNormal();
                MessageBox.Show("Grupo alterado com Sucesso!", "Cadastro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCadGrupos_KeyDown(object sender, KeyEventArgs e)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            LimparCampos();
            ModoNormal();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (id_Excluir <= -1)
            {
                MessageBox.Show("É necessario Selecionar um Grupo Para a Exclusão !", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var resposta = MessageBox.Show("Deseja Realmente Excluir esse Grupo ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resposta == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "DELETE FROM tbl_grupo WHERE id_grupo = @id_grupo";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id_grupo", id_grupo);
                    cmd.ExecuteNonQuery();
                    con.FecharConexao();
                    CarregarGrid();
                    MessageBox.Show("Grupo Excluido com Sucesso !", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    return;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id_Excluir <= -1)
            {
                MessageBox.Show("É necessario Selecionar um Grupo Para a Editar !", "Cadastro de Grupos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ModoEdicao();
                HabilitarCampos();
                modoSalvar = 20;
            }
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
                MessageBox.Show("ERRO !");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            modoSalvar = 10;
            HabilitarCampos();
            ModoEdicao();
            LimparCampos();
        }
    }
}
