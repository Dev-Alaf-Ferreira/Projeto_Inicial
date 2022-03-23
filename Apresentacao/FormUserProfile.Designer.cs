namespace Apresentacao
{
    partial class FormUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserProfile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lnklblEdite = new System.Windows.Forms.LinkLabel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtAtualSenha = new System.Windows.Forms.TextBox();
            this.txtCfSenha = new System.Windows.Forms.TextBox();
            this.txtNvSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSbNome = new System.Windows.Forms.TextBox();
            this.txtPNome = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblCfrmSenha = new System.Windows.Forms.Label();
            this.lblSenhatualProfile = new System.Windows.Forms.Label();
            this.lblNvSenhaProfile = new System.Windows.Forms.Label();
            this.lblEmailProfile = new System.Windows.Forms.Label();
            this.lblSbNomeProfile = new System.Windows.Forms.Label();
            this.lblNomeProfile = new System.Windows.Forms.Label();
            this.lblUserNameProfile = new System.Windows.Forms.Label();
            this.pbx_FotoPerfil = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSobreNomeProfile = new System.Windows.Forms.Label();
            this.lblNomeProfilePerfil = new System.Windows.Forms.Label();
            this.lblUsuário = new System.Windows.Forms.Label();
            this.lblCargoProfile = new System.Windows.Forms.Label();
            this.linklblEditarProfile = new System.Windows.Forms.LinkLabel();
            this.btnEncerrarProfile = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPNome = new System.Windows.Forms.Label();
            this.lblSbNome = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_FotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrarProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lnklblEdite);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.txtAtualSenha);
            this.panel1.Controls.Add(this.txtCfSenha);
            this.panel1.Controls.Add(this.txtNvSenha);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtSbNome);
            this.panel1.Controls.Add(this.txtPNome);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.lblCfrmSenha);
            this.panel1.Controls.Add(this.lblSenhatualProfile);
            this.panel1.Controls.Add(this.lblNvSenhaProfile);
            this.panel1.Controls.Add(this.lblEmailProfile);
            this.panel1.Controls.Add(this.lblSbNomeProfile);
            this.panel1.Controls.Add(this.lblNomeProfile);
            this.panel1.Controls.Add(this.lblUserNameProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(451, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 461);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "Editar meu perfil";
            // 
            // lnklblEdite
            // 
            this.lnklblEdite.AutoSize = true;
            this.lnklblEdite.Location = new System.Drawing.Point(123, 240);
            this.lnklblEdite.Name = "lnklblEdite";
            this.lnklblEdite.Size = new System.Drawing.Size(34, 13);
            this.lnklblEdite.TabIndex = 16;
            this.lnklblEdite.TabStop = true;
            this.lnklblEdite.Text = "Editar";
            this.lnklblEdite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblEdite_LinkClicked_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Location = new System.Drawing.Point(217, 389);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(110, 40);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.Location = new System.Drawing.Point(64, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtAtualSenha
            // 
            this.txtAtualSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtualSenha.Location = new System.Drawing.Point(31, 344);
            this.txtAtualSenha.Name = "txtAtualSenha";
            this.txtAtualSenha.Size = new System.Drawing.Size(309, 23);
            this.txtAtualSenha.TabIndex = 13;
            // 
            // txtCfSenha
            // 
            this.txtCfSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCfSenha.Location = new System.Drawing.Point(31, 301);
            this.txtCfSenha.Name = "txtCfSenha";
            this.txtCfSenha.Size = new System.Drawing.Size(309, 23);
            this.txtCfSenha.TabIndex = 12;
            // 
            // txtNvSenha
            // 
            this.txtNvSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNvSenha.Location = new System.Drawing.Point(31, 258);
            this.txtNvSenha.Name = "txtNvSenha";
            this.txtNvSenha.Size = new System.Drawing.Size(309, 23);
            this.txtNvSenha.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(31, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(309, 23);
            this.txtEmail.TabIndex = 10;
            // 
            // txtSbNome
            // 
            this.txtSbNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSbNome.Location = new System.Drawing.Point(31, 172);
            this.txtSbNome.Name = "txtSbNome";
            this.txtSbNome.Size = new System.Drawing.Size(309, 23);
            this.txtSbNome.TabIndex = 9;
            // 
            // txtPNome
            // 
            this.txtPNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPNome.Location = new System.Drawing.Point(31, 129);
            this.txtPNome.Name = "txtPNome";
            this.txtPNome.Size = new System.Drawing.Size(309, 23);
            this.txtPNome.TabIndex = 8;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(31, 86);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(309, 23);
            this.txtUserName.TabIndex = 7;
            // 
            // lblCfrmSenha
            // 
            this.lblCfrmSenha.AutoSize = true;
            this.lblCfrmSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfrmSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCfrmSenha.Location = new System.Drawing.Point(28, 281);
            this.lblCfrmSenha.Name = "lblCfrmSenha";
            this.lblCfrmSenha.Size = new System.Drawing.Size(120, 17);
            this.lblCfrmSenha.TabIndex = 6;
            this.lblCfrmSenha.Text = "Confirmar Senha:";
            // 
            // lblSenhatualProfile
            // 
            this.lblSenhatualProfile.AutoSize = true;
            this.lblSenhatualProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhatualProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSenhatualProfile.Location = new System.Drawing.Point(30, 324);
            this.lblSenhatualProfile.Name = "lblSenhatualProfile";
            this.lblSenhatualProfile.Size = new System.Drawing.Size(89, 17);
            this.lblSenhatualProfile.TabIndex = 5;
            this.lblSenhatualProfile.Text = "Senha Atual:";
            // 
            // lblNvSenhaProfile
            // 
            this.lblNvSenhaProfile.AutoSize = true;
            this.lblNvSenhaProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNvSenhaProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNvSenhaProfile.Location = new System.Drawing.Point(28, 238);
            this.lblNvSenhaProfile.Name = "lblNvSenhaProfile";
            this.lblNvSenhaProfile.Size = new System.Drawing.Size(91, 17);
            this.lblNvSenhaProfile.TabIndex = 4;
            this.lblNvSenhaProfile.Text = "Nova Senha:";
            // 
            // lblEmailProfile
            // 
            this.lblEmailProfile.AutoSize = true;
            this.lblEmailProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmailProfile.Location = new System.Drawing.Point(29, 195);
            this.lblEmailProfile.Name = "lblEmailProfile";
            this.lblEmailProfile.Size = new System.Drawing.Size(51, 17);
            this.lblEmailProfile.TabIndex = 3;
            this.lblEmailProfile.Text = "E-mail:";
            // 
            // lblSbNomeProfile
            // 
            this.lblSbNomeProfile.AutoSize = true;
            this.lblSbNomeProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSbNomeProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSbNomeProfile.Location = new System.Drawing.Point(28, 152);
            this.lblSbNomeProfile.Name = "lblSbNomeProfile";
            this.lblSbNomeProfile.Size = new System.Drawing.Size(86, 17);
            this.lblSbNomeProfile.TabIndex = 2;
            this.lblSbNomeProfile.Text = "Sobrenome:";
            // 
            // lblNomeProfile
            // 
            this.lblNomeProfile.AutoSize = true;
            this.lblNomeProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeProfile.Location = new System.Drawing.Point(28, 109);
            this.lblNomeProfile.Name = "lblNomeProfile";
            this.lblNomeProfile.Size = new System.Drawing.Size(52, 17);
            this.lblNomeProfile.TabIndex = 1;
            this.lblNomeProfile.Text = "Nome:";
            // 
            // lblUserNameProfile
            // 
            this.lblUserNameProfile.AutoSize = true;
            this.lblUserNameProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserNameProfile.Location = new System.Drawing.Point(30, 66);
            this.lblUserNameProfile.Name = "lblUserNameProfile";
            this.lblUserNameProfile.Size = new System.Drawing.Size(58, 17);
            this.lblUserNameProfile.TabIndex = 0;
            this.lblUserNameProfile.Text = "Usuário:";
            // 
            // pbx_FotoPerfil
            // 
            this.pbx_FotoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.pbx_FotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbx_FotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pbx_FotoPerfil.Image")));
            this.pbx_FotoPerfil.Location = new System.Drawing.Point(13, 75);
            this.pbx_FotoPerfil.Name = "pbx_FotoPerfil";
            this.pbx_FotoPerfil.Size = new System.Drawing.Size(240, 223);
            this.pbx_FotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_FotoPerfil.TabIndex = 1;
            this.pbx_FotoPerfil.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(260, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSobreNomeProfile
            // 
            this.lblSobreNomeProfile.AutoSize = true;
            this.lblSobreNomeProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblSobreNomeProfile.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSobreNomeProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreNomeProfile.ForeColor = System.Drawing.Color.White;
            this.lblSobreNomeProfile.Location = new System.Drawing.Point(259, 161);
            this.lblSobreNomeProfile.Name = "lblSobreNomeProfile";
            this.lblSobreNomeProfile.Size = new System.Drawing.Size(86, 17);
            this.lblSobreNomeProfile.TabIndex = 6;
            this.lblSobreNomeProfile.Text = "Sobrenome:";
            // 
            // lblNomeProfilePerfil
            // 
            this.lblNomeProfilePerfil.AutoSize = true;
            this.lblNomeProfilePerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeProfilePerfil.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNomeProfilePerfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfilePerfil.ForeColor = System.Drawing.Color.White;
            this.lblNomeProfilePerfil.Location = new System.Drawing.Point(260, 117);
            this.lblNomeProfilePerfil.Name = "lblNomeProfilePerfil";
            this.lblNomeProfilePerfil.Size = new System.Drawing.Size(52, 17);
            this.lblNomeProfilePerfil.TabIndex = 5;
            this.lblNomeProfilePerfil.Text = "Nome:";
            // 
            // lblUsuário
            // 
            this.lblUsuário.AutoSize = true;
            this.lblUsuário.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuário.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUsuário.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuário.ForeColor = System.Drawing.Color.White;
            this.lblUsuário.Location = new System.Drawing.Point(259, 75);
            this.lblUsuário.Name = "lblUsuário";
            this.lblUsuário.Size = new System.Drawing.Size(58, 17);
            this.lblUsuário.TabIndex = 4;
            this.lblUsuário.Text = "Usuário:";
            // 
            // lblCargoProfile
            // 
            this.lblCargoProfile.AutoSize = true;
            this.lblCargoProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblCargoProfile.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCargoProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoProfile.ForeColor = System.Drawing.Color.White;
            this.lblCargoProfile.Location = new System.Drawing.Point(259, 248);
            this.lblCargoProfile.Name = "lblCargoProfile";
            this.lblCargoProfile.Size = new System.Drawing.Size(54, 17);
            this.lblCargoProfile.TabIndex = 8;
            this.lblCargoProfile.Text = "Cargo:";
            // 
            // linklblEditarProfile
            // 
            this.linklblEditarProfile.AutoSize = true;
            this.linklblEditarProfile.BackColor = System.Drawing.Color.Transparent;
            this.linklblEditarProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblEditarProfile.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linklblEditarProfile.Location = new System.Drawing.Point(89, 324);
            this.linklblEditarProfile.Name = "linklblEditarProfile";
            this.linklblEditarProfile.Size = new System.Drawing.Size(79, 17);
            this.linklblEditarProfile.TabIndex = 17;
            this.linklblEditarProfile.TabStop = true;
            this.linklblEditarProfile.Text = "Editar Perfil";
            this.linklblEditarProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblEditarProfile_LinkClicked);
            // 
            // btnEncerrarProfile
            // 
            this.btnEncerrarProfile.BackColor = System.Drawing.SystemColors.Control;
            this.btnEncerrarProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnEncerrarProfile.Image")));
            this.btnEncerrarProfile.Location = new System.Drawing.Point(378, 12);
            this.btnEncerrarProfile.Name = "btnEncerrarProfile";
            this.btnEncerrarProfile.Size = new System.Drawing.Size(17, 17);
            this.btnEncerrarProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEncerrarProfile.TabIndex = 19;
            this.btnEncerrarProfile.TabStop = false;
            this.btnEncerrarProfile.Click += new System.EventHandler(this.btnEncerrarProfile_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(260, 97);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 16);
            this.lblUser.TabIndex = 20;
            this.lblUser.Text = "usuário";
            // 
            // lblPNome
            // 
            this.lblPNome.AutoSize = true;
            this.lblPNome.BackColor = System.Drawing.Color.Transparent;
            this.lblPNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPNome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPNome.ForeColor = System.Drawing.Color.White;
            this.lblPNome.Location = new System.Drawing.Point(260, 140);
            this.lblPNome.Name = "lblPNome";
            this.lblPNome.Size = new System.Drawing.Size(81, 16);
            this.lblPNome.TabIndex = 21;
            this.lblPNome.Text = "primeiroNome";
            // 
            // lblSbNome
            // 
            this.lblSbNome.AutoSize = true;
            this.lblSbNome.BackColor = System.Drawing.Color.Transparent;
            this.lblSbNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSbNome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSbNome.ForeColor = System.Drawing.Color.White;
            this.lblSbNome.Location = new System.Drawing.Point(260, 184);
            this.lblSbNome.Name = "lblSbNome";
            this.lblSbNome.Size = new System.Drawing.Size(68, 16);
            this.lblSbNome.TabIndex = 22;
            this.lblSbNome.Text = "sobreNome";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(260, 229);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 16);
            this.lblMail.TabIndex = 23;
            this.lblMail.Text = "email";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(259, 268);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(39, 16);
            this.lblCargo.TabIndex = 24;
            this.lblCargo.Text = "cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(57, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 38);
            this.label2.TabIndex = 18;
            this.label2.Text = "Meu Perfil";
            // 
            // FormUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblSbNome);
            this.Controls.Add(this.lblPNome);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnEncerrarProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linklblEditarProfile);
            this.Controls.Add(this.lblCargoProfile);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSobreNomeProfile);
            this.Controls.Add(this.lblNomeProfilePerfil);
            this.Controls.Add(this.lblUsuário);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbx_FotoPerfil);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "FormUserProfile";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserProfile";
            this.Load += new System.EventHandler(this.FormUserProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_FotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrarProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmailProfile;
        private System.Windows.Forms.Label lblSbNomeProfile;
        private System.Windows.Forms.Label lblNomeProfile;
        private System.Windows.Forms.Label lblUserNameProfile;
        private System.Windows.Forms.Label lblCfrmSenha;
        private System.Windows.Forms.Label lblSenhatualProfile;
        private System.Windows.Forms.Label lblNvSenhaProfile;
        private System.Windows.Forms.TextBox txtAtualSenha;
        private System.Windows.Forms.TextBox txtCfSenha;
        private System.Windows.Forms.TextBox txtNvSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSbNome;
        private System.Windows.Forms.TextBox txtPNome;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.LinkLabel lnklblEdite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSobreNomeProfile;
        private System.Windows.Forms.Label lblNomeProfilePerfil;
        private System.Windows.Forms.Label lblUsuário;
        private System.Windows.Forms.Label lblCargoProfile;
        private System.Windows.Forms.LinkLabel linklblEditarProfile;
        private System.Windows.Forms.PictureBox btnEncerrarProfile;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPNome;
        private System.Windows.Forms.Label lblSbNome;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbx_FotoPerfil;
    }
}