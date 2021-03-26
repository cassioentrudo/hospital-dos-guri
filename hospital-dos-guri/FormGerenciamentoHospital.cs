using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace hospital_dos_guri
{
    public partial class FormGerenciamentoHospital : Form
    {
        LocalDatabase db; 
        public FormGerenciamentoHospital()
        {
            InitializeComponent();
            this.db = new LocalDatabase();
        }

        private void btnOfertaLeito_Click(object sender, EventArgs e)
        {
            int userId = 1; //será obtido atráves do Id do usuário logado
            string query;
            int soma = (int)nupNumeroLeitos.Value;
            switch (cbTipoLeito.SelectedItem.ToString().Trim())
            {
                case "Leitos de Emergência":
                    query = $"UPDATE Hospital SET Emergencia = Emergencia + {soma} WHERE ( ID == {userId})";
                    break;
                case "Leitos de UTI Adulta":
                    query = $"UPDATE Hospital SET UTI_Adulto = UTI_Adulto + {soma} WHERE ( ID == {userId})";
                    break;
                case "Leitos de UTI Neonatal":
                    query = $"UPDATE Hospital SET UTI_Neonatal = UTI_Neonatal + {soma} WHERE ( ID == {userId})";
                    break;
                case "Leitos de UTI Pediatrica":
                    query = $"UPDATE Hospital SET UTI_Pediatrica = UTI_Pediatrica + {soma} WHERE ( ID == {userId})";
                    break;
                default:
                    query = "SELECT * FROM Hospital";
                    break;

            }
            this.db.UpdateQuery(query);
        }
    }
}
