using System.Windows.Forms;

namespace hospital_dos_guri
{
    public partial class FormMain : Form
    {
        private FormLogin formLogin;

        public FormMain()
        {
            InitializeComponent();

            this.formLogin = new FormLogin();
            DialogResult res = this.formLogin.ShowDialog();
            if (res != DialogResult.OK)
            {
                this.Close();
            }            
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            this.SetMode((Tipos_de_Usuario)this.formLogin.CurrentUser.Tipo_Usuario);
        }

        private void SetMode(Tipos_de_Usuario userType)
        {
            foreach (Control item in this.panelButtons.Controls)
            {
                item.Visible = false;
            }

            if (userType == Tipos_de_Usuario.GOVERNO)
            {
                this.btnGestaoCadastros.Visible = true;
                
            }
            else
            {
                this.btnSolicitarLeitos.Visible = true;
                this.btnOfertarLeitos.Visible = true;
            }
            this.btnGestaoTransferencias.Visible = true;
            this.btnClose.Visible = true;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnOfertarLeitos_Click(object sender, System.EventArgs e)
        {
            this.panelRight.Controls.Clear();

            Hospital hosp = new Hospital(this.formLogin.CurrentUser);
            FormGerenciamentoHospital formGerenciamentoHospital = new FormGerenciamentoHospital(hosp);
            formGerenciamentoHospital.TopLevel = false;
            formGerenciamentoHospital.AutoScroll = true;
            formGerenciamentoHospital.Dock = DockStyle.Fill;

            this.panelRight.Controls.Add(formGerenciamentoHospital);
            formGerenciamentoHospital.Show();
        }

        private void btnGestaoCadastros_Click(object sender, System.EventArgs e)
        {
            this.panelRight.Controls.Clear();

            Governo governo = new Governo(this.formLogin.CurrentUser);
            Form formGestaocadastro = new FormGestaoCadastro(governo);
            formGestaocadastro.TopLevel = false;
            formGestaocadastro.AutoScroll = true;
            formGestaocadastro.Dock = DockStyle.Fill;

            this.panelRight.Controls.Add(formGestaocadastro);
            formGestaocadastro.Show();
        }

        private void btnSolicitarLeitos_Click(object sender, System.EventArgs e)
        {
            this.panelRight.Controls.Clear();

            Hospital hosp = new Hospital(this.formLogin.CurrentUser);
            FormPesquisaVagas formPesquisaVagas = new FormPesquisaVagas(hosp);
            formPesquisaVagas.TopLevel = false;
            formPesquisaVagas.AutoScroll = true;
            formPesquisaVagas.Dock = DockStyle.Fill;

            this.panelRight.Controls.Add(formPesquisaVagas);
            formPesquisaVagas.Show();
        }

        private void btnGestaoTransferencias_Click(object sender, System.EventArgs e)
        {
            this.panelRight.Controls.Clear();

            FormGerenciaTransferencias formGerenciaTransferencias = new FormGerenciaTransferencias(this.formLogin.CurrentUser);
            formGerenciaTransferencias.TopLevel = false;
            formGerenciaTransferencias.AutoScroll = true;
            formGerenciaTransferencias.Dock = DockStyle.Fill;

            this.panelRight.Controls.Add(formGerenciaTransferencias);
            formGerenciaTransferencias.Show();
        }
    }
}