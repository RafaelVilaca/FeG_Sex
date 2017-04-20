namespace Loja_FeG_Sex.Forms
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Font = new System.Drawing.Font("Times New Roman", 18.25F, System.Drawing.FontStyle.Bold);
            this.btn_Sair.ForeColor = System.Drawing.Color.Coral;
            this.btn_Sair.Location = new System.Drawing.Point(728, 440);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(128, 46);
            this.btn_Sair.TabIndex = 10;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Editar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Editar.Font = new System.Drawing.Font("Times New Roman", 18.25F, System.Drawing.FontStyle.Bold);
            this.btn_Editar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Editar.Location = new System.Drawing.Point(550, 440);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(172, 46);
            this.btn_Editar.TabIndex = 14;
            this.btn_Editar.Text = "Editar Cliente";
            this.btn_Editar.UseVisualStyleBackColor = false;
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Inserir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Inserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Inserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Inserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Inserir.Font = new System.Drawing.Font("Times New Roman", 18.25F, System.Drawing.FontStyle.Bold);
            this.btn_Inserir.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Inserir.Location = new System.Drawing.Point(362, 440);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(182, 46);
            this.btn_Inserir.TabIndex = 13;
            this.btn_Inserir.Text = "Inserir Cliente";
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(8, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "SEGREDO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(36, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "DOCE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(868, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.btn_Sair);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}