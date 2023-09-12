namespace prjAula1
{
    partial class Extra
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
            valorDeposito = new TextBox();
            btnDepositar = new Button();
            btnSaque = new Button();
            btnValorSaldo = new Button();
            lblSaldo = new Label();
            SuspendLayout();
            // 
            // valorDeposito
            // 
            valorDeposito.Location = new Point(12, 12);
            valorDeposito.Name = "valorDeposito";
            valorDeposito.Size = new Size(174, 23);
            valorDeposito.TabIndex = 0;
            valorDeposito.TextChanged += textBox1_TextChanged;
            // 
            // btnDepositar
            // 
            btnDepositar.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepositar.Location = new Point(12, 84);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(174, 36);
            btnDepositar.TabIndex = 1;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnSaque
            // 
            btnSaque.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaque.Location = new Point(12, 41);
            btnSaque.Name = "btnSaque";
            btnSaque.Size = new Size(174, 36);
            btnSaque.TabIndex = 2;
            btnSaque.Text = "Saque";
            btnSaque.UseVisualStyleBackColor = true;
            btnSaque.Click += button1_Click;
            // 
            // btnValorSaldo
            // 
            btnValorSaldo.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnValorSaldo.Location = new Point(12, 126);
            btnValorSaldo.Name = "btnValorSaldo";
            btnValorSaldo.Size = new Size(174, 36);
            btnValorSaldo.TabIndex = 3;
            btnValorSaldo.Text = "Mostrar Saldo";
            btnValorSaldo.UseVisualStyleBackColor = true;
            btnValorSaldo.Click += btnValorSaldo_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(12, 186);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(0, 15);
            lblSaldo.TabIndex = 5;
            // 
            // Extra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(197, 234);
            Controls.Add(lblSaldo);
            Controls.Add(btnValorSaldo);
            Controls.Add(btnSaque);
            Controls.Add(btnDepositar);
            Controls.Add(valorDeposito);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Extra";
            Text = "Extra";
            Load += Extra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox valorDeposito;
        private Button btnDepositar;
        private Button btnSaque;
        private Button btnValorSaldo;
        private Label lblSaldo;
    }
}