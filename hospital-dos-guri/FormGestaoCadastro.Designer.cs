
namespace hospital_dos_guri
{
    partial class FormGestaoCadastro
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
            this.gbGestaoCadastro = new System.Windows.Forms.GroupBox();
            this.dgvHospitais = new System.Windows.Forms.DataGridView();
            this.btRejeita = new System.Windows.Forms.Button();
            this.btAprova = new System.Windows.Forms.Button();
            this.gbGestaoCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitais)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGestaoCadastro
            // 
            this.gbGestaoCadastro.Controls.Add(this.dgvHospitais);
            this.gbGestaoCadastro.Location = new System.Drawing.Point(3, 3);
            this.gbGestaoCadastro.Name = "gbGestaoCadastro";
            this.gbGestaoCadastro.Size = new System.Drawing.Size(795, 442);
            this.gbGestaoCadastro.TabIndex = 0;
            this.gbGestaoCadastro.TabStop = false;
            this.gbGestaoCadastro.Text = "Gestao de Cadastros";
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
            this.dgvHospitais.Location = new System.Drawing.Point(9, 22);
            this.dgvHospitais.MultiSelect = false;
            this.dgvHospitais.Name = "dgvHospitais";
            this.dgvHospitais.RowHeadersVisible = false;
            this.dgvHospitais.RowTemplate.Height = 25;
            this.dgvHospitais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospitais.Size = new System.Drawing.Size(780, 406);
            this.dgvHospitais.TabIndex = 1;
            // 
            // btRejeita
            // 
            this.btRejeita.Location = new System.Drawing.Point(12, 460);
            this.btRejeita.Name = "btRejeita";
            this.btRejeita.Size = new System.Drawing.Size(283, 38);
            this.btRejeita.TabIndex = 1;
            this.btRejeita.Text = "Rejeitar Selecionado";
            this.btRejeita.UseVisualStyleBackColor = true;
            this.btRejeita.Click += new System.EventHandler(this.btRejeita_Click);
            // 
            // btAprova
            // 
            this.btAprova.Location = new System.Drawing.Point(514, 462);
            this.btAprova.Name = "btAprova";
            this.btAprova.Size = new System.Drawing.Size(274, 35);
            this.btAprova.TabIndex = 2;
            this.btAprova.Text = "Aprovar Selecionado";
            this.btAprova.UseVisualStyleBackColor = true;
            this.btAprova.Click += new System.EventHandler(this.btAprova_Click);
            // 
            // FormGestaoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.btAprova);
            this.Controls.Add(this.btRejeita);
            this.Controls.Add(this.gbGestaoCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestaoCadastro";
            this.Text = "Gestão de Cadastros";
            this.gbGestaoCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGestaoCadastro;
        private System.Windows.Forms.DataGridView dgvHospitais;
        private System.Windows.Forms.Button btRejeita;
        private System.Windows.Forms.Button btAprova;
    }
}