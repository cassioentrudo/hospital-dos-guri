using System;
using System.Windows.Forms;

namespace hospital_dos_guri
{
    public partial class FormSolicitaCadastro : Form
    {
        public FormSolicitaCadastro()
        {
            InitializeComponent();
        }

        private void btSolicitaCadastro_Click(object sender, EventArgs e)
        {
            string nomeHosp = this.tbHospital.Text;
            string nomeUsu = this.tbUsuario.Text;
            string CEP = this.tbCEP.Text;
            string cidade = this.tbCidade.Text;
            string senha = this.tbSenha.Text;
            Hospital.SolicitaCadastro(nomeUsu,nomeHosp,senha,CEP,cidade);
            string mensagem = "Solicitação de Cadastro Enviada";
            string legenda = "Sua Solicitação de Cadastro foi enviada com Sucesso!";
            MessageBoxButtons bot = MessageBoxButtons.OK;
            DialogResult resultado;


            resultado = MessageBox.Show(mensagem, legenda, bot);
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
