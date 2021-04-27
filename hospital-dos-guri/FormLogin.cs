using System;
using System.Windows.Forms;

namespace hospital_dos_guri
{
    public partial class FormLogin : Form
    {

        public Usuario CurrentUser { get; set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;

            this.CurrentUser = new Usuario(this.tbUsuario.Text);

            if (this.CurrentUser.EfetuarLogin(this.tbSenha.Text) == false)
            {
                MessageBox.Show("Falha ao realizar Login. Verifique os dados digitados e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }

            this.Close();
        }

        private void llbSolicitaCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new FormSolicitaCadastro();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}