using System;
using System.Windows.Forms;

namespace hospital_dos_guri
{
    public partial class FormSolictaLeito : Form
    {
        public int Quantidade { get; set; } = 0;

        public FormSolictaLeito()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            this.Quantidade = (int)this.nudQuantidade.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
