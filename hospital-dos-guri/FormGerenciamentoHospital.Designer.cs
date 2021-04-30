
namespace hospital_dos_guri
{
    partial class FormGerenciamentoHospital
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAll = new System.Windows.Forms.Panel();
            this.gbOfertaLeitos = new System.Windows.Forms.GroupBox();
            this.chbCancelarOferta = new System.Windows.Forms.CheckBox();
            this.lbNumeroLeitos = new System.Windows.Forms.Label();
            this.lbTipoLeito = new System.Windows.Forms.Label();
            this.btnOfertaLeito = new System.Windows.Forms.Button();
            this.nupNumeroLeitos = new System.Windows.Forms.NumericUpDown();
            this.cbTipoLeito = new System.Windows.Forms.ComboBox();
            this.panelAll.SuspendLayout();
            this.gbOfertaLeitos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroLeitos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.gbOfertaLeitos);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(0, 0);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(376, 274);
            this.panelAll.TabIndex = 0;
            // 
            // gbOfertaLeitos
            // 
            this.gbOfertaLeitos.Controls.Add(this.chbCancelarOferta);
            this.gbOfertaLeitos.Controls.Add(this.lbNumeroLeitos);
            this.gbOfertaLeitos.Controls.Add(this.lbTipoLeito);
            this.gbOfertaLeitos.Controls.Add(this.btnOfertaLeito);
            this.gbOfertaLeitos.Controls.Add(this.nupNumeroLeitos);
            this.gbOfertaLeitos.Controls.Add(this.cbTipoLeito);
            this.gbOfertaLeitos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOfertaLeitos.Location = new System.Drawing.Point(0, 0);
            this.gbOfertaLeitos.Name = "gbOfertaLeitos";
            this.gbOfertaLeitos.Size = new System.Drawing.Size(376, 274);
            this.gbOfertaLeitos.TabIndex = 0;
            this.gbOfertaLeitos.TabStop = false;
            this.gbOfertaLeitos.Text = "Ofertar/Cancelar Leitos";
            // 
            // chbCancelarOferta
            // 
            this.chbCancelarOferta.AutoSize = true;
            this.chbCancelarOferta.Location = new System.Drawing.Point(7, 149);
            this.chbCancelarOferta.Name = "chbCancelarOferta";
            this.chbCancelarOferta.Size = new System.Drawing.Size(158, 19);
            this.chbCancelarOferta.TabIndex = 5;
            this.chbCancelarOferta.Text = "Cancelar Oferta de Leitos";
            this.chbCancelarOferta.UseVisualStyleBackColor = true;
            this.chbCancelarOferta.CheckedChanged += new System.EventHandler(this.chbCancelarOferta_CheckedChanged);
            // 
            // lbNumeroLeitos
            // 
            this.lbNumeroLeitos.AutoSize = true;
            this.lbNumeroLeitos.Location = new System.Drawing.Point(7, 84);
            this.lbNumeroLeitos.Name = "lbNumeroLeitos";
            this.lbNumeroLeitos.Size = new System.Drawing.Size(246, 15);
            this.lbNumeroLeitos.TabIndex = 4;
            this.lbNumeroLeitos.Text = "Indique o número de leitos a serem ofertados";
            // 
            // lbTipoLeito
            // 
            this.lbTipoLeito.AutoSize = true;
            this.lbTipoLeito.Location = new System.Drawing.Point(7, 29);
            this.lbTipoLeito.Name = "lbTipoLeito";
            this.lbTipoLeito.Size = new System.Drawing.Size(208, 15);
            this.lbTipoLeito.TabIndex = 3;
            this.lbTipoLeito.Text = "Selecione o tipo de leito a ser ofertado";
            // 
            // btnOfertaLeito
            // 
            this.btnOfertaLeito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOfertaLeito.Location = new System.Drawing.Point(7, 208);
            this.btnOfertaLeito.Name = "btnOfertaLeito";
            this.btnOfertaLeito.Size = new System.Drawing.Size(360, 47);
            this.btnOfertaLeito.TabIndex = 2;
            this.btnOfertaLeito.Text = "Ofertar Leitos";
            this.btnOfertaLeito.UseVisualStyleBackColor = true;
            this.btnOfertaLeito.Click += new System.EventHandler(this.btnOfertaLeito_Click);
            // 
            // nupNumeroLeitos
            // 
            this.nupNumeroLeitos.Location = new System.Drawing.Point(7, 102);
            this.nupNumeroLeitos.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupNumeroLeitos.Name = "nupNumeroLeitos";
            this.nupNumeroLeitos.Size = new System.Drawing.Size(360, 23);
            this.nupNumeroLeitos.TabIndex = 1;
            // 
            // cbTipoLeito
            // 
            this.cbTipoLeito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoLeito.FormattingEnabled = true;
            this.cbTipoLeito.Items.AddRange(new object[] {
            "Emergencia",
            "UTI_Adulto",
            "UTI_Neonatal",
            "UTI_Pediatrica"});
            this.cbTipoLeito.Location = new System.Drawing.Point(7, 47);
            this.cbTipoLeito.Name = "cbTipoLeito";
            this.cbTipoLeito.Size = new System.Drawing.Size(361, 23);
            this.cbTipoLeito.TabIndex = 0;
            // 
            // FormGerenciamentoHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(376, 274);
            this.Controls.Add(this.panelAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGerenciamentoHospital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Hospital";
            this.panelAll.ResumeLayout(false);
            this.gbOfertaLeitos.ResumeLayout(false);
            this.gbOfertaLeitos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroLeitos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.GroupBox gbOfertaLeitos;
        private System.Windows.Forms.Label lbNumeroLeitos;
        private System.Windows.Forms.Label lbTipoLeito;
        private System.Windows.Forms.Button btnOfertaLeito;
        private System.Windows.Forms.NumericUpDown nupNumeroLeitos;
        private System.Windows.Forms.ComboBox cbTipoLeito;
        private System.Windows.Forms.CheckBox chbCancelarOferta;
    }
}