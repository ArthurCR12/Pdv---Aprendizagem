using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pdv.Telas.Retaguarda
{
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Obtendo o texto das TextBox
            string forn = txtForn.Text;
            string prod = txtProd.Text;
            string qtd = txtQuant.Text;
            string preco = txtPreço.Text;
            string obs = txtObs.Text;

            // Criando uma nova linha no DataGrid e Atribuindo os valores das TextBox
            DataGridViewRow novaLinha = new DataGridViewRow();
            novaLinha.CreateCells(Grid, forn, prod, qtd, preco, obs);
            Grid.Rows.Add(novaLinha);

            //Limpe as Txt após adicionar ao Grid
            txtForn.Clear();
            txtProd.Clear();
            txtQuant.Clear();
            txtQuant.Clear();
            txtPreço.Clear();
            txtObs.Clear();
        }

         #region Funcoes

         private void FormatarGrid()
        {
            
        }



         #endregion Fucoes




        
    }
}
