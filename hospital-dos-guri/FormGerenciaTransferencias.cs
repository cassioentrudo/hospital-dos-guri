using System.Windows.Forms;

namespace hospital_dos_guri
{
    public partial class FormGerenciaTransferencias : Form
    {
        public FormGerenciaTransferencias()
        {
            InitializeComponent();
        }

        private void FormGerenciaTransferencias_Load(object sender, System.EventArgs e)
        {
            this.dgvTransferencias.DataSource = Usuario.PesquisaTransferenciasPendentes();
            this.dgvTransferencias.Columns[nameof(Transferencias.Status)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
