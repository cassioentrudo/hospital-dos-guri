using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hospital_dos_guri
{
    public partial class FormLogin : Form
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
                this.lbSenha.Text = "logou";
                switch (user.Tipo_Usuario)
                {
                    case (int)Tipos_de_Usuario.HOSPITAL:
                        break;
                    case (int)Tipos_de_Usuario.GOVERNO:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                this.lbSenha.Text = "naologou";
            }
        }
    }
}
