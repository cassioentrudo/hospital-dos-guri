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
    public partial class FormMain : Form
    {
        LocalDatabase db;

        public FormMain()
        {
            InitializeComponent();

            this.db = new LocalDatabase();
        }

        private void btnBuscaHospitais_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Hospital";

            SQLiteDataReader sqlite_datareader = this.db.Query(query);

            BindingList<Hospital> hospitais = new BindingList<Hospital>();

            while (sqlite_datareader.Read())
            {
                Hospital hospital = new Hospital();
                hospital.id = (Int64)sqlite_datareader[nameof(Hospital.id)];
                hospital.Nome = (string)sqlite_datareader[nameof(Hospital.Nome)];
                hospital.Cidade = (string)sqlite_datareader[nameof(Hospital.Cidade)];
                hospital.CEP = (string)sqlite_datareader[nameof(Hospital.CEP)];
                hospital.UTI_Adulto = (Int64)sqlite_datareader[nameof(Hospital.UTI_Adulto)];
                hospital.UTI_Neonatal = (Int64)sqlite_datareader[nameof(Hospital.UTI_Neonatal)];
                hospital.UTI_Pediatrica = (Int64)sqlite_datareader[nameof(Hospital.UTI_Pediatrica)];
                hospital.Emergencia = (Int64)sqlite_datareader[nameof(Hospital.Emergencia)];

                hospitais.Add(hospital);
            }

            this.dgvHospitais.DataSource = hospitais;

            this.dgvHospitais.Columns[nameof(Hospital.Nome)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
