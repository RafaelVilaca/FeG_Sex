namespace Loja_FeG_Sex
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Verificacao = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // txt_Login
            // 
            this.txt_Login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login.ForeColor = System.Drawing.Color.DarkBlue;
            this.txt_Login.Location = new System.Drawing.Point(113, 37);
            this.txt_Login.MaxLength = 20;
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(260, 29);
            this.txt_Login.TabIndex = 1;
            this.txt_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(201, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.ForeColor = System.Drawing.Color.DarkBlue;
            this.txt_Senha.Location = new System.Drawing.Point(113, 97);
            this.txt_Senha.MaxLength = 20;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(260, 29);
            this.txt_Senha.TabIndex = 3;
            this.txt_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Verificacao
            // 
            this.lbl_Verificacao.AutoSize = true;
            this.lbl_Verificacao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Verificacao.Font = new System.Drawing.Font("Times New Roman", 16.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Verificacao.ForeColor = System.Drawing.Color.Red;
            this.lbl_Verificacao.Location = new System.Drawing.Point(157, 247);
            this.lbl_Verificacao.Name = "lbl_Verificacao";
            this.lbl_Verificacao.Size = new System.Drawing.Size(0, 25);
            this.lbl_Verificacao.TabIndex = 4;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Login.FlatAppearance.BorderSize = 3;
            this.btn_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 18.25F, System.Drawing.FontStyle.Bold);
            this.btn_Login.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Login.Location = new System.Drawing.Point(13, 150);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(221, 57);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Fazer Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Times New Roman", 18.25F, System.Drawing.FontStyle.Bold);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.Location = new System.Drawing.Point(245, 150);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(221, 57);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(329, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "SEGREDO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(358, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "DOCE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(477, 280);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Verificacao);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLogin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_Verificacao;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}

