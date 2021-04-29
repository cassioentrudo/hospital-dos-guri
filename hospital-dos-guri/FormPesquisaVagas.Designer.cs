
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
            this.tbCep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.splitContainer1.Size = new System.Drawing.Size(986, 646);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelLeft.Controls.Add(this.tbCep);
            this.panelLeft.Controls.Add(this.label1);
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
            this.panelLeft.Size = new System.Drawing.Size(246, 646);
            this.panelLeft.TabIndex = 0;
            // 
            // tbCep
            // 
            this.tbCep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCep.Location = new System.Drawing.Point(5, 121);
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(234, 23);
            this.tbCep.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione o Tipo de Leito:";
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
            this.tbNomeHospital.Size = new System.Drawing.Size(234, 23);
            this.tbNomeHospital.TabIndex = 4;
            // 
            // tbCidadeHospital
            // 
            this.tbCidadeHospital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCidadeHospital.Location = new System.Drawing.Point(5, 77);
            this.tbCidadeHospital.Name = "tbCidadeHospital";
            this.tbCidadeHospital.Size = new System.Drawing.Size(234, 23);
            this.tbCidadeHospital.TabIndex = 3;
            // 
            // lbTipoLeito
            // 
            this.lbTipoLeito.AutoSize = true;
            this.lbTipoLeito.Location = new System.Drawing.Point(5, 103);
            this.lbTipoLeito.Name = "lbTipoLeito";
            this.lbTipoLeito.Size = new System.Drawing.Size(105, 15);
            this.lbTipoLeito.TabIndex = 2;
            this.lbTipoLeito.Text = "Selecione um CEP:";
            // 
            // cbTipoLeito
            // 
            this.cbTipoLeito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoLeito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoLeito.FormattingEnabled = true;
            this.cbTipoLeito.Location = new System.Drawing.Point(5, 163);
            this.cbTipoLeito.Name = "cbTipoLeito";
            this.cbTipoLeito.Size = new System.Drawing.Size(232, 23);
            this.cbTipoLeito.TabIndex = 1;
            this.cbTipoLeito.Tag = "";
            // 
            // btnBuscaHospitais
            // 
            this.btnBuscaHospitais.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBuscaHospitais.Location = new System.Drawing.Point(5, 603);
            this.btnBuscaHospitais.Name = "btnBuscaHospitais";
            this.btnBuscaHospitais.Size = new System.Drawing.Size(236, 38);
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
            this.panelAll.Size = new System.Drawing.Size(736, 646);
            this.panelAll.TabIndex = 1;
            // 
            // dgvHospitais
            // 
            this.dgvHospitais.AllowUserToAddRows = false;
            this.dgvHospitais.AllowUserToDeleteRows = false;
            this.dgvHospitais.AllowUserToResizeColumns = false;
            this.dgvHospitais.AllowUserToResizeRows = false;
            this.dgvHospitais.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvHospitais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHospitais.Location = new System.Drawing.Point(5, 5);
            this.dgvHospitais.MultiSelect = false;
            this.dgvHospitais.Name = "dgvHospitais";
            this.dgvHospitais.RowHeadersVisible = false;
            this.dgvHospitais.RowTemplate.Height = 25;
            this.dgvHospitais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospitais.Size = new System.Drawing.Size(726, 636);
            this.dgvHospitais.TabIndex = 0;
            // 
            // FormPesquisaVagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(986, 646);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.TextBox tbCep;
        private System.Windows.Forms.Label label1;
    }
}

