using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace pdv
{
    class Conexao
    {
        // Conectar localhost    //porta está empty pq o rapaz do video disse que funciona assim melhor com a 3306
        public string conexao = "SERVER=localhost; DATABASE=pdv; UID=root; PWD=wmretrobx19; PORT=3309";

        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            con = new MySqlConnection(conexao);
            con.Open();
        }
        public void FecharConexao()
        {
            con = new MySqlConnection(conexao);
            con.Close();
            con.Dispose(); // derruba algumas conexoes abertas
            con.ClearAllPoolsAsync(); // metodo de limpeza
        }

    }
}
