namespace Loja_FeG_Sex.Forms.Produtos
{
    partial class FormInsereProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsereProduto));
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.grp_dados_Cliente = new System.Windows.Forms.GroupBox();
            this.msk_Venda = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.msk_Unidade = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_dados_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancelar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Coral;
            this.btn_Cancelar.Location = new System.Drawing.Point(469, 154);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(142, 46);
            this.btn_Cancelar.TabIndex = 21;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Confirmar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Confirmar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Confirmar.Location = new System.Drawing.Point(310, 154);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(144, 46);
            this.btn_Confirmar.TabIndex = 20;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            // 
            // grp_dados_Cliente
            // 
            this.grp_dados_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.grp_dados_Cliente.Controls.Add(this.msk_Venda);
            this.grp_dados_Cliente.Controls.Add(this.label9);
            this.grp_dados_Cliente.Controls.Add(this.msk_Unidade);
            this.grp_dados_Cliente.Controls.Add(this.label8);
            this.grp_dados_Cliente.Controls.Add(this.numericUpDown1);
            this.grp_dados_Cliente.Controls.Add(this.label2);
            this.grp_dados_Cliente.Controls.Add(this.txt_Data);
            this.grp_dados_Cliente.Controls.Add(this.label10);
            this.grp_dados_Cliente.Controls.Add(this.txt_Nome);
            this.grp_dados_Cliente.Controls.Add(this.label1);
            this.grp_dados_Cliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_dados_Cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grp_dados_Cliente.Location = new System.Drawing.Point(12, 12);
            this.grp_dados_Cliente.Name = "grp_dados_Cliente";
            this.grp_dados_Cliente.Size = new System.Drawing.Size(599, 136);
            this.grp_dados_Cliente.TabIndex = 18;
            this.grp_dados_Cliente.TabStop = false;
            this.grp_dados_Cliente.Text = "Dados do Produto";
            // 
            // msk_Venda
            // 
            this.msk_Venda.Location = new System.Drawing.Point(280, 102);
            this.msk_Venda.Mask = "$ 000,00";
            this.msk_Venda.Name = "msk_Venda";
            this.msk_Venda.Size = new System.Drawing.Size(110, 26);
            this.msk_Venda.TabIndex = 25;
            this.msk_Venda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(276, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Valor de Venda";
            // 
            // msk_Unidade
            // 
            this.msk_Unidade.Location = new System.Drawing.Point(140, 102);
            this.msk_Unidade.Mask = "$ 000,00";
            this.msk_Unidade.Name = "msk_Unidade";
            this.msk_Unidade.Size = new System.Drawing.Size(130, 26);
            this.msk_Unidade.TabIndex = 23;
            this.msk_Unidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(140, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Valor por Unidade";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(511, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 26);
            this.numericUpDown1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(507, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantidade";
            // 
            // txt_Data
            // 
            this.txt_Data.Location = new System.Drawing.Point(11, 102);
            this.txt_Data.MaxLength = 30;
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.ReadOnly = true;
            this.txt_Data.Size = new System.Drawing.Size(123, 26);
            this.txt_Data.TabIndex = 20;
            this.txt_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(7, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Data de Cadastro";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(11, 42);
            this.txt_Nome.MaxLength = 100;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(485, 26);
            this.txt_Nome.TabIndex = 1;
            this.txt_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição do Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(5, 176);
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
            this.label3.Location = new System.Drawing.Point(33, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "DOCE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInsereProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(625, 206);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.grp_dados_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInsereProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.grp_dados_Cliente.ResumeLayout(false);
            this.grp_dados_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.GroupBox grp_dados_Cliente;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_Venda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox msk_Unidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}