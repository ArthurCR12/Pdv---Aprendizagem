﻿using MySql.Data.MySqlClient;
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
        Conexao con = new Conexao();

        string UserOn = CheckBD.nomeUser;

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

        #region Telas

        private void menuCadCargos_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand("SELECT user_pcadcargo FROM user WHERE user_name = @user_name", con.con);
                cmd.Parameters.AddWithValue("@user_name", UserOn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int valor = reader.GetInt32(0);

                    if (valor == 0)
                    {
                        MessageBox.Show("Você não tem Permissão para Acessar !", "PERMISSÕES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (valor == 1)
                    {
                        Telas.Cadastros.frmCadCargos frm = new Telas.Cadastros.frmCadCargos();
                        frm.ShowDialog();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_CadCli_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand("SELECT user_pcadprod FROM user WHERE user_name = @user_name", con.con);
                cmd.Parameters.AddWithValue("@user_name", UserOn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int valor = reader.GetInt32(0);

                    if (valor == 0)
                    {
                        MessageBox.Show("Você não tem Permissão para Acessar !", "PERMISSÕES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (valor == 1)
                    {
                        ;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Telas.Cadastros.frmCadClientes frm = new Telas.Cadastros.frmCadClientes();
            frm.ShowDialog();

        }

        private void btn_CadProd_Click(object sender, EventArgs e)
        {                       
            try
            {
                con.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand("SELECT user_pcadprod FROM user WHERE user_name = @user_name", con.con);                
                cmd.Parameters.AddWithValue("@user_name", UserOn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int valor = reader.GetInt32(0);

                    if (valor == 0)
                    {
                        MessageBox.Show("Você não tem Permissão para Acessar !", "PERMISSÕES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (valor == 1)
                    {
                        Telas.Cadastros.frmCadProd frm = new Telas.Cadastros.frmCadProd();
                        frm.ShowDialog();
                    }

                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.ToString());
            }

        }

        private void btn_CadForn_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand("SELECT user_pcadprod FROM user WHERE user_name = @user_name", con.con);
                cmd.Parameters.AddWithValue("@user_name", UserOn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int valor = reader.GetInt32(0);

                    if (valor == 0)
                    {
                        MessageBox.Show("Você não tem Permissão para Acessar !", "PERMISSÕES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (valor == 1)
                    {
                        ;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Telas.Cadastros.frmCadForn frm = new Telas.Cadastros.frmCadForn();
            frm.ShowDialog();
        }

        private void btn_CadFuncionarios_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand("SELECT user_pcadprod FROM user WHERE user_name = @user_name", con.con);
                cmd.Parameters.AddWithValue("@user_name", UserOn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int valor = reader.GetInt32(0);

                    if (valor == 0)
                    {
                        MessageBox.Show("Você não tem Permissão para Acessar !", "PERMISSÕES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (valor == 1)
                    {
                        ;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Telas.Cadastros.frmCadFuncionario frm = new Telas.Cadastros.frmCadFuncionario();
            frm.ShowDialog();

        }

        private void menuCadUser_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand("SELECT user_pcadprod FROM user WHERE user_name = @user_name", con.con);
                cmd.Parameters.AddWithValue("@user_name", UserOn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int valor = reader.GetInt32(0);

                    if (valor == 0)
                    {
                        MessageBox.Show("Você não tem Permissão para Acessar !", "PERMISSÕES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (valor == 1)
                    {
                        ;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Telas.Cadastros.frmCadUsuario frm = new Telas.Cadastros.frmCadUsuario();
            frm.ShowDialog();
        }

        private void cadastroDeGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand("SELECT user_pcadprod FROM user WHERE user_name = @user_name", con.con);
                cmd.Parameters.AddWithValue("@user_name", UserOn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int valor = reader.GetInt32(0);

                    if (valor == 0)
                    {
                        MessageBox.Show("Você não tem Permissão para Acessar !", "PERMISSÕES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (valor == 1)
                    {
                        ;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Telas.Cadastros.frmCadGrupos frm = new Telas.Cadastros.frmCadGrupos();
            frm.ShowDialog();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand("SELECT user_pcadprod FROM user WHERE user_name = @user_name", con.con);
                cmd.Parameters.AddWithValue("@user_name", UserOn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int valor = reader.GetInt32(0);

                    if (valor == 0)
                    {
                        MessageBox.Show("Você não tem Permissão para Acessar !", "PERMISSÕES", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (valor == 1)
                    {
                        ;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Telas.Retaguarda.frmCompra frm = new Telas.Retaguarda.frmCompra();
            frm.ShowDialog();
        }

        #endregion Telas
       
        #region CoresBTN

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
            btn_CadFuncionarios.ForeColor = Color.White;
        }

        private void btnCompra_MouseLeave(object sender, EventArgs e)
        {
            btnCompra.ForeColor = Color.White;
        }

        private void btnCompra_MouseEnter(object sender, EventArgs e)
        {
            btnCompra.ForeColor = Color.Black;
        }

        #endregion CoresBTN

        private void timer_Tick(object sender, EventArgs e)
        {
            dataHotaStripLB.Text = DateTime.Today.ToString("dd/MM/yyyy");
            horaStripLB.Text = DateTime.Now.ToString("HH:mm:ss");
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

    }
}
