using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Apresentacao
{
    public partial class FormRecuperarSenha : Form
    {
        public FormRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btn_EnviarRequest_Click(object sender, EventArgs e)
        {
            var usuario = new UserModel();
            var result = usuario.RecuperarSenha(txtUserRequest.Text);
            lblResult.Text = result;
        }
    }
}
