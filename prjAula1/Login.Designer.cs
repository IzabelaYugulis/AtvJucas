namespace prjAula1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtSenha = new TextBox();
            txtcpf = new TextBox();
            aqui = new Label();
            lblLogin = new Label();
            btnEsqueceuSenha = new Button();
            btnCadastrar = new Button();
            lblMensagem = new Label();
            label2 = new Label();
            btnacessar = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(285, 217);
            txtSenha.MaxLength = 6;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "senha";
            txtSenha.Size = new Size(133, 33);
            txtSenha.TabIndex = 0;
            // 
            // txtcpf
            // 
            txtcpf.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtcpf.ForeColor = SystemColors.ScrollBar;
            txtcpf.Location = new Point(285, 173);
            txtcpf.MaxLength = 11;
            txtcpf.Name = "txtcpf";
            txtcpf.PlaceholderText = "usuario";
            txtcpf.Size = new Size(133, 33);
            txtcpf.TabIndex = 1;
            txtcpf.TextChanged += textBox2_TextChanged;
            // 
            // aqui
            // 
            aqui.AutoSize = true;
            aqui.Location = new Point(347, 199);
            aqui.Name = "aqui";
            aqui.Size = new Size(0, 15);
            aqui.TabIndex = 3;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Agency FB", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.HotPink;
            lblLogin.Location = new Point(317, 128);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(76, 42);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "LOGIN";
            lblLogin.Click += label1_Click;
            // 
            // btnEsqueceuSenha
            // 
            btnEsqueceuSenha.BackColor = Color.DeepPink;
            btnEsqueceuSenha.BackgroundImageLayout = ImageLayout.None;
            btnEsqueceuSenha.Cursor = Cursors.Hand;
            btnEsqueceuSenha.FlatStyle = FlatStyle.Flat;
            btnEsqueceuSenha.ForeColor = SystemColors.ButtonFace;
            btnEsqueceuSenha.Location = new Point(266, 340);
            btnEsqueceuSenha.Name = "btnEsqueceuSenha";
            btnEsqueceuSenha.Size = new Size(178, 23);
            btnEsqueceuSenha.TabIndex = 6;
            btnEsqueceuSenha.Text = "Esqueceu a senha?";
            btnEsqueceuSenha.UseVisualStyleBackColor = false;
            btnEsqueceuSenha.Click += button2_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.DeepPink;
            btnCadastrar.BackgroundImageLayout = ImageLayout.None;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.ForeColor = SystemColors.ButtonFace;
            btnCadastrar.Location = new Point(266, 369);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(178, 23);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar-se";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += button3_Click;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.ForeColor = SystemColors.ControlLightLight;
            lblMensagem.Location = new Point(314, 419);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 15);
            lblMensagem.TabIndex = 9;
            lblMensagem.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.HotPink;
            label2.Location = new Point(319, 523);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 10;
            label2.Text = "JUKA'S BANK";
            label2.Click += label2_Click_2;
            // 
            // btnacessar
            // 
            btnacessar.BackColor = Color.DeepPink;
            btnacessar.BackgroundImageLayout = ImageLayout.None;
            btnacessar.Cursor = Cursors.Hand;
            btnacessar.FlatStyle = FlatStyle.Flat;
            btnacessar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnacessar.ForeColor = SystemColors.ButtonFace;
            btnacessar.Location = new Point(306, 275);
            btnacessar.Name = "btnacessar";
            btnacessar.Size = new Size(100, 39);
            btnacessar.TabIndex = 11;
            btnacessar.Text = "Acessar";
            btnacessar.UseVisualStyleBackColor = false;
            btnacessar.Click += button1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(209, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(293, 113);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(714, 559);
            Controls.Add(pictureBox2);
            Controls.Add(btnacessar);
            Controls.Add(label2);
            Controls.Add(lblMensagem);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEsqueceuSenha);
            Controls.Add(lblLogin);
            Controls.Add(aqui);
            Controls.Add(txtcpf);
            Controls.Add(txtSenha);
            Cursor = Cursors.Hand;
            Name = "Form1";
            Text = "Tela Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSenha;
        private TextBox txtcpf;
        private Label aqui;
        private Label lblLogin;
        private Button btnEsqueceuSenha;
        private Button btnCadastrar;
        private Label lblMensagem;
        private Label label2;
        private Button btnacessar;
        internal protected PictureBox pictureBox2;
    }
}