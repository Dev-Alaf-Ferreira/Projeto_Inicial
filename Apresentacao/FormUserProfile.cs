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
            //botões transparentes código simples
            /*button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;*/
        }

        private void FormUserProfile_Load(object sender, EventArgs e)
        {
            loadUserData();
            initializePassEditControls();
         
        }

        private void loadUserData()
        {
            //View
            lblLogin.Text = UserCache.LoginName;
            lblPNome.Text = UserCache.PrimeiroNome;
            lblSbNome.Text = UserCache.SobreNome;
            lblMail.Text = UserCache.Email;
            lblCargo.Text = UserCache.Cargo;
            //Edit Panel
            txtUserName.Text = UserCache.LoginName;
            txtPNome.Text = UserCache.PrimeiroNome;
            txtSbNome.Text = UserCache.SobreNome;
            txtEmail.Text = UserCache.Email;
            txtSenha.Text = UserCache.Senha;
            txtCfSenha.Text = UserCache.Senha;
            txtAtualSenha.Text = "";
        }
        private void initializePassEditControls()
        {
            lnklblEdite.Text = "Editar";
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.Enabled = false;
            txtCfSenha.UseSystemPasswordChar = true;
            txtCfSenha.Enabled = false;
        }
        private void reset()
        {
            loadUserData();
            initializePassEditControls();
        }

        private void linklblEditarProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            loadUserData();
            btnEncerrarProfile.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Length >= 5)
            {
                if (txtSenha.Text == txtCfSenha.Text)
                {
                    if (txtAtualSenha.Text == UserCache.Senha)
                    {
                        var userModel = new UserModel(
                            usuario_ID: UserCache.UsuarioID,
                            loginName: txtUserName.Text,
                            senha: txtSenha.Text,
                            primeiroNome: txtPNome.Text,
                            sobreNome: txtSbNome.Text,
                            cargo: null,
                            email: txtEmail.Text);
                        var result = userModel.editUserProfile();
                        MessageBox.Show(result);
                        reset();
                        panel1.Visible = false;
                    }
                    else
                        MessageBox.Show("Senha atual incorreta, tente novamente");
                }
                else
                    MessageBox.Show("A senha não corresponde, tente novamente");
            }
            else
                MessageBox.Show("A senha deve ter no mínimo 5 caracteres");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            reset();
            btnEncerrarProfile.Visible = true;
        }

        private void btnEncerrarProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnklblEdite_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lnklblEdite.Text == "Editar")
            {
                lnklblEdite.Text = "Cancelar";
                txtSenha.Enabled = true;
                txtSenha.Text = "";
                txtCfSenha.Enabled = true;
                txtCfSenha.Text = "";
            }
            else if (lnklblEdite.Text == "Cancelar")
            {
                initializePassEditControls();
                txtSenha.Text = UserCache.Senha;
                txtCfSenha.Text = UserCache.Senha;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
