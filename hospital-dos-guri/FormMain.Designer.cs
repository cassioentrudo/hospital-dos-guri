
namespace hospital_dos_guri
{
    partial class FormMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGestaoTransferencias = new System.Windows.Forms.Button();
            this.btnGestaoCadastros = new System.Windows.Forms.Button();
            this.btnSolicitarLeitos = new System.Windows.Forms.Button();
            this.btnOfertarLeitos = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelButtons);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelRight);
            this.splitContainer1.Size = new System.Drawing.Size(1165, 637);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Controls.Add(this.btnGestaoTransferencias);
            this.panelButtons.Controls.Add(this.btnGestaoCadastros);
            this.panelButtons.Controls.Add(this.btnSolicitarLeitos);
            this.panelButtons.Controls.Add(this.btnOfertarLeitos);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(5);
            this.panelButtons.Size = new System.Drawing.Size(248, 635);
            this.panelButtons.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.Location = new System.Drawing.Point(5, 555);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(236, 73);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "SAIR";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGestaoTransferencias
            // 
            this.btnGestaoTransferencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestaoTransferencias.Location = new System.Drawing.Point(5, 224);
            this.btnGestaoTransferencias.Name = "btnGestaoTransferencias";
            this.btnGestaoTransferencias.Size = new System.Drawing.Size(236, 73);
            this.btnGestaoTransferencias.TabIndex = 3;
            this.btnGestaoTransferencias.Text = "GESTÃO DE TRANSFERÊNCIAS";
            this.btnGestaoTransferencias.UseVisualStyleBackColor = true;
            // 
            // btnGestaoCadastros
            // 
            this.btnGestaoCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestaoCadastros.Location = new System.Drawing.Point(5, 151);
            this.btnGestaoCadastros.Name = "btnGestaoCadastros";
            this.btnGestaoCadastros.Size = new System.Drawing.Size(236, 73);
            this.btnGestaoCadastros.TabIndex = 2;
            this.btnGestaoCadastros.Text = "GESTÃO DE CADASTROS";
            this.btnGestaoCadastros.UseVisualStyleBackColor = true;
            this.btnGestaoCadastros.Click += new System.EventHandler(this.btnGestaoCadastros_Click);
            // 
            // btnSolicitarLeitos
            // 
            this.btnSolicitarLeitos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolicitarLeitos.Location = new System.Drawing.Point(5, 78);
            this.btnSolicitarLeitos.Name = "btnSolicitarLeitos";
            this.btnSolicitarLeitos.Size = new System.Drawing.Size(236, 73);
            this.btnSolicitarLeitos.TabIndex = 1;
            this.btnSolicitarLeitos.Text = "SOLICITAR LEITOS";
            this.btnSolicitarLeitos.UseVisualStyleBackColor = true;
            // 
            // btnOfertarLeitos
            // 
            this.btnOfertarLeitos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOfertarLeitos.Location = new System.Drawing.Point(5, 5);
            this.btnOfertarLeitos.Name = "btnOfertarLeitos";
            this.btnOfertarLeitos.Size = new System.Drawing.Size(236, 73);
            this.btnOfertarLeitos.TabIndex = 0;
            this.btnOfertarLeitos.Text = "OFERTAR/CANCELAR LEITOS";
            this.btnOfertarLeitos.UseVisualStyleBackColor = true;
            this.btnOfertarLeitos.Click += new System.EventHandler(this.btnOfertarLeitos_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(5);
            this.panelRight.Size = new System.Drawing.Size(909, 635);
            this.panelRight.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1165, 637);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btnSolicitarLeitos;
        private System.Windows.Forms.Button btnOfertarLeitos;
        private System.Windows.Forms.Button btnGestaoCadastros;
        private System.Windows.Forms.Button btnGestaoTransferencias;
        private System.Windows.Forms.Button btnClose;
    }
}