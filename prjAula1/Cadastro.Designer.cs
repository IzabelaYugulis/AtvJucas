namespace prjAula1
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            lblLogin = new Label();
            txtNome = new TextBox();
            txtSenhaCadastro = new TextBox();
            txtCpfCadastro = new TextBox();
            txtDataNascimento = new TextBox();
            txtEmail = new TextBox();
            rbOutro = new RadioButton();
            rbFeminino = new RadioButton();
            rbMasculino = new RadioButton();
            btnCriarConta = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Agency FB", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.HotPink;
            lblLogin.Location = new Point(298, 32);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(156, 45);
            lblLogin.TabIndex = 16;
            lblLogin.Text = "CADASTRAR";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.ScrollBar;
            txtNome.Location = new Point(264, 116);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome Completo";
            txtNome.Size = new Size(217, 33);
            txtNome.TabIndex = 17;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaCadastro.ForeColor = SystemColors.ScrollBar;
            txtSenhaCadastro.Location = new Point(264, 194);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.PlaceholderText = "senha(6 digitos)";
            txtSenhaCadastro.Size = new Size(217, 33);
            txtSenhaCadastro.TabIndex = 19;
            // 
            // txtCpfCadastro
            // 
            txtCpfCadastro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfCadastro.ForeColor = SystemColors.ScrollBar;
            txtCpfCadastro.Location = new Point(264, 155);
            txtCpfCadastro.Name = "txtCpfCadastro";
            txtCpfCadastro.PlaceholderText = "CPF";
            txtCpfCadastro.Size = new Size(217, 33);
            txtCpfCadastro.TabIndex = 22;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataNascimento.ForeColor = SystemColors.ScrollBar;
            txtDataNascimento.Location = new Point(264, 233);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.PlaceholderText = "data de nascimento";
            txtDataNascimento.Size = new Size(217, 33);
            txtDataNascimento.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = SystemColors.ScrollBar;
            txtEmail.Location = new Point(264, 272);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email";
            txtEmail.Size = new Size(217, 33);
            txtEmail.TabIndex = 24;
            // 
            // rbOutro
            // 
            rbOutro.AutoSize = true;
            rbOutro.BackColor = Color.Transparent;
            rbOutro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbOutro.ForeColor = Color.DeepPink;
            rbOutro.Location = new Point(422, 339);
            rbOutro.Name = "rbOutro";
            rbOutro.Size = new Size(76, 29);
            rbOutro.TabIndex = 27;
            rbOutro.TabStop = true;
            rbOutro.Text = "outro";
            rbOutro.UseVisualStyleBackColor = false;
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.BackColor = Color.Transparent;
            rbFeminino.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbFeminino.ForeColor = Color.DeepPink;
            rbFeminino.Location = new Point(248, 339);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(105, 29);
            rbFeminino.TabIndex = 28;
            rbFeminino.TabStop = true;
            rbFeminino.Text = "feminino";
            rbFeminino.UseVisualStyleBackColor = false;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.BackColor = Color.Transparent;
            rbMasculino.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbMasculino.ForeColor = Color.DeepPink;
            rbMasculino.Location = new Point(248, 374);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(116, 29);
            rbMasculino.TabIndex = 29;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "masculino";
            rbMasculino.UseVisualStyleBackColor = false;
            // 
            // btnCriarConta
            // 
            btnCriarConta.BackColor = Color.DeepPink;
            btnCriarConta.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCriarConta.ForeColor = Color.White;
            btnCriarConta.Location = new Point(289, 420);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(165, 36);
            btnCriarConta.TabIndex = 30;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = false;
            btnCriarConta.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(536, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(725, 516);
            Controls.Add(pictureBox2);
            Controls.Add(btnCriarConta);
            Controls.Add(rbMasculino);
            Controls.Add(rbFeminino);
            Controls.Add(rbOutro);
            Controls.Add(txtEmail);
            Controls.Add(txtDataNascimento);
            Controls.Add(txtCpfCadastro);
            Controls.Add(txtSenhaCadastro);
            Controls.Add(txtNome);
            Controls.Add(lblLogin);
            Name = "Cadastro";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogin;
        private TextBox txtNome;
        private TextBox txtSenhaCadastro;
        private TextBox txtCpfCadastro;
        private TextBox txtDataNascimento;
        private TextBox txtEmail;
        private RadioButton rbOutro;
        private RadioButton rbFeminino;
        private RadioButton rbMasculino;
        private Button btnCriarConta;
        internal protected PictureBox pictureBox2;
    }
}