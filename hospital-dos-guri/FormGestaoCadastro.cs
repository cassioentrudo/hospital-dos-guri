using System;
using System.Windows.Forms;

namespace hospital_dos_guri
{
    public partial class FormGestaoCadastro : Form
    {
        Governo governo;
        public FormGestaoCadastro(Governo gov)
        {
            this.governo = gov;
            InitializeComponent();
            this.dgvHospitais.DataSource = this.governo.ListaUsuariosPendentes();

            //this.dgvHospitais.Columns[nameof(Hospital.Nome_Hospital)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btAprova_Click(object sender, EventArgs e)
        {

            long id = (long)this.dgvHospitais.SelectedRows[0].Cells[0].Value;
            this.governo.ValidaCadastro(id, 'v');

            this.dgvHospitais.DataSource = this.governo.ListaUsuariosPendentes();

            //this.dgvHospitais.Columns[nameof(Hospital.Nome_Hospital)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btRejeita_Click(object sender, EventArgs e)
        {
            long id = (long)this.dgvHospitais.SelectedRows[0].Cells[0].Value;
            this.governo.ValidaCadastro(id, 'i');

            this.dgvHospitais.DataSource = this.governo.ListaUsuariosPendentes();

            //this.dgvHospitais.Columns[nameof(Hospital.Nome_Hospital)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }
    }
}
