
namespace hospital_dos_guri
{
    partial class FormMain
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
            this.panelLeft.Controls.Add(this.btnBuscaHospitais);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft.Size = new System.Drawing.Size(173, 420);
            this.panelLeft.TabIndex = 0;
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
            this.dgvHospitais.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvHospitais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHospitais.Location = new System.Drawing.Point(5, 5);
            this.dgvHospitais.MultiSelect = false;
            this.dgvHospitais.Name = "dgvHospitais";
            this.dgvHospitais.RowHeadersVisible = false;
            this.dgvHospitais.RowTemplate.Height = 25;
            this.dgvHospitais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospitais.Size = new System.Drawing.Size(506, 410);
            this.dgvHospitais.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 420);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.Text = "Gerenciador de Vagas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
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
    }
}

