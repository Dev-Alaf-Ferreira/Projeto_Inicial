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
        private string id_Contatos = null;
        private bool EditarCont = false;
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
            //Inserir
            if (EditarCont == false)
            {
                try
                {

                    objetoCsts.InserirCst(txtNomeCompleto.Text, txtEmaiil.Text, txt_endereco.Text, txt_Telefone.Text);
                    MessageBox.Show("Registro inserido com sucesso!!!");
                    MostrarContatos();
                    limparForm();
                    btnEncerraContatos.Visible = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Registro não foi salvo, tente novamente " + ex);
                    btnEncerraContatos.Visible = true;
                }
            }
            //EDITAR
            if (EditarCont == true)
            {
                try
                {
                    objetoCsts.EditarCont(txtNomeCompleto.Text, txtEmaiil.Text, txt_endereco.Text, txt_Telefone.Text, id_Contatos);
                    MessageBox.Show("Registro atualizado com sucesso!!!");
                    MostrarContatos();
                    limparForm();
                    EditarCont = false;
                    btnEncerraContatos.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Os dados não puderam ser editados porque: " + ex);
                    btnEncerraContatos.Visible = true;
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditarCont = true;
                txtNomeCompleto.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
                txtEmaiil.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                txt_endereco.Text = dataGridView1.CurrentRow.Cells["Endereco"].Value.ToString();
                txt_Telefone.Text = dataGridView1.CurrentRow.Cells["Telefone"].Value.ToString();
                id_Contatos = dataGridView1.CurrentRow.Cells["id_Contatos"].Value.ToString();
            }
            else
                MessageBox.Show("Selecione uma linha por favor");
                    btnEncerraContatos.Visible = true;

        }
        private void limparForm()
        {
            txtNomeCompleto.Text = "";
            txtEmaiil.Text = "";
            txt_Telefone.Text = "";
            txt_endereco.Text = "";
            txtNomeCompleto.Focus();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    id_Contatos = dataGridView1.CurrentRow.Cells["id_Contatos"].Value.ToString();
                    objetoCsts.EliminarCsts(id_Contatos);
                    MessageBox.Show("Eliminado corretamente");
                    MostrarContatos();
                        btnEncerraContatos.Visible = true;
                }
                else
                    MessageBox.Show("Selecione uma linha por favor");
                        btnEncerraContatos.Visible = true;

        }
    }
}
