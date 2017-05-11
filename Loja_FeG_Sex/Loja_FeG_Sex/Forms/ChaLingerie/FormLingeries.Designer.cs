namespace Loja_FeG_Sex.Forms.ChaLingerie
{
    partial class FormLingeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLingeries));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grp_Decrescente = new System.Windows.Forms.GroupBox();
            this.btn_transa_dec = new System.Windows.Forms.Button();
            this.btn_nome_dec = new System.Windows.Forms.Button();
            this.grp_Crescente = new System.Windows.Forms.GroupBox();
            this.btn_transa_asc = new System.Windows.Forms.Button();
            this.btn_nome_asc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_inicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_ChaLingerie = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_insereCha = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_editarCha = new System.Windows.Forms.Button();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorFormatado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.grp_Decrescente.SuspendLayout();
            this.grp_Crescente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChaLingerie)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.grp_Decrescente);
            this.groupBox2.Controls.Add(this.grp_Crescente);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Location = new System.Drawing.Point(508, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenação";
            // 
            // grp_Decrescente
            // 
            this.grp_Decrescente.BackColor = System.Drawing.Color.Transparent;
            this.grp_Decrescente.Controls.Add(this.btn_transa_dec);
            this.grp_Decrescente.Controls.Add(this.btn_nome_dec);
            this.grp_Decrescente.ForeColor = System.Drawing.Color.AliceBlue;
            this.grp_Decrescente.Location = new System.Drawing.Point(202, 12);
            this.grp_Decrescente.Name = "grp_Decrescente";
            this.grp_Decrescente.Size = new System.Drawing.Size(181, 50);
            this.grp_Decrescente.TabIndex = 1;
            this.grp_Decrescente.TabStop = false;
            this.grp_Decrescente.Text = "Decrescente:";
            // 
            // btn_transa_dec
            // 
            this.btn_transa_dec.BackColor = System.Drawing.Color.Navy;
            this.btn_transa_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_transa_dec.BackgroundImage")));
            this.btn_transa_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_transa_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_transa_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_transa_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_transa_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_transa_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transa_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_transa_dec.Location = new System.Drawing.Point(93, 17);
            this.btn_transa_dec.Name = "btn_transa_dec";
            this.btn_transa_dec.Size = new System.Drawing.Size(81, 25);
            this.btn_transa_dec.TabIndex = 1;
            this.btn_transa_dec.Text = "Data Evento";
            this.btn_transa_dec.UseVisualStyleBackColor = false;
            this.btn_transa_dec.Click += new System.EventHandler(this.btn_transa_dec_Click);
            // 
            // btn_nome_dec
            // 
            this.btn_nome_dec.BackColor = System.Drawing.Color.Navy;
            this.btn_nome_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nome_dec.BackgroundImage")));
            this.btn_nome_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nome_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_nome_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_nome_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_nome_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nome_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nome_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_nome_dec.Location = new System.Drawing.Point(6, 17);
            this.btn_nome_dec.Name = "btn_nome_dec";
            this.btn_nome_dec.Size = new System.Drawing.Size(81, 25);
            this.btn_nome_dec.TabIndex = 0;
            this.btn_nome_dec.Text = "Nome";
            this.btn_nome_dec.UseVisualStyleBackColor = false;
            this.btn_nome_dec.Click += new System.EventHandler(this.btn_nome_dec_Click);
            // 
            // grp_Crescente
            // 
            this.grp_Crescente.BackColor = System.Drawing.Color.Transparent;
            this.grp_Crescente.Controls.Add(this.btn_transa_asc);
            this.grp_Crescente.Controls.Add(this.btn_nome_asc);
            this.grp_Crescente.ForeColor = System.Drawing.Color.AliceBlue;
            this.grp_Crescente.Location = new System.Drawing.Point(11, 12);
            this.grp_Crescente.Name = "grp_Crescente";
            this.grp_Crescente.Size = new System.Drawing.Size(187, 50);
            this.grp_Crescente.TabIndex = 0;
            this.grp_Crescente.TabStop = false;
            this.grp_Crescente.Text = "Crescente:";
            // 
            // btn_transa_asc
            // 
            this.btn_transa_asc.BackColor = System.Drawing.Color.Navy;
            this.btn_transa_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_transa_asc.BackgroundImage")));
            this.btn_transa_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_transa_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_transa_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_transa_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_transa_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_transa_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transa_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_transa_asc.Location = new System.Drawing.Point(96, 17);
            this.btn_transa_asc.Name = "btn_transa_asc";
            this.btn_transa_asc.Size = new System.Drawing.Size(81, 25);
            this.btn_transa_asc.TabIndex = 1;
            this.btn_transa_asc.Text = "Data Evento";
            this.btn_transa_asc.UseVisualStyleBackColor = false;
            this.btn_transa_asc.Click += new System.EventHandler(this.btn_transa_asc_Click);
            // 
            // btn_nome_asc
            // 
            this.btn_nome_asc.BackColor = System.Drawing.Color.Navy;
            this.btn_nome_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nome_asc.BackgroundImage")));
            this.btn_nome_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nome_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_nome_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_nome_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_nome_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nome_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nome_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_nome_asc.Location = new System.Drawing.Point(6, 17);
            this.btn_nome_asc.Name = "btn_nome_asc";
            this.btn_nome_asc.Size = new System.Drawing.Size(81, 25);
            this.btn_nome_asc.TabIndex = 0;
            this.btn_nome_asc.Text = "Nome";
            this.btn_nome_asc.UseVisualStyleBackColor = false;
            this.btn_nome_asc.Click += new System.EventHandler(this.btn_nome_asc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_inicial);
            this.groupBox1.Controls.Add(this.dtp_final);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(241, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Data Inicial Evento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(355, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Data Final Evento:";
            // 
            // dtp_inicial
            // 
            this.dtp_inicial.CalendarForeColor = System.Drawing.Color.DarkBlue;
            this.dtp_inicial.CalendarTitleForeColor = System.Drawing.Color.DarkBlue;
            this.dtp_inicial.CalendarTrailingForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicial.Location = new System.Drawing.Point(244, 36);
            this.dtp_inicial.Name = "dtp_inicial";
            this.dtp_inicial.Size = new System.Drawing.Size(102, 21);
            this.dtp_inicial.TabIndex = 2;
            this.dtp_inicial.Value = new System.DateTime(2016, 4, 28, 14, 19, 0, 0);
            this.dtp_inicial.ValueChanged += new System.EventHandler(this.dtp_inicial_ValueChanged);
            // 
            // dtp_final
            // 
            this.dtp_final.CalendarForeColor = System.Drawing.Color.DarkBlue;
            this.dtp_final.CalendarTitleForeColor = System.Drawing.Color.DarkBlue;
            this.dtp_final.CalendarTrailingForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(356, 36);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(102, 21);
            this.dtp_final.TabIndex = 3;
            this.dtp_final.ValueChanged += new System.EventHandler(this.dtp_final_ValueChanged);
            // 
            // txt_Nome
            // 
            this.txt_Nome.ForeColor = System.Drawing.Color.DarkBlue;
            this.txt_Nome.Location = new System.Drawing.Point(8, 36);
            this.txt_Nome.MaxLength = 50;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(227, 21);
            this.txt_Nome.TabIndex = 1;
            this.txt_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(42, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Busca pelo Nome do Cliente:";
            // 
            // dtg_ChaLingerie
            // 
            this.dtg_ChaLingerie.AllowUserToAddRows = false;
            this.dtg_ChaLingerie.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.dtg_ChaLingerie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_ChaLingerie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_ChaLingerie.BackgroundColor = System.Drawing.Color.Navy;
            this.dtg_ChaLingerie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_ChaLingerie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_ChaLingerie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ChaLingerie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCliente,
            this.Descricao,
            this.Data_Evento,
            this.Data_Cadastro,
            this.valorFormatado});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_ChaLingerie.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_ChaLingerie.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_ChaLingerie.Location = new System.Drawing.Point(12, 83);
            this.dtg_ChaLingerie.Name = "dtg_ChaLingerie";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_ChaLingerie.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_ChaLingerie.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_ChaLingerie.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_ChaLingerie.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_ChaLingerie.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dtg_ChaLingerie.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_ChaLingerie.Size = new System.Drawing.Size(892, 416);
            this.dtg_ChaLingerie.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(964, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 30);
            this.label5.TabIndex = 39;
            this.label5.Text = "SEGREDO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_insereCha
            // 
            this.btn_insereCha.BackColor = System.Drawing.Color.Navy;
            this.btn_insereCha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_insereCha.BackgroundImage")));
            this.btn_insereCha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_insereCha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_insereCha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_insereCha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_insereCha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_insereCha.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insereCha.ForeColor = System.Drawing.Color.Transparent;
            this.btn_insereCha.Location = new System.Drawing.Point(909, 93);
            this.btn_insereCha.Name = "btn_insereCha";
            this.btn_insereCha.Size = new System.Drawing.Size(229, 46);
            this.btn_insereCha.TabIndex = 3;
            this.btn_insereCha.Text = "Inserir Chá";
            this.btn_insereCha.UseVisualStyleBackColor = false;
            this.btn_insereCha.Click += new System.EventHandler(this.btn_insereCliente_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.Navy;
            this.btn_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sair.BackgroundImage")));
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Sair.Location = new System.Drawing.Point(910, 217);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(230, 46);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(991, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 43;
            this.label2.Text = "DOCE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_editarCha
            // 
            this.btn_editarCha.BackColor = System.Drawing.Color.Navy;
            this.btn_editarCha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editarCha.BackgroundImage")));
            this.btn_editarCha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editarCha.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_editarCha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_editarCha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_editarCha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editarCha.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarCha.ForeColor = System.Drawing.Color.Transparent;
            this.btn_editarCha.Location = new System.Drawing.Point(910, 155);
            this.btn_editarCha.Name = "btn_editarCha";
            this.btn_editarCha.Size = new System.Drawing.Size(229, 46);
            this.btn_editarCha.TabIndex = 4;
            this.btn_editarCha.Text = "Editar Chá";
            this.btn_editarCha.UseVisualStyleBackColor = false;
            this.btn_editarCha.Click += new System.EventHandler(this.btn_editaCliente_Click);
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "Nome";
            this.NomeCliente.HeaderText = "Nome Cliente";
            this.NomeCliente.MaxInputLength = 100;
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeCliente.Width = 200;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Descricao.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descricao.HeaderText = "Descricao do Chá";
            this.Descricao.MaxInputLength = 200;
            this.Descricao.Name = "Descricao";
            this.Descricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descricao.Width = 245;
            // 
            // Data_Evento
            // 
            this.Data_Evento.DataPropertyName = "Data_Evento";
            this.Data_Evento.HeaderText = "Data do Evento";
            this.Data_Evento.MaxInputLength = 30;
            this.Data_Evento.Name = "Data_Evento";
            this.Data_Evento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Evento.Width = 150;
            // 
            // Data_Cadastro
            // 
            this.Data_Cadastro.DataPropertyName = "Data_Cadastro";
            this.Data_Cadastro.HeaderText = "Data do Cadastro";
            this.Data_Cadastro.MaxInputLength = 15;
            this.Data_Cadastro.Name = "Data_Cadastro";
            this.Data_Cadastro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Cadastro.Width = 150;
            // 
            // valorFormatado
            // 
            this.valorFormatado.DataPropertyName = "ValorFormatado";
            this.valorFormatado.HeaderText = "Valor Recebido";
            this.valorFormatado.MaxInputLength = 15;
            this.valorFormatado.Name = "valorFormatado";
            this.valorFormatado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.valorFormatado.Width = 120;
            // 
            // FormLingeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 513);
            this.Controls.Add(this.btn_editarCha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_ChaLingerie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_insereCha);
            this.Controls.Add(this.btn_Sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLingeries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chá de Lingeries";
            this.Load += new System.EventHandler(this.FormLingeries_Load);
            this.groupBox2.ResumeLayout(false);
            this.grp_Decrescente.ResumeLayout(false);
            this.grp_Crescente.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ChaLingerie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grp_Decrescente;
        private System.Windows.Forms.Button btn_transa_dec;
        private System.Windows.Forms.Button btn_nome_dec;
        private System.Windows.Forms.GroupBox grp_Crescente;
        private System.Windows.Forms.Button btn_transa_asc;
        private System.Windows.Forms.Button btn_nome_asc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_inicial;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtg_ChaLingerie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_insereCha;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_editarCha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorFormatado;
    }
}