using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Common.Cache;

namespace Apresentacao
{
    
    public partial class Form_Contatos : Form
    {
        public Form_Contatos()
        {
            InitializeComponent(); 

        }
        private void txtPNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEncerrarProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Contatos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazenTechDataSet.ListaConsulta'. Você pode movê-la ou removê-la conforme necessário.
            this.listaConsultaTableAdapter.Fill(this.fazenTechDataSet.ListaConsulta);

        }

        private void btnNewContato_Click(object sender, EventArgs e)
        {
            txtPNome.Text = "";
            txtSbNome.Text = "";
            txtEmail.Text = "";
            txt_Telefone.Text = "";
            txtPNome.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

                if (txtPNome.Text != "" && txtSbNome.Text != "" && txt_Telefone.Text != "" && txtEmail.Text != "")
                {
                    
                    
                 var userModel = new UserModel(
                    usuario_ID: UserCache.UsuarioID,
                    loginName: txtUserName.Text,
                    senha: txtNvSenha.Text,
                    primeiroNome: txtPNome.Text,
                    sobreNome: txtSbNome.Text,
                    cargo: null,
                    email: txtEmail.Text);
                 var result = userModel.editUserProfile();
                    MessageBox.Show(result);

                }
                else
                    MessageBox.Show("A senha não corresponde, tente novamente");
                btnEncerraContatos.Visible = true;
        
        }
    }
}
