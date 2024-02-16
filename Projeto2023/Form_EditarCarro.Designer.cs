namespace Projeto2023
{
    partial class Form_EditarCarro
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
            this.Dgv_Carros = new System.Windows.Forms.DataGridView();
            this.Pb_ImagemCarro = new System.Windows.Forms.PictureBox();
            this.Btn_AbrirImagem = new FontAwesome.Sharp.IconButton();
            this.Pb_shield = new FontAwesome.Sharp.IconPictureBox();
            this.Txt_Km = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Preco = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Preco = new System.Windows.Forms.Label();
            this.Btn_RegistrarCarro = new FontAwesome.Sharp.IconButton();
            this.Dtp_AnoCarro = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Ano = new System.Windows.Forms.Label();
            this.Lbl_Km = new System.Windows.Forms.Label();
            this.CB_UnicoDono = new System.Windows.Forms.CheckBox();
            this.Lbl_Combustivel = new System.Windows.Forms.Label();
            this.Lb_Combustivel = new System.Windows.Forms.ListBox();
            this.Lbl_Blindado = new System.Windows.Forms.Label();
            this.Lbl_Marca = new System.Windows.Forms.Label();
            this.Lbl_Modelo = new System.Windows.Forms.Label();
            this.Txt_Modelo = new System.Windows.Forms.TextBox();
            this.Cb_Marca = new System.Windows.Forms.ComboBox();
            this.Rdb_Nao = new System.Windows.Forms.RadioButton();
            this.Rdb_sim = new System.Windows.Forms.RadioButton();
            this.Pb_UnicoDono = new FontAwesome.Sharp.IconPictureBox();
            this.Btn_Cancelar = new FontAwesome.Sharp.IconButton();
            this.SeletorImagem = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Carros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ImagemCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_shield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_UnicoDono)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Carros
            // 
            this.Dgv_Carros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Carros.Location = new System.Drawing.Point(12, 249);
            this.Dgv_Carros.Name = "Dgv_Carros";
            this.Dgv_Carros.ReadOnly = true;
            this.Dgv_Carros.Size = new System.Drawing.Size(240, 150);
            this.Dgv_Carros.TabIndex = 0;
            this.Dgv_Carros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Carros_CellClick);
            // 
            // Pb_ImagemCarro
            // 
            this.Pb_ImagemCarro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_ImagemCarro.Location = new System.Drawing.Point(12, 12);
            this.Pb_ImagemCarro.Name = "Pb_ImagemCarro";
            this.Pb_ImagemCarro.Size = new System.Drawing.Size(167, 169);
            this.Pb_ImagemCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_ImagemCarro.TabIndex = 21;
            this.Pb_ImagemCarro.TabStop = false;
            // 
            // Btn_AbrirImagem
            // 
            this.Btn_AbrirImagem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_AbrirImagem.FlatAppearance.BorderSize = 0;
            this.Btn_AbrirImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AbrirImagem.IconChar = FontAwesome.Sharp.IconChar.ArrowUpFromBracket;
            this.Btn_AbrirImagem.IconColor = System.Drawing.Color.White;
            this.Btn_AbrirImagem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_AbrirImagem.IconSize = 30;
            this.Btn_AbrirImagem.Location = new System.Drawing.Point(12, 181);
            this.Btn_AbrirImagem.Name = "Btn_AbrirImagem";
            this.Btn_AbrirImagem.Size = new System.Drawing.Size(167, 30);
            this.Btn_AbrirImagem.TabIndex = 20;
            this.Btn_AbrirImagem.UseVisualStyleBackColor = false;
            this.Btn_AbrirImagem.Click += new System.EventHandler(this.Btn_AbrirImagem_Click);
            // 
            // Pb_shield
            // 
            this.Pb_shield.BackColor = System.Drawing.Color.Transparent;
            this.Pb_shield.ForeColor = System.Drawing.Color.Black;
            this.Pb_shield.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.Pb_shield.IconColor = System.Drawing.Color.Black;
            this.Pb_shield.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Pb_shield.IconSize = 23;
            this.Pb_shield.Location = new System.Drawing.Point(209, 119);
            this.Pb_shield.Name = "Pb_shield";
            this.Pb_shield.Size = new System.Drawing.Size(24, 23);
            this.Pb_shield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_shield.TabIndex = 42;
            this.Pb_shield.TabStop = false;
            // 
            // Txt_Km
            // 
            this.Txt_Km.Location = new System.Drawing.Point(262, 251);
            this.Txt_Km.Mask = "000000";
            this.Txt_Km.Name = "Txt_Km";
            this.Txt_Km.Size = new System.Drawing.Size(118, 20);
            this.Txt_Km.TabIndex = 41;
            // 
            // Txt_Preco
            // 
            this.Txt_Preco.Location = new System.Drawing.Point(262, 308);
            this.Txt_Preco.Mask = "$0000000000";
            this.Txt_Preco.Name = "Txt_Preco";
            this.Txt_Preco.Size = new System.Drawing.Size(118, 20);
            this.Txt_Preco.TabIndex = 40;
            // 
            // Lbl_Preco
            // 
            this.Lbl_Preco.AutoSize = true;
            this.Lbl_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Preco.Location = new System.Drawing.Point(258, 285);
            this.Lbl_Preco.Name = "Lbl_Preco";
            this.Lbl_Preco.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Preco.TabIndex = 39;
            this.Lbl_Preco.Text = "Preço";
            // 
            // Btn_RegistrarCarro
            // 
            this.Btn_RegistrarCarro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_RegistrarCarro.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Btn_RegistrarCarro.FlatAppearance.BorderSize = 0;
            this.Btn_RegistrarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RegistrarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RegistrarCarro.ForeColor = System.Drawing.Color.White;
            this.Btn_RegistrarCarro.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_RegistrarCarro.IconColor = System.Drawing.Color.White;
            this.Btn_RegistrarCarro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_RegistrarCarro.IconSize = 30;
            this.Btn_RegistrarCarro.Location = new System.Drawing.Point(453, 369);
            this.Btn_RegistrarCarro.Name = "Btn_RegistrarCarro";
            this.Btn_RegistrarCarro.Size = new System.Drawing.Size(120, 30);
            this.Btn_RegistrarCarro.TabIndex = 38;
            this.Btn_RegistrarCarro.Text = "Salvar";
            this.Btn_RegistrarCarro.UseVisualStyleBackColor = false;
            this.Btn_RegistrarCarro.Click += new System.EventHandler(this.Btn_RegistrarCarro_Click);
            // 
            // Dtp_AnoCarro
            // 
            this.Dtp_AnoCarro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_AnoCarro.Location = new System.Drawing.Point(453, 251);
            this.Dtp_AnoCarro.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.Dtp_AnoCarro.Name = "Dtp_AnoCarro";
            this.Dtp_AnoCarro.Size = new System.Drawing.Size(81, 20);
            this.Dtp_AnoCarro.TabIndex = 37;
            this.Dtp_AnoCarro.Value = new System.DateTime(2023, 11, 13, 0, 0, 0, 0);
            // 
            // Lbl_Ano
            // 
            this.Lbl_Ano.AutoSize = true;
            this.Lbl_Ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ano.Location = new System.Drawing.Point(449, 228);
            this.Lbl_Ano.Name = "Lbl_Ano";
            this.Lbl_Ano.Size = new System.Drawing.Size(38, 20);
            this.Lbl_Ano.TabIndex = 36;
            this.Lbl_Ano.Text = "Ano";
            // 
            // Lbl_Km
            // 
            this.Lbl_Km.AutoSize = true;
            this.Lbl_Km.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Km.Location = new System.Drawing.Point(258, 228);
            this.Lbl_Km.Name = "Lbl_Km";
            this.Lbl_Km.Size = new System.Drawing.Size(32, 20);
            this.Lbl_Km.TabIndex = 35;
            this.Lbl_Km.Text = "KM";
            // 
            // CB_UnicoDono
            // 
            this.CB_UnicoDono.AutoSize = true;
            this.CB_UnicoDono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_UnicoDono.Location = new System.Drawing.Point(209, 168);
            this.CB_UnicoDono.Name = "CB_UnicoDono";
            this.CB_UnicoDono.Size = new System.Drawing.Size(95, 20);
            this.CB_UnicoDono.TabIndex = 34;
            this.CB_UnicoDono.Text = "Único dono";
            this.CB_UnicoDono.UseVisualStyleBackColor = true;
            this.CB_UnicoDono.CheckedChanged += new System.EventHandler(this.CB_UnicoDono_CheckedChanged);
            // 
            // Lbl_Combustivel
            // 
            this.Lbl_Combustivel.AutoSize = true;
            this.Lbl_Combustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Combustivel.Location = new System.Drawing.Point(425, 118);
            this.Lbl_Combustivel.Name = "Lbl_Combustivel";
            this.Lbl_Combustivel.Size = new System.Drawing.Size(148, 20);
            this.Lbl_Combustivel.TabIndex = 33;
            this.Lbl_Combustivel.Text = "Tipo de combustivel";
            // 
            // Lb_Combustivel
            // 
            this.Lb_Combustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Combustivel.FormattingEnabled = true;
            this.Lb_Combustivel.ItemHeight = 16;
            this.Lb_Combustivel.Items.AddRange(new object[] {
            "Flex",
            "Gasolina",
            "Álcool",
            "Diesel",
            "GNV"});
            this.Lb_Combustivel.Location = new System.Drawing.Point(453, 141);
            this.Lb_Combustivel.Name = "Lb_Combustivel";
            this.Lb_Combustivel.Size = new System.Drawing.Size(120, 84);
            this.Lb_Combustivel.TabIndex = 32;
            // 
            // Lbl_Blindado
            // 
            this.Lbl_Blindado.AutoSize = true;
            this.Lbl_Blindado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Blindado.Location = new System.Drawing.Point(231, 120);
            this.Lbl_Blindado.Name = "Lbl_Blindado";
            this.Lbl_Blindado.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Blindado.TabIndex = 31;
            this.Lbl_Blindado.Text = "Blindado?";
            // 
            // Lbl_Marca
            // 
            this.Lbl_Marca.AutoSize = true;
            this.Lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Marca.Location = new System.Drawing.Point(205, 10);
            this.Lbl_Marca.Name = "Lbl_Marca";
            this.Lbl_Marca.Size = new System.Drawing.Size(53, 20);
            this.Lbl_Marca.TabIndex = 30;
            this.Lbl_Marca.Text = "Marca";
            // 
            // Lbl_Modelo
            // 
            this.Lbl_Modelo.AutoSize = true;
            this.Lbl_Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modelo.Location = new System.Drawing.Point(205, 67);
            this.Lbl_Modelo.Name = "Lbl_Modelo";
            this.Lbl_Modelo.Size = new System.Drawing.Size(61, 20);
            this.Lbl_Modelo.TabIndex = 29;
            this.Lbl_Modelo.Text = "Modelo";
            // 
            // Txt_Modelo
            // 
            this.Txt_Modelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Modelo.Location = new System.Drawing.Point(212, 87);
            this.Txt_Modelo.Name = "Txt_Modelo";
            this.Txt_Modelo.Size = new System.Drawing.Size(344, 20);
            this.Txt_Modelo.TabIndex = 28;
            // 
            // Cb_Marca
            // 
            this.Cb_Marca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Marca.FormattingEnabled = true;
            this.Cb_Marca.Items.AddRange(new object[] {
            "Chevrolet",
            "Fiat",
            "Ford",
            "Honda",
            "Peugeot",
            "Renault",
            "Toyota",
            "VolksWagem",
            "Citroën"});
            this.Cb_Marca.Location = new System.Drawing.Point(212, 30);
            this.Cb_Marca.Name = "Cb_Marca";
            this.Cb_Marca.Size = new System.Drawing.Size(344, 21);
            this.Cb_Marca.TabIndex = 27;
            // 
            // Rdb_Nao
            // 
            this.Rdb_Nao.AutoSize = true;
            this.Rdb_Nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Nao.Location = new System.Drawing.Point(260, 142);
            this.Rdb_Nao.Name = "Rdb_Nao";
            this.Rdb_Nao.Size = new System.Drawing.Size(51, 20);
            this.Rdb_Nao.TabIndex = 26;
            this.Rdb_Nao.TabStop = true;
            this.Rdb_Nao.Text = "Não";
            this.Rdb_Nao.UseVisualStyleBackColor = true;
            this.Rdb_Nao.CheckedChanged += new System.EventHandler(this.Rdb_Nao_CheckedChanged);
            // 
            // Rdb_sim
            // 
            this.Rdb_sim.AutoSize = true;
            this.Rdb_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_sim.Location = new System.Drawing.Point(212, 142);
            this.Rdb_sim.Name = "Rdb_sim";
            this.Rdb_sim.Size = new System.Drawing.Size(48, 20);
            this.Rdb_sim.TabIndex = 25;
            this.Rdb_sim.TabStop = true;
            this.Rdb_sim.Text = "Sim";
            this.Rdb_sim.UseVisualStyleBackColor = true;
            this.Rdb_sim.CheckedChanged += new System.EventHandler(this.Rdb_sim_CheckedChanged);
            // 
            // Pb_UnicoDono
            // 
            this.Pb_UnicoDono.BackColor = System.Drawing.Color.Transparent;
            this.Pb_UnicoDono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pb_UnicoDono.ForeColor = System.Drawing.Color.Black;
            this.Pb_UnicoDono.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Pb_UnicoDono.IconColor = System.Drawing.Color.Black;
            this.Pb_UnicoDono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Pb_UnicoDono.IconSize = 17;
            this.Pb_UnicoDono.Location = new System.Drawing.Point(297, 168);
            this.Pb_UnicoDono.Name = "Pb_UnicoDono";
            this.Pb_UnicoDono.Size = new System.Drawing.Size(17, 20);
            this.Pb_UnicoDono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pb_UnicoDono.TabIndex = 43;
            this.Pb_UnicoDono.TabStop = false;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancelar.BackColor = System.Drawing.Color.Crimson;
            this.Btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Btn_Cancelar.IconColor = System.Drawing.Color.White;
            this.Btn_Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Cancelar.IconSize = 30;
            this.Btn_Cancelar.Location = new System.Drawing.Point(262, 369);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(120, 30);
            this.Btn_Cancelar.TabIndex = 44;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // SeletorImagem
            // 
            this.SeletorImagem.FileName = "openFileDialog1";
            // 
            // Form_EditarCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 411);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Pb_UnicoDono);
            this.Controls.Add(this.Pb_shield);
            this.Controls.Add(this.Txt_Km);
            this.Controls.Add(this.Txt_Preco);
            this.Controls.Add(this.Lbl_Preco);
            this.Controls.Add(this.Btn_RegistrarCarro);
            this.Controls.Add(this.Dtp_AnoCarro);
            this.Controls.Add(this.Lbl_Ano);
            this.Controls.Add(this.Lbl_Km);
            this.Controls.Add(this.CB_UnicoDono);
            this.Controls.Add(this.Lbl_Combustivel);
            this.Controls.Add(this.Lb_Combustivel);
            this.Controls.Add(this.Lbl_Blindado);
            this.Controls.Add(this.Lbl_Marca);
            this.Controls.Add(this.Lbl_Modelo);
            this.Controls.Add(this.Txt_Modelo);
            this.Controls.Add(this.Cb_Marca);
            this.Controls.Add(this.Rdb_Nao);
            this.Controls.Add(this.Rdb_sim);
            this.Controls.Add(this.Pb_ImagemCarro);
            this.Controls.Add(this.Btn_AbrirImagem);
            this.Controls.Add(this.Dgv_Carros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EditarCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_EditarCarro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Carros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ImagemCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_shield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_UnicoDono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Carros;
        private System.Windows.Forms.PictureBox Pb_ImagemCarro;
        private FontAwesome.Sharp.IconButton Btn_AbrirImagem;
        private FontAwesome.Sharp.IconPictureBox Pb_shield;
        private System.Windows.Forms.MaskedTextBox Txt_Km;
        private System.Windows.Forms.MaskedTextBox Txt_Preco;
        private System.Windows.Forms.Label Lbl_Preco;
        private FontAwesome.Sharp.IconButton Btn_RegistrarCarro;
        private System.Windows.Forms.DateTimePicker Dtp_AnoCarro;
        private System.Windows.Forms.Label Lbl_Ano;
        private System.Windows.Forms.Label Lbl_Km;
        private System.Windows.Forms.CheckBox CB_UnicoDono;
        private System.Windows.Forms.Label Lbl_Combustivel;
        private System.Windows.Forms.ListBox Lb_Combustivel;
        private System.Windows.Forms.Label Lbl_Blindado;
        private System.Windows.Forms.Label Lbl_Marca;
        private System.Windows.Forms.Label Lbl_Modelo;
        private System.Windows.Forms.TextBox Txt_Modelo;
        private System.Windows.Forms.ComboBox Cb_Marca;
        private System.Windows.Forms.RadioButton Rdb_Nao;
        private System.Windows.Forms.RadioButton Rdb_sim;
        private FontAwesome.Sharp.IconPictureBox Pb_UnicoDono;
        private FontAwesome.Sharp.IconButton Btn_Cancelar;
        private System.Windows.Forms.OpenFileDialog SeletorImagem;
    }
}