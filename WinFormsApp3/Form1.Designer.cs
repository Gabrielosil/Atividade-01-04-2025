namespace WinFormsApp3
{
    partial class Form1
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtIdade = new TextBox();
            txtSenha = new TextBox();
            txtConfirmarSenha = new TextBox();
            cbxTermosdeUso = new CheckBox();
            btnEnviar = new Button();
            btnClear = new Button();
            lblName = new Label();
            lblEmail = new Label();
            lblIdade = new Label();
            lblSenha = new Label();
            lblConfirmarSenha = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(339, 119);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(339, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(339, 177);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(339, 206);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 3;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(339, 235);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(100, 23);
            txtConfirmarSenha.TabIndex = 4;
            // 
            // cbxTermosdeUso
            // 
            cbxTermosdeUso.AutoSize = true;
            cbxTermosdeUso.Location = new Point(343, 275);
            cbxTermosdeUso.Name = "cbxTermosdeUso";
            cbxTermosdeUso.Size = new Size(103, 19);
            cbxTermosdeUso.TabIndex = 6;
            cbxTermosdeUso.Text = "Termos de Uso";
            cbxTermosdeUso.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(314, 314);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 7;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(406, 314);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Limpar";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(279, 120);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 15);
            lblName.TabIndex = 9;
            lblName.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(279, 156);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "E-mail";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(280, 185);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(36, 15);
            lblIdade.TabIndex = 11;
            lblIdade.Text = "Idade";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(280, 209);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 12;
            lblSenha.Text = "Senha";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(237, 238);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(96, 15);
            lblConfirmarSenha.TabIndex = 13;
            lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblIdade);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(btnClear);
            Controls.Add(btnEnviar);
            Controls.Add(cbxTermosdeUso);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtIdade);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtIdade;
        private TextBox txtSenha;
        private TextBox txtConfirmarSenha;
        private CheckBox cbxTermosdeUso;
        private Button btnEnviar;
        private Button btnClear;
        private Label lblName;
        private Label lblEmail;
        private Label lblIdade;
        private Label lblSenha;
        private Label lblConfirmarSenha;
    }
}
