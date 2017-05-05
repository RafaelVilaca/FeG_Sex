namespace Loja_FeG_Sex.Forms.Produtos
{
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_Produtos = new System.Windows.Forms.DataGridView();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt_Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vl_Venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nud_busca = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Busca = new System.Windows.Forms.TextBox();
            this.grp_Crescente = new System.Windows.Forms.GroupBox();
            this.btn_Venda_asc = new System.Windows.Forms.Button();
            this.btn_Compra_asc = new System.Windows.Forms.Button();
            this.btn_dt_Cad_asc = new System.Windows.Forms.Button();
            this.btn_qtde_asc = new System.Windows.Forms.Button();
            this.btn_desc_asc = new System.Windows.Forms.Button();
            this.btn_venda_dec = new System.Windows.Forms.Button();
            this.grp_Decrescente = new System.Windows.Forms.GroupBox();
            this.btn_compra_dec = new System.Windows.Forms.Button();
            this.btn_dt_cad_dec = new System.Windows.Forms.Button();
            this.btn_qtde_dec = new System.Windows.Forms.Button();
            this.btn_desc_dec = new System.Windows.Forms.Button();
            this.btn_Editar_Produto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Produtos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_busca)).BeginInit();
            this.grp_Crescente.SuspendLayout();
            this.grp_Decrescente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sair.BackgroundImage")));
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Sair.Location = new System.Drawing.Point(830, 440);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(251, 46);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Inserir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Inserir.BackgroundImage")));
            this.btn_Inserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Inserir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Inserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Inserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Inserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Inserir.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inserir.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Inserir.Location = new System.Drawing.Point(830, 336);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(251, 46);
            this.btn_Inserir.TabIndex = 3;
            this.btn_Inserir.Text = "Inserir Produto";
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.Insere_Produto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(891, 258);
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
            this.label2.Location = new System.Drawing.Point(916, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "DOCE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtg_Produtos
            // 
            this.dtg_Produtos.AllowUserToAddRows = false;
            this.dtg_Produtos.AllowUserToDeleteRows = false;
            this.dtg_Produtos.AllowUserToResizeColumns = false;
            this.dtg_Produtos.AllowUserToResizeRows = false;
            this.dtg_Produtos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Produtos.BackgroundColor = System.Drawing.Color.Navy;
            this.dtg_Produtos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Produtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descricao,
            this.Qtde,
            this.Dt_Cadastro,
            this.Vl_Compra,
            this.Vl_Venda,
            this.Situacao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Produtos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Produtos.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtg_Produtos.Location = new System.Drawing.Point(13, 62);
            this.dtg_Produtos.Name = "dtg_Produtos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Produtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_Produtos.RowHeadersVisible = false;
            this.dtg_Produtos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Produtos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_Produtos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_Produtos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dtg_Produtos.Size = new System.Drawing.Size(802, 424);
            this.dtg_Produtos.TabIndex = 24;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MaxInputLength = 100;
            this.Descricao.Name = "Descricao";
            this.Descricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descricao.Width = 305;
            // 
            // Qtde
            // 
            this.Qtde.DataPropertyName = "Qtde";
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.MaxInputLength = 5;
            this.Qtde.Name = "Qtde";
            this.Qtde.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Qtde.Width = 50;
            // 
            // Dt_Cadastro
            // 
            this.Dt_Cadastro.DataPropertyName = "Dt_Cadastro";
            this.Dt_Cadastro.HeaderText = "Data Cadastro";
            this.Dt_Cadastro.MaxInputLength = 20;
            this.Dt_Cadastro.Name = "Dt_Cadastro";
            this.Dt_Cadastro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Dt_Cadastro.Width = 150;
            // 
            // Vl_Compra
            // 
            this.Vl_Compra.DataPropertyName = "compraFormatado";
            this.Vl_Compra.HeaderText = "Valor Compra";
            this.Vl_Compra.MaxInputLength = 10;
            this.Vl_Compra.Name = "Vl_Compra";
            this.Vl_Compra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Vl_Venda
            // 
            this.Vl_Venda.DataPropertyName = "vendaFormatado";
            this.Vl_Venda.HeaderText = "Valor Venda";
            this.Vl_Venda.MaxInputLength = 10;
            this.Vl_Venda.Name = "Vl_Venda";
            this.Vl_Venda.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Situacao";
            this.Situacao.HeaderText = "Situação";
            this.Situacao.MaxInputLength = 10;
            this.Situacao.Name = "Situacao";
            this.Situacao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Situacao.Width = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nud_busca);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Busca);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(830, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela";
            // 
            // nud_busca
            // 
            this.nud_busca.Location = new System.Drawing.Point(70, 88);
            this.nud_busca.Name = "nud_busca";
            this.nud_busca.Size = new System.Drawing.Size(120, 21);
            this.nud_busca.TabIndex = 1;
            this.nud_busca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_busca.ValueChanged += new System.EventHandler(this.nud_busca_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Busca pela Quantidade Menor que:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Busca pela Descrição do Produto:";
            // 
            // txt_Busca
            // 
            this.txt_Busca.Location = new System.Drawing.Point(9, 37);
            this.txt_Busca.MaxLength = 50;
            this.txt_Busca.Name = "txt_Busca";
            this.txt_Busca.Size = new System.Drawing.Size(227, 21);
            this.txt_Busca.TabIndex = 0;
            this.txt_Busca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Busca.TextChanged += new System.EventHandler(this.txt_Busca_TextChanged);
            // 
            // grp_Crescente
            // 
            this.grp_Crescente.BackColor = System.Drawing.Color.Transparent;
            this.grp_Crescente.Controls.Add(this.btn_Venda_asc);
            this.grp_Crescente.Controls.Add(this.btn_Compra_asc);
            this.grp_Crescente.Controls.Add(this.btn_dt_Cad_asc);
            this.grp_Crescente.Controls.Add(this.btn_qtde_asc);
            this.grp_Crescente.Controls.Add(this.btn_desc_asc);
            this.grp_Crescente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grp_Crescente.Location = new System.Drawing.Point(13, 3);
            this.grp_Crescente.Name = "grp_Crescente";
            this.grp_Crescente.Size = new System.Drawing.Size(353, 53);
            this.grp_Crescente.TabIndex = 0;
            this.grp_Crescente.TabStop = false;
            this.grp_Crescente.Text = "Ordenar por ordem Crescente:";
            // 
            // btn_Venda_asc
            // 
            this.btn_Venda_asc.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Venda_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Venda_asc.BackgroundImage")));
            this.btn_Venda_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Venda_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Venda_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Venda_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Venda_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Venda_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Venda_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Venda_asc.Location = new System.Drawing.Point(296, 19);
            this.btn_Venda_asc.Name = "btn_Venda_asc";
            this.btn_Venda_asc.Size = new System.Drawing.Size(48, 25);
            this.btn_Venda_asc.TabIndex = 4;
            this.btn_Venda_asc.Text = "Venda";
            this.btn_Venda_asc.UseVisualStyleBackColor = false;
            this.btn_Venda_asc.Click += new System.EventHandler(this.btn_Venda_asc_Click);
            // 
            // btn_Compra_asc
            // 
            this.btn_Compra_asc.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Compra_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Compra_asc.BackgroundImage")));
            this.btn_Compra_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Compra_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Compra_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Compra_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Compra_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Compra_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Compra_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Compra_asc.Location = new System.Drawing.Point(231, 19);
            this.btn_Compra_asc.Name = "btn_Compra_asc";
            this.btn_Compra_asc.Size = new System.Drawing.Size(59, 25);
            this.btn_Compra_asc.TabIndex = 3;
            this.btn_Compra_asc.Text = "Compra";
            this.btn_Compra_asc.UseVisualStyleBackColor = false;
            this.btn_Compra_asc.Click += new System.EventHandler(this.btn_Compra_asc_Click);
            // 
            // btn_dt_Cad_asc
            // 
            this.btn_dt_Cad_asc.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_dt_Cad_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dt_Cad_asc.BackgroundImage")));
            this.btn_dt_Cad_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dt_Cad_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_dt_Cad_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_dt_Cad_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_dt_Cad_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dt_Cad_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dt_Cad_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dt_Cad_asc.Location = new System.Drawing.Point(132, 19);
            this.btn_dt_Cad_asc.Name = "btn_dt_Cad_asc";
            this.btn_dt_Cad_asc.Size = new System.Drawing.Size(93, 25);
            this.btn_dt_Cad_asc.TabIndex = 2;
            this.btn_dt_Cad_asc.Text = "Data Cadastro";
            this.btn_dt_Cad_asc.UseVisualStyleBackColor = false;
            this.btn_dt_Cad_asc.Click += new System.EventHandler(this.btn_dt_Cad_asc_Click);
            // 
            // btn_qtde_asc
            // 
            this.btn_qtde_asc.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_qtde_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_qtde_asc.BackgroundImage")));
            this.btn_qtde_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_qtde_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_qtde_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_qtde_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_qtde_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_qtde_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qtde_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_qtde_asc.Location = new System.Drawing.Point(82, 19);
            this.btn_qtde_asc.Name = "btn_qtde_asc";
            this.btn_qtde_asc.Size = new System.Drawing.Size(44, 25);
            this.btn_qtde_asc.TabIndex = 1;
            this.btn_qtde_asc.Text = "Qtde";
            this.btn_qtde_asc.UseVisualStyleBackColor = false;
            this.btn_qtde_asc.Click += new System.EventHandler(this.btn_qtde_asc_Click);
            // 
            // btn_desc_asc
            // 
            this.btn_desc_asc.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_desc_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_desc_asc.BackgroundImage")));
            this.btn_desc_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desc_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_desc_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_desc_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_desc_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_desc_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desc_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_desc_asc.Location = new System.Drawing.Point(6, 19);
            this.btn_desc_asc.Name = "btn_desc_asc";
            this.btn_desc_asc.Size = new System.Drawing.Size(70, 25);
            this.btn_desc_asc.TabIndex = 0;
            this.btn_desc_asc.Text = "Descrição";
            this.btn_desc_asc.UseVisualStyleBackColor = false;
            this.btn_desc_asc.Click += new System.EventHandler(this.btn_desc_asc_Click);
            // 
            // btn_venda_dec
            // 
            this.btn_venda_dec.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_venda_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_venda_dec.BackgroundImage")));
            this.btn_venda_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_venda_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_venda_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_venda_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_venda_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_venda_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venda_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_venda_dec.Location = new System.Drawing.Point(296, 19);
            this.btn_venda_dec.Name = "btn_venda_dec";
            this.btn_venda_dec.Size = new System.Drawing.Size(48, 25);
            this.btn_venda_dec.TabIndex = 4;
            this.btn_venda_dec.Text = "Venda";
            this.btn_venda_dec.UseVisualStyleBackColor = false;
            this.btn_venda_dec.Click += new System.EventHandler(this.btn_venda_dec_Click);
            // 
            // grp_Decrescente
            // 
            this.grp_Decrescente.BackColor = System.Drawing.Color.Transparent;
            this.grp_Decrescente.Controls.Add(this.btn_venda_dec);
            this.grp_Decrescente.Controls.Add(this.btn_compra_dec);
            this.grp_Decrescente.Controls.Add(this.btn_dt_cad_dec);
            this.grp_Decrescente.Controls.Add(this.btn_qtde_dec);
            this.grp_Decrescente.Controls.Add(this.btn_desc_dec);
            this.grp_Decrescente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grp_Decrescente.Location = new System.Drawing.Point(418, 3);
            this.grp_Decrescente.Name = "grp_Decrescente";
            this.grp_Decrescente.Size = new System.Drawing.Size(353, 53);
            this.grp_Decrescente.TabIndex = 1;
            this.grp_Decrescente.TabStop = false;
            this.grp_Decrescente.Text = "Ordenar por ordem Decrescente:";
            // 
            // btn_compra_dec
            // 
            this.btn_compra_dec.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_compra_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_compra_dec.BackgroundImage")));
            this.btn_compra_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_compra_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_compra_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_compra_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_compra_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_compra_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compra_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_compra_dec.Location = new System.Drawing.Point(231, 19);
            this.btn_compra_dec.Name = "btn_compra_dec";
            this.btn_compra_dec.Size = new System.Drawing.Size(59, 25);
            this.btn_compra_dec.TabIndex = 3;
            this.btn_compra_dec.Text = "Compra";
            this.btn_compra_dec.UseVisualStyleBackColor = false;
            this.btn_compra_dec.Click += new System.EventHandler(this.btn_compra_dec_Click);
            // 
            // btn_dt_cad_dec
            // 
            this.btn_dt_cad_dec.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_dt_cad_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dt_cad_dec.BackgroundImage")));
            this.btn_dt_cad_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dt_cad_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_dt_cad_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_dt_cad_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_dt_cad_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dt_cad_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dt_cad_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_dt_cad_dec.Location = new System.Drawing.Point(132, 19);
            this.btn_dt_cad_dec.Name = "btn_dt_cad_dec";
            this.btn_dt_cad_dec.Size = new System.Drawing.Size(93, 25);
            this.btn_dt_cad_dec.TabIndex = 2;
            this.btn_dt_cad_dec.Text = "Data Cadastro";
            this.btn_dt_cad_dec.UseVisualStyleBackColor = false;
            this.btn_dt_cad_dec.Click += new System.EventHandler(this.btn_dt_cad_dec_Click);
            // 
            // btn_qtde_dec
            // 
            this.btn_qtde_dec.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_qtde_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_qtde_dec.BackgroundImage")));
            this.btn_qtde_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_qtde_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_qtde_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_qtde_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_qtde_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_qtde_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qtde_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_qtde_dec.Location = new System.Drawing.Point(82, 19);
            this.btn_qtde_dec.Name = "btn_qtde_dec";
            this.btn_qtde_dec.Size = new System.Drawing.Size(44, 25);
            this.btn_qtde_dec.TabIndex = 1;
            this.btn_qtde_dec.Text = "Qtde";
            this.btn_qtde_dec.UseVisualStyleBackColor = false;
            this.btn_qtde_dec.Click += new System.EventHandler(this.btn_qtde_dec_Click);
            // 
            // btn_desc_dec
            // 
            this.btn_desc_dec.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_desc_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_desc_dec.BackgroundImage")));
            this.btn_desc_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desc_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_desc_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_desc_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_desc_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_desc_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desc_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_desc_dec.Location = new System.Drawing.Point(6, 19);
            this.btn_desc_dec.Name = "btn_desc_dec";
            this.btn_desc_dec.Size = new System.Drawing.Size(70, 25);
            this.btn_desc_dec.TabIndex = 0;
            this.btn_desc_dec.Text = "Descrição";
            this.btn_desc_dec.UseVisualStyleBackColor = false;
            this.btn_desc_dec.Click += new System.EventHandler(this.btn_desc_dec_Click);
            // 
            // btn_Editar_Produto
            // 
            this.btn_Editar_Produto.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_Editar_Produto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Editar_Produto.BackgroundImage")));
            this.btn_Editar_Produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar_Produto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Editar_Produto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Editar_Produto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Editar_Produto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Editar_Produto.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar_Produto.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Editar_Produto.Location = new System.Drawing.Point(830, 388);
            this.btn_Editar_Produto.Name = "btn_Editar_Produto";
            this.btn_Editar_Produto.Size = new System.Drawing.Size(251, 46);
            this.btn_Editar_Produto.TabIndex = 4;
            this.btn_Editar_Produto.Text = "Editar Produto";
            this.btn_Editar_Produto.UseVisualStyleBackColor = false;
            this.btn_Editar_Produto.Click += new System.EventHandler(this.btn_Editar_Produto_Click);
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1096, 498);
            this.Controls.Add(this.btn_Editar_Produto);
            this.Controls.Add(this.grp_Decrescente);
            this.Controls.Add(this.grp_Crescente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_Produtos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.btn_Sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Produtos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_busca)).EndInit();
            this.grp_Crescente.ResumeLayout(false);
            this.grp_Decrescente.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtg_Produtos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Busca;
        private System.Windows.Forms.NumericUpDown nud_busca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_Crescente;
        private System.Windows.Forms.Button btn_Venda_asc;
        private System.Windows.Forms.Button btn_Compra_asc;
        private System.Windows.Forms.Button btn_dt_Cad_asc;
        private System.Windows.Forms.Button btn_qtde_asc;
        private System.Windows.Forms.Button btn_desc_asc;
        private System.Windows.Forms.GroupBox grp_Decrescente;
        private System.Windows.Forms.Button btn_venda_dec;
        private System.Windows.Forms.Button btn_compra_dec;
        private System.Windows.Forms.Button btn_dt_cad_dec;
        private System.Windows.Forms.Button btn_qtde_dec;
        private System.Windows.Forms.Button btn_desc_dec;
        private System.Windows.Forms.Button btn_Editar_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt_Cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vl_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vl_Venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
    }
}