using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;
using Common.Cache;

namespace Apresentacao
{
    public partial class FormTelaAcessar : Form
    {
        public FormTelaAcessar()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // Configurações de Acesso Login-------------------------------------------
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.LightGray;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.ForeColor = Color.DimGray;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO" && txtUsuario.TextLength>2) {
                if (txtSenha.Text != "SENHA")
                {
                    UserModel usuario = new UserModel();
                    var validarLogin = usuario.LoginUser(txtUsuario.Text, txtSenha.Text);
                    if (validarLogin == true)
                    {
                        if (UserCache.Cargo == Cargo.Administrador)
                        {
                            FormPrincipal mainMenu = new FormPrincipal();
                            MessageBox.Show("Bem Vindo " + UserCache.PrimeiroNome + " " + UserCache.SobreNome);
                            mainMenu.Show();
                            mainMenu.FormClosed += Deslogar;
                            
                            this.Hide();
                        }
                        if(UserCache.Cargo == Cargo.Contador)
                        {
                            Comercial.MainMenuComerc mainMenu = new Comercial.MainMenuComerc();
                            MessageBox.Show("Bem Vindo " + UserCache.PrimeiroNome + " " + UserCache.SobreNome);
                            mainMenu.Show();
                            mainMenu.FormClosed += Deslogar;

                            this.Hide();
                        }
                    }
                    else
                    {
                        msgError("Usuário ou Senha incorreto \n    Por favor tente novamente.");
                        txtSenha.Text ="SENHA";
                        txtSenha.UseSystemPasswordChar = false;
                        txtUsuario.Focus();
                    }
                }
            else msgError("Por favor entre com a Senha");
            }
            else msgError("Por favor entre com o Usuário");
        }
        private void msgError(string msg)
        {
            lblMensagemError.Text = "    " + msg;
            lblMensagemError.Visible = true;

        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtSenha.Text != "SENHA")
                {
                    UserModel usuario = new UserModel();
                    var validarLogin = usuario.LoginUser(txtUsuario.Text, txtSenha.Text);
                    if (validarLogin == true)
                    {
                        FormPrincipal mainMenu = new FormPrincipal();
                        mainMenu.Show();
                        this.Hide();
                    }

                }
            }
        }
        private void Deslogar (object sender, FormClosedEventArgs e)
        {
            txtSenha.Text = "SENHA"; 
            txtSenha.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblMensagemError.Visible = false;
            this.Show();
        }
    }
}
