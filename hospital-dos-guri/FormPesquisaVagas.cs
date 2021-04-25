using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospital_dos_guri
{
    public partial class FormPesquisaVagas : System.Windows.Forms.Form
    {
        public FormPesquisaVagas()
        {
            InitializeComponent();
        }


        private void btnBuscaHospitais_Click(object sender, EventArgs e)
        {
            string tipoVagas = cbTipoLeito.SelectedItem.ToString().Trim();
            
            this.dgvHospitais.DataSource = Usuario.PesquisaVagas(tipoVagas);

            this.dgvHospitais.Columns[nameof(Hospital.Nome_Hospital)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
