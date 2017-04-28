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
            this.label9 = new System.Windows.Forms.Label();
            this.nud_QTD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_Desconto = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_venda_banco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_troco = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nud_recebido = new System.Windows.Forms.NumericUpDown();
            this.grp_dados_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_QTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Desconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_recebido)).BeginInit();
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
            this.btn_Cancelar.Location = new System.Drawing.Point(399, 272);
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
            this.btn_Confirmar.Location = new System.Drawing.Point(249, 272);
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
            this.grp_dados_Cliente.Controls.Add(this.nud_recebido);
            this.grp_dados_Cliente.Controls.Add(this.txt_troco);
            this.grp_dados_Cliente.Controls.Add(this.label13);
            this.grp_dados_Cliente.Controls.Add(this.label12);
            this.grp_dados_Cliente.Controls.Add(this.txt_venda_banco);
            this.grp_dados_Cliente.Controls.Add(this.txt_Total);
            this.grp_dados_Cliente.Controls.Add(this.label11);
            this.grp_dados_Cliente.Controls.Add(this.nud_Desconto);
            this.grp_dados_Cliente.Controls.Add(this.label7);
            this.grp_dados_Cliente.Controls.Add(this.label8);
            this.grp_dados_Cliente.Controls.Add(this.label6);
            this.grp_dados_Cliente.Controls.Add(this.cb_Cliente);
            this.grp_dados_Cliente.Controls.Add(this.label3);
            this.grp_dados_Cliente.Controls.Add(this.cb_Produto);
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
            this.grp_dados_Cliente.Size = new System.Drawing.Size(525, 239);
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
            this.btn_Calc.Location = new System.Drawing.Point(133, 257);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(28, 28);
            this.btn_Calc.TabIndex = 30;
            this.btn_Calc.UseVisualStyleBackColor = false;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.DropDownHeight = 190;
            this.cb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Cliente.ForeColor = System.Drawing.Color.Black;
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.IntegralHeight = false;
            this.cb_Cliente.ItemHeight = 19;
            this.cb_Cliente.Location = new System.Drawing.Point(148, 51);
            this.cb_Cliente.MaxDropDownItems = 2;
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(358, 27);
            this.cb_Cliente.TabIndex = 29;
            this.cb_Cliente.SelectedIndexChanged += new System.EventHandler(this.cb_Cliente_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Selecionar Cliente";
            // 
            // cb_Produto
            // 
            this.cb_Produto.DropDownHeight = 190;
            this.cb_Produto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Produto.ForeColor = System.Drawing.Color.Black;
            this.cb_Produto.FormattingEnabled = true;
            this.cb_Produto.IntegralHeight = false;
            this.cb_Produto.ItemHeight = 19;
            this.cb_Produto.Location = new System.Drawing.Point(148, 17);
            this.cb_Produto.MaxDropDownItems = 2;
            this.cb_Produto.Name = "cb_Produto";
            this.cb_Produto.Size = new System.Drawing.Size(358, 27);
            this.cb_Produto.TabIndex = 27;
            this.cb_Produto.SelectedIndexChanged += new System.EventHandler(this.cb_Produto_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(7, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Valor da Venda:";
            // 
            // nud_QTD
            // 
            this.nud_QTD.ForeColor = System.Drawing.Color.Black;
            this.nud_QTD.Location = new System.Drawing.Point(431, 86);
            this.nud_QTD.Name = "nud_QTD";
            this.nud_QTD.Size = new System.Drawing.Size(75, 26);
            this.nud_QTD.TabIndex = 22;
            this.nud_QTD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_QTD.ValueChanged += new System.EventHandler(this.nud_QTD_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(339, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantidade";
            // 
            // txt_Data
            // 
            this.txt_Data.ForeColor = System.Drawing.Color.Black;
            this.txt_Data.Location = new System.Drawing.Point(147, 85);
            this.txt_Data.MaxLength = 30;
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.ReadOnly = true;
            this.txt_Data.Size = new System.Drawing.Size(186, 26);
            this.txt_Data.TabIndex = 20;
            this.txt_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(99, 88);
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
            this.label5.Location = new System.Drawing.Point(20, 288);
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
            this.label4.Location = new System.Drawing.Point(49, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "DOCE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(7, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "R$";
            // 
            // nud_Desconto
            // 
            this.nud_Desconto.DecimalPlaces = 2;
            this.nud_Desconto.ForeColor = System.Drawing.Color.Black;
            this.nud_Desconto.Location = new System.Drawing.Point(179, 141);
            this.nud_Desconto.Name = "nud_Desconto";
            this.nud_Desconto.Size = new System.Drawing.Size(75, 26);
            this.nud_Desconto.TabIndex = 34;
            this.nud_Desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Desconto.ThousandsSeparator = true;
            this.nud_Desconto.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(144, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 19);
            this.label7.TabIndex = 33;
            this.label7.Text = "R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(168, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Desconto:";
            // 
            // txt_Total
            // 
            this.txt_Total.ForeColor = System.Drawing.Color.Black;
            this.txt_Total.Location = new System.Drawing.Point(399, 138);
            this.txt_Total.MaxLength = 30;
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(107, 26);
            this.txt_Total.TabIndex = 36;
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(272, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "Total à Receber:";
            // 
            // txt_venda_banco
            // 
            this.txt_venda_banco.Location = new System.Drawing.Point(38, 141);
            this.txt_venda_banco.Name = "txt_venda_banco";
            this.txt_venda_banco.ReadOnly = true;
            this.txt_venda_banco.Size = new System.Drawing.Size(85, 26);
            this.txt_venda_banco.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(272, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Total Recebido:";
            // 
            // txt_troco
            // 
            this.txt_troco.ForeColor = System.Drawing.Color.Black;
            this.txt_troco.Location = new System.Drawing.Point(399, 205);
            this.txt_troco.MaxLength = 30;
            this.txt_troco.Name = "txt_troco";
            this.txt_troco.ReadOnly = true;
            this.txt_troco.Size = new System.Drawing.Size(107, 26);
            this.txt_troco.TabIndex = 41;
            this.txt_troco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(338, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 19);
            this.label13.TabIndex = 40;
            this.label13.Text = "Troco:";
            // 
            // nud_recebido
            // 
            this.nud_recebido.DecimalPlaces = 2;
            this.nud_recebido.ForeColor = System.Drawing.Color.Black;
            this.nud_recebido.Location = new System.Drawing.Point(399, 172);
            this.nud_recebido.Name = "nud_recebido";
            this.nud_recebido.Size = new System.Drawing.Size(107, 26);
            this.nud_recebido.TabIndex = 42;
            this.nud_recebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_recebido.ThousandsSeparator = true;
            this.nud_recebido.ValueChanged += new System.EventHandler(this.nud_recebido_ValueChanged);
            // 
            // FormInsereVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(551, 330);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.grp_dados_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            ((System.ComponentModel.ISupportInitialize)(this.nud_Desconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_recebido)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nud_QTD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nud_Desconto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_venda_banco;
        private System.Windows.Forms.NumericUpDown nud_recebido;
        private System.Windows.Forms.TextBox txt_troco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}