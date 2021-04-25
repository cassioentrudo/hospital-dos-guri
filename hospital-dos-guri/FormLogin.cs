using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hospital_dos_guri
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario(this.tbUsuario.Text);
            if(user.EfetuarLogin(this.tbSenha.Text))
            {
               
                switch (user.Tipo_Usuario)
                {
                    case (int)Tipos_de_Usuario.HOSPITAL:
                        Hospital hospital = new Hospital(user);
                        Form f = new FormGerenciamentoHospital(hospital);
                        f.Show();
                        
                        break;
                    case (int)Tipos_de_Usuario.GOVERNO:
                        Governo governo = new Governo(user);
                        Form g = new FormGestaoCadastro(governo);
                        g.Show();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                
            }
        }

        private void llbSolicitaCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new FormSolicitaCadastro();
            f.Show();
        }
    }
}
