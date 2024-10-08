using agenda_project.Data;
using MySql.Data.MySqlClient;
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

namespace agenda_project
{
    public partial class pag_cadastro : Form
    {



        private void validacaoCadastro()
        {
            if (txtCadastroNome.Text != "" && txtTelefone.Text != "" && txtSenhaCadastro.Text.Length >= 8 && txtRedigiteSenha.Text == txtSenhaCadastro.Text)
            {
                btnCadastro.Enabled = true;
            }

            else
            {
                btnCadastro.Enabled = false;
            }

        }
        public pag_cadastro()
        {
            InitializeComponent();
        }

        private void txtCadastroNome_TextChanged(object sender, EventArgs e)
        {
            validacaoCadastro();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {

            MySqlConnection conexao = Conexao_database.CriaConexao();

            conexao.Open();


            ///criando o comando sql para inserir o usuario///
            string sql = $"INSERT INTO tb_usuario (nome, usuario, telefone, senha) VALUES (@nome,@usuario,@telefone, @senha)";


            ///executando o sql///
            MySqlCommand comando = new MySqlCommand(sql, conexao);


            //adicionando um valor para os "apelidos"//
            comando.Parameters.AddWithValue("@nome", txtCadastroNome.Text);

            comando.Parameters.AddWithValue("@usuario", txtCadastroNome.Text);

            comando.Parameters.AddWithValue("@telefone", txtCadastroNome.Text);

            comando.Parameters.AddWithValue("@senha", txtCadastroNome.Text);

            comando.ExecuteNonQuery();


            //fechando a conexão com o banco//
            conexao.Close();

            validacaoCadastro();

            MessageBox.Show("você foi cadastrado com sucesso");
            this.Close();

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            validacaoCadastro();
        }

        private void txtSenhaCadastro_TextChanged(object sender, EventArgs e)
        {
            validacaoCadastro();
        }

        private void txtRedigiteSenha_TextChanged(object sender, EventArgs e)
        {
            validacaoCadastro();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            validacaoCadastro();
        }
    }
}
