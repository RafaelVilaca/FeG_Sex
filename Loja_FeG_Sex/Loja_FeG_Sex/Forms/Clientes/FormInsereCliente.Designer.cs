namespace Loja_FeG_Sex.Forms.Cliente
{
    partial class FormInsereCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInsereCliente));
            this.grp_dados_Cliente = new System.Windows.Forms.GroupBox();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.msk_Celular = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.msk_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_Fem = new System.Windows.Forms.RadioButton();
            this.rd_Masc = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Complemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grp_dados_Cliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_dados_Cliente
            // 
            this.grp_dados_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.grp_dados_Cliente.Controls.Add(this.txt_Data);
            this.grp_dados_Cliente.Controls.Add(this.label10);
            this.grp_dados_Cliente.Controls.Add(this.msk_Celular);
            this.grp_dados_Cliente.Controls.Add(this.label9);
            this.grp_dados_Cliente.Controls.Add(this.msk_Telefone);
            this.grp_dados_Cliente.Controls.Add(this.label8);
            this.grp_dados_Cliente.Controls.Add(this.groupBox1);
            this.grp_dados_Cliente.Controls.Add(this.label3);
            this.grp_dados_Cliente.Controls.Add(this.dt_Nascimento);
            this.grp_dados_Cliente.Controls.Add(this.txt_Email);
            this.grp_dados_Cliente.Controls.Add(this.label2);
            this.grp_dados_Cliente.Controls.Add(this.txt_Nome);
            this.grp_dados_Cliente.Controls.Add(this.label1);
            this.grp_dados_Cliente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_dados_Cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grp_dados_Cliente.Location = new System.Drawing.Point(13, 13);
            this.grp_dados_Cliente.Name = "grp_dados_Cliente";
            this.grp_dados_Cliente.Size = new System.Drawing.Size(653, 136);
            this.grp_dados_Cliente.TabIndex = 0;
            this.grp_dados_Cliente.TabStop = false;
            this.grp_dados_Cliente.Text = "Dados do Cliente";
            // 
            // txt_Data
            // 
            this.txt_Data.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Data.ForeColor = System.Drawing.Color.Black;
            this.txt_Data.Location = new System.Drawing.Point(403, 93);
            this.txt_Data.MaxLength = 30;
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.ReadOnly = true;
            this.txt_Data.Size = new System.Drawing.Size(123, 22);
            this.txt_Data.TabIndex = 5;
            this.txt_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Data de Cadastro";
            // 
            // msk_Celular
            // 
            this.msk_Celular.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_Celular.ForeColor = System.Drawing.Color.Black;
            this.msk_Celular.Location = new System.Drawing.Point(532, 93);
            this.msk_Celular.Mask = "(99) 00000-0000";
            this.msk_Celular.Name = "msk_Celular";
            this.msk_Celular.Size = new System.Drawing.Size(110, 22);
            this.msk_Celular.TabIndex = 7;
            this.msk_Celular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msk_Celular.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msk_Celular_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(528, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Celular";
            // 
            // msk_Telefone
            // 
            this.msk_Telefone.ForeColor = System.Drawing.Color.Black;
            this.msk_Telefone.Location = new System.Drawing.Point(532, 42);
            this.msk_Telefone.Mask = "(99) 0000-0000";
            this.msk_Telefone.Name = "msk_Telefone";
            this.msk_Telefone.Size = new System.Drawing.Size(110, 26);
            this.msk_Telefone.TabIndex = 6;
            this.msk_Telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.msk_Telefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msk_Celular_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(528, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telefone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_Fem);
            this.groupBox1.Controls.Add(this.rd_Masc);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(292, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rd_Fem
            // 
            this.rd_Fem.AutoSize = true;
            this.rd_Fem.Location = new System.Drawing.Point(9, 53);
            this.rd_Fem.Name = "rd_Fem";
            this.rd_Fem.Size = new System.Drawing.Size(88, 23);
            this.rd_Fem.TabIndex = 1;
            this.rd_Fem.TabStop = true;
            this.rd_Fem.Text = "Feminino";
            this.rd_Fem.UseVisualStyleBackColor = true;
            // 
            // rd_Masc
            // 
            this.rd_Masc.AutoSize = true;
            this.rd_Masc.Location = new System.Drawing.Point(9, 27);
            this.rd_Masc.Name = "rd_Masc";
            this.rd_Masc.Size = new System.Drawing.Size(97, 23);
            this.rd_Masc.TabIndex = 0;
            this.rd_Masc.TabStop = true;
            this.rd_Masc.Text = "Masculino";
            this.rd_Masc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de Nasc.";
            // 
            // dt_Nascimento
            // 
            this.dt_Nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Nascimento.Location = new System.Drawing.Point(403, 42);
            this.dt_Nascimento.MaxDate = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            this.dt_Nascimento.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dt_Nascimento.Name = "dt_Nascimento";
            this.dt_Nascimento.Size = new System.Drawing.Size(123, 26);
            this.dt_Nascimento.TabIndex = 4;
            this.dt_Nascimento.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // txt_Email
            // 
            this.txt_Email.ForeColor = System.Drawing.Color.Black;
            this.txt_Email.Location = new System.Drawing.Point(11, 93);
            this.txt_Email.MaxLength = 50;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(276, 26);
            this.txt_Email.TabIndex = 2;
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // txt_Nome
            // 
            this.txt_Nome.ForeColor = System.Drawing.Color.Black;
            this.txt_Nome.Location = new System.Drawing.Point(11, 42);
            this.txt_Nome.MaxLength = 50;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(276, 26);
            this.txt_Nome.TabIndex = 1;
            this.txt_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.ForeColor = System.Drawing.Color.Black;
            this.txt_Endereco.Location = new System.Drawing.Point(12, 38);
            this.txt_Endereco.MaxLength = 50;
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(194, 26);
            this.txt_Endereco.TabIndex = 7;
            this.txt_Endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rua";
            // 
            // txt_Numero
            // 
            this.txt_Numero.ForeColor = System.Drawing.Color.Black;
            this.txt_Numero.Location = new System.Drawing.Point(212, 38);
            this.txt_Numero.MaxLength = 5;
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(66, 26);
            this.txt_Numero.TabIndex = 9;
            this.txt_Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Numero_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Numero";
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.ForeColor = System.Drawing.Color.Black;
            this.txt_Bairro.Location = new System.Drawing.Point(284, 38);
            this.txt_Bairro.MaxLength = 30;
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(167, 26);
            this.txt_Bairro.TabIndex = 11;
            this.txt_Bairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bairro";
            // 
            // txt_Complemento
            // 
            this.txt_Complemento.ForeColor = System.Drawing.Color.Black;
            this.txt_Complemento.Location = new System.Drawing.Point(457, 38);
            this.txt_Complemento.MaxLength = 30;
            this.txt_Complemento.Name = "txt_Complemento";
            this.txt_Complemento.Size = new System.Drawing.Size(186, 26);
            this.txt_Complemento.TabIndex = 13;
            this.txt_Complemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Complemento";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Complemento);
            this.groupBox2.Controls.Add(this.txt_Numero);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_Endereco);
            this.groupBox2.Controls.Add(this.txt_Bairro);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(654, 77);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
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
            this.btn_Cancelar.Location = new System.Drawing.Point(524, 238);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(142, 46);
            this.btn_Cancelar.TabIndex = 17;
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
            this.btn_Confirmar.Location = new System.Drawing.Point(366, 238);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(144, 46);
            this.btn_Confirmar.TabIndex = 16;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(10, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 30);
            this.label11.TabIndex = 23;
            this.label11.Text = "SEGREDO";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(39, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 30);
            this.label12.TabIndex = 22;
            this.label12.Text = "DOCE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInsereCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(678, 295);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_dados_Cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInsereCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInsereCliente_FormClosed);
            this.Load += new System.EventHandler(this.FormInsereCliente_Load);
            this.grp_dados_Cliente.ResumeLayout(false);
            this.grp_dados_Cliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_dados_Cliente;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_Nascimento;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msk_Celular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox msk_Telefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_Fem;
        private System.Windows.Forms.RadioButton rd_Masc;
        private System.Windows.Forms.TextBox txt_Complemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}