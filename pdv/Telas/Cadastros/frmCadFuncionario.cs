using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace pdv.Telas.Cadastros
{
    public partial class frmCadFuncionario : Form
    {

        Conexao con = new Conexao(); // aqui eu chamo a Classe Conexao
        string sql;
        MySqlCommand cmd;

        string foto;
        string alterouImagem;
        string id_func;
        string cpfAntigo;
        int id_Excluir = -1;
        int modoEdicao = 0;
        
        

        public frmCadFuncionario()
        {
            InitializeComponent();           
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            LimparFoto();
            MostrarGrid();
            FormatarGrid();
            alterouImagem = "não";
            CarregarCargos();
            comboFuncCargo.Text = "Selecione um Cargo";
            
        }

        private void MostrarGrid()  // Montar o Grid no Sistema
        {
            con.AbrirConexao();
            sql = "SELECT * FROM funcionarios ORDER BY id_func asc";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridFunc.DataSource = dt; // aqui chama a grid do form
            con.FecharConexao();

        }

        private void FormatarGrid()
        {
            gridFunc.Columns[0].HeaderText = "ID";
            gridFunc.Columns[1].HeaderText = "Nome";
            gridFunc.Columns[2].HeaderText = "CPF";
            gridFunc.Columns[3].HeaderText = "Telefone";
            gridFunc.Columns[4].HeaderText = "Cargo";
            gridFunc.Columns[5].HeaderText = "Endereço";
            gridFunc.Columns[6].HeaderText = "Data";

            gridFunc.Columns[0].Width = 30;
            gridFunc.Columns[1].Width = 150;
            gridFunc.Columns[2].Width = 100;
            gridFunc.Columns[3].Width = 100;
            gridFunc.Columns[5].Width = 150;
            gridFunc.Columns[6].Width = 150;
            gridFunc.Columns[7].Visible = false;            

            gridFunc.MultiSelect = false;

        }

        private void gridFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                id_Excluir = (int)gridFunc.CurrentRow.Cells[0].Value;
                id_func = gridFunc.CurrentRow.Cells[0].Value.ToString();  // aqui ta passando o id para depois ser usado em outros lugares
                cpfAntigo = gridFunc.CurrentRow.Cells[2].Value.ToString(); // aqui tbm esta enviando uma informação para uma var ser usada em outro lugar
                txtFuncNome.Text = gridFunc.CurrentRow.Cells[1].Value.ToString();  // Aqui seleciona a row e exibi ela no txt
                txtFuncCPF.Text = gridFunc.CurrentRow.Cells[2].Value.ToString();
                txtFuncTel.Text = gridFunc.CurrentRow.Cells[3].Value.ToString();
                comboFuncCargo.Text = gridFunc.CurrentRow.Cells[4].Value.ToString();
                txtFuncEnd.Text = gridFunc.CurrentRow.Cells[5].Value.ToString();

                if (gridFunc.CurrentRow.Cells[7].Value != DBNull.Value) // DBNull.Value é o campo que tem no BD
                {
                    byte[] imagem = (byte[])gridFunc.Rows[e.RowIndex].Cells[7].Value; //Criada var byte[] imagem para receber convertido em byte o que vem da grid
                    MemoryStream ms = new MemoryStream(imagem); // recebe a var byte q já contem o valor da grid (decodificado / convertido)

                    // o componente 'Image' sempre pede um 'System.Drawing' então...
                    pictureBoxFuncionario.Image = Image.FromStream(ms);
                }
                else
                {
                    pictureBoxFuncionario.Image = Properties.Resources.sem_foto;
                }


            }
            else
            {
                return;
            }

        }

        private byte[] Img() // este metodo é padrao, serve sempre q deseja enviar uma imagem para o bd
        {
            byte[] imagem_byte = null; // essa var vou usar p enviar o comprimento da imagem
            if (foto == "")  // a string foto, nunca vai estar vazia, pq no metodo LimparFoto() foi passado o caminho de uma imagem 'sem_foto'
            {
                return null;
            }

            // usar o FileStream p eviar imagem para o bd e tres parametros 'local(foto), tipo de img(FileMode), tipo de acesso(FileAcess)'
            FileStream fs = new FileStream(foto, FileMode.Open, FileAccess.Read); // isso é padrão

            BinaryReader br = new BinaryReader(fs); // serve para trabalhar com FileStream

            imagem_byte = br.ReadBytes((int)fs.Length); // Pegando o comprimento de FileStream e jogando dentro de uma tipo de IMAGEM BYTE

            return imagem_byte;
        }     

        private void CarregarCargos()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM cargos ORDER BY id_cargo ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboFuncCargo.DataSource = dt;
            comboFuncCargo.DisplayMember = "nome_cargo"; // aqui carrega ele pela a tabela estabelecida no bd
            con.FecharConexao();
        }

        private void LimparCampos()
        {
            txtFuncCPF.Text = string.Empty;
            txtFuncEnd.Text = string.Empty;
            txtFuncNome.Text = string.Empty;
            txtFuncTel.Text = string.Empty;
            comboFuncCargo.Text = "Selecione um Cargo";
        }

        private void HabilitarCampos()
        {
            txtFuncNome.Enabled = true;
            txtFuncCPF.Enabled = true;
            txtFuncTel.Enabled = true;
            txtFuncEnd.Enabled = true;
            comboFuncCargo.Enabled = true;
            btn_foto.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtFuncNome.Enabled = false;
            txtFuncCPF.Enabled = false;
            txtFuncTel.Enabled = false;
            txtFuncEnd.Enabled = false;
            comboFuncCargo.Enabled = false;   
            btn_foto.Enabled = false;
        }

        private void SalvarInformacoes()
        {           
            // Conferir arquivos
            // Tratando o Nome
            if (txtFuncNome.Text.ToString().Trim() == "") // ToSring().Trim() serve para tirar os espaços
            {
                MessageBox.Show("É necessário informar um Nome !", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFuncNome.Text = null; // aqui pra limpar o campo
                txtFuncNome.Focus(); // aqui para focar no campo
                return; // é preciso colocar o return, para não avançar na programação
            }

            // Tratando o CPF
            if (txtFuncCPF.Text == "   .   .   -")
            {
                MessageBox.Show("É necessário informar um CPF !", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFuncCPF.Text = null;
                txtFuncCPF.Focus();
                return;
            }
            if (txtFuncCPF.Text.Length < 14)
            {
                MessageBox.Show("É necessário informar um CPF Válido !", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFuncCPF.Text = null;
                txtFuncCPF.Focus();
                return;
            }

            // Tratando o Cargo
            if (comboFuncCargo.Text == "Selecione um Cargo" || comboFuncCargo.Text == string.Empty)
            {
                MessageBox.Show("É neceesário informar um Cargo", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboFuncCargo.Text = null;
                comboFuncCargo.Focus();
                return;
            }

            // Tratando As Mascaras
            string mCpf = txtFuncCPF.Text;
            string smCpf = mCpf.Replace(" ", "").Replace(".", "").Replace("-", "").Replace(",", "");

            string mTel = txtFuncTel.Text;
            string smTel = mTel.Replace(" ", "").Replace(")", "").Replace("(", "").Replace("-", "");

            con.AbrirConexao();

            sql = "INSERT INTO funcionarios(func_nome, func_cpf, func_telefone, func_cargo, func_endereco, func_data, func_foto) VALUES((UPPER(@func_nome)), @func_cpf, @func_telefone, @func_cargo, (UPPER(@func_endereco)), curDate(), @func_foto)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@func_nome", txtFuncNome.Text);
            cmd.Parameters.AddWithValue("@func_cpf", smCpf);
            cmd.Parameters.AddWithValue("@func_telefone", smTel);
            cmd.Parameters.AddWithValue("@func_cargo", comboFuncCargo.Text);
            cmd.Parameters.AddWithValue("@func_endereco", txtFuncEnd.Text);
            cmd.Parameters.AddWithValue("@func_foto", Img()); // os () é o metodo criado p/ tratar img no bd

            if (txtFuncCPF.Text != cpfAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM funcionarios WHERE func_cpf = @func_cpf", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@func_cpf", txtFuncCPF.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF já Registrado !", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFuncCPF.Text = "";
                    txtFuncCPF.Focus();
                    return;
                }
            }

            cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Funcionário Cadastrado com Sucesso !", "Cadastro de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            DesabilitarCampos();            
            gridFunc.Enabled = true;
            LimparCampos();
            MostrarGrid();
            modoEdicao = 0;

            btnFuncNovo.Enabled = true;
            btnFuncExcluir.Enabled = true;
            btnFuncEditar.Enabled = true;
            gridFunc.Enabled = true;
            btnFuncSalvar.Enabled = false;
            btnCadCargo.Enabled = false;
        }

        private void AlterarInformacoes() 
        {
            if (txtFuncNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("É necessário informar um Nome !", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFuncNome.Text = null; // aqui pra limpar o campo
                txtFuncNome.Focus(); // aqui para focar no campo
                return; // é preciso colocar o return, para não avançar na programação
            }

            if (txtFuncCPF.Text == "   .   .   -")
            {
                MessageBox.Show("É necessário informar um CPF !", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFuncCPF.Text = null;
                txtFuncCPF.Focus();
                return;
            }
            if (txtFuncCPF.Text.Length < 14)
            {
                MessageBox.Show("É necessário informar um CPF Válido !", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFuncCPF.Text = null;
                txtFuncCPF.Focus();
                return;
            }

            // Tratando o Cargo
            if (comboFuncCargo.Text == "Selecione um Cargo" || comboFuncCargo.Text == string.Empty)
            {
                MessageBox.Show("É neceesário informar um Cargo", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboFuncCargo.Text = null;
                comboFuncCargo.Focus();
                return;
            }

            // Tratando As Mascaras
            string mCpf = txtFuncCPF.Text;
            string smCpf = mCpf.Replace(" ", "").Replace(".", "").Replace("-", "").Replace(",", "");

            string mTel = txtFuncTel.Text;
            string smTel = mTel.Replace(" ", "").Replace(")", "").Replace("(", "").Replace("-", "");

            

            // Editar
            con.AbrirConexao();
            if (alterouImagem == "sim")
            {
                sql = "UPDATE funcionarios Set func_nome = @func_nome, func_cpf = @func_cpf, func_telefone = @func_telefone, func_cargo = @func_cargo, " +
                    "func_endereco = @func_endereco, func_foto = @func_foto WHERE id_func = @id_func";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id_func", id_func);
                cmd.Parameters.AddWithValue("@func_nome", txtFuncNome.Text);
                cmd.Parameters.AddWithValue("@func_cpf", smCpf);
                cmd.Parameters.AddWithValue("@func_telefone", smTel);
                cmd.Parameters.AddWithValue("@func_cargo", comboFuncCargo.Text);
                cmd.Parameters.AddWithValue("@func_endereco", txtFuncEnd.Text);
                cmd.Parameters.AddWithValue("@func_foto", Img());
            }
            else
            {
                sql = "UPDATE funcionarios Set func_nome = @func_nome, func_cpf = @func_cpf, func_telefone = @func_telefone, func_cargo = @func_cargo, " +
                    "func_endereco = @func_endereco WHERE id_func = @id_func";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@id_func", id_func);
                cmd.Parameters.AddWithValue("@func_nome", txtFuncNome.Text);
                cmd.Parameters.AddWithValue("@func_cpf", smCpf);
                cmd.Parameters.AddWithValue("@func_telefone", smTel);
                cmd.Parameters.AddWithValue("@func_cargo", comboFuncCargo.Text);
                cmd.Parameters.AddWithValue("@func_endereco", txtFuncEnd.Text);
            }

            if (txtFuncCPF.Text != cpfAntigo)
            {
                MySqlCommand cmdVerificar;
                cmdVerificar = new MySqlCommand("SELECT * FROM funcionarios WHERE func_cpf = @func_cpf", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@func_cpf", txtFuncCPF.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("CPF já Registrado !", "Cadastro de Funcionários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFuncCPF.Text = "";
                    txtFuncCPF.Focus();
                    return;
                }
            }

            cmd.ExecuteNonQuery();
            con.FecharConexao();
            MostrarGrid();
            DesabilitarCampos();

            MessageBox.Show("Cadastro Alterado com Sucesso !", "Cadastro de Funcionarios", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //modoEdicao(false);
            btnFuncNovo.Enabled = true;
            btnFuncExcluir.Enabled = true;
            btnFuncEditar.Enabled = true;
            gridFunc.Enabled = true;
            btnFuncSalvar.Enabled = false;
            btnCadCargo.Enabled = false;
            modoEdicao = 0;
        }

        private void btnFuncFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFuncNovo_Click(object sender, EventArgs e)
        {
            modoEdicao = 10;
            gridFunc.Enabled = false;
            LimparCampos();
            txtFuncNome.Focus();
            btnFuncNovo.Enabled = false;
            txtFuncNome.Enabled = true;
            txtFuncCPF.Enabled = true;
            txtFuncTel.Enabled = true;
            txtFuncEnd.Enabled = true;
            comboFuncCargo.Enabled = true;
            btnFunCancelar.Enabled = true;
            btnFuncSalvar.Enabled = true;
            btn_foto.Enabled = true;
            btnFuncEditar.Enabled = false;
            btnFuncExcluir.Enabled = false;
            btnCadCargo.Enabled = true;
        }

        private void btnFuncSalvar_Click(object sender, EventArgs e)
        {
            if (modoEdicao == 10)
            {
                SalvarInformacoes();
            }
            else if (modoEdicao == 20)
            {
                AlterarInformacoes();
            }
           
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // dialog.Filter = Arquivos(*.jpg)|*jpg | Aquivos(*.png)|*.png; ALL(*.*)|*.*; mostra uma de cada vez
            dialog.Filter = "Imagens(*.jpg; *.png) | *.jpg;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString(); // pegando o caminho da imagens q selecionei. Precisa criar uma var no inicio
                pictureBoxFuncionario.ImageLocation = foto; // jogando caminho para uma var para exibir no form
                alterouImagem = "sim"; // para editar alterando imagem
            }
        }
      
        private void LimparFoto()
        {
            pictureBoxFuncionario.Image = Properties.Resources.sem_foto;  // aqui tem que pegar a pictureBox e a imagem na pasta que ela está
            foto = "img/sem_foto.png";  // atribuindo um caminho da foto (Está imagem tem que estar na pasta debug)

        }

        private void btnFuncEditar_Click(object sender, EventArgs e)
        {
            if (id_Excluir <= -1)
            {
                MessageBox.Show("É necessario Selecionar um Funcionario Para a Editar !", "Cadastro de Cargos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                modoEdicao = 20;
                btnFuncNovo.Enabled = false; 
                btnFuncEditar.Enabled = false;
                btnFuncExcluir.Enabled = false;
                btnFuncSalvar.Enabled = true;
                btnFunCancelar.Enabled = true;
                gridFunc.Enabled = false;
                btnCadCargo.Enabled = true;
                //modoEdicao(true);               
                HabilitarCampos();
            }
                       
        }        
        

        private void btnFunCancelar_Click(object sender, EventArgs e)
        {
            btnFuncNovo.Enabled = true;
            btnFuncEditar.Enabled = true;
            btnFuncSalvar.Enabled = false;
            btnFuncExcluir.Enabled = true;
            gridFunc.Enabled = true;
            btnCadCargo.Enabled = false;
            //modoEdicao(false);
            DesabilitarCampos();
            LimparCampos();
        }

        private void btnFuncExcluir_Click(object sender, EventArgs e)
        {
            if (id_Excluir <= -1)
            {
                MessageBox.Show("É necessario Selecionar um Funcionario Para a Exclusão !", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var resposta = MessageBox.Show("Deseja realmente excluir este Funcionario ?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta == DialogResult.Yes)
                {
                    con.AbrirConexao();
                    sql = "DELETE FROM funcionarios WHERE id_func = @id_func";
                    cmd = new MySqlCommand(sql, con.con);
                    cmd.Parameters.AddWithValue("@id_func", id_func);
                    cmd.ExecuteNonQuery();
                    con.FecharConexao();
                    MostrarGrid();

                    MessageBox.Show("Funcionario Excluido com Sucesso !", "Exclusão Concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DesabilitarCampos();
                    LimparCampos();
                    LimparFoto();
                }
                else
                {
                    LimparCampos();
                    LimparFoto();
                    return;
                }
            }
            

            
        }

        private void frmCadFuncionario_KeyDown(object sender, KeyEventArgs e)
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

        private void btnCadCargo_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.frmCadCargos frm = new frmCadCargos();
            frm.ShowDialog();
        }
        
    }








}
