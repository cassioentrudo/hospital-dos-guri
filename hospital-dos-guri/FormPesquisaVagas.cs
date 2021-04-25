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

        }

        private void btnBuscaHospitais_Click(object sender, EventArgs e)
        {
            string tipoVagas = cbTipoLeito.SelectedItem.ToString().Trim();
            /*
            switch (cbTipoLeito.SelectedItem.ToString().Trim()) {
                case "Leitos de Emergência":
                    query = "SELECT * FROM Hospital WHERE ( Emergencia > 0)";
                    break;
                case "Leitos de UTI Adulta":
                    query = "SELECT * FROM Hospital WHERE ( UTI_Adulto > 0)";
                    break;
                case "Leitos de UTI Neonatal":
                    query = "SELECT * FROM Hospital WHERE ( UTI_Neonatal > 0)";
                    break;
                case "Leitos de UTI Pediatrica":
                    query = "SELECT * FROM Hospital WHERE ( UTI_Pediatrica > 0)";
                    break;
                case "Todos os Leitos":
                default:
                    query = "SELECT * FROM Hospital WHERE (UTI_Adulto > 0 OR UTI_Neonatal > 0 OR UTI_Pediatrica > 0 OR Emergencia > 0)";
                    break;

            }

            SQLiteDataReader sqlite_datareader = this.db.Query(query);

            BindingList<Hospital> hospitais = new BindingList<Hospital>();

            while (sqlite_datareader.Read())
            {
                Hospital hospital = new Hospital();
                hospital.ID_Hospital = (Int64)sqlite_datareader[nameof(Hospital.ID_Hospital)];
                hospital.Nome_Hospital = (string)sqlite_datareader[nameof(Hospital.Nome_Hospital)];
                hospital.Cidade = (string)sqlite_datareader[nameof(Hospital.Cidade)];
                hospital.CEP = (string)sqlite_datareader[nameof(Hospital.CEP)];
                hospital.UTI_Adulto = (Int64)sqlite_datareader[nameof(Hospital.UTI_Adulto)];
                hospital.UTI_Neonatal = (Int64)sqlite_datareader[nameof(Hospital.UTI_Neonatal)];
                hospital.UTI_Pediatrica = (Int64)sqlite_datareader[nameof(Hospital.UTI_Pediatrica)];
                hospital.Emergencia = (Int64)sqlite_datareader[nameof(Hospital.Emergencia)];

                hospitais.Add(hospital);
            }
            */
            this.dgvHospitais.DataSource = Usuario.PesquisaVagas(tipoVagas);

            this.dgvHospitais.Columns[nameof(Hospital.Nome_Hospital)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
