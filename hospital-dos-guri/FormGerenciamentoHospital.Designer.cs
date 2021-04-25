
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbOfertaLeitos = new System.Windows.Forms.GroupBox();
            this.lbNumeroLeitos = new System.Windows.Forms.Label();
            this.lbTipoLeito = new System.Windows.Forms.Label();
            this.btnOfertaLeito = new System.Windows.Forms.Button();
            this.nupNumeroLeitos = new System.Windows.Forms.NumericUpDown();
            this.cbTipoLeito = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbSolicitacaoTransferencia = new System.Windows.Forms.GroupBox();
            this.chbCancelarOferta = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.gbOfertaLeitos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroLeitos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbOfertaLeitos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 301);
            this.panel1.TabIndex = 0;
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
            this.gbOfertaLeitos.Size = new System.Drawing.Size(390, 301);
            this.gbOfertaLeitos.TabIndex = 0;
            this.gbOfertaLeitos.TabStop = false;
            this.gbOfertaLeitos.Text = "Ofertar/Cancelar Leitos";
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
            this.btnOfertaLeito.Location = new System.Drawing.Point(6, 235);
            this.btnOfertaLeito.Name = "btnOfertaLeito";
            this.btnOfertaLeito.Size = new System.Drawing.Size(361, 47);
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
            "Leitos de Emergência",
            "",
            "Leitos de UTI Adulta",
            "",
            "Leitos de UTI Neonatal",
            "",
            "Leitos de UTI Pediatrica"});
            this.cbTipoLeito.Location = new System.Drawing.Point(7, 47);
            this.cbTipoLeito.Name = "cbTipoLeito";
            this.cbTipoLeito.Size = new System.Drawing.Size(361, 23);
            this.cbTipoLeito.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbSolicitacaoTransferencia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(390, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 301);
            this.panel2.TabIndex = 1;
            // 
            // gbSolicitacaoTransferencia
            // 
            this.gbSolicitacaoTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSolicitacaoTransferencia.Location = new System.Drawing.Point(6, 0);
            this.gbSolicitacaoTransferencia.Name = "gbSolicitacaoTransferencia";
            this.gbSolicitacaoTransferencia.Size = new System.Drawing.Size(394, 295);
            this.gbSolicitacaoTransferencia.TabIndex = 0;
            this.gbSolicitacaoTransferencia.TabStop = false;
            this.gbSolicitacaoTransferencia.Text = "Solicitação de Transferência";
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
            // FormGerenciamentoHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 301);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormGerenciamentoHospital";
            this.Text = "Gerenciamento de Hospital";
            this.panel1.ResumeLayout(false);
            this.gbOfertaLeitos.ResumeLayout(false);
            this.gbOfertaLeitos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroLeitos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbOfertaLeitos;
        private System.Windows.Forms.Label lbNumeroLeitos;
        private System.Windows.Forms.Label lbTipoLeito;
        private System.Windows.Forms.Button btnOfertaLeito;
        private System.Windows.Forms.NumericUpDown nupNumeroLeitos;
        private System.Windows.Forms.ComboBox cbTipoLeito;
        private System.Windows.Forms.GroupBox gbSolicitacaoTransferencia;
        private System.Windows.Forms.CheckBox chbCancelarOferta;
    }
}