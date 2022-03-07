namespace Apresentacao
{
    partial class FormRecuperarSenha
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
            this.btn_EnviarRequest = new System.Windows.Forms.Button();
            this.lblEmailouUsuario = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtUserRequest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_EnviarRequest
            // 
            this.btn_EnviarRequest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EnviarRequest.Location = new System.Drawing.Point(276, 83);
            this.btn_EnviarRequest.Name = "btn_EnviarRequest";
            this.btn_EnviarRequest.Size = new System.Drawing.Size(75, 23);
            this.btn_EnviarRequest.TabIndex = 0;
            this.btn_EnviarRequest.Text = "Enviar";
            this.btn_EnviarRequest.UseVisualStyleBackColor = true;
            this.btn_EnviarRequest.Click += new System.EventHandler(this.btn_EnviarRequest_Click);
            // 
            // lblEmailouUsuario
            // 
            this.lblEmailouUsuario.AutoSize = true;
            this.lblEmailouUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailouUsuario.Location = new System.Drawing.Point(41, 25);
            this.lblEmailouUsuario.Name = "lblEmailouUsuario";
            this.lblEmailouUsuario.Size = new System.Drawing.Size(235, 17);
            this.lblEmailouUsuario.TabIndex = 1;
            this.lblEmailouUsuario.Text = "Insira o nome do Usuário ou E-mail:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(41, 138);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Resultado";
            // 
            // txtUserRequest
            // 
            this.txtUserRequest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserRequest.Location = new System.Drawing.Point(44, 54);
            this.txtUserRequest.Name = "txtUserRequest";
            this.txtUserRequest.Size = new System.Drawing.Size(307, 23);
            this.txtUserRequest.TabIndex = 3;
            // 
            // FormRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.txtUserRequest);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblEmailouUsuario);
            this.Controls.Add(this.btn_EnviarRequest);
            this.Name = "FormRecuperarSenha";
            this.Text = "FormRecuperarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EnviarRequest;
        private System.Windows.Forms.Label lblEmailouUsuario;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtUserRequest;
    }
}