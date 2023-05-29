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
    public partial class frmCadProd : Form
    {

        Conexao con = new Conexao(); // aqui eu chamo a Classe Conexao
        string sql;
        MySqlCommand cmd;
        
        int modoSalvar = 0;
        int id_Excluir = -1;

        string id_prod;

        public frmCadProd()
        {
            InitializeComponent();
        }

        private void frmCadProd_Load(object sender, EventArgs e)
        {                    
            CarregarGrid();
            CarregarGridForn();
            FormatarGrid();
            FormatarGridForn();
            CarregarGrupos();
            
        }

        private void CarregarGrupos()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM tbl_grupo ORDER BY id_grupo ASC";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboGrupos.DataSource = dt;
                comboGrupos.DisplayMember = "grupo_descricao";
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            } 
        }

        private void CarregarGridForn()
        {
            try 
            {
                con.AbrirConexao();
                sql = "SELECT * FROM fornecedores ORDER BY id_forn asc";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridforn.DataSource = dt;
                con.FecharConexao();
            } 
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarGrid()
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM produtos ORDER BY id_prod asc";
                cmd = new MySqlCommand(sql, con.con);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                grid.DataSource = dt;
                con.FecharConexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);              
            }   
        }

        private void MostraForn(string forn)  // Aqui carrega a grid em baixo para mostrar o fornecedor
        {
            try
            {
                con.AbrirConexao();
                sql = "SELECT * FROM fornecedores WHERE forn_nomef LIKE @forn_nomef";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@forn_nomef", forn + "%");
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                gridforn.DataSource = dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }     

        private void FormatarGrid()
        {
            grid.Columns[0].HeaderText = "ID";
            grid.Columns[1].HeaderText = "Descrição";
            grid.Columns[2].HeaderText = "UN";
            grid.Columns[5].HeaderText = "Estoque";
            grid.Columns[6].HeaderText = "Custo";
            grid.Columns[7].HeaderText = "Venda";
            grid.Columns[8].HeaderText = "Fornecedor";

            grid.Columns[0].Visible = true;
            grid.Columns[1].Visible = true;
            grid.Columns[2].Visible = true;
            grid.Columns[3].Visible = false;
            grid.Columns[4].Visible = false;
            grid.Columns[5].Visible = true;
            grid.Columns[6].Visible = true;
            grid.Columns[7].Visible = true;
            grid.Columns[9].Visible = false;

            grid.Columns[0].Width = 20;
            grid.Columns[1].Width = 120;
            grid.Columns[2].Width = 40;
            grid.Columns[5].Width = 60;
            grid.Columns[6].Width = 70;
            grid.Columns[7].Width = 70;
            grid.Columns[8].Width = 150;

            grid.MultiSelect = false;
        }

        private void FormatarGridForn()
        {
            gridforn.Columns[0].HeaderText = "";
            gridforn.Columns[1].HeaderText = "";

            gridforn.Columns[2].Visible = false;
            gridforn.Columns[3].Visible = false;
            gridforn.Columns[4].Visible = false;

            gridforn.Columns[0].Width = 30;

            
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_Excluir = (int)grid.CurrentRow.Cells[0].Value;
                id_prod = grid.CurrentRow.Cells[0].Value.ToString();
                txtDescricao.Text = grid.CurrentRow.Cells[1].Value.ToString();
                txtUnidade.Text = grid.CurrentRow.Cells[2].Value.ToString();
                txtCodBarras.Text = grid.CurrentRow.Cells[3].Value.ToString();
                comboGrupos.Text = grid.CurrentRow.Cells[4].Value.ToString();     //TODO          
                txtPrecoCompra.Text = grid.CurrentRow.Cells[6].Value.ToString();
                txtPrecoVenda.Text = grid.CurrentRow.Cells[7].Value.ToString();
                txtForncedor.Text = grid.CurrentRow.Cells[8].Value.ToString();
                txtNCM.Text = grid.CurrentRow.Cells[9].Value.ToString();
            }
            else
            {
                return;
            }

        }

        private void gridforn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {               
                txtForncedor.Text = gridforn.CurrentRow.Cells[1].Value.ToString();
                gridforn.Visible = false;
                gridforn.Enabled = false;
            }
            else
            {
                MessageBox.Show(e.ToString());
                return;
            }
        }       

        private void LimparCampos()
        {
            txtDescricao.Clear(); txtUnidade.Clear(); txtNCM.Clear(); txtMostraNcm.Clear(); lblMostraNcm.Text = "--"; comboGrupos.Text = "";
            txtCodBarras.Clear(); txtPrecoCompra.Clear(); txtPrecoVenda.Clear(); txtForncedor.Clear();
        }

        private void ModoEdicao()
        {
            btnNovo.Enabled = false; btnEditar.Enabled = false; btnExcluir.Enabled = false; txtPesquisar.Enabled = false; btnPesquisar.Enabled = false; grid.Enabled = false;
            btnSalvar.Enabled = true; btnCancelar.Enabled = true; btnFechar.Enabled = true;
            gridforn.Visible = true;
        }

        private void ModoNormal()
        {
            btnNovo.Enabled = true; btnEditar.Enabled = true; btnExcluir.Enabled = true; grid.Enabled = true; txtPesquisar.Enabled = true; btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false; btnCancelar.Enabled = false;
            gridforn.Visible = false;
        }

        private void HabilitarCampos()
        {
            painel.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            painel.Enabled = false;
        }

        private void BuscarProd()
        {
            //TODO BuscarProd
            con.AbrirConexao();
            sql = "SELECT * FROM produtos WHERE prod_descricao LIKE @prod_descricao ORDER BY prod_descricao asc";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@prod_descricao", txtPesquisar.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
            con.FecharConexao();

        }

        private static void Moeda(ref TextBox txt)
        {
            string n = string.Empty; // peguei na net
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                {
                    n = "";
                }
                n.PadLeft(3,'0');
                if (n.Length > 3 & n.Substring(0,1) == "0")
                {
                    n = n.Substring(1,n.Length - 1);
                }
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
                    
               

            }
            catch (Exception)
            {
               
            }
        }

        private void SalvarInformacoes()
        {
            if (txtDescricao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("É necessario informar uma Descrição para o Produto!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtDescricao.Focus(); return;
            }
            if (txtUnidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("É necessario informar um Tipo de Unidade para o Produto!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtUnidade.Focus(); return;
            }
            if (comboGrupos.SelectedIndex == 0)
            {
                MessageBox.Show("É necessario informar um Grupo para o Produto!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                comboGrupos.Focus(); return;
            }
            if (txtPrecoCompra.Text.ToString().Trim() == "")
            {
                MessageBox.Show("É necessario informar um Preço de Custo para o Produto!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPrecoCompra.Focus(); return;
            }
            if (txtPrecoVenda.Text.ToString().Trim() == "")
            {
                MessageBox.Show("É necessario informar um Preço de Venda para o Produto!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtPrecoVenda.Focus(); return;
            }
            if (txtNCM.Text.ToString().Trim() == "")
            {
                MessageBox.Show("É necessario informar um NCM para o Produto!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtNCM.Focus(); return;
            }


            // tratando Numeros
            string mcusto = txtPrecoCompra.Text;
            string smcusto = mcusto.Replace(",", ".");
            string smcusto2 = mcusto.Replace(".", "").Replace(",",".");

            string mpreco = txtPrecoVenda.Text;
            string smpreco = mpreco.Replace(",", ".");
            string smpreco2 = mpreco.Replace(".", "").Replace(",",".");




            con.AbrirConexao();
            sql = "INSERT INTO produtos(prod_descricao, prod_un, prod_codbarras, prod_grupo, prod_precocusto, prod_precovenda, prod_forn, prod_ncm) VALUES (@prod_descricao, @prod_un, @prod_codbarras, @prod_grupo, @prod_precocusto, @prod_precovenda, @prod_forn, @prod_ncm)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@prod_descricao", txtDescricao.Text);
            cmd.Parameters.AddWithValue("@prod_un", txtUnidade.Text);
            cmd.Parameters.AddWithValue("@prod_codbarras", txtCodBarras.Text);
            cmd.Parameters.AddWithValue("@prod_grupo", comboGrupos.Text);
            if (txtPrecoCompra.Text.Length < 6)
            {
                cmd.Parameters.AddWithValue("@prod_precocusto", smcusto);
            }
            else
            {
                cmd.Parameters.AddWithValue("@prod_precocusto", smcusto2);
            }
            if (txtPrecoVenda.Text.Length < 6)
            {
                cmd.Parameters.AddWithValue("@prod_precovenda", smpreco);
            }
            else
            {
                cmd.Parameters.AddWithValue("@prod_precovenda", smpreco2);
            }
            cmd.Parameters.AddWithValue("@prod_forn", txtForncedor.Text);
            cmd.Parameters.AddWithValue("@prod_ncm", txtNCM.Text);

            cmd.ExecuteNonQuery();
            con.FecharConexao();

            CarregarGrid();
            modoSalvar = 0;
            DesabilitarCampos();
            ModoNormal();

            MessageBox.Show("O Cliente " + txtDescricao.Text + " Cadastrado com Sucesso !", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
        }

        private void AlterarInformacoes()
        {

            try
            {
                if (txtDescricao.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("É necessario informar uma Descrição para o Produto!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtDescricao.Focus(); return;
                }
                if (txtUnidade.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("É necessario informar um Tipo de Unidade para o Produto!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtUnidade.Focus(); return;
                }
                if (comboGrupos.Text == "")
                {
                    MessageBox.Show("É necessario informar um Grupo para o Produto!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    comboGrupos.Focus(); return;
                }
                if (txtPrecoCompra.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("É necessario informar um Preço de Custo para o Produto!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtPrecoCompra.Focus(); return;
                }
                if (txtPrecoVenda.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("É necessario informar um Preço de Venda para o Produto!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtPrecoVenda.Focus(); return;
                }
                if (txtNCM.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("É necessario informar um NCM para o Produto!", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtNCM.Focus(); return;
                }


                string mcusto = txtPrecoCompra.Text;
                string smcusto = mcusto.Replace(",", ".");
                string smcusto2 = mcusto.Replace(".", "").Replace(",", ".");

                string mpreco = txtPrecoVenda.Text;
                string smpreco = mpreco.Replace(",", ".");
                string smpreco2 = mpreco.Replace(".", "").Replace(",", ".");

                string mforn = txtForncedor.Text;
                string smforn = mforn.Replace("0", "");


                con.AbrirConexao();
                sql = "UPDATE produtos SET prod_descricao = @prod_descricao, prod_un = @prod_un, prod_codbarras = @prod_codbarras, prod_grupo = @prod_grupo," +
                    " prod_precocusto = @prod_precocusto, prod_precovenda = @prod_precovenda, prod_forn = @prod_forn, prod_ncm = @prod_ncm WHERE id_prod = @id_prod";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id_prod", id_prod);
                cmd.Parameters.AddWithValue("@prod_descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@prod_un", txtUnidade.Text);
                cmd.Parameters.AddWithValue("@prod_codbarras", txtCodBarras.Text);
                cmd.Parameters.AddWithValue("@prod_grupo", comboGrupos.Text);
                if (txtPrecoCompra.Text.Length < 6)
                {
                    cmd.Parameters.AddWithValue("@prod_precocusto", smcusto);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@prod_precocusto", smcusto2);
                }
                if (txtPrecoVenda.Text.Length < 6)
                {
                    cmd.Parameters.AddWithValue("@prod_precovenda", smpreco);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@prod_precovenda", smpreco2);
                }
                if (txtForncedor.Text.Length <= 3 && txtForncedor.Text.Length >= 0) 
                {
                    cmd.Parameters.AddWithValue("@prod_forn", smforn);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@prod_forn", txtForncedor.Text);
                }                         
                cmd.Parameters.AddWithValue("@prod_ncm", txtNCM.Text);
                cmd.ExecuteNonQuery();
                con.FecharConexao();

                CarregarGrid();
                modoSalvar = 0;
                DesabilitarCampos();
                ModoNormal();

                MessageBox.Show("Produto Alterado com Sucesso !", "Cadastro de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alteração de Produtos");             
            }
            



        }

        private void SearchData(string valorDigitado)
        {            
            con.AbrirConexao();
            sql = "SELECT ncm_descricao FROM tbl_ncm WHERE ncm_cod = @ncm_cod";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@ncm_cod", valorDigitado);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {                 
                lblMostraNcm.Text = reader.GetString(0);                
            }
            else
            {
                lblMostraNcm.Text = "NCM não consta no Banco de Dados.";
            }
            reader.Close();
            con.FecharConexao();
        }

        private void txtNCM_TextChanged(object sender, EventArgs e)
        {
            if (txtNCM.Text.Length <= 7)
            {
                lblMostraNcm.Text = "";
            }
            else if (txtNCM.Text.Length == 8)
            {
                SearchData(txtNCM.Text);
            }

                
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            CarregarGridForn();
            gridforn.Visible = true;
            modoSalvar = 10;
            HabilitarCampos();
            ModoEdicao();
            LimparCampos();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (id_Excluir <= -1)
            {
                MessageBox.Show("É necessario Selecionar um Produto Para a Editar !", "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CarregarGridForn();
                gridforn.Visible = true;
                ModoEdicao();
                HabilitarCampos();
                modoSalvar = 20;
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (id_Excluir <= -1)
            {                
                MessageBox.Show("É necessario Selecionar um Produto Para a Exclusão !", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var resposta = MessageBox.Show("Deseja Realmente Excluir esse Produto ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resposta == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "DELETE FROM produtos WHERE id_prod = @id_prod";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id_prod", id_prod);
                    cmd.ExecuteNonQuery();
                    con.FecharConexao();
                    CarregarGrid();
                    MessageBox.Show("Produto Excluido com Sucesso !", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    return;
                }
                
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DesabilitarCampos();
            ModoNormal();
            LimparCampos();
            gridforn.Visible = false;
            gridforn.Enabled = false;
            comboGrupos.Text = string.Empty;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            BuscarProd();
        }

        private void txtForncedor_TextChanged(object sender, EventArgs e)
        {                       
            MostraForn(txtForncedor.Text);
            gridforn.Visible = true;
            gridforn.Enabled = true;                      
        }

        private void txtPrecoCompra_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoCompra);
        }

        private void txtPrecoVenda_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtPrecoVenda);
        }

        private void frmCadProd_KeyDown(object sender, KeyEventArgs e)
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

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.frmCadGrupos frmGrupos = new Telas.Cadastros.frmCadGrupos();
            frmGrupos.ShowDialog();            
        }

        private void comboGrupos_Click(object sender, EventArgs e)
        {
            CarregarGrupos();
        }
    }
}
