using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace pdv
{
    class Conexao
    {
        // Conectar localhost    //porta está empty pq o rapaz do video disse que funciona assim melhor com a 3306
        public string conexao = "SERVER=localhost; DATABASE=pdv; UID=root; PWD=wmretrobx19; PORT=3309";
        MySqlTransaction tran;
        public MySqlConnection con = null;
               


        #region Conect
        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Open();
            }
            catch (Exception e)
            {                
                MessageBox.Show("Erro ao conectar-se ao banco de dados. " + e.Message);
            }
            
        }
        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Close();
                con.Dispose(); // derruba algumas conexoes abertas
                con.ClearAllPoolsAsync(); // metodo de limpeza
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);                
            }
            
        }  
        
        public MySqlTransaction IniciarTransacao(MySqlCommand cmd)
        {
            tran = con.BeginTransaction();
            cmd.Connection = con;
            cmd.Transaction = tran;
            return tran;
        }

        public void FinalizarTransacao(Boolean ret)
        {
            if (ret)
            {
                tran.Commit();
            }
            else
            {
                tran.Rollback();
            }
        }


        #endregion



        
    }
}
