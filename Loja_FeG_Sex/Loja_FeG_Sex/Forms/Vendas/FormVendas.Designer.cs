namespace Loja_FeG_Sex.Forms
{
    partial class FormVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendas));
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Venda = new System.Windows.Forms.Button();
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
            this.btn_Sair.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.Coral;
            this.btn_Sair.Location = new System.Drawing.Point(726, 439);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(128, 46);
            this.btn_Sair.TabIndex = 10;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Venda
            // 
            this.btn_Venda.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Venda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Venda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Venda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Venda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Venda.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Venda.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Venda.Location = new System.Drawing.Point(549, 440);
            this.btn_Venda.Name = "btn_Venda";
            this.btn_Venda.Size = new System.Drawing.Size(171, 46);
            this.btn_Venda.TabIndex = 13;
            this.btn_Venda.Text = "Efetuar Venda";
            this.btn_Venda.UseVisualStyleBackColor = false;
            this.btn_Venda.Click += new System.EventHandler(this.btn_Venda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(9, 461);
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
            this.label2.Location = new System.Drawing.Point(37, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "DOCE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(868, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Venda);
            this.Controls.Add(this.btn_Sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Venda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}