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
            loadUserData();

        }
        private void loadUserData()
        {

            //view data grid Panel
            txtNomeCompleto.Text = UserCache.Nome_Completo;
            txtEmaiil.Text = UserCache.Emaiil;
            txt_endereco.Text = UserCache.Endereco;
            txt_Telefone.Text = UserCache.Telefone;

        }

        private void Form_Contatos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'fazenTechDataSet.Contatos'. Você pode movê-la ou removê-la conforme necessário.
            this.contatosTableAdapter.Fill(this.fazenTechDataSet.Contatos);
            
        }

        private void btnEncerrarProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewContato_Click(object sender, EventArgs e)
        {
            txtNomeCompleto.Text = "";
            txtEmaiil.Text = "";
            txt_Telefone.Text = "";
            txt_endereco.Text = "";
            txtNomeCompleto.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text != "" && txt_Telefone.Text != "" && txt_endereco.Text != "" && txtEmaiil.Text != "")
            {

                var userModel = new UserModel(
                   id_contatos: UserCache.id_Contatos,
                   nome: txtNomeCompleto.Text,
                   telefone: txt_Telefone.Text,
                   endereco: txt_endereco.Text,
                   Emaiil: txtEmaiil.Text);
                var result = userModel.editUserConsultas();
                MessageBox.Show(result);

            }
            else
                MessageBox.Show("Registro não foi salvo, tente novamente");
            btnEncerraContatos.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
