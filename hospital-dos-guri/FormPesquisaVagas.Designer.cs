
namespace hospital_dos_guri
{
    partial class FormPesquisaVagas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lbCidadeHospital = new System.Windows.Forms.Label();
            this.lbNomeHospital = new System.Windows.Forms.Label();
            this.tbNomeHospital = new System.Windows.Forms.TextBox();
            this.tbCidadeHospital = new System.Windows.Forms.TextBox();
            this.lbTipoLeito = new System.Windows.Forms.Label();
            this.cbTipoLeito = new System.Windows.Forms.ComboBox();
            this.btnBuscaHospitais = new System.Windows.Forms.Button();
            this.panelAll = new System.Windows.Forms.Panel();
            this.dgvHospitais = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitais)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelAll);
            this.splitContainer1.Size = new System.Drawing.Size(693, 420);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.lbCidadeHospital);
            this.panelLeft.Controls.Add(this.lbNomeHospital);
            this.panelLeft.Controls.Add(this.tbNomeHospital);
            this.panelLeft.Controls.Add(this.tbCidadeHospital);
            this.panelLeft.Controls.Add(this.lbTipoLeito);
            this.panelLeft.Controls.Add(this.cbTipoLeito);
            this.panelLeft.Controls.Add(this.btnBuscaHospitais);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft.Size = new System.Drawing.Size(173, 420);
            this.panelLeft.TabIndex = 0;
            // 
            // lbCidadeHospital
            // 
            this.lbCidadeHospital.AutoSize = true;
            this.lbCidadeHospital.Location = new System.Drawing.Point(5, 59);
            this.lbCidadeHospital.Name = "lbCidadeHospital";
            this.lbCidadeHospital.Size = new System.Drawing.Size(169, 15);
            this.lbCidadeHospital.TabIndex = 6;
            this.lbCidadeHospital.Text = "Insira uma Cidade para buscar:";
            // 
            // lbNomeHospital
            // 
            this.lbNomeHospital.AutoSize = true;
            this.lbNomeHospital.Location = new System.Drawing.Point(5, 9);
            this.lbNomeHospital.Name = "lbNomeHospital";
            this.lbNomeHospital.Size = new System.Drawing.Size(170, 15);
            this.lbNomeHospital.TabIndex = 5;
            this.lbNomeHospital.Text = "Insira um Hospital para buscar:";
            // 
            // tbNomeHospital
            // 
            this.tbNomeHospital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomeHospital.Location = new System.Drawing.Point(5, 27);
            this.tbNomeHospital.Name = "tbNomeHospital";
            this.tbNomeHospital.Size = new System.Drawing.Size(163, 23);
            this.tbNomeHospital.TabIndex = 4;
            // 
            // tbCidadeHospital
            // 
            this.tbCidadeHospital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCidadeHospital.Location = new System.Drawing.Point(5, 77);
            this.tbCidadeHospital.Name = "tbCidadeHospital";
            this.tbCidadeHospital.Size = new System.Drawing.Size(163, 23);
            this.tbCidadeHospital.TabIndex = 3;
            // 
            // lbTipoLeito
            // 
            this.lbTipoLeito.AutoSize = true;
            this.lbTipoLeito.Location = new System.Drawing.Point(5, 103);
            this.lbTipoLeito.Name = "lbTipoLeito";
            this.lbTipoLeito.Size = new System.Drawing.Size(141, 15);
            this.lbTipoLeito.TabIndex = 2;
            this.lbTipoLeito.Text = "Selecione o Tipo de Leito:";
            // 
            // cbTipoLeito
            // 
            this.cbTipoLeito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoLeito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoLeito.FormattingEnabled = true;
            this.cbTipoLeito.Items.AddRange(new object[] {
            "Leitos de Emergência",
            "Leitos de UTI Adulta",
            "Leitos de UTI Neonatal",
            "Leitos de UTI Pediatrica",
            "Todos os Leitos"});
            this.cbTipoLeito.Location = new System.Drawing.Point(5, 121);
            this.cbTipoLeito.Name = "cbTipoLeito";
            this.cbTipoLeito.Size = new System.Drawing.Size(163, 23);
            this.cbTipoLeito.TabIndex = 1;
            this.cbTipoLeito.Tag = "";
            // 
            // btnBuscaHospitais
            // 
            this.btnBuscaHospitais.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBuscaHospitais.Location = new System.Drawing.Point(5, 377);
            this.btnBuscaHospitais.Name = "btnBuscaHospitais";
            this.btnBuscaHospitais.Size = new System.Drawing.Size(163, 38);
            this.btnBuscaHospitais.TabIndex = 0;
            this.btnBuscaHospitais.Text = "Pesquisar Vagas";
            this.btnBuscaHospitais.UseVisualStyleBackColor = true;
            this.btnBuscaHospitais.Click += new System.EventHandler(this.btnBuscaHospitais_Click);
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.dgvHospitais);
            this.panelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAll.Location = new System.Drawing.Point(0, 0);
            this.panelAll.Name = "panelAll";
            this.panelAll.Padding = new System.Windows.Forms.Padding(5);
            this.panelAll.Size = new System.Drawing.Size(516, 420);
            this.panelAll.TabIndex = 1;
            // 
            // dgvHospitais
            // 
            this.dgvHospitais.AllowUserToAddRows = false;
            this.dgvHospitais.AllowUserToDeleteRows = false;
            this.dgvHospitais.AllowUserToResizeColumns = false;
            this.dgvHospitais.AllowUserToResizeRows = false;
            this.dgvHospitais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHospitais.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvHospitais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitais.Location = new System.Drawing.Point(3, 5);
            this.dgvHospitais.MultiSelect = false;
            this.dgvHospitais.Name = "dgvHospitais";
            this.dgvHospitais.RowHeadersVisible = false;
            this.dgvHospitais.RowTemplate.Height = 25;
            this.dgvHospitais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospitais.Size = new System.Drawing.Size(508, 410);
            this.dgvHospitais.TabIndex = 0;
            // 
            // FormPesquisaVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 420);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormPesquisaVagas";
            this.Text = "Gerenciador de Vagas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnBuscaHospitais;
        private System.Windows.Forms.DataGridView dgvHospitais;
        private System.Windows.Forms.Label lbTipoLeito;
        private System.Windows.Forms.ComboBox cbTipoLeito;
        private System.Windows.Forms.Label lbCidadeHospital;
        private System.Windows.Forms.Label lbNomeHospital;
        private System.Windows.Forms.TextBox tbNomeHospital;
        private System.Windows.Forms.TextBox tbCidadeHospital;
    }
}

