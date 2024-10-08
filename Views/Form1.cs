namespace agenda_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void habilitarBotaoLogin()
        {
            ///se usuario possuir ao menos 1 caracter e a senha possuir mais de 8 digitos, o botao entrar estara ativo///
            if (txtUsuario.Text != "" && txtSenha.Text.Length >= 8 )
            {
                botaoEntrar.Enabled = true;
            }
            ///senao, o botao estara desativado///
            else
            {
                botaoEntrar.Enabled = false;
            }
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            pag_cadastro Pag_cadastro = new pag_cadastro();
            Pag_cadastro.ShowDialog();
        }

        private void entrar_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }
    }
}
