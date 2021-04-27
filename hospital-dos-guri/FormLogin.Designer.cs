
namespace hospital_dos_guri
{
    partial class FormLogin
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbcadastro = new System.Windows.Forms.Label();
            this.llbSolicitaCadastro = new System.Windows.Forms.LinkLabel();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.button1);
            this.gbLogin.Controls.Add(this.lbcadastro);
            this.gbLogin.Controls.Add(this.llbSolicitaCadastro);
            this.gbLogin.Controls.Add(this.btLogin);
            this.gbLogin.Controls.Add(this.tbSenha);
            this.gbLogin.Controls.Add(this.tbUsuario);
            this.gbLogin.Controls.Add(this.lbSenha);
            this.gbLogin.Controls.Add(this.lbUsuario);
            this.gbLogin.Location = new System.Drawing.Point(9, 5);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(425, 197);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbcadastro
            // 
            this.lbcadastro.AutoSize = true;
            this.lbcadastro.Location = new System.Drawing.Point(109, 125);
            this.lbcadastro.Name = "lbcadastro";
            this.lbcadastro.Size = new System.Drawing.Size(104, 15);
            this.lbcadastro.TabIndex = 6;
            this.lbcadastro.Text = "Não é cadastrado?";
            // 
            // llbSolicitaCadastro
            // 
            this.llbSolicitaCadastro.AutoSize = true;
            this.llbSolicitaCadastro.Location = new System.Drawing.Point(219, 125);
            this.llbSolicitaCadastro.Name = "llbSolicitaCadastro";
            this.llbSolicitaCadastro.Size = new System.Drawing.Size(99, 15);
            this.llbSolicitaCadastro.TabIndex = 5;
            this.llbSolicitaCadastro.TabStop = true;
            this.llbSolicitaCadastro.Text = "Solicitar Cadastro";
            this.llbSolicitaCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSolicitaCadastro_LinkClicked);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(151, 162);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(131, 29);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Logar";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(92, 89);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(327, 23);
            this.tbSenha.TabIndex = 3;
            this.tbSenha.Text = "1234567";
            this.tbSenha.UseSystemPasswordChar = true;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(92, 58);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(327, 23);
            this.tbUsuario.TabIndex = 2;
            this.tbUsuario.Text = "hosp_salv";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSenha.Location = new System.Drawing.Point(30, 89);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(56, 21);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha:";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsuario.Location = new System.Drawing.Point(19, 56);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(67, 21);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuário:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(442, 214);
            this.Controls.Add(this.gbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbcadastro;
        private System.Windows.Forms.LinkLabel llbSolicitaCadastro;
        private System.Windows.Forms.Button button1;
    }
}