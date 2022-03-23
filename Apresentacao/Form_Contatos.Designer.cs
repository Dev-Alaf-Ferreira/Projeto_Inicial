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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Contatos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSbNome = new System.Windows.Forms.TextBox();
            this.txtPNome = new System.Windows.Forms.TextBox();
            this.lblEmailProfile = new System.Windows.Forms.Label();
            this.lblSbNomeProfile = new System.Windows.Forms.Label();
            this.lblNomeProfile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncerraContatos = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerraContatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btnEncerraContatos);
            this.panel1.Controls.Add(this.txt_Telefone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtSbNome);
            this.panel1.Controls.Add(this.txtPNome);
            this.panel1.Controls.Add(this.lblEmailProfile);
            this.panel1.Controls.Add(this.lblSbNomeProfile);
            this.panel1.Controls.Add(this.lblNomeProfile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 603);
            this.panel1.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(119, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(309, 23);
            this.txtEmail.TabIndex = 18;
            // 
            // txtSbNome
            // 
            this.txtSbNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSbNome.Location = new System.Drawing.Point(119, 128);
            this.txtSbNome.Name = "txtSbNome";
            this.txtSbNome.Size = new System.Drawing.Size(309, 23);
            this.txtSbNome.TabIndex = 17;
            // 
            // txtPNome
            // 
            this.txtPNome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPNome.Location = new System.Drawing.Point(119, 87);
            this.txtPNome.Name = "txtPNome";
            this.txtPNome.Size = new System.Drawing.Size(309, 23);
            this.txtPNome.TabIndex = 16;
            this.txtPNome.TextChanged += new System.EventHandler(this.txtPNome_TextChanged);
            // 
            // lblEmailProfile
            // 
            this.lblEmailProfile.AutoSize = true;
            this.lblEmailProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmailProfile.Location = new System.Drawing.Point(15, 176);
            this.lblEmailProfile.Name = "lblEmailProfile";
            this.lblEmailProfile.Size = new System.Drawing.Size(51, 17);
            this.lblEmailProfile.TabIndex = 14;
            this.lblEmailProfile.Text = "E-mail:";
            // 
            // lblSbNomeProfile
            // 
            this.lblSbNomeProfile.AutoSize = true;
            this.lblSbNomeProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSbNomeProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSbNomeProfile.Location = new System.Drawing.Point(13, 134);
            this.lblSbNomeProfile.Name = "lblSbNomeProfile";
            this.lblSbNomeProfile.Size = new System.Drawing.Size(86, 17);
            this.lblSbNomeProfile.TabIndex = 13;
            this.lblSbNomeProfile.Text = "Sobrenome:";
            // 
            // lblNomeProfile
            // 
            this.lblNomeProfile.AutoSize = true;
            this.lblNomeProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNomeProfile.Location = new System.Drawing.Point(14, 93);
            this.lblNomeProfile.Name = "lblNomeProfile";
            this.lblNomeProfile.Size = new System.Drawing.Size(52, 17);
            this.lblNomeProfile.TabIndex = 12;
            this.lblNomeProfile.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(112, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Contatos";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefone.Location = new System.Drawing.Point(119, 210);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(160, 23);
            this.txt_Telefone.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Telefone:";
            // 
            // btnEncerraContatos
            // 
            this.btnEncerraContatos.BackColor = System.Drawing.SystemColors.Control;
            this.btnEncerraContatos.Image = ((System.Drawing.Image)(resources.GetObject("btnEncerraContatos.Image")));
            this.btnEncerraContatos.Location = new System.Drawing.Point(1083, 12);
            this.btnEncerraContatos.Name = "btnEncerraContatos";
            this.btnEncerraContatos.Size = new System.Drawing.Size(17, 17);
            this.btnEncerraContatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEncerraContatos.TabIndex = 22;
            this.btnEncerraContatos.TabStop = false;
            this.btnEncerraContatos.Click += new System.EventHandler(this.btnEncerrarProfile_Click);
            // 
            // Form_Contatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1112, 603);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Contatos";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerraContatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSbNome;
        private System.Windows.Forms.TextBox txtPNome;
        private System.Windows.Forms.Label lblEmailProfile;
        private System.Windows.Forms.Label lblSbNomeProfile;
        private System.Windows.Forms.Label lblNomeProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnEncerraContatos;
    }
}