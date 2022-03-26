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
using Domain;
using Common.Cache;

namespace Apresentacao
{
    
    public partial class Form_Contatos : Form
    {
        public Form_Contatos()
        {
            InitializeComponent();
            limparDados();
            loadConsultadata();

        }
        private void limparDados()
        {
            txtPNome.Clear();
            txtEmail.Clear();
            txt_Telefone.Clear();
            txtendereco.Clear();
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
            // TODO: esta linha de código carrega dados na tabela 'fazenTechDataSet.Contatos'. Você pode movê-la ou removê-la conforme necessário.
            this.contatosTableAdapter.Fill(this.fazenTechDataSet.Contatos);
            // TODO: esta linha de código carrega dados na tabela 'fazenTechDataSet.ListaConsulta'. Você pode movê-la ou removê-la conforme necessário.
            this.listaConsultaTableAdapter.Fill(this.fazenTechDataSet.ListaConsulta);

        }
        private void loadConsultadata()
        {
            //editConsulta
            txtPNome.Text = UserCache.nome;
            txtEmail.Text = UserCache.Email;
            txtendereco.Text = UserCache.endereco;
            txt_Telefone.Text = UserCache.telefone;
        }

        private void btnNewContato_Click(object sender, EventArgs e)
        {
            txtPNome.Text = "";
            txtEmail.Text = "";
            txt_Telefone.Text = "";
            lblende.Text = "";
            txtPNome.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

                if (txtPNome.Text != "" && txt_Telefone.Text != "" && txtEmail.Text != "" && txtendereco.Text !="")
                {
                    
                 var userModel = new UserModel(
                    id_contatos: UserCache.id_Contatos,
                    nome: txtPNome.Text,
                    telefone: txt_Telefone.Text,
                    endereco: txtendereco.Text,
                    Email: txtEmail.Text);
                 var result = userModel.editUserConsultas();
                    MessageBox.Show(result);
                    limparDados();

                }
                else
                    MessageBox.Show("Registro não encontrado, tente novamente.");
                btnEncerraContatos.Visible = true;
        
        }
    }
}
