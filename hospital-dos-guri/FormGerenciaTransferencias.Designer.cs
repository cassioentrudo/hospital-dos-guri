
namespace hospital_dos_guri
{
    partial class FormGerenciaTransferencias
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
            this.dgvTransferencias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferencias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransferencias
            // 
            this.dgvTransferencias.AllowUserToAddRows = false;
            this.dgvTransferencias.AllowUserToDeleteRows = false;
            this.dgvTransferencias.AllowUserToResizeColumns = false;
            this.dgvTransferencias.AllowUserToResizeRows = false;
            this.dgvTransferencias.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvTransferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransferencias.Location = new System.Drawing.Point(0, 0);
            this.dgvTransferencias.MultiSelect = false;
            this.dgvTransferencias.Name = "dgvTransferencias";
            this.dgvTransferencias.RowHeadersVisible = false;
            this.dgvTransferencias.RowTemplate.Height = 25;
            this.dgvTransferencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransferencias.Size = new System.Drawing.Size(800, 450);
            this.dgvTransferencias.TabIndex = 1;
            // 
            // FormGerenciaTransferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTransferencias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGerenciaTransferencias";
            this.Text = "FormGerenciaTransferencias";
            this.Load += new System.EventHandler(this.FormGerenciaTransferencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransferencias;
    }
}