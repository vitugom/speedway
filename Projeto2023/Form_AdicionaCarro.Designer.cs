namespace Projeto2023
{
    partial class Form_AdicionaCarro
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
            this.Btn_AbrirImagem = new FontAwesome.Sharp.IconButton();
            this.Rdb_sim = new System.Windows.Forms.RadioButton();
            this.Rdb_Nao = new System.Windows.Forms.RadioButton();
            this.Cb_Marca = new System.Windows.Forms.ComboBox();
            this.Txt_Modelo = new System.Windows.Forms.TextBox();
            this.Lbl_Modelo = new System.Windows.Forms.Label();
            this.Lbl_Marca = new System.Windows.Forms.Label();
            this.Lbl_Blindado = new System.Windows.Forms.Label();
            this.Lb_Combustivel = new System.Windows.Forms.ListBox();
            this.Lbl_Combustivel = new System.Windows.Forms.Label();
            this.CB_UnicoDono = new System.Windows.Forms.CheckBox();
            this.Lbl_Km = new System.Windows.Forms.Label();
            this.Lbl_Ano = new System.Windows.Forms.Label();
            this.Dtp_AnoCarro = new System.Windows.Forms.DateTimePicker();
            this.Btn_RegistrarCarro = new FontAwesome.Sharp.IconButton();
            this.SeletorImagem = new System.Windows.Forms.OpenFileDialog();
            this.Pb_ImagemCarro = new System.Windows.Forms.PictureBox();
            this.Lbl_Preco = new System.Windows.Forms.Label();
            this.Txt_Preco = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Km = new System.Windows.Forms.MaskedTextBox();
            this.Pb_shield = new FontAwesome.Sharp.IconPictureBox();
            this.Pb_UnicoDono = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ImagemCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_shield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_UnicoDono)).BeginInit();
            this.SuspendLayout();
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
            this.Btn_AbrirImagem.Location = new System.Drawing.Point(12, 182);
            this.Btn_AbrirImagem.Name = "Btn_AbrirImagem";
            this.Btn_AbrirImagem.Size = new System.Drawing.Size(167, 30);
            this.Btn_AbrirImagem.TabIndex = 1;
            this.Btn_AbrirImagem.UseVisualStyleBackColor = false;
            this.Btn_AbrirImagem.Click += new System.EventHandler(this.Btn_AbrirImagem_Click);
            // 
            // Rdb_sim
            // 
            this.Rdb_sim.AutoSize = true;
            this.Rdb_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_sim.Location = new System.Drawing.Point(206, 145);
            this.Rdb_sim.Name = "Rdb_sim";
            this.Rdb_sim.Size = new System.Drawing.Size(48, 20);
            this.Rdb_sim.TabIndex = 2;
            this.Rdb_sim.TabStop = true;
            this.Rdb_sim.Text = "Sim";
            this.Rdb_sim.UseVisualStyleBackColor = true;
            this.Rdb_sim.CheckedChanged += new System.EventHandler(this.Rdb_sim_CheckedChanged);
            // 
            // Rdb_Nao
            // 
            this.Rdb_Nao.AutoSize = true;
            this.Rdb_Nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Nao.Location = new System.Drawing.Point(254, 145);
            this.Rdb_Nao.Name = "Rdb_Nao";
            this.Rdb_Nao.Size = new System.Drawing.Size(51, 20);
            this.Rdb_Nao.TabIndex = 3;
            this.Rdb_Nao.TabStop = true;
            this.Rdb_Nao.Text = "Não";
            this.Rdb_Nao.UseVisualStyleBackColor = true;
            this.Rdb_Nao.CheckedChanged += new System.EventHandler(this.Rdb_Nao_CheckedChanged);
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
            this.Cb_Marca.Location = new System.Drawing.Point(206, 33);
            this.Cb_Marca.Name = "Cb_Marca";
            this.Cb_Marca.Size = new System.Drawing.Size(344, 21);
            this.Cb_Marca.TabIndex = 4;
            // 
            // Txt_Modelo
            // 
            this.Txt_Modelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Modelo.Location = new System.Drawing.Point(206, 90);
            this.Txt_Modelo.Name = "Txt_Modelo";
            this.Txt_Modelo.Size = new System.Drawing.Size(344, 20);
            this.Txt_Modelo.TabIndex = 5;
            // 
            // Lbl_Modelo
            // 
            this.Lbl_Modelo.AutoSize = true;
            this.Lbl_Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modelo.Location = new System.Drawing.Point(199, 70);
            this.Lbl_Modelo.Name = "Lbl_Modelo";
            this.Lbl_Modelo.Size = new System.Drawing.Size(61, 20);
            this.Lbl_Modelo.TabIndex = 6;
            this.Lbl_Modelo.Text = "Modelo";
            // 
            // Lbl_Marca
            // 
            this.Lbl_Marca.AutoSize = true;
            this.Lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Marca.Location = new System.Drawing.Point(199, 13);
            this.Lbl_Marca.Name = "Lbl_Marca";
            this.Lbl_Marca.Size = new System.Drawing.Size(53, 20);
            this.Lbl_Marca.TabIndex = 7;
            this.Lbl_Marca.Text = "Marca";
            // 
            // Lbl_Blindado
            // 
            this.Lbl_Blindado.AutoSize = true;
            this.Lbl_Blindado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Blindado.Location = new System.Drawing.Point(225, 123);
            this.Lbl_Blindado.Name = "Lbl_Blindado";
            this.Lbl_Blindado.Size = new System.Drawing.Size(80, 20);
            this.Lbl_Blindado.TabIndex = 8;
            this.Lbl_Blindado.Text = "Blindado?";
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
            this.Lb_Combustivel.Location = new System.Drawing.Point(430, 144);
            this.Lb_Combustivel.Name = "Lb_Combustivel";
            this.Lb_Combustivel.Size = new System.Drawing.Size(120, 84);
            this.Lb_Combustivel.TabIndex = 9;
            // 
            // Lbl_Combustivel
            // 
            this.Lbl_Combustivel.AutoSize = true;
            this.Lbl_Combustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Combustivel.Location = new System.Drawing.Point(426, 122);
            this.Lbl_Combustivel.Name = "Lbl_Combustivel";
            this.Lbl_Combustivel.Size = new System.Drawing.Size(148, 20);
            this.Lbl_Combustivel.TabIndex = 10;
            this.Lbl_Combustivel.Text = "Tipo de combustivel";
            // 
            // CB_UnicoDono
            // 
            this.CB_UnicoDono.AutoSize = true;
            this.CB_UnicoDono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_UnicoDono.Location = new System.Drawing.Point(206, 208);
            this.CB_UnicoDono.Name = "CB_UnicoDono";
            this.CB_UnicoDono.Size = new System.Drawing.Size(95, 20);
            this.CB_UnicoDono.TabIndex = 11;
            this.CB_UnicoDono.Text = "Único dono";
            this.CB_UnicoDono.UseVisualStyleBackColor = true;
            this.CB_UnicoDono.CheckedChanged += new System.EventHandler(this.CB_UnicoDono_CheckedChanged);
            // 
            // Lbl_Km
            // 
            this.Lbl_Km.AutoSize = true;
            this.Lbl_Km.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Km.Location = new System.Drawing.Point(202, 232);
            this.Lbl_Km.Name = "Lbl_Km";
            this.Lbl_Km.Size = new System.Drawing.Size(32, 20);
            this.Lbl_Km.TabIndex = 12;
            this.Lbl_Km.Text = "KM";
            // 
            // Lbl_Ano
            // 
            this.Lbl_Ano.AutoSize = true;
            this.Lbl_Ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ano.Location = new System.Drawing.Point(426, 232);
            this.Lbl_Ano.Name = "Lbl_Ano";
            this.Lbl_Ano.Size = new System.Drawing.Size(38, 20);
            this.Lbl_Ano.TabIndex = 14;
            this.Lbl_Ano.Text = "Ano";
            // 
            // Dtp_AnoCarro
            // 
            this.Dtp_AnoCarro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_AnoCarro.Location = new System.Drawing.Point(430, 255);
            this.Dtp_AnoCarro.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.Dtp_AnoCarro.Name = "Dtp_AnoCarro";
            this.Dtp_AnoCarro.Size = new System.Drawing.Size(81, 20);
            this.Dtp_AnoCarro.TabIndex = 16;
            this.Dtp_AnoCarro.Value = new System.DateTime(2023, 11, 13, 0, 0, 0, 0);
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
            this.Btn_RegistrarCarro.Location = new System.Drawing.Point(430, 356);
            this.Btn_RegistrarCarro.Name = "Btn_RegistrarCarro";
            this.Btn_RegistrarCarro.Size = new System.Drawing.Size(120, 30);
            this.Btn_RegistrarCarro.TabIndex = 18;
            this.Btn_RegistrarCarro.Text = "Salvar";
            this.Btn_RegistrarCarro.UseVisualStyleBackColor = false;
            this.Btn_RegistrarCarro.Click += new System.EventHandler(this.Btn_RegistrarCarro_Click);
            // 
            // SeletorImagem
            // 
            this.SeletorImagem.FileName = "openFileDialog1";
            // 
            // Pb_ImagemCarro
            // 
            this.Pb_ImagemCarro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pb_ImagemCarro.Location = new System.Drawing.Point(12, 13);
            this.Pb_ImagemCarro.Name = "Pb_ImagemCarro";
            this.Pb_ImagemCarro.Size = new System.Drawing.Size(167, 169);
            this.Pb_ImagemCarro.TabIndex = 19;
            this.Pb_ImagemCarro.TabStop = false;
            // 
            // Lbl_Preco
            // 
            this.Lbl_Preco.AutoSize = true;
            this.Lbl_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Preco.Location = new System.Drawing.Point(202, 288);
            this.Lbl_Preco.Name = "Lbl_Preco";
            this.Lbl_Preco.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Preco.TabIndex = 20;
            this.Lbl_Preco.Text = "Preço";
            // 
            // Txt_Preco
            // 
            this.Txt_Preco.Location = new System.Drawing.Point(206, 311);
            this.Txt_Preco.Mask = "$0000000000";
            this.Txt_Preco.Name = "Txt_Preco";
            this.Txt_Preco.Size = new System.Drawing.Size(118, 20);
            this.Txt_Preco.TabIndex = 22;
            // 
            // Txt_Km
            // 
            this.Txt_Km.Location = new System.Drawing.Point(206, 255);
            this.Txt_Km.Mask = "000000";
            this.Txt_Km.Name = "Txt_Km";
            this.Txt_Km.Size = new System.Drawing.Size(118, 20);
            this.Txt_Km.TabIndex = 23;
            // 
            // Pb_shield
            // 
            this.Pb_shield.BackColor = System.Drawing.Color.Transparent;
            this.Pb_shield.ForeColor = System.Drawing.Color.Black;
            this.Pb_shield.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.Pb_shield.IconColor = System.Drawing.Color.Black;
            this.Pb_shield.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Pb_shield.IconSize = 23;
            this.Pb_shield.Location = new System.Drawing.Point(203, 122);
            this.Pb_shield.Name = "Pb_shield";
            this.Pb_shield.Size = new System.Drawing.Size(24, 23);
            this.Pb_shield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_shield.TabIndex = 24;
            this.Pb_shield.TabStop = false;
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
            this.Pb_UnicoDono.Location = new System.Drawing.Point(294, 208);
            this.Pb_UnicoDono.Name = "Pb_UnicoDono";
            this.Pb_UnicoDono.Size = new System.Drawing.Size(17, 20);
            this.Pb_UnicoDono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pb_UnicoDono.TabIndex = 25;
            this.Pb_UnicoDono.TabStop = false;
            // 
            // Form_AdicionaCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 411);
            this.Controls.Add(this.Pb_UnicoDono);
            this.Controls.Add(this.Pb_shield);
            this.Controls.Add(this.Txt_Km);
            this.Controls.Add(this.Txt_Preco);
            this.Controls.Add(this.Lbl_Preco);
            this.Controls.Add(this.Pb_ImagemCarro);
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
            this.Controls.Add(this.Btn_AbrirImagem);
            this.Name = "Form_AdicionaCarro";
            this.Text = "Form_AdicionaCarro";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ImagemCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_shield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_UnicoDono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton Btn_AbrirImagem;
        private System.Windows.Forms.RadioButton Rdb_sim;
        private System.Windows.Forms.RadioButton Rdb_Nao;
        private System.Windows.Forms.ComboBox Cb_Marca;
        private System.Windows.Forms.TextBox Txt_Modelo;
        private System.Windows.Forms.Label Lbl_Modelo;
        private System.Windows.Forms.Label Lbl_Marca;
        private System.Windows.Forms.Label Lbl_Blindado;
        private System.Windows.Forms.ListBox Lb_Combustivel;
        private System.Windows.Forms.Label Lbl_Combustivel;
        private System.Windows.Forms.CheckBox CB_UnicoDono;
        private System.Windows.Forms.Label Lbl_Km;
        private System.Windows.Forms.Label Lbl_Ano;
        private System.Windows.Forms.DateTimePicker Dtp_AnoCarro;
        private FontAwesome.Sharp.IconButton Btn_RegistrarCarro;
        private System.Windows.Forms.OpenFileDialog SeletorImagem;
        private System.Windows.Forms.PictureBox Pb_ImagemCarro;
        private System.Windows.Forms.Label Lbl_Preco;
        private System.Windows.Forms.MaskedTextBox Txt_Preco;
        private System.Windows.Forms.MaskedTextBox Txt_Km;
        private FontAwesome.Sharp.IconPictureBox Pb_shield;
        private FontAwesome.Sharp.IconPictureBox Pb_UnicoDono;
    }
}