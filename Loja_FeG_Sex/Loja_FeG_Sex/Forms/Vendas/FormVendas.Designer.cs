namespace Loja_FeG_Sex.Forms.Vendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Venda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtg_Vendas = new System.Windows.Forms.DataGridView();
            this.Nome_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dt_Transacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaFormatado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_Decrescente = new System.Windows.Forms.GroupBox();
            this.btn_venda_dec = new System.Windows.Forms.Button();
            this.btn_prod_dec = new System.Windows.Forms.Button();
            this.btn_transa_dec = new System.Windows.Forms.Button();
            this.btn_nome_dec = new System.Windows.Forms.Button();
            this.grp_Crescente = new System.Windows.Forms.GroupBox();
            this.btn_venda_asc = new System.Windows.Forms.Button();
            this.btn_prod_asc = new System.Windows.Forms.Button();
            this.btn_transa_asc = new System.Windows.Forms.Button();
            this.btn_nome_asc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_inicial = new System.Windows.Forms.DateTimePicker();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vendas)).BeginInit();
            this.grp_Decrescente.SuspendLayout();
            this.grp_Crescente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.Black;
            this.btn_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Sair.BackgroundImage")));
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sair.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_Sair.Location = new System.Drawing.Point(982, 440);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(230, 46);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Venda
            // 
            this.btn_Venda.BackColor = System.Drawing.Color.Black;
            this.btn_Venda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Venda.BackgroundImage")));
            this.btn_Venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Venda.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Venda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_Venda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Venda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Venda.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Venda.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Venda.Location = new System.Drawing.Point(982, 382);
            this.btn_Venda.Name = "btn_Venda";
            this.btn_Venda.Size = new System.Drawing.Size(229, 46);
            this.btn_Venda.TabIndex = 2;
            this.btn_Venda.Text = "Efetuar Venda";
            this.btn_Venda.UseVisualStyleBackColor = false;
            this.btn_Venda.Click += new System.EventHandler(this.btn_Venda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.AliceBlue;
            this.label5.Location = new System.Drawing.Point(1037, 85);
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
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(1060, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "DOCE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtg_Vendas
            // 
            this.dtg_Vendas.AllowUserToAddRows = false;
            this.dtg_Vendas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.DodgerBlue;
            this.dtg_Vendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtg_Vendas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Vendas.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.dtg_Vendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtg_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome_Cliente,
            this.Desc_Produto,
            this.Qtde,
            this.Dt_Transacao,
            this.vendaFormatado,
            this.Pagamento});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Vendas.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtg_Vendas.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_Vendas.Location = new System.Drawing.Point(12, 70);
            this.dtg_Vendas.Name = "dtg_Vendas";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Vendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dtg_Vendas.RowHeadersVisible = false;
            this.dtg_Vendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Vendas.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dtg_Vendas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtg_Vendas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Navy;
            this.dtg_Vendas.Size = new System.Drawing.Size(964, 416);
            this.dtg_Vendas.TabIndex = 25;
            // 
            // Nome_Cliente
            // 
            this.Nome_Cliente.DataPropertyName = "Nome";
            this.Nome_Cliente.HeaderText = "Nome Cliente";
            this.Nome_Cliente.MaxInputLength = 100;
            this.Nome_Cliente.Name = "Nome_Cliente";
            this.Nome_Cliente.Width = 200;
            // 
            // Desc_Produto
            // 
            this.Desc_Produto.DataPropertyName = "Descricao";
            this.Desc_Produto.HeaderText = "Descricao Produto";
            this.Desc_Produto.MaxInputLength = 150;
            this.Desc_Produto.Name = "Desc_Produto";
            this.Desc_Produto.Width = 250;
            // 
            // Qtde
            // 
            this.Qtde.DataPropertyName = "Qtde";
            this.Qtde.HeaderText = "Qtde";
            this.Qtde.MaxInputLength = 10;
            this.Qtde.Name = "Qtde";
            this.Qtde.Width = 50;
            // 
            // Dt_Transacao
            // 
            this.Dt_Transacao.DataPropertyName = "Dt_Transacao";
            this.Dt_Transacao.HeaderText = "Data Transação";
            this.Dt_Transacao.MaxInputLength = 30;
            this.Dt_Transacao.Name = "Dt_Transacao";
            this.Dt_Transacao.Width = 150;
            // 
            // vendaFormatado
            // 
            this.vendaFormatado.DataPropertyName = "VendaFormatado";
            this.vendaFormatado.HeaderText = "Valor Venda";
            this.vendaFormatado.MaxInputLength = 15;
            this.vendaFormatado.Name = "vendaFormatado";
            this.vendaFormatado.Width = 90;
            // 
            // Pagamento
            // 
            this.Pagamento.DataPropertyName = "PagamentoFormatado";
            this.Pagamento.HeaderText = "Relatório Pagamento";
            this.Pagamento.MaxInputLength = 100;
            this.Pagamento.Name = "Pagamento";
            this.Pagamento.Width = 200;
            // 
            // grp_Decrescente
            // 
            this.grp_Decrescente.BackColor = System.Drawing.Color.Transparent;
            this.grp_Decrescente.Controls.Add(this.btn_venda_dec);
            this.grp_Decrescente.Controls.Add(this.btn_prod_dec);
            this.grp_Decrescente.Controls.Add(this.btn_transa_dec);
            this.grp_Decrescente.Controls.Add(this.btn_nome_dec);
            this.grp_Decrescente.ForeColor = System.Drawing.Color.AliceBlue;
            this.grp_Decrescente.Location = new System.Drawing.Point(124, 17);
            this.grp_Decrescente.Name = "grp_Decrescente";
            this.grp_Decrescente.Size = new System.Drawing.Size(93, 146);
            this.grp_Decrescente.TabIndex = 2;
            this.grp_Decrescente.TabStop = false;
            this.grp_Decrescente.Text = "Decrescente:";
            // 
            // btn_venda_dec
            // 
            this.btn_venda_dec.BackColor = System.Drawing.Color.Black;
            this.btn_venda_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_venda_dec.BackgroundImage")));
            this.btn_venda_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_venda_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_venda_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_venda_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_venda_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_venda_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venda_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_venda_dec.Location = new System.Drawing.Point(6, 112);
            this.btn_venda_dec.Name = "btn_venda_dec";
            this.btn_venda_dec.Size = new System.Drawing.Size(81, 25);
            this.btn_venda_dec.TabIndex = 3;
            this.btn_venda_dec.Text = "Venda";
            this.btn_venda_dec.UseVisualStyleBackColor = false;
            this.btn_venda_dec.Click += new System.EventHandler(this.btn_venda_dec_Click);
            // 
            // btn_prod_dec
            // 
            this.btn_prod_dec.BackColor = System.Drawing.Color.Black;
            this.btn_prod_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_prod_dec.BackgroundImage")));
            this.btn_prod_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prod_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_prod_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_prod_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_prod_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_prod_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_prod_dec.Location = new System.Drawing.Point(6, 81);
            this.btn_prod_dec.Name = "btn_prod_dec";
            this.btn_prod_dec.Size = new System.Drawing.Size(81, 25);
            this.btn_prod_dec.TabIndex = 2;
            this.btn_prod_dec.Text = "Produto";
            this.btn_prod_dec.UseVisualStyleBackColor = false;
            this.btn_prod_dec.Click += new System.EventHandler(this.btn_prod_dec_Click);
            // 
            // btn_transa_dec
            // 
            this.btn_transa_dec.BackColor = System.Drawing.Color.Black;
            this.btn_transa_dec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_transa_dec.BackgroundImage")));
            this.btn_transa_dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_transa_dec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_transa_dec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_transa_dec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_transa_dec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_transa_dec.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transa_dec.ForeColor = System.Drawing.Color.Transparent;
            this.btn_transa_dec.Location = new System.Drawing.Point(6, 50);
            this.btn_transa_dec.Name = "btn_transa_dec";
            this.btn_transa_dec.Size = new System.Drawing.Size(81, 25);
            this.btn_transa_dec.TabIndex = 1;
            this.btn_transa_dec.Text = "Transação";
            this.btn_transa_dec.UseVisualStyleBackColor = false;
            this.btn_transa_dec.Click += new System.EventHandler(this.btn_transa_dec_Click);
            // 
            // btn_nome_dec
            // 
            this.btn_nome_dec.BackColor = System.Drawing.Color.Black;
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
            this.btn_nome_dec.Size = new System.Drawing.Size(81, 25);
            this.btn_nome_dec.TabIndex = 0;
            this.btn_nome_dec.Text = "Nome";
            this.btn_nome_dec.UseVisualStyleBackColor = false;
            this.btn_nome_dec.Click += new System.EventHandler(this.btn_nome_dec_Click);
            // 
            // grp_Crescente
            // 
            this.grp_Crescente.BackColor = System.Drawing.Color.Transparent;
            this.grp_Crescente.Controls.Add(this.btn_venda_asc);
            this.grp_Crescente.Controls.Add(this.btn_prod_asc);
            this.grp_Crescente.Controls.Add(this.btn_transa_asc);
            this.grp_Crescente.Controls.Add(this.btn_nome_asc);
            this.grp_Crescente.ForeColor = System.Drawing.Color.AliceBlue;
            this.grp_Crescente.Location = new System.Drawing.Point(15, 17);
            this.grp_Crescente.Name = "grp_Crescente";
            this.grp_Crescente.Size = new System.Drawing.Size(93, 146);
            this.grp_Crescente.TabIndex = 1;
            this.grp_Crescente.TabStop = false;
            this.grp_Crescente.Text = "Crescente:";
            // 
            // btn_venda_asc
            // 
            this.btn_venda_asc.BackColor = System.Drawing.Color.Black;
            this.btn_venda_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_venda_asc.BackgroundImage")));
            this.btn_venda_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_venda_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_venda_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_venda_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_venda_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_venda_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_venda_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_venda_asc.Location = new System.Drawing.Point(6, 112);
            this.btn_venda_asc.Name = "btn_venda_asc";
            this.btn_venda_asc.Size = new System.Drawing.Size(81, 25);
            this.btn_venda_asc.TabIndex = 3;
            this.btn_venda_asc.Text = "Venda";
            this.btn_venda_asc.UseVisualStyleBackColor = false;
            this.btn_venda_asc.Click += new System.EventHandler(this.btn_venda_asc_Click);
            // 
            // btn_prod_asc
            // 
            this.btn_prod_asc.BackColor = System.Drawing.Color.Black;
            this.btn_prod_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_prod_asc.BackgroundImage")));
            this.btn_prod_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prod_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_prod_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_prod_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_prod_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_prod_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_prod_asc.Location = new System.Drawing.Point(6, 81);
            this.btn_prod_asc.Name = "btn_prod_asc";
            this.btn_prod_asc.Size = new System.Drawing.Size(81, 25);
            this.btn_prod_asc.TabIndex = 2;
            this.btn_prod_asc.Text = "Produto";
            this.btn_prod_asc.UseVisualStyleBackColor = false;
            this.btn_prod_asc.Click += new System.EventHandler(this.btn_prod_asc_Click);
            // 
            // btn_transa_asc
            // 
            this.btn_transa_asc.BackColor = System.Drawing.Color.Black;
            this.btn_transa_asc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_transa_asc.BackgroundImage")));
            this.btn_transa_asc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_transa_asc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_transa_asc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_transa_asc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_transa_asc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_transa_asc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transa_asc.ForeColor = System.Drawing.Color.Transparent;
            this.btn_transa_asc.Location = new System.Drawing.Point(6, 50);
            this.btn_transa_asc.Name = "btn_transa_asc";
            this.btn_transa_asc.Size = new System.Drawing.Size(81, 25);
            this.btn_transa_asc.TabIndex = 1;
            this.btn_transa_asc.Text = "Transação";
            this.btn_transa_asc.UseVisualStyleBackColor = false;
            this.btn_transa_asc.Click += new System.EventHandler(this.btn_transa_asc_Click);
            // 
            // btn_nome_asc
            // 
            this.btn_nome_asc.BackColor = System.Drawing.Color.Black;
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Descricao);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabela";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.AliceBlue;
            this.label6.Location = new System.Drawing.Point(598, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Data Inicial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(738, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Data Final:";
            // 
            // dtp_inicial
            // 
            this.dtp_inicial.CalendarForeColor = System.Drawing.Color.DarkBlue;
            this.dtp_inicial.CalendarTitleForeColor = System.Drawing.Color.DarkBlue;
            this.dtp_inicial.CalendarTrailingForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtp_inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_inicial.Location = new System.Drawing.Point(582, 37);
            this.dtp_inicial.Name = "dtp_inicial";
            this.dtp_inicial.Size = new System.Drawing.Size(102, 21);
            this.dtp_inicial.TabIndex = 2;
            this.dtp_inicial.Value = new System.DateTime(2016, 4, 28, 14, 19, 0, 0);
            this.dtp_inicial.ValueChanged += new System.EventHandler(this.BuscaDataInicial);
            // 
            // dtp_final
            // 
            this.dtp_final.CalendarForeColor = System.Drawing.Color.DarkBlue;
            this.dtp_final.CalendarTitleForeColor = System.Drawing.Color.DarkBlue;
            this.dtp_final.CalendarTrailingForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_final.Location = new System.Drawing.Point(722, 37);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(102, 21);
            this.dtp_final.TabIndex = 3;
            this.dtp_final.ValueChanged += new System.EventHandler(this.BuscaDataFinal);
            // 
            // txt_Nome
            // 
            this.txt_Nome.ForeColor = System.Drawing.Color.DarkBlue;
            this.txt_Nome.Location = new System.Drawing.Point(37, 37);
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
            this.label3.Location = new System.Drawing.Point(75, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Busca pelo Nome do Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(341, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Busca pela Descrição do Produto:";
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.ForeColor = System.Drawing.Color.DarkBlue;
            this.txt_Descricao.Location = new System.Drawing.Point(313, 37);
            this.txt_Descricao.MaxLength = 50;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(227, 21);
            this.txt_Descricao.TabIndex = 0;
            this.txt_Descricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Descricao.TextChanged += new System.EventHandler(this.txt_Descricao_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.grp_Decrescente);
            this.groupBox2.Controls.Add(this.grp_Crescente);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Location = new System.Drawing.Point(982, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenação";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_Vendas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Venda);
            this.Controls.Add(this.btn_Sair);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Vendas)).EndInit();
            this.grp_Decrescente.ResumeLayout(false);
            this.grp_Crescente.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Venda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtg_Vendas;
        private System.Windows.Forms.GroupBox grp_Decrescente;
        private System.Windows.Forms.Button btn_venda_dec;
        private System.Windows.Forms.Button btn_prod_dec;
        private System.Windows.Forms.Button btn_transa_dec;
        private System.Windows.Forms.Button btn_nome_dec;
        private System.Windows.Forms.GroupBox grp_Crescente;
        private System.Windows.Forms.Button btn_venda_asc;
        private System.Windows.Forms.Button btn_prod_asc;
        private System.Windows.Forms.Button btn_transa_asc;
        private System.Windows.Forms.Button btn_nome_asc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_inicial;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dt_Transacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendaFormatado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
    }
}