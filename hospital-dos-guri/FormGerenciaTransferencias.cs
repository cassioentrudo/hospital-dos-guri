using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace hospital_dos_guri
{    enum ACAO
    {
        Aprovar,
        Rejeitar,
        Gerar_Relatorio
    }
    public partial class FormGerenciaTransferencias : Form
    {
        private Usuario CurrentUser;
        public FormGerenciaTransferencias(Usuario CurrentUser)
        {
            InitializeComponent();
            this.CurrentUser = CurrentUser;
            Tipos_de_Usuario userType = (Tipos_de_Usuario)CurrentUser.Tipo_Usuario;
            ContextMenuStrip contextResolverTransferencia = new ContextMenuStrip();
            if (userType == Tipos_de_Usuario.GOVERNO)
            {
                contextResolverTransferencia.Items.Add(nameof(ACAO.Aprovar));
                contextResolverTransferencia.Items.Add(nameof(ACAO.Rejeitar));
                contextResolverTransferencia.Items.Add(nameof(ACAO.Gerar_Relatorio));
            }
            else
            {
                contextResolverTransferencia.Items.Add(nameof(ACAO.Gerar_Relatorio));
            }
            
            
            contextResolverTransferencia.ItemClicked += ContextResolverTransferencia_ItemClicked;
            this.ContextMenuStrip = contextResolverTransferencia;
        }

        private void ContextResolverTransferencia_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Transferencias transferenciaSelecionada = (Transferencias)this.dgvTransferencias.CurrentRow.DataBoundItem;
            LocalDatabase db = new LocalDatabase();
            if (e.ClickedItem.Text == ACAO.Gerar_Relatorio.ToString())
            {
                string mensagemRelatorio;
                string query = $"SELECT Nome_Hospital FROM Hospital WHERE ID_HOspital == {transferenciaSelecionada.ID_Hospital_Origem} ";
                SQLiteDataReader sqlite_datareader = db.Query(query);
                sqlite_datareader.Read();
                string hospitalOrigem = (string)sqlite_datareader[nameof(Hospital.Nome_Hospital)];

                query = $"SELECT Nome_Hospital FROM Hospital WHERE ID_HOspital == {transferenciaSelecionada.ID_Hospital_Destino} ";
                sqlite_datareader = db.Query(query);
                sqlite_datareader.Read();
                string hospitalDestino = (string)sqlite_datareader[nameof(Hospital.Nome_Hospital)];


                mensagemRelatorio = $"A transferencia do {hospitalOrigem} para o {hospitalDestino}, envolvendo ";
                if (transferenciaSelecionada.UTI_Adulto > 0)
                    mensagemRelatorio += $" {transferenciaSelecionada.UTI_Adulto} vaga(s) de" +
                        $" {nameof(transferenciaSelecionada.UTI_Adulto)},";
                if (transferenciaSelecionada.UTI_Pediatrica > 0)
                    mensagemRelatorio += $" {transferenciaSelecionada.UTI_Pediatrica} vaga(s) de " +
                        $"{nameof(transferenciaSelecionada.UTI_Pediatrica)},";
                if (transferenciaSelecionada.UTI_Neonatal > 0)
                    mensagemRelatorio += $" {transferenciaSelecionada.UTI_Neonatal} vaga(s) de" +
                        $" {nameof(transferenciaSelecionada.UTI_Neonatal)},";
                if (transferenciaSelecionada.Emergencia > 0)
                    mensagemRelatorio += $" {transferenciaSelecionada.Emergencia} vaga(s) de " +
                        $"{nameof(transferenciaSelecionada.Emergencia)},";
                switch (transferenciaSelecionada.Status)
                {
                    case "p":
                        mensagemRelatorio += " encontra-se pendente.";
                        break;
                    case "r":
                        mensagemRelatorio += " foi rejeitada.";
                        break;
                    case "a":
                    default:
                        mensagemRelatorio += " foi aprovada.";
                        break;
                }
                string nomeArquivo = $"Relatorio_Transferencia_{transferenciaSelecionada.ID_Transferencia}.txt";
                File.WriteAllTextAsync(nomeArquivo, mensagemRelatorio);
            }
            else
            {
                if (transferenciaSelecionada.Status == "p")
                {
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
                }
            }
            this.FormGerenciaTransferencias_Load(null, null);

        }

        private void FormGerenciaTransferencias_Load(object sender, System.EventArgs e)
        {
            this.dgvTransferencias.DataSource = this.CurrentUser.PesquisaTransferencias();
            this.dgvTransferencias.Columns[nameof(Transferencias.Status)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
