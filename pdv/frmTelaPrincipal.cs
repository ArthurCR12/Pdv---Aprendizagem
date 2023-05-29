using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdv
{
    public partial class frmTelaPrincipal : Form
    {        

        public frmTelaPrincipal()
        {
            InitializeComponent();
            
        }        

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            dataHotaStripLB.Text = DateTime.Today.ToString("dd/MM/yyyy");
            horaStripLB.Text = DateTime.Now.ToString("HH:mm:ss");
            nomeUserStripLB.Text = CheckBD.nomeUser;
            cargoStripLB.Text = CheckBD.cargoUser;           
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Deseja Realmente Sair ?", "PDV - BETA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                this.Close();                

            }
            else
            {
                return;
            }

        }     

        private void menuCadCargos_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.frmCadCargos frm = new Telas.Cadastros.frmCadCargos();
            frm.ShowDialog();
        }      

        private void btn_CadCli_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.frmCadClientes frm = new Telas.Cadastros.frmCadClientes();
            frm.ShowDialog();
            
        }

        private void btn_CadProd_Click(object sender, EventArgs e)
        {            
            Telas.Cadastros.frmCadProd frm = new Telas.Cadastros.frmCadProd();
            frm.ShowDialog();
        }

        private void btn_CadForn_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.frmCadForn frm = new Telas.Cadastros.frmCadForn();
            frm.ShowDialog();
        }

        private void btn_CadFuncionarios_Click(object sender, EventArgs e)
        {
             Telas.Cadastros.frmCadFuncionario frm = new Telas.Cadastros.frmCadFuncionario();
             frm.ShowDialog();

        }

        private void frmTelaPrincipal_KeyDown(object sender, KeyEventArgs e)
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

        private void cadastroDeGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Cadastros.frmCadGrupos frm = new Telas.Cadastros.frmCadGrupos();
            frm.ShowDialog();
        }

        private void btn_CadProd_MouseLeave(object sender, EventArgs e)
        {
            btn_CadProd.ForeColor = Color.White;
        }

        private void btn_CadProd_MouseEnter(object sender, EventArgs e)
        {
            btn_CadProd.ForeColor = Color.Black;            
        }

        private void btn_CadCli_MouseLeave(object sender, EventArgs e)
        {
            btn_CadCli.ForeColor = Color.White;
        }

        private void btn_CadCli_MouseEnter(object sender, EventArgs e)
        {
            btn_CadCli.ForeColor = Color.Black;
        }

        private void btn_CadForn_MouseEnter(object sender, EventArgs e)
        {
            btn_CadForn.ForeColor = Color.Black;
        }

        private void btn_CadForn_MouseLeave(object sender, EventArgs e)
        {
            btn_CadForn.ForeColor = Color.White;
        }

        private void btn_CadFuncionarios_MouseEnter(object sender, EventArgs e)
        {
            btn_CadFuncionarios.ForeColor = Color.Black;
        }

        private void btn_CadFuncionarios_MouseLeave(object sender, EventArgs e)
        {
            btn_CadFuncionarios.ForeColor= Color.White;
        }

       
    }
}
