
namespace hospital_dos_guri
{
    partial class FormSolicitaCadastro
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
            this.gbSolicitaCadastro = new System.Windows.Forms.GroupBox();
            this.btSolicitaCadastro = new System.Windows.Forms.Button();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbCEP = new System.Windows.Forms.TextBox();
            this.tbHospital = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbNomeHospital = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbCEP = new System.Windows.Forms.Label();
            this.lnSenha = new System.Windows.Forms.Label();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.gbSolicitaCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSolicitaCadastro
            // 
            this.gbSolicitaCadastro.Controls.Add(this.btSolicitaCadastro);
            this.gbSolicitaCadastro.Controls.Add(this.tbSenha);
            this.gbSolicitaCadastro.Controls.Add(this.tbCidade);
            this.gbSolicitaCadastro.Controls.Add(this.tbCEP);
            this.gbSolicitaCadastro.Controls.Add(this.tbHospital);
            this.gbSolicitaCadastro.Controls.Add(this.tbUsuario);
            this.gbSolicitaCadastro.Controls.Add(this.lbNomeHospital);
            this.gbSolicitaCadastro.Controls.Add(this.lbCidade);
            this.gbSolicitaCadastro.Controls.Add(this.lbCEP);
            this.gbSolicitaCadastro.Controls.Add(this.lnSenha);
            this.gbSolicitaCadastro.Controls.Add(this.lbNomeUsuario);
            this.gbSolicitaCadastro.Location = new System.Drawing.Point(2, 3);
            this.gbSolicitaCadastro.Name = "gbSolicitaCadastro";
            this.gbSolicitaCadastro.Size = new System.Drawing.Size(533, 344);
            this.gbSolicitaCadastro.TabIndex = 0;
            this.gbSolicitaCadastro.TabStop = false;
            this.gbSolicitaCadastro.Text = "Solitação de Cadastro Hospital";
            // 
            // btSolicitaCadastro
            // 
            this.btSolicitaCadastro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSolicitaCadastro.Location = new System.Drawing.Point(8, 302);
            this.btSolicitaCadastro.Name = "btSolicitaCadastro";
            this.btSolicitaCadastro.Size = new System.Drawing.Size(524, 32);
            this.btSolicitaCadastro.TabIndex = 10;
            this.btSolicitaCadastro.Text = "Solicitar Cadastro";
            this.btSolicitaCadastro.UseVisualStyleBackColor = true;
            this.btSolicitaCadastro.Click += new System.EventHandler(this.btSolicitaCadastro_Click);
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(160, 195);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(364, 23);
            this.tbSenha.TabIndex = 9;
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(160, 159);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(364, 23);
            this.tbCidade.TabIndex = 8;
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(160, 122);
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(364, 23);
            this.tbCEP.TabIndex = 7;
            // 
            // tbHospital
            // 
            this.tbHospital.Location = new System.Drawing.Point(160, 86);
            this.tbHospital.Name = "tbHospital";
            this.tbHospital.Size = new System.Drawing.Size(364, 23);
            this.tbHospital.TabIndex = 6;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(160, 49);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(364, 23);
            this.tbUsuario.TabIndex = 5;
            // 
            // lbNomeHospital
            // 
            this.lbNomeHospital.AutoSize = true;
            this.lbNomeHospital.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNomeHospital.Location = new System.Drawing.Point(15, 85);
            this.lbNomeHospital.Name = "lbNomeHospital";
            this.lbNomeHospital.Size = new System.Drawing.Size(135, 20);
            this.lbNomeHospital.TabIndex = 4;
            this.lbNomeHospital.Text = "Nome do Hospital:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCidade.Location = new System.Drawing.Point(15, 158);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(59, 20);
            this.lbCidade.TabIndex = 3;
            this.lbCidade.Text = "Cidade:";
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCEP.Location = new System.Drawing.Point(15, 121);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(37, 20);
            this.lbCEP.TabIndex = 2;
            this.lbCEP.Text = "CEP:";
            // 
            // lnSenha
            // 
            this.lnSenha.AutoSize = true;
            this.lnSenha.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnSenha.Location = new System.Drawing.Point(15, 194);
            this.lnSenha.Name = "lnSenha";
            this.lnSenha.Size = new System.Drawing.Size(52, 20);
            this.lnSenha.TabIndex = 1;
            this.lnSenha.Text = "Senha:";
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.AutoSize = true;
            this.lbNomeUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNomeUsuario.Location = new System.Drawing.Point(15, 48);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(62, 20);
            this.lbNomeUsuario.TabIndex = 0;
            this.lbNomeUsuario.Text = "Usuário:";
            // 
            // FormSolicitaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 349);
            this.Controls.Add(this.gbSolicitaCadastro);
            this.Name = "FormSolicitaCadastro";
            this.Text = "Solicitação de cadastro";
            this.gbSolicitaCadastro.ResumeLayout(false);
            this.gbSolicitaCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSolicitaCadastro;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lbNomeHospital;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Label lnSenha;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.Button btSolicitaCadastro;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbCEP;
        private System.Windows.Forms.TextBox tbHospital;
    }
}