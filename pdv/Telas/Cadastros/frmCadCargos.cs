using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdv.Telas.Cadastros
{
    public partial class frmCadCargos : Form
    {

        Conexao con = new Conexao(); // aqui eu chamo a Classe Conexao
        string sql;
        MySqlCommand cmd;

        string id_Cargo;
        string nomeCargo;
        int id_Excluir = -1;
        int modoEdicao;


        public frmCadCargos()
        {
            InitializeComponent();
        }

        private void frmCadCargos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            FormatarGrid();
        }

        private void CarregarGrid()  // Montar o Grid no Sistema
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cargos ORDER BY id_cargo asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridCargos.DataSource = dt; // aqui chama a grid do form
            con.FecharConexao();

        }

        private void FormatarGrid()
        {
            gridCargos.Columns[0].HeaderText = "ID";
            gridCargos.Columns[1].HeaderText = "Cargo";
            
            gridCargos.Columns[0].Visible = false;
            //gridCargos.Columns[1].Width = 10;

            gridCargos.MultiSelect = false;

        }

        private void gridCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                nomeCargo = gridCargos.CurrentRow.Cells[1].Value.ToString();
                id_Excluir = (int)gridCargos.CurrentRow.Cells[0].Value;
                id_Cargo = gridCargos.CurrentRow.Cells[0].Value.ToString();  // aqui ta passando o id para depois ser usado em outros lugares                
                txtDescricaoCargos.Text = gridCargos.CurrentRow.Cells[1].Value.ToString();  // Aqui seleciona a row e exibi ela no txt                    
            }
            else
            {
                return;
            }
        }  

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (id_Excluir <= -1)
            {
                MessageBox.Show("É necessario Selecionar um Cargo Para a Exclusão !", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var resposta = MessageBox.Show("Deseja realmente excluir este Cargo ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "DELETE FROM cargos WHERE id_cargo = @id_cargo";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id_cargo", id_Cargo);

                    cmd.ExecuteNonQuery();
                    con.FecharConexao();
                    CarregarGrid();

                    MessageBox.Show("Cargo com Sucesso !", "Exclusão Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    txtDescricaoCargos.Text = "";
                    return;
                }
                txtDescricaoCargos.Clear();
            }

            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDescricaoCargos.Text = string.Empty;
            btnNovo.Enabled = true; btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
            gridCargos.Enabled = true; btnExcluir.Enabled = true;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            modoEdicao = 10;
            txtDescricaoCargos.Clear();
            btnNovo.Enabled=false; btnSalvar.Enabled=true; gridCargos.Enabled=false; btnEditar.Enabled=false; btnExcluir.Enabled=false; btnCancelar.Enabled=true;
            txtDescricaoCargos.Enabled=true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (modoEdicao == 10)
            {
                if (txtDescricaoCargos.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("É necessario Informar um Cargo !", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return;
                }

                con.AbrirConexao();

                sql = "INSERT INTO cargos(nome_cargo) VALUES((UPPER(@nome_cargo)))"; // esse UPPER é pra salvar em maiusculo
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@nome_cargo", txtDescricaoCargos.Text);


                if (txtDescricaoCargos.Text != nomeCargo)
                {
                    MySqlCommand cmdVerificar;
                    cmdVerificar = new MySqlCommand("SELECT * FROM cargos WHERE nome_cargo = @nome_cargo", con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmdVerificar;
                    cmdVerificar.Parameters.AddWithValue("@nome_cargo", txtDescricaoCargos.Text);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("O Cargo " + txtDescricaoCargos.Text + " já está Registrado !", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDescricaoCargos.Text = "";
                        txtDescricaoCargos.Focus();
                        return;
                    }
                }

                cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("O Cargo " + txtDescricaoCargos.Text + " Cadastrado com Sucesso !", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDescricaoCargos.Enabled = false;
                txtDescricaoCargos.Clear();
                gridCargos.Enabled = true; btnNovo.Enabled = true; btnEditar.Enabled = true; btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;

                CarregarGrid();
                modoEdicao = 0;
            }
            else if (modoEdicao == 20)
            {
                if (txtDescricaoCargos.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("É necessário informar um Cargo !", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescricaoCargos.Text = null; // aqui pra limpar o campo
                    txtDescricaoCargos.Focus(); // aqui para focar no campo
                    return; // é preciso colocar o return, para não avançar na programação
                }

                // Editar
                con.AbrirConexao();

                sql = "UPDATE cargos Set nome_cargo = @nome_cargo WHERE id_cargo = @id_Cargo";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id_cargo", id_Cargo);
                cmd.Parameters.AddWithValue("@nome_cargo", txtDescricaoCargos.Text);

                if (txtDescricaoCargos.Text != nomeCargo)
                {
                    MySqlCommand cmdVerificar;
                    cmdVerificar = new MySqlCommand("SELECT * FROM cargos WHERE nome_cargo = @nome_cargo", con.con);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmdVerificar;
                    cmdVerificar.Parameters.AddWithValue("@nome_cargo", txtDescricaoCargos.Text);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("O Cargo " + txtDescricaoCargos.Text + " já está Registrado !", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDescricaoCargos.Text = "";
                        txtDescricaoCargos.Focus();
                        return;
                    }
                }

                cmd.ExecuteNonQuery();
                con.FecharConexao();
                CarregarGrid();

                MessageBox.Show(txtDescricaoCargos.Text + " Editado com Sucesso !", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
              
                btnNovo.Enabled = true; btnEditar.Enabled = true; btnExcluir.Enabled = true; gridCargos.Enabled = true;
                btnSalvar.Enabled = false; txtDescricaoCargos.Enabled = false;
                txtDescricaoCargos.Clear();
                modoEdicao = 0;

            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (id_Excluir <= -1)
            {
                MessageBox.Show("É necessario Selecionar um Cargo Para a Editar !", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                modoEdicao = 20;
                txtDescricaoCargos.Enabled = true; btnCancelar.Enabled = true; btnSalvar.Enabled = true;
                btnEditar.Enabled = false; btnNovo.Enabled = false; btnExcluir.Enabled = false; gridCargos.Enabled = false;
            }
            

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            

        }

        private void frmCadCargos_KeyDown(object sender, KeyEventArgs e)
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
