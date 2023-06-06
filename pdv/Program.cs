using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdv
{  
    internal static class Program
    {        
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]        
        static void Main()
        {
            Conexao con = new Conexao(); // aqui eu chamo a Classe Conexao                        
            try
            {
                con.AbrirConexao();
                MySqlCommand cmd = new MySqlCommand("SELECT sys_login FROM sistema", con.con);
                MySqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    int valor = reader.GetInt32(0);

                    if (valor == 0)
                    {
                        AbrirRetaguarda();
                    }
                    else if (valor == 1)
                    {
                        AbrirLogin();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
            
        }

        static void AbrirRetaguarda()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTelaPrincipal());
        }

        static void AbrirLogin()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Telas.frmLogin());
        }

    }
}
