using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class FormCadastro : Form
    {
        private readonly ErrorProvider errorProvider = new ErrorProvider();
        private readonly TextBox txtName = new TextBox();
        private readonly TextBox txtEmail = new TextBox();
        private readonly TextBox txtIdade = new TextBox();
        private readonly TextBox txtSenha = new TextBox();
        private readonly TextBox txtConfirmarSenha = new TextBox();
        private readonly CheckBox cbxTermosdeUso = new CheckBox();
        private readonly Button btnEnviar = new Button();
        private readonly Button btnClear = new Button();

        private FormCadastro()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            this.Text = "Formulário de Cadastro";
            this.ClientSize = new Size(350, 280);
            this.StartPosition = FormStartPosition.CenterScreen;

            int currentY = 20;
            const int spacing = 30;

            var lblName = new Label { Text = "Nome:", Location = new Point(20, currentY), AutoSize = true };
            txtName.Location = new Point(150, currentY);
            txtName.Width = 180;
            currentY += spacing;

            var lblEmail = new Label { Text = "E-mail:", Location = new Point(20, currentY), AutoSize = true };
            txtEmail.Location = new Point(150, currentY);
            txtEmail.Width = 180;
            currentY += spacing;

            var lblIdade = new Label { Text = "Idade:", Location = new Point(20, currentY), AutoSize = true };
            txtIdade.Location = new Point(150, currentY);
            txtIdade.Width = 50;
            currentY += spacing;

            var lblSenha = new Label { Text = "Senha:", Location = new Point(20, currentY), AutoSize = true };
            txtSenha.Location = new Point(150, currentY);
            txtSenha.Width = 180;
            txtSenha.PasswordChar = '*';
            currentY += spacing;

            var lblConfirmarSenha = new Label { Text = "Confirmar Senha:", Location = new Point(20, currentY), AutoSize = true };
            txtConfirmarSenha.Location = new Point(150, currentY);
            txtConfirmarSenha.Width = 180;
            txtConfirmarSenha.PasswordChar = '*';
            currentY += spacing;

            cbxTermosdeUso.Text = "Eu aceito os termos de uso.";
            cbxTermosdeUso.Location = new Point(20, currentY);
            cbxTermosdeUso.AutoSize = true;
            currentY += spacing;

            btnEnviar.Text = "Enviar";
            btnEnviar.Location = new Point(20, currentY);
            btnEnviar.Width = 100;

            btnClear.Text = "Limpar";
            btnClear.Location = new Point(150, currentY);
            btnClear.Width = 100;

            this.Controls.AddRange(new Control[] {
                lblName, txtName,
                lblEmail, txtEmail,
                lblIdade, txtIdade,
                lblSenha, txtSenha,
                lblConfirmarSenha, txtConfirmarSenha,
                cbxTermosdeUso,
                btnEnviar, btnClear
            });

            txtEmail.Leave += (sender, e) => ValidateEmail();
            txtSenha.Leave += (sender, e) => ValidatePassword();
            txtConfirmarSenha.Leave += (sender, e) => ValidateConfirmPassword();
            btnEnviar.Click += (sender, e) => ValidateForm();
            btnClear.Click += (sender, e) => ClearForm();
        }

        private void ValidateEmail()
        {
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorProvider.SetError(txtEmail, "E-mail inválido.");
            }
            else
            {
                errorProvider.SetError(txtEmail, string.Empty);
            }
        }

        private void ValidatePassword()
        {
            if (txtSenha.Text.Length < 6)
            {
                errorProvider.SetError(txtSenha, "A senha deve ter no mínimo 6 caracteres.");
            }
            else
            {
                errorProvider.SetError(txtSenha, string.Empty);
            }
        }

        private void ValidateConfirmPassword()
        {
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                errorProvider.SetError(txtConfirmarSenha, "As senhas não coincidem.");
            }
            else
            {
                errorProvider.SetError(txtConfirmarSenha, string.Empty);
            }
        }

        private void ValidateForm()
        {
            ValidateEmail();
            ValidatePassword();
            ValidateConfirmPassword();

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider.SetError(txtName, "Nome é obrigatório.");
            }
            else
            {
                errorProvider.SetError(txtName, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(txtIdade.Text) || !int.TryParse(txtIdade.Text, out int idade) || idade < 0)
            {
                errorProvider.SetError(txtIdade, "Idade inválida.");
            }
            else
            {
                errorProvider.SetError(txtIdade, string.Empty);
            }

            if (errorProvider.GetError(txtName) == "" &&
                errorProvider.GetError(txtEmail) == "" &&
                errorProvider.GetError(txtIdade) == "" &&
                errorProvider.GetError(txtSenha) == "" &&
                errorProvider.GetError(txtConfirmarSenha) == "" &&
                cbxTermosdeUso.Checked)
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!cbxTermosdeUso.Checked)
            {
                MessageBox.Show("Você deve aceitar os termos de uso.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Por favor, corrija os erros no formulário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtIdade.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
            cbxTermosdeUso.Checked = false;
            errorProvider.Clear();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCadastro());
        }
    }
}