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
        
        private void habilitarBotaoCadastrar()
        {
            bool erro = false;

            if(txtCadastroNome.Text == "")
            {
                erro = true;
            }

            if(txtTelefone.Text == "")
            {
                erro = true;
            }


            if(txtSenhaCadastro.Text.Length < 8)
            {
                erro = true;
            }

            if(erro == false)
            {
                btnCadastro.Enabled = true; 
            }
            else
            {
                btnCadastro.Enabled= false;
            }


            


        }
        
        private void validacaoCadastro()
        {
            if (txtCadastroNome.Text != "" && txtTelefone.Text != "" && txtSenhaCadastro.Text.Length >= 8 && txtRedigiteSenha == txtSenhaCadastro)
            {
                btnCadastro.Enabled = true;
            }

            else
            {
                btnCadastro.Enabled= false;
            }


        }
        public pag_cadastro()
        {
            InitializeComponent();
        }

        private void txtCadastroNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            validacaoCadastro();
        }
    }
}
