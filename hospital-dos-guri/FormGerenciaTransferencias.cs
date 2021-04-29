using System.Windows.Forms;

namespace hospital_dos_guri
{    enum ACAO
    {
        Aprovar,
        Rejeitar
    }
    public partial class FormGerenciaTransferencias : Form
    {
        public FormGerenciaTransferencias()
        {
            InitializeComponent();

            ContextMenuStrip contextResolverTransferencia = new ContextMenuStrip();
            contextResolverTransferencia.Items.Add(nameof(ACAO.Aprovar));
            contextResolverTransferencia.Items.Add(nameof(ACAO.Rejeitar));
            contextResolverTransferencia.ItemClicked += ContextResolverTransferencia_ItemClicked;
            this.ContextMenuStrip = contextResolverTransferencia;
        }

        private void ContextResolverTransferencia_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Transferencias transferenciaSelecionada = (Transferencias)this.dgvTransferencias.CurrentRow.DataBoundItem;
            LocalDatabase db = new LocalDatabase();

            //se aprovar, decrementa vagas do hospital de origem. Todas serão 0, exceto as que foram solicitadas realmente.
            if (e.ClickedItem.Text == ACAO.Aprovar.ToString())
            {
                //atualiza contagem de vagas no hospital destino
                string queryLeitos = $"UPDATE Hospital SET {nameof(Hospital.UTI_Pediatrica)} = {nameof(Hospital.UTI_Pediatrica)} - {transferenciaSelecionada.UTI_Pediatrica}, " +
                    $"{nameof(Hospital.UTI_Adulto)} = {nameof(Hospital.UTI_Adulto)} - {transferenciaSelecionada.UTI_Adulto}, " +
                    $"{nameof(Hospital.UTI_Neonatal)} = {nameof(Hospital.UTI_Neonatal)} - {transferenciaSelecionada.UTI_Neonatal}, " +
                    $"{nameof(Hospital.Emergencia)} ={nameof(Hospital.Emergencia)} - {transferenciaSelecionada.Emergencia} " +
                    $"WHERE {nameof(Hospital.ID_Hospital)} == {transferenciaSelecionada.ID_Hospital_Destino}";

                db.UpdateQuery(queryLeitos);
            }

            string novoStatus = e.ClickedItem.Text == ACAO.Aprovar.ToString() ? "a" : "r";
            string query = $"UPDATE {nameof(Transferencias)} SET {nameof(Transferencias.Status)} = '{novoStatus}'  WHERE {nameof(Transferencias.ID_Transferencia)} = {transferenciaSelecionada.ID_Transferencia} ";
            db.UpdateQuery(query);

            this.FormGerenciaTransferencias_Load(null, null);

        }

        private void FormGerenciaTransferencias_Load(object sender, System.EventArgs e)
        {
            this.dgvTransferencias.DataSource = Usuario.PesquisaTransferenciasPendentes();
            this.dgvTransferencias.Columns[nameof(Transferencias.Status)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
