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
                this.lbSenha.Text = $"log {user.Tipo_Usuario}";
                switch (user.Tipo_Usuario)
                {
                    case (int)Tipos_de_Usuario.HOSPITAL:
                        Hospital hospital = new Hospital(user);
                        Form f = new FormGerenciamentoHospital(hospital);
                        f.Show();
                        break;
                    case (int)Tipos_de_Usuario.GOVERNO:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                this.lbSenha.Text = $"N {user.Tipo_Usuario}";
            }
        }
    }
}
