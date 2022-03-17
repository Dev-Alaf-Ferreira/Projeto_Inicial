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
using Common.Cache;

namespace Apresentacao
{
    public partial class FormUserProfile : Form
    {
        public FormUserProfile()
        {
            InitializeComponent();
        }

        private void lblLoginProfile_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuário_Click(object sender, EventArgs e)
        {

        }

        private void FormUserProfile_Load(object sender, EventArgs e)
        {
            loadUserData();
            initializePassEditControls();
        }
        private void loadUserData()
        {
            //View
            lblUser.Text = UserCache.LoginName;
            lblPNome.Text = UserCache.PrimeiroNome;
            lblSbNome.Text = UserCache.SobreNome;
            lblMail.Text = UserCache.Email;
            lblCargo.Text = UserCache.Cargo;
            //Edit Panel
            txtUserName.Text = UserCache.LoginName;
            txtPNome.Text = UserCache.PrimeiroNome;
            txtSbNome.Text = UserCache.SobreNome;
            txtEmail.Text = UserCache.Email;
            txtNvSenha.Text = UserCache.Senha;
            txtCfSenha.Text = UserCache.Senha;
            txtAtualSenha.Text = "";
        }
        private void initializePassEditControls()
        {
            linklblEditarProfile.Text = "Edit";
            txtNvSenha.UseSystemPasswordChar = true;
            txtNvSenha.Enabled = false;
            txtCfSenha.UseSystemPasswordChar = true;
            txtCfSenha.Enabled = false;
        }
        private void reset()
        {
            loadUserData();
            initializePassEditControls();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linklblEditarProfile.Text == "Editar")
            {

                .Text = "Cancel";
                txtNvSenha.Enabled = true;
                txtNvSenha.Text = "";
                txtCfSenha.Enabled = true;
                txtCfSenha.Text = "";
            }
            else if (linklblEditarProfile.Text == "Cancel")
            {
                initializePassEditControls();
                txtNvSenha.Text = UserCache.Senha;
                txtCfSenha.Text = UserCache.Senha;
            }
        }

        private void linklblEditarProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            loadUserData();
        }
    }
}
