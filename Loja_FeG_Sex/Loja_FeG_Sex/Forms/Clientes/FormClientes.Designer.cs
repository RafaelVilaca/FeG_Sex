namespace Loja_FeG_Sex.Forms.Clientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_Clientes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grp_Decrescente = new System.Windows.Forms.GroupBox();
            this.btn_dtCad_dec = new System.Windows.Forms.Button();
            this.btn_sexo_dec = new System.Windows.Forms.Button();
            this.btn_dtNasc_dec = new System.Windows.Forms.Button();
            this.btn_nome_dec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_Crescente = new System.Windows.Forms.GroupBox();
            this.btn_dtCad_asc = new System.Windows.Forms.Button();
            this.btn_sexo_asc = new System.Windows.Forms.Button();
            this.btn_qtde_asc = new System.Windows.Forms.Button();
            this.btn_nome_asc = new System.Windows.Forms.Button();
            this.txt_Busca = new System.Windows.Forms.TextBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt_Nasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt_Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp_Decrescente.SuspendLayout();
            this.grp_Crescente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sair.BackgroundImage")));
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Sair.Location = new System.Drawing.Point(1039, 13);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(67, 46);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Inserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Inserir.BackgroundImage")));
            this.btn_Inserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Inserir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Inserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Inserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Inserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Inserir.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inserir.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Inserir.Location = new System.Drawing.Point(872, 13);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(67, 46);
            this.btn_Inserir.TabIndex = 1;
            this.btn_Inserir.Text = "Inserir Cliente";
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1164, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "SEGREDO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1192, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "DOCE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtg_Clientes
            // 
            this.dtg_Clientes.AllowUserToAddRows = false;
            this.dtg_Clientes.AllowUserToDeleteRows = false;
            this.dtg_Clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dtg_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Email,
            this.Dt_Nasc,
            this.Sexo,
            this.Dt_Cadastro,
            this.Telefone,
            this.Celular,
            this.Endereco,
            this.Situacao});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Clientes.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_Clientes.Location = new System.Drawing.Point(13, 71);
            this.dtg_Clientes.Name = "dtg_Clientes";
            this.dtg_Clientes.RowHeadersVisible = false;
            this.dtg_Clientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Clientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_Clientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_Clientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dtg_Clientes.Size = new System.Drawing.Size(1303, 415);
            this.dtg_Clientes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.grp_Decrescente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grp_Crescente);
            this.groupBox1.Controls.Add(this.txt_Busca);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela";
            // 
            // grp_Decrescente
            // 
            this.grp_Decrescente.BackColor = System.Drawing.Color.Transparent;
            this.grp_Decrescente.Controls.Add(this.btn_dtCad_dec);
            this.grp_Decrescente.Controls.Add(this.btn_sexo_dec);
            this.grp_Decrescente.Controls.Add(this.btn_dtNasc_dec);
            this.grp_Decrescente.Controls.Add(this.btn_nome_dec);
            this.grp_Decrescente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grp_Decrescente.Location = new System.Drawing.Point(557, 8);
            this.grp_Decrescente.Name = "grp_Decrescente";
            this.grp_Decrescente.Size = new System.Drawing.Size(267, 53);
            this.grp_Decrescente.TabIndex = 2;
            this.grp_Decrescente.TabStop = false;
            this.grp_Decrescente.Text = "Ordenar por ordem Decrescente:";
            // 
            // btn_dtCad_dec
            // 
            this.btn_dtCad_dec.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_dtCad_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dtCad_dec.BackgroundImage")));
            this.btn_dtCad_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dtCad_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_dtCad_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_dtCad_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_dtCad_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dtCad_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dtCad_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dtCad_dec.Location = new System.Drawing.Point(195, 19);
            this.btn_dtCad_dec.Name = "btn_dtCad_dec";
            this.btn_dtCad_dec.Size = new System.Drawing.Size(64, 25);
            this.btn_dtCad_dec.TabIndex = 3;
            this.btn_dtCad_dec.Text = "Cadastro";
            this.btn_dtCad_dec.UseVisualStyleBackColor = false;
            this.btn_dtCad_dec.Click += new System.EventHandler(this.btn_dtCad_dec_Click);
            // 
            // btn_sexo_dec
            // 
            this.btn_sexo_dec.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_sexo_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sexo_dec.BackgroundImage")));
            this.btn_sexo_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sexo_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sexo_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_sexo_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_sexo_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sexo_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sexo_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sexo_dec.Location = new System.Drawing.Point(146, 19);
            this.btn_sexo_dec.Name = "btn_sexo_dec";
            this.btn_sexo_dec.Size = new System.Drawing.Size(43, 25);
            this.btn_sexo_dec.TabIndex = 2;
            this.btn_sexo_dec.Text = "Sexo";
            this.btn_sexo_dec.UseVisualStyleBackColor = false;
            this.btn_sexo_dec.Click += new System.EventHandler(this.btn_sexo_dec_Click);
            // 
            // btn_dtNasc_dec
            // 
            this.btn_dtNasc_dec.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_dtNasc_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dtNasc_dec.BackgroundImage")));
            this.btn_dtNasc_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dtNasc_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_dtNasc_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_dtNasc_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_dtNasc_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dtNasc_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dtNasc_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dtNasc_dec.Location = new System.Drawing.Point(59, 19);
            this.btn_dtNasc_dec.Name = "btn_dtNasc_dec";
            this.btn_dtNasc_dec.Size = new System.Drawing.Size(81, 25);
            this.btn_dtNasc_dec.TabIndex = 1;
            this.btn_dtNasc_dec.Text = "Nascimento";
            this.btn_dtNasc_dec.UseVisualStyleBackColor = false;
            this.btn_dtNasc_dec.Click += new System.EventHandler(this.btn_dtNasc_dec_Click);
            // 
            // btn_nome_dec
            // 
            this.btn_nome_dec.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_nome_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nome_dec.BackgroundImage")));
            this.btn_nome_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nome_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_nome_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_nome_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_nome_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nome_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nome_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_nome_dec.Location = new System.Drawing.Point(6, 19);
            this.btn_nome_dec.Name = "btn_nome_dec";
            this.btn_nome_dec.Size = new System.Drawing.Size(47, 25);
            this.btn_nome_dec.TabIndex = 0;
            this.btn_nome_dec.Text = "Nome";
            this.btn_nome_dec.UseVisualStyleBackColor = false;
            this.btn_nome_dec.Click += new System.EventHandler(this.btn_nome_dec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Busca pelo Nome do Cliente";
            // 
            // grp_Crescente
            // 
            this.grp_Crescente.BackColor = System.Drawing.Color.Transparent;
            this.grp_Crescente.Controls.Add(this.btn_dtCad_asc);
            this.grp_Crescente.Controls.Add(this.btn_sexo_asc);
            this.grp_Crescente.Controls.Add(this.btn_qtde_asc);
            this.grp_Crescente.Controls.Add(this.btn_nome_asc);
            this.grp_Crescente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grp_Crescente.Location = new System.Drawing.Point(269, 8);
            this.grp_Crescente.Name = "grp_Crescente";
            this.grp_Crescente.Size = new System.Drawing.Size(265, 53);
            this.grp_Crescente.TabIndex = 1;
            this.grp_Crescente.TabStop = false;
            this.grp_Crescente.Text = "Ordenar por ordem Crescente:";
            // 
            // btn_dtCad_asc
            // 
            this.btn_dtCad_asc.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_dtCad_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dtCad_asc.BackgroundImage")));
            this.btn_dtCad_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dtCad_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_dtCad_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_dtCad_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_dtCad_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dtCad_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dtCad_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dtCad_asc.Location = new System.Drawing.Point(190, 19);
            this.btn_dtCad_asc.Name = "btn_dtCad_asc";
            this.btn_dtCad_asc.Size = new System.Drawing.Size(66, 25);
            this.btn_dtCad_asc.TabIndex = 3;
            this.btn_dtCad_asc.Text = "Cadastro";
            this.btn_dtCad_asc.UseVisualStyleBackColor = false;
            this.btn_dtCad_asc.Click += new System.EventHandler(this.btn_dtCad_asc_Click);
            // 
            // btn_sexo_asc
            // 
            this.btn_sexo_asc.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_sexo_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sexo_asc.BackgroundImage")));
            this.btn_sexo_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sexo_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_sexo_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_sexo_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_sexo_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sexo_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sexo_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sexo_asc.Location = new System.Drawing.Point(143, 19);
            this.btn_sexo_asc.Name = "btn_sexo_asc";
            this.btn_sexo_asc.Size = new System.Drawing.Size(41, 25);
            this.btn_sexo_asc.TabIndex = 2;
            this.btn_sexo_asc.Text = "Sexo";
            this.btn_sexo_asc.UseVisualStyleBackColor = false;
            this.btn_sexo_asc.Click += new System.EventHandler(this.btn_sexo_asc_Click);
            // 
            // btn_qtde_asc
            // 
            this.btn_qtde_asc.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_qtde_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_qtde_asc.BackgroundImage")));
            this.btn_qtde_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_qtde_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_qtde_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_qtde_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_qtde_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_qtde_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qtde_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_qtde_asc.Location = new System.Drawing.Point(58, 19);
            this.btn_qtde_asc.Name = "btn_qtde_asc";
            this.btn_qtde_asc.Size = new System.Drawing.Size(79, 25);
            this.btn_qtde_asc.TabIndex = 1;
            this.btn_qtde_asc.Text = "Nascimento";
            this.btn_qtde_asc.UseVisualStyleBackColor = false;
            this.btn_qtde_asc.Click += new System.EventHandler(this.btn_Nasc_asc_Click);
            // 
            // btn_nome_asc
            // 
            this.btn_nome_asc.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_nome_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nome_asc.BackgroundImage")));
            this.btn_nome_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nome_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_nome_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_nome_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_nome_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nome_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nome_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_nome_asc.Location = new System.Drawing.Point(6, 19);
            this.btn_nome_asc.Name = "btn_nome_asc";
            this.btn_nome_asc.Size = new System.Drawing.Size(46, 25);
            this.btn_nome_asc.TabIndex = 0;
            this.btn_nome_asc.Text = "Nome";
            this.btn_nome_asc.UseVisualStyleBackColor = false;
            this.btn_nome_asc.Click += new System.EventHandler(this.btn_nome_asc_Click);
            // 
            // txt_Busca
            // 
            this.txt_Busca.Location = new System.Drawing.Point(18, 36);
            this.txt_Busca.MaxLength = 50;
            this.txt_Busca.Name = "txt_Busca";
            this.txt_Busca.Size = new System.Drawing.Size(229, 21);
            this.txt_Busca.TabIndex = 0;
            this.txt_Busca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Busca.TextChanged += new System.EventHandler(this.txt_Busca_TextChanged);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Editar.BackgroundImage")));
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Editar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Editar.Location = new System.Drawing.Point(954, 14);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(72, 46);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.Text = "Editar Clientes";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.MaxInputLength = 50;
            this.Nome.Name = "Nome";
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 200;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MaxInputLength = 50;
            this.Email.Name = "Email";
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Width = 180;
            // 
            // Dt_Nasc
            // 
            this.Dt_Nasc.DataPropertyName = "Dt_Nasc";
            this.Dt_Nasc.HeaderText = "Data Nascimento";
            this.Dt_Nasc.MaxInputLength = 30;
            this.Dt_Nasc.Name = "Dt_Nasc";
            this.Dt_Nasc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dt_Nasc.Width = 70;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MaxInputLength = 2;
            this.Sexo.Name = "Sexo";
            this.Sexo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sexo.Width = 40;
            // 
            // Dt_Cadastro
            // 
            this.Dt_Cadastro.DataPropertyName = "Dt_Cadastro";
            this.Dt_Cadastro.HeaderText = "Data Cadastro";
            this.Dt_Cadastro.MaxInputLength = 30;
            this.Dt_Cadastro.Name = "Dt_Cadastro";
            this.Dt_Cadastro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dt_Cadastro.Width = 150;
            // 
            // Telefone
            // 
            this.Telefone.DataPropertyName = "TelefoneFormatado";
            dataGridViewCellStyle2.NullValue = "0";
            this.Telefone.DefaultCellStyle = dataGridViewCellStyle2;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.MaxInputLength = 20;
            this.Telefone.Name = "Telefone";
            this.Telefone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "CelularFormatado";
            dataGridViewCellStyle3.NullValue = "0";
            this.Celular.DefaultCellStyle = dataGridViewCellStyle3;
            this.Celular.HeaderText = "Celular";
            this.Celular.MaxInputLength = 20;
            this.Celular.Name = "Celular";
            this.Celular.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "Endereco";
            this.Endereco.HeaderText = "Endereço Completo";
            this.Endereco.MaxInputLength = 300;
            this.Endereco.Name = "Endereco";
            this.Endereco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Endereco.Width = 370;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Situacao";
            this.Situacao.HeaderText = "Situação";
            this.Situacao.MaxInputLength = 10;
            this.Situacao.Name = "Situacao";
            this.Situacao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Situacao.Width = 60;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 498);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_Clientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.btn_Sair);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClientes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Clientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_Decrescente.ResumeLayout(false);
            this.grp_Crescente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtg_Clientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Busca;
        private System.Windows.Forms.GroupBox grp_Decrescente;
        private System.Windows.Forms.Button btn_dtCad_dec;
        private System.Windows.Forms.Button btn_sexo_dec;
        private System.Windows.Forms.Button btn_dtNasc_dec;
        private System.Windows.Forms.Button btn_nome_dec;
        private System.Windows.Forms.GroupBox grp_Crescente;
        private System.Windows.Forms.Button btn_dtCad_asc;
        private System.Windows.Forms.Button btn_sexo_asc;
        private System.Windows.Forms.Button btn_qtde_asc;
        private System.Windows.Forms.Button btn_nome_asc;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt_Nasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt_Cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
    }
}