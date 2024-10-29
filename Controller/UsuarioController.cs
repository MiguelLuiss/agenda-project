using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agenda_project.Data;

namespace agenda_project.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {
            
            MySqlConnection conexao = Conexao_database.CriaConexao();

            string sql = "INSERT INTO tbUsuarios (nome, usuario, telefone, senha) values  (@nome, @usuario, @telefone, @senha);";

            conexao.Open();

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", nome);

            comando.Parameters.AddWithValue("@usuario", usuario);

            comando.Parameters.AddWithValue("@telefone", telefone);

            comando.Parameters.AddWithValue("@senha", senha);

            //executando comando no banco de dados
            int LinhasAfetadas = comando.ExecuteNonQuery();

            conexao.Close();

            if (LinhasAfetadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
}
    }

