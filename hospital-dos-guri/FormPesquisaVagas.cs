using System;
using System.Windows.Forms;

namespace hospital_dos_guri
{
    public partial class FormPesquisaVagas : Form
    {
        private Hospital hospital;

        public FormPesquisaVagas(Hospital hospital)
        {
            InitializeComponent();

            this.cbTipoLeito.Items.Add(nameof(Hospital.UTI_Adulto));
            this.cbTipoLeito.Items.Add(nameof(Hospital.UTI_Neonatal));
            this.cbTipoLeito.Items.Add(nameof(Hospital.UTI_Pediatrica));
            this.cbTipoLeito.Items.Add(nameof(Hospital.Emergencia));

            ContextMenuStrip contextSolicita = new ContextMenuStrip();
            contextSolicita.Items.Add("Solicitar vaga de leito...");
            contextSolicita.ItemClicked += ContextSolicita_ItemClicked; ;
            this.ContextMenuStrip = contextSolicita;

            this.cbTipoLeito.SelectedIndex = 0;
            this.hospital = hospital;
        }

        private void ContextSolicita_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                FormSolictaLeito formSolicitaLeito = new FormSolictaLeito();
                DialogResult res = formSolicitaLeito.ShowDialog();

                if (res != DialogResult.OK)
                {
                    return;
                }

                string tipo_leito = this.cbTipoLeito.Text;
                int vagasnecessarias = formSolicitaLeito.Quantidade;
                Hospital hospitalDestino = (Hospital)this.dgvHospitais.CurrentRow.DataBoundItem;

                string query = $"Insert into Transferencias ({nameof(Transferencias.ID_Hospital_Origem)}, {nameof(Transferencias.ID_Hospital_Destino)}, {tipo_leito} , Status) VALUES ({this.hospital.ID_Hospital}, {hospitalDestino.ID_Hospital}, {vagasnecessarias}, 'p')";

                LocalDatabase db = new LocalDatabase();
                db.UpdateQuery(query);
                db.Close();

                MessageBox.Show("Solicitação efetuada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao realizar solicitação.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnBuscaHospitais_Click(object sender, EventArgs e)
        {
            if (cbTipoLeito.SelectedItem == null)
            {
                return;
            }

            string tipoVagas = cbTipoLeito.SelectedItem.ToString().Trim();
            
            this.dgvHospitais.DataSource = Usuario.PesquisaVagas(tipoVagas, tbNomeHospital.Text, tbCep.Text, tbCidadeHospital.Text);

            this.dgvHospitais.Columns[nameof(Hospital.ID_Hospital)].Visible = false;
            this.dgvHospitais.Columns[nameof(Hospital.ID_Usuario)].Visible = false;
            this.dgvHospitais.Columns[nameof(Hospital.Nome_Usuario)].Visible = false;
            this.dgvHospitais.Columns[nameof(Hospital.Tipo_Usuario)].Visible = false;

            this.dgvHospitais.Columns[nameof(Hospital.Nome_Hospital)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
