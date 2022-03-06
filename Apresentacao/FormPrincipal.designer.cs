namespace Apresentacao
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelformularios = new System.Windows.Forms.Panel();
            this.Img_MenuPrincipal = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnDeslogar = new System.Windows.Forms.Button();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.btnOpcoes = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelformularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_MenuPrincipal)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelformularios);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1022, 537);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelformularios
            // 
            this.panelformularios.BackColor = System.Drawing.SystemColors.Control;
            this.panelformularios.Controls.Add(this.Img_MenuPrincipal);
            this.panelformularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelformularios.Location = new System.Drawing.Point(188, 32);
            this.panelformularios.Margin = new System.Windows.Forms.Padding(2);
            this.panelformularios.Name = "panelformularios";
            this.panelformularios.Size = new System.Drawing.Size(834, 505);
            this.panelformularios.TabIndex = 2;
            // 
            // Img_MenuPrincipal
            // 
            this.Img_MenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Img_MenuPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("Img_MenuPrincipal.Image")));
            this.Img_MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.Img_MenuPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.Img_MenuPrincipal.Name = "Img_MenuPrincipal";
            this.Img_MenuPrincipal.Size = new System.Drawing.Size(834, 505);
            this.Img_MenuPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_MenuPrincipal.TabIndex = 0;
            this.Img_MenuPrincipal.TabStop = false;
            this.Img_MenuPrincipal.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnConsultas);
            this.panelMenu.Controls.Add(this.btnDeslogar);
            this.panelMenu.Controls.Add(this.panelPerfil);
            this.panelMenu.Controls.Add(this.btnCalendario);
            this.panelMenu.Controls.Add(this.btnPerfil);
            this.panelMenu.Controls.Add(this.btnContatos);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 505);
            this.panelMenu.TabIndex = 1;
            // 
            // btnConsultas
            // 
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(2, 265);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(188, 40);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnDeslogar
            // 
            this.btnDeslogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeslogar.FlatAppearance.BorderSize = 0;
            this.btnDeslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeslogar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeslogar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeslogar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeslogar.Image")));
            this.btnDeslogar.Location = new System.Drawing.Point(0, 465);
            this.btnDeslogar.Name = "btnDeslogar";
            this.btnDeslogar.Size = new System.Drawing.Size(188, 40);
            this.btnDeslogar.TabIndex = 1;
            this.btnDeslogar.Text = "Sair";
            this.btnDeslogar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeslogar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeslogar.UseVisualStyleBackColor = true;
            this.btnDeslogar.Click += new System.EventHandler(this.btnDeslogar_Click);
            // 
            // panelPerfil
            // 
            this.panelPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(75)))));
            this.panelPerfil.Controls.Add(this.btnOpcoes);
            this.panelPerfil.Controls.Add(this.lblEmail);
            this.panelPerfil.Controls.Add(this.lblNome);
            this.panelPerfil.Controls.Add(this.lblCargo);
            this.panelPerfil.Controls.Add(this.pictureBox2);
            this.panelPerfil.Location = new System.Drawing.Point(0, 0);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(190, 129);
            this.panelPerfil.TabIndex = 1;
            // 
            // btnOpcoes
            // 
            this.btnOpcoes.FlatAppearance.BorderSize = 0;
            this.btnOpcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcoes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcoes.Image = ((System.Drawing.Image)(resources.GetObject("btnOpcoes.Image")));
            this.btnOpcoes.Location = new System.Drawing.Point(153, 0);
            this.btnOpcoes.Name = "btnOpcoes";
            this.btnOpcoes.Size = new System.Drawing.Size(35, 35);
            this.btnOpcoes.TabIndex = 1;
            this.btnOpcoes.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(3, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNome.Location = new System.Drawing.Point(95, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 16);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCargo.Location = new System.Drawing.Point(95, 72);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(41, 16);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnCalendario
            // 
            this.btnCalendario.FlatAppearance.BorderSize = 0;
            this.btnCalendario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCalendario.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendario.Image")));
            this.btnCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendario.Location = new System.Drawing.Point(3, 221);
            this.btnCalendario.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(188, 40);
            this.btnCalendario.TabIndex = 2;
            this.btnCalendario.Text = "Calendário";
            this.btnCalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(3, 133);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(2);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(188, 40);
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnContatos
            // 
            this.btnContatos.FlatAppearance.BorderSize = 0;
            this.btnContatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnContatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnContatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContatos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContatos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnContatos.Image = ((System.Drawing.Image)(resources.GetObject("btnContatos.Image")));
            this.btnContatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContatos.Location = new System.Drawing.Point(2, 177);
            this.btnContatos.Margin = new System.Windows.Forms.Padding(2);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(188, 40);
            this.btnContatos.TabIndex = 0;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContatos.UseVisualStyleBackColor = true;
            this.btnContatos.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnFechar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1022, 32);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(984, 9);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(12, 13);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(968, 9);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(12, 13);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(984, 9);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(12, 13);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1000, 9);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(12, 13);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 537);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(550, 375);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelformularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img_MenuPrincipal)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelformularios;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.PictureBox Img_MenuPrincipal;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDeslogar;
        private System.Windows.Forms.Button btnOpcoes;
        private System.Windows.Forms.Button btnConsultas;
    }
}

