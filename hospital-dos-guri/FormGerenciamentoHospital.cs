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

            
            string mensagem = "Deseja Realizar outra Operação?";
            string legenda = "Operação Realizada com Sucesso";
            MessageBoxButtons bot = MessageBoxButtons.YesNo;
            DialogResult resultado;

           
            resultado = MessageBox.Show(mensagem, legenda, bot);
            if (resultado == System.Windows.Forms.DialogResult.No)
            {
                
                this.Close();
            }
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
