namespace Loja_FeG_Sex.Forms.Vendas
{
    partial class FormInsereVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsereVenda));
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.grp_dados_Cliente = new System.Windows.Forms.GroupBox();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Produto = new System.Windows.Forms.ComboBox();
            this.msk_Venda = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nud_QTD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grp_dados_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_QTD)).BeginInit();
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
            this.btn_Cancelar.Location = new System.Drawing.Point(395, 180);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(142, 46);
            this.btn_Cancelar.TabIndex = 24;
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
            this.btn_Confirmar.Location = new System.Drawing.Point(245, 180);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(144, 46);
            this.btn_Confirmar.TabIndex = 23;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // grp_dados_Cliente
            // 
            this.grp_dados_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.grp_dados_Cliente.Controls.Add(this.btn_Calc);
            this.grp_dados_Cliente.Controls.Add(this.cb_Cliente);
            this.grp_dados_Cliente.Controls.Add(this.label3);
            this.grp_dados_Cliente.Controls.Add(this.cb_Produto);
            this.grp_dados_Cliente.Controls.Add(this.msk_Venda);
            this.grp_dados_Cliente.Controls.Add(this.label9);
            this.grp_dados_Cliente.Controls.Add(this.nud_QTD);
            this.grp_dados_Cliente.Controls.Add(this.label2);
            this.grp_dados_Cliente.Controls.Add(this.txt_Data);
            this.grp_dados_Cliente.Controls.Add(this.label10);
            this.grp_dados_Cliente.Controls.Add(this.label1);
            this.grp_dados_Cliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_dados_Cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grp_dados_Cliente.Location = new System.Drawing.Point(12, 12);
            this.grp_dados_Cliente.Name = "grp_dados_Cliente";
            this.grp_dados_Cliente.Size = new System.Drawing.Size(525, 162);
            this.grp_dados_Cliente.TabIndex = 22;
            this.grp_dados_Cliente.TabStop = false;
            this.grp_dados_Cliente.Text = "Dados da Venda";
            // 
            // btn_Calc
            // 
            this.btn_Calc.BackColor = System.Drawing.Color.Navy;
            this.btn_Calc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Calc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Calc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Calc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Calc.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Calc.Location = new System.Drawing.Point(327, 83);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(179, 59);
            this.btn_Calc.TabIndex = 30;
            this.btn_Calc.Text = "Calculadora";
            this.btn_Calc.UseVisualStyleBackColor = false;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.ForeColor = System.Drawing.Color.Black;
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.Location = new System.Drawing.Point(148, 50);
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(358, 27);
            this.cb_Cliente.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Selecionar Cliente";
            // 
            // cb_Produto
            // 
            this.cb_Produto.ForeColor = System.Drawing.Color.Black;
            this.cb_Produto.FormattingEnabled = true;
            this.cb_Produto.Location = new System.Drawing.Point(148, 17);
            this.cb_Produto.Name = "cb_Produto";
            this.cb_Produto.Size = new System.Drawing.Size(358, 27);
            this.cb_Produto.TabIndex = 27;
            // 
            // msk_Venda
            // 
            this.msk_Venda.ForeColor = System.Drawing.Color.Black;
            this.msk_Venda.Location = new System.Drawing.Point(31, 116);
            this.msk_Venda.Mask = "$ 000,00";
            this.msk_Venda.Name = "msk_Venda";
            this.msk_Venda.Size = new System.Drawing.Size(107, 26);
            this.msk_Venda.TabIndex = 25;
            this.msk_Venda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(27, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Valor de Venda";
            // 
            // nud_QTD
            // 
            this.nud_QTD.ForeColor = System.Drawing.Color.Black;
            this.nud_QTD.Location = new System.Drawing.Point(246, 84);
            this.nud_QTD.Name = "nud_QTD";
            this.nud_QTD.Size = new System.Drawing.Size(75, 26);
            this.nud_QTD.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(154, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantidade";
            // 
            // txt_Data
            // 
            this.txt_Data.ForeColor = System.Drawing.Color.Black;
            this.txt_Data.Location = new System.Drawing.Point(205, 116);
            this.txt_Data.MaxLength = 30;
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.ReadOnly = true;
            this.txt_Data.Size = new System.Drawing.Size(116, 26);
            this.txt_Data.TabIndex = 20;
            this.txt_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(154, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecionar Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(9, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 30);
            this.label5.TabIndex = 26;
            this.label5.Text = "SEGREDO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(38, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "DOCE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInsereVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(551, 242);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.grp_dados_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInsereVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Venda";
            this.Load += new System.EventHandler(this.FormInsereVenda_Load);
            this.grp_dados_Cliente.ResumeLayout(false);
            this.grp_dados_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_QTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.GroupBox grp_dados_Cliente;
        private System.Windows.Forms.ComboBox cb_Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Produto;
        private System.Windows.Forms.MaskedTextBox msk_Venda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nud_QTD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}