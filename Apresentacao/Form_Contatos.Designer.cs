namespace Apresentacao
{
    partial class Form_Contatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Contatos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listaConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazenTechDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazenTechDataSet = new Apresentacao.FazenTechDataSet();
            this.listaConsultaTableAdapter = new Apresentacao.FazenTechDataSetTableAdapters.ListaConsultaTableAdapter();
            this.lblNomeProfile = new System.Windows.Forms.Label();
            this.lblEmailProfile = new System.Windows.Forms.Label();
            this.txtPNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.btnEncerraContatos = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblende = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNewContato = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contatosTableAdapter = new Apresentacao.FazenTechDataSetTableAdapters.ContatosTableAdapter();
            this.contatosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.id_Contatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listaConsultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazenTechDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazenTechDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerraContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listaConsultaBindingSource
            // 
            this.listaConsultaBindingSource.DataMember = "ListaConsulta";
            this.listaConsultaBindingSource.DataSource = this.fazenTechDataSetBindingSource;
            // 
            // fazenTechDataSetBindingSource
            // 
            this.fazenTechDataSetBindingSource.DataSource = this.fazenTechDataSet;
            this.fazenTechDataSetBindingSource.Position = 0;
            // 
            // fazenTechDataSet
            // 
            this.fazenTechDataSet.DataSetName = "FazenTechDataSet";
            this.fazenTechDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaConsultaTableAdapter
            // 
            this.listaConsultaTableAdapter.ClearBeforeFill = true;
            // 
            // lblNomeProfile
            // 
            this.lblNomeProfile.AutoSize = true;
            this.lblNomeProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNomeProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeProfile.Location = new System.Drawing.Point(15, 94);
            this.lblNomeProfile.Name = "lblNomeProfile";
            this.lblNomeProfile.Size = new System.Drawing.Size(49, 16);
            this.lblNomeProfile.TabIndex = 12;
            this.lblNomeProfile.Text = "Nome:";
            // 
            // lblEmailProfile
            // 
            this.lblEmailProfile.AutoSize = true;
            this.lblEmailProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmailProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmailProfile.Location = new System.Drawing.Point(15, 125);
            this.lblEmailProfile.Name = "lblEmailProfile";
            this.lblEmailProfile.Size = new System.Drawing.Size(52, 16);
            this.lblEmailProfile.TabIndex = 14;
            this.lblEmailProfile.Text = "E-mail:";
            // 
            // txtPNome
            // 
            this.txtPNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPNome.Location = new System.Drawing.Point(117, 87);
            this.txtPNome.Name = "txtPNome";
            this.txtPNome.Size = new System.Drawing.Size(335, 23);
            this.txtPNome.TabIndex = 16;
            this.txtPNome.TextChanged += new System.EventHandler(this.txtPNome_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(117, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(335, 23);
            this.txtEmail.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(178, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 44);
            this.label1.TabIndex = 19;
            this.label1.Text = "Contatos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Telefone:";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefone.Location = new System.Drawing.Point(117, 195);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(175, 23);
            this.txt_Telefone.TabIndex = 21;
            // 
            // btnEncerraContatos
            // 
            this.btnEncerraContatos.BackColor = System.Drawing.SystemColors.Control;
            this.btnEncerraContatos.Image = ((System.Drawing.Image)(resources.GetObject("btnEncerraContatos.Image")));
            this.btnEncerraContatos.Location = new System.Drawing.Point(714, 3);
            this.btnEncerraContatos.Name = "btnEncerraContatos";
            this.btnEncerraContatos.Size = new System.Drawing.Size(17, 17);
            this.btnEncerraContatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEncerraContatos.TabIndex = 22;
            this.btnEncerraContatos.TabStop = false;
            this.btnEncerraContatos.Click += new System.EventHandler(this.btnEncerrarProfile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Contatos,
            this.nomeDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contatosBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 314);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Size = new System.Drawing.Size(834, 247);
            this.dataGridView1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.txtendereco);
            this.panel1.Controls.Add(this.lblende);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNewContato);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnEncerraContatos);
            this.panel1.Controls.Add(this.txt_Telefone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPNome);
            this.panel1.Controls.Add(this.lblEmailProfile);
            this.panel1.Controls.Add(this.lblNomeProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 561);
            this.panel1.TabIndex = 0;
            // 
            // txtendereco
            // 
            this.txtendereco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendereco.Location = new System.Drawing.Point(117, 159);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(335, 23);
            this.txtendereco.TabIndex = 30;
            // 
            // lblende
            // 
            this.lblende.AutoSize = true;
            this.lblende.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblende.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblende.ForeColor = System.Drawing.SystemColors.Control;
            this.lblende.Location = new System.Drawing.Point(15, 162);
            this.lblende.Name = "lblende";
            this.lblende.Size = new System.Drawing.Size(72, 16);
            this.lblende.TabIndex = 29;
            this.lblende.Text = "Endereço:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(568, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "Deletar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(568, 157);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(135, 34);
            this.btnAtualizar.TabIndex = 27;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(568, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 35);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewContato
            // 
            this.btnNewContato.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewContato.FlatAppearance.BorderSize = 0;
            this.btnNewContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewContato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewContato.ForeColor = System.Drawing.Color.White;
            this.btnNewContato.Location = new System.Drawing.Point(568, 74);
            this.btnNewContato.Name = "btnNewContato";
            this.btnNewContato.Size = new System.Drawing.Size(135, 35);
            this.btnNewContato.TabIndex = 25;
            this.btnNewContato.Text = "Novo ";
            this.btnNewContato.UseVisualStyleBackColor = false;
            this.btnNewContato.Click += new System.EventHandler(this.btnNewContato_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // contatosBindingSource
            // 
            this.contatosBindingSource.DataMember = "Contatos";
            this.contatosBindingSource.DataSource = this.fazenTechDataSetBindingSource;
            // 
            // contatosTableAdapter
            // 
            this.contatosTableAdapter.ClearBeforeFill = true;
            // 
            // contatosBindingSource1
            // 
            this.contatosBindingSource1.DataMember = "Contatos";
            this.contatosBindingSource1.DataSource = this.fazenTechDataSetBindingSource;
            // 
            // id_Contatos
            // 
            this.id_Contatos.DataPropertyName = "id_Contatos";
            this.id_Contatos.HeaderText = "id_Contatos";
            this.id_Contatos.Name = "id_Contatos";
            this.id_Contatos.ReadOnly = true;
            this.id_Contatos.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Form_Contatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Contatos";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.Form_Contatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaConsultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazenTechDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazenTechDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerraContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource fazenTechDataSetBindingSource;
        private FazenTechDataSet fazenTechDataSet;
        private System.Windows.Forms.BindingSource listaConsultaBindingSource;
        private FazenTechDataSetTableAdapters.ListaConsultaTableAdapter listaConsultaTableAdapter;
        private System.Windows.Forms.Label lblNomeProfile;
        private System.Windows.Forms.Label lblEmailProfile;
        private System.Windows.Forms.TextBox txtPNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.PictureBox btnEncerraContatos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewContato;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label lblende;
        private System.Windows.Forms.BindingSource contatosBindingSource;
        private FazenTechDataSetTableAdapters.ContatosTableAdapter contatosTableAdapter;
        private System.Windows.Forms.BindingSource contatosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Contatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}