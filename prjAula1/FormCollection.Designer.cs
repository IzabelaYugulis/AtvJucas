namespace prjAula1
{
    partial class FormCollection
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
            txtId = new TextBox();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            btnListar = new Button();
            lstClientes = new ListBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 89);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(521, 23);
            txtNome.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(160, 133);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(98, 35);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(293, 133);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(98, 35);
            btnListar.TabIndex = 4;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(12, 192);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(521, 214);
            lstClientes.TabIndex = 5;
            // 
            // FormCollection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 425);
            Controls.Add(lstClientes);
            Controls.Add(btnListar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Name = "FormCollection";
            Text = " Cliente";
            Load += FormCollection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNome;
        private Button btnAdicionar;
        private Button btnListar;
        private ListBox lstClientes;
    }
}