namespace agenda_project
{
    partial class pag_cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pag_cadastro));
            txtCadastroNome = new TextBox();
            nome = new Label();
            label1 = new Label();
            txtTelefone = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtSenhaCadastro = new TextBox();
            label3 = new Label();
            txtRedigiteSenha = new TextBox();
            btnCadastro = new Button();
            txtUsuario = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCadastroNome
            // 
            txtCadastroNome.Location = new Point(37, 27);
            txtCadastroNome.Multiline = true;
            txtCadastroNome.Name = "txtCadastroNome";
            txtCadastroNome.Size = new Size(361, 37);
            txtCadastroNome.TabIndex = 0;
            txtCadastroNome.TextChanged += txtCadastroNome_TextChanged;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(193, 9);
            nome.Name = "nome";
            nome.Size = new Size(40, 15);
            nome.TabIndex = 1;
            nome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 97);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 2;
            label1.Text = "Telefone (00)00000-0000";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(37, 140);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(361, 37);
            txtTelefone.TabIndex = 3;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(632, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 199);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 5;
            label2.Text = "Crie uma senha";
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Location = new Point(37, 236);
            txtSenhaCadastro.Multiline = true;
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.Size = new Size(361, 37);
            txtSenhaCadastro.TabIndex = 6;
            txtSenhaCadastro.TextChanged += txtSenhaCadastro_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(170, 302);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 7;
            label3.Text = "redigite a senha";
            // 
            // txtRedigiteSenha
            // 
            txtRedigiteSenha.Location = new Point(37, 334);
            txtRedigiteSenha.Multiline = true;
            txtRedigiteSenha.Name = "txtRedigiteSenha";
            txtRedigiteSenha.Size = new Size(361, 37);
            txtRedigiteSenha.TabIndex = 8;
            txtRedigiteSenha.TextChanged += txtRedigiteSenha_TextChanged;
            // 
            // btnCadastro
            // 
            btnCadastro.Enabled = false;
            btnCadastro.Location = new Point(106, 394);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(220, 46);
            btnCadastro.TabIndex = 9;
            btnCadastro.Text = "Cadastro";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(427, 84);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(361, 37);
            txtUsuario.TabIndex = 10;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(586, 49);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 11;
            label4.Text = "Usuário";
            // 
            // pag_cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtUsuario);
            Controls.Add(btnCadastro);
            Controls.Add(txtRedigiteSenha);
            Controls.Add(label3);
            Controls.Add(txtSenhaCadastro);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(txtTelefone);
            Controls.Add(label1);
            Controls.Add(nome);
            Controls.Add(txtCadastroNome);
            Name = "pag_cadastro";
            Text = "pag_cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCadastroNome;
        private Label nome;
        private Label label1;
        private TextBox txtTelefone;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtSenhaCadastro;
        private Label label3;
        private TextBox txtRedigiteSenha;
        private Button btnCadastro;
        private TextBox txtUsuario;
        private Label label4;
    }
}