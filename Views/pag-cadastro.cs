using agenda_project.Controller;
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
            string nome = txtCadastroNome.Text;
            string usuario = txtUsuario.Text;
            string telefone = txtTelefone.Text;
            string senha = txtSenhaCadastro.Text;


            UsuarioController usuarioController = new UsuarioController();

            bool resultado = usuarioController.AddUsuario(nome, usuario, telefone, senha);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso");
            }
            else 
            {
                MessageBox.Show("Falha no cadastro do usuario");
            }
            
            

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
