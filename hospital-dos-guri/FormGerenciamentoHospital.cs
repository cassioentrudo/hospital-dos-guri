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
    public partial class FormGerenciamentoHospital : System.Windows.Forms.Form
    {
        Hospital hospital;
        public FormGerenciamentoHospital(Hospital hosp)
        {
            InitializeComponent();
            this.hospital = hosp;
        }

        private void btnOfertaLeito_Click(object sender, EventArgs e)
        {
            int numVagas = (int)nupNumeroLeitos.Value;
            string tipoVagas = cbTipoLeito.SelectedItem.ToString().Trim();
            if (this.chbCancelarOferta.Checked)
                this.hospital.CancelarVagas(numVagas, tipoVagas);
            else
                this.hospital.OfertarVagas(numVagas, tipoVagas);


        }

        private void chbCancelarOferta_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbCancelarOferta.Checked)
                this.btnOfertaLeito.Text = "Cancelar Oferta de Leitos";
            else
                this.btnOfertaLeito.Text = "Ofertar Leitos";
        }
    }
}
