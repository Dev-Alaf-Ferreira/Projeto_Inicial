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
        UserModel.Dm_Consulta objetoCsts = new UserModel.Dm_Consulta();
        public Form_Contatos()
        {
            InitializeComponent();

        }

        private void Form_Contatos_Load(object sender, EventArgs e)
        {
            MostrarContatos();
        }
        private void MostrarContatos()
        {
            UserModel.Dm_Consulta objeto = new UserModel.Dm_Consulta();
            dataGridView1.DataSource = objeto.MostrarCst();
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
            try
            {
                if (txtNomeCompleto.Text != "" && txt_Telefone.Text != "" && txt_endereco.Text != "" && txtEmaiil.Text != "")
                {

                    objetoCsts.InserirCst(txtNomeCompleto.Text, txtEmaiil.Text, txt_endereco.Text, txt_Telefone.Text);
                    MessageBox.Show("Registro inserido com sucesso!!!");
                    MostrarContatos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registro não foi salvo, tente novamente");
            }
                btnEncerraContatos.Visible = true;
        }

    }
}
