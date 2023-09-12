namespace prjAula1
{
    partial class SenhaNova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenhaNova));
            lblSenhaNova = new Label();
            lblConfirmaSenhaNova = new Label();
            txtSenhaNova = new TextBox();
            txtConfirmaSenha = new TextBox();
            btnAlterarSenha = new Button();
            pictureBox2 = new PictureBox();
            lblLogin = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblSenhaNova
            // 
            lblSenhaNova.AutoSize = true;
            lblSenhaNova.BackColor = Color.Transparent;
            lblSenhaNova.Location = new Point(82, 165);
            lblSenhaNova.Name = "lblSenhaNova";
            lblSenhaNova.Size = new Size(110, 15);
            lblSenhaNova.TabIndex = 0;
            lblSenhaNova.Text = "Digite a senha nova";
            lblSenhaNova.Click += label1_Click;
            // 
            // lblConfirmaSenhaNova
            // 
            lblConfirmaSenhaNova.AutoSize = true;
            lblConfirmaSenhaNova.BackColor = Color.Transparent;
            lblConfirmaSenhaNova.Location = new Point(82, 239);
            lblConfirmaSenhaNova.Name = "lblConfirmaSenhaNova";
            lblConfirmaSenhaNova.Size = new Size(129, 15);
            lblConfirmaSenhaNova.TabIndex = 1;
            lblConfirmaSenhaNova.Text = "Confirme a senha nova";
            // 
            // txtSenhaNova
            // 
            txtSenhaNova.Location = new Point(82, 183);
            txtSenhaNova.Name = "txtSenhaNova";
            txtSenhaNova.Size = new Size(100, 23);
            txtSenhaNova.TabIndex = 2;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(82, 257);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.Size = new Size(100, 23);
            txtConfirmaSenha.TabIndex = 3;
            // 
            // btnAlterarSenha
            // 
            btnAlterarSenha.BackColor = Color.DeepPink;
            btnAlterarSenha.ForeColor = SystemColors.ButtonHighlight;
            btnAlterarSenha.Location = new Point(514, 392);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(105, 32);
            btnAlterarSenha.TabIndex = 4;
            btnAlterarSenha.Text = "Alterar Senha";
            btnAlterarSenha.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(254, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 59);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Agency FB", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.HotPink;
            lblLogin.Location = new Point(241, 93);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(175, 42);
            lblLogin.TabIndex = 40;
            lblLogin.Text = "ALTERAR SENHA";
            lblLogin.Click += lblLogin_Click;
            // 
            // SenhaNova
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Pink___Green_Gradient_Desktop_Wallpaper__1_;
            ClientSize = new Size(695, 506);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox2);
            Controls.Add(btnAlterarSenha);
            Controls.Add(txtConfirmaSenha);
            Controls.Add(txtSenhaNova);
            Controls.Add(lblConfirmaSenhaNova);
            Controls.Add(lblSenhaNova);
            Name = "SenhaNova";
            Text = "SenhaNova";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSenhaNova;
        private Label lblConfirmaSenhaNova;
        private TextBox txtSenhaNova;
        private TextBox txtConfirmaSenha;
        private Button btnAlterarSenha;
        internal protected PictureBox pictureBox2;
        private Label lblLogin;
    }
}