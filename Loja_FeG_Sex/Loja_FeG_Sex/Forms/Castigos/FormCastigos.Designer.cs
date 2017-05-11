namespace Loja_FeG_Sex.Forms.Castigos
{
    partial class FormCastigos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCastigos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_editarCha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grp_Decrescente = new System.Windows.Forms.GroupBox();
            this.btn_pessoa_desc = new System.Windows.Forms.Button();
            this.btn_descricao_dec = new System.Windows.Forms.Button();
            this.grp_Crescente = new System.Windows.Forms.GroupBox();
            this.btn_pessoa_asc = new System.Windows.Forms.Button();
            this.btn_descricao_asc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_Castigo = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_insereCha = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.grp_Decrescente.SuspendLayout();
            this.grp_Crescente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Castigo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_editarCha
            // 
            this.btn_editarCha.BackColor = System.Drawing.Color.Red;
            this.btn_editarCha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editarCha.BackgroundImage")));
            this.btn_editarCha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editarCha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_editarCha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_editarCha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_editarCha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editarCha.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarCha.ForeColor = System.Drawing.Color.Transparent;
            this.btn_editarCha.Location = new System.Drawing.Point(662, 155);
            this.btn_editarCha.Name = "btn_editarCha";
            this.btn_editarCha.Size = new System.Drawing.Size(229, 46);
            this.btn_editarCha.TabIndex = 4;
            this.btn_editarCha.Text = "Editar Castigo";
            this.btn_editarCha.UseVisualStyleBackColor = false;
            this.btn_editarCha.Click += new System.EventHandler(this.btn_editarCha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(739, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 51;
            this.label2.Text = "DOCE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.grp_Decrescente);
            this.groupBox2.Controls.Add(this.grp_Crescente);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Location = new System.Drawing.Point(262, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenação";
            // 
            // grp_Decrescente
            // 
            this.grp_Decrescente.BackColor = System.Drawing.Color.Transparent;
            this.grp_Decrescente.Controls.Add(this.btn_pessoa_desc);
            this.grp_Decrescente.Controls.Add(this.btn_descricao_dec);
            this.grp_Decrescente.ForeColor = System.Drawing.Color.AliceBlue;
            this.grp_Decrescente.Location = new System.Drawing.Point(201, 13);
            this.grp_Decrescente.Name = "grp_Decrescente";
            this.grp_Decrescente.Size = new System.Drawing.Size(182, 50);
            this.grp_Decrescente.TabIndex = 1;
            this.grp_Decrescente.TabStop = false;
            this.grp_Decrescente.Text = "Decrescente:";
            // 
            // btn_pessoa_desc
            // 
            this.btn_pessoa_desc.BackColor = System.Drawing.Color.Red;
            this.btn_pessoa_desc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pessoa_desc.BackgroundImage")));
            this.btn_pessoa_desc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pessoa_desc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_pessoa_desc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_pessoa_desc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_pessoa_desc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pessoa_desc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pessoa_desc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_pessoa_desc.Location = new System.Drawing.Point(93, 16);
            this.btn_pessoa_desc.Name = "btn_pessoa_desc";
            this.btn_pessoa_desc.Size = new System.Drawing.Size(81, 25);
            this.btn_pessoa_desc.TabIndex = 1;
            this.btn_pessoa_desc.Text = "Pessoa";
            this.btn_pessoa_desc.UseVisualStyleBackColor = false;
            this.btn_pessoa_desc.Click += new System.EventHandler(this.btn_pessoa_desc_Click);
            // 
            // btn_descricao_dec
            // 
            this.btn_descricao_dec.BackColor = System.Drawing.Color.Red;
            this.btn_descricao_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_descricao_dec.BackgroundImage")));
            this.btn_descricao_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_descricao_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_descricao_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_descricao_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_descricao_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_descricao_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descricao_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_descricao_dec.Location = new System.Drawing.Point(6, 16);
            this.btn_descricao_dec.Name = "btn_descricao_dec";
            this.btn_descricao_dec.Size = new System.Drawing.Size(81, 25);
            this.btn_descricao_dec.TabIndex = 0;
            this.btn_descricao_dec.Text = "Descrição";
            this.btn_descricao_dec.UseVisualStyleBackColor = false;
            this.btn_descricao_dec.Click += new System.EventHandler(this.btn_descricao_dec_Click);
            // 
            // grp_Crescente
            // 
            this.grp_Crescente.BackColor = System.Drawing.Color.Transparent;
            this.grp_Crescente.Controls.Add(this.btn_pessoa_asc);
            this.grp_Crescente.Controls.Add(this.btn_descricao_asc);
            this.grp_Crescente.ForeColor = System.Drawing.Color.AliceBlue;
            this.grp_Crescente.Location = new System.Drawing.Point(11, 12);
            this.grp_Crescente.Name = "grp_Crescente";
            this.grp_Crescente.Size = new System.Drawing.Size(184, 50);
            this.grp_Crescente.TabIndex = 0;
            this.grp_Crescente.TabStop = false;
            this.grp_Crescente.Text = "Crescente:";
            // 
            // btn_pessoa_asc
            // 
            this.btn_pessoa_asc.BackColor = System.Drawing.Color.Red;
            this.btn_pessoa_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pessoa_asc.BackgroundImage")));
            this.btn_pessoa_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pessoa_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_pessoa_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_pessoa_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_pessoa_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pessoa_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pessoa_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_pessoa_asc.Location = new System.Drawing.Point(93, 17);
            this.btn_pessoa_asc.Name = "btn_pessoa_asc";
            this.btn_pessoa_asc.Size = new System.Drawing.Size(81, 25);
            this.btn_pessoa_asc.TabIndex = 1;
            this.btn_pessoa_asc.Text = "Pessoa";
            this.btn_pessoa_asc.UseVisualStyleBackColor = false;
            this.btn_pessoa_asc.Click += new System.EventHandler(this.btn_pessoa_asc_Click);
            // 
            // btn_descricao_asc
            // 
            this.btn_descricao_asc.BackColor = System.Drawing.Color.Red;
            this.btn_descricao_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_descricao_asc.BackgroundImage")));
            this.btn_descricao_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_descricao_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_descricao_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_descricao_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_descricao_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_descricao_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descricao_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_descricao_asc.Location = new System.Drawing.Point(6, 17);
            this.btn_descricao_asc.Name = "btn_descricao_asc";
            this.btn_descricao_asc.Size = new System.Drawing.Size(81, 25);
            this.btn_descricao_asc.TabIndex = 0;
            this.btn_descricao_asc.Text = "Descrição";
            this.btn_descricao_asc.UseVisualStyleBackColor = false;
            this.btn_descricao_asc.Click += new System.EventHandler(this.btn_descricao_asc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_Descricao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela";
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.ForeColor = System.Drawing.Color.DarkBlue;
            this.txt_Descricao.Location = new System.Drawing.Point(8, 36);
            this.txt_Descricao.MaxLength = 50;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(227, 21);
            this.txt_Descricao.TabIndex = 1;
            this.txt_Descricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Descricao.TextChanged += new System.EventHandler(this.txt_Descricao_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(59, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Busca pela Descrição:";
            // 
            // dtg_Castigo
            // 
            this.dtg_Castigo.AllowUserToAddRows = false;
            this.dtg_Castigo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.dtg_Castigo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Castigo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Castigo.BackgroundColor = System.Drawing.Color.Maroon;
            this.dtg_Castigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Castigo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Castigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Castigo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.Pessoa});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Castigo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_Castigo.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_Castigo.Location = new System.Drawing.Point(12, 83);
            this.dtg_Castigo.Name = "dtg_Castigo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Castigo.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_Castigo.RowHeadersVisible = false;
            this.dtg_Castigo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Castigo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_Castigo.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtg_Castigo.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.MistyRose;
            this.dtg_Castigo.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
            this.dtg_Castigo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Red;
            this.dtg_Castigo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtg_Castigo.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Castigo.Size = new System.Drawing.Size(644, 416);
            this.dtg_Castigo.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(712, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 30);
            this.label5.TabIndex = 49;
            this.label5.Text = "SEGREDO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_insereCha
            // 
            this.btn_insereCha.BackColor = System.Drawing.Color.Red;
            this.btn_insereCha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_insereCha.BackgroundImage")));
            this.btn_insereCha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_insereCha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_insereCha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_insereCha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_insereCha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insereCha.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insereCha.ForeColor = System.Drawing.Color.Transparent;
            this.btn_insereCha.Location = new System.Drawing.Point(661, 93);
            this.btn_insereCha.Name = "btn_insereCha";
            this.btn_insereCha.Size = new System.Drawing.Size(229, 46);
            this.btn_insereCha.TabIndex = 3;
            this.btn_insereCha.Text = "Inserir Castigo";
            this.btn_insereCha.UseVisualStyleBackColor = false;
            this.btn_insereCha.Click += new System.EventHandler(this.btn_insereCha_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.Red;
            this.btn_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sair.BackgroundImage")));
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Sair.Location = new System.Drawing.Point(662, 217);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(230, 46);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Descricao.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descricao.HeaderText = "Descricao do Castigo";
            this.Descricao.MaxInputLength = 200;
            this.Descricao.Name = "Descricao";
            this.Descricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descricao.Width = 520;
            // 
            // Pessoa
            // 
            this.Pessoa.DataPropertyName = "Referente";
            this.Pessoa.HeaderText = "Pessoa";
            this.Pessoa.MaxInputLength = 15;
            this.Pessoa.Name = "Pessoa";
            this.Pessoa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FormCastigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 508);
            this.Controls.Add(this.btn_editarCha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_Castigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_insereCha);
            this.Controls.Add(this.btn_Sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCastigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Castigos";
            this.Load += new System.EventHandler(this.FormCastigos_Load);
            this.groupBox2.ResumeLayout(false);
            this.grp_Decrescente.ResumeLayout(false);
            this.grp_Crescente.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Castigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_editarCha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grp_Decrescente;
        private System.Windows.Forms.Button btn_descricao_dec;
        private System.Windows.Forms.GroupBox grp_Crescente;
        private System.Windows.Forms.Button btn_descricao_asc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtg_Castigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_insereCha;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_pessoa_desc;
        private System.Windows.Forms.Button btn_pessoa_asc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pessoa;
    }
}