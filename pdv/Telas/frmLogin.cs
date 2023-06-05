using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace pdv.Telas
{
    public partial class frmLogin : Form
    {

        Conexao con = new Conexao(); // aqui eu chamo a Classe Conexao        

        private Timer timer;

        public frmLogin()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 7000;
            timer.Tick += Timer_Tick;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Visible = true;
            timer.Stop();

        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.Enter)
            {
                CallLogin();
            }
        }

        private void CallLogin()
        {
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("Digite um Usuário !", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtUser.Focus();
                return;
            }
            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("Digite uma Senha !", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtSenha.Focus();
                return;
            }

            try
            {
                con.AbrirConexao();
                MySqlCommand cmdVerifica = new MySqlCommand("SELECT * FROM user WHERE user_name = @user_name AND user_password = @user_password", con.con);
                MySqlDataReader reader; // Com o reader vou conseguir extrair dados da tabela e usar em outros form
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerifica;
                cmdVerifica.Parameters.AddWithValue("@user_name", txtUser.Text);
                cmdVerifica.Parameters.AddWithValue("@user_password", txtSenha.Text);
                reader = cmdVerifica.ExecuteReader();
                if (reader.HasRows)
                {
                    // extraindo dados do login
                    while (reader.Read())
                    {
                        CheckBD.nomeUser = Convert.ToString(reader["user_name"]);
                        if (CheckBD.cargoUser == "ADMIN")
                        {
                            this.Hide();
                            frmTelaPrincipal frmTelaPrincipal = new frmTelaPrincipal();
                            frmTelaPrincipal.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            CheckBD.cargoUser = Convert.ToString(reader["user_cargo"]); this.Hide();
                            frmTelaPrincipal frmTelaPrincipal = new frmTelaPrincipal();
                            frmTelaPrincipal.ShowDialog();
                            this.Close();
                        }
                        
                    }
                    
                }
                else
                {
                    
                    lbAvisoSenha.Visible = true;                    
                    txtSenha.Text = "";
                    txtUser.Text = "";
                    txtUser.Focus();                    
                    
                    return;
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.FecharConexao();
            }

            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CallLogin();                        
        }

        
        
        
    }
}
