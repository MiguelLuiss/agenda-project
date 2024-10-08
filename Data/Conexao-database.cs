using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_project.Data
{
    static internal class Conexao_database
    {
        static public MySqlConnection CriaConexao()
        {
            //string que contem as informações para a conexão//
            string stringConexao = "Server=127.0.0.1;Database =dbagenda; User ID=root;Password=root;";

            //criando a conexão//
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;
        }
    }
}
