namespace Projeto2023
{
    partial class CarroCard
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarroCard));
            this.Pb_ImagemCarro = new System.Windows.Forms.PictureBox();
            this.Lbl_Modelo = new System.Windows.Forms.Label();
            this.Lbl_Marca = new System.Windows.Forms.Label();
            this.Lbl_Preco = new System.Windows.Forms.Label();
            this.Lbl_Ano = new System.Windows.Forms.Label();
            this.Lbl_Km = new System.Windows.Forms.Label();
            this.Pb_shield = new FontAwesome.Sharp.IconPictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Pb_UnicoDono = new FontAwesome.Sharp.IconPictureBox();
            this.Lbl_Combustivel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ImagemCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_shield)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_UnicoDono)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_ImagemCarro
            // 
            this.Pb_ImagemCarro.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pb_ImagemCarro.Image = ((System.Drawing.Image)(resources.GetObject("Pb_ImagemCarro.Image")));
            this.Pb_ImagemCarro.Location = new System.Drawing.Point(0, 0);
            this.Pb_ImagemCarro.Name = "Pb_ImagemCarro";
            this.Pb_ImagemCarro.Size = new System.Drawing.Size(270, 150);
            this.Pb_ImagemCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_ImagemCarro.TabIndex = 0;
            this.Pb_ImagemCarro.TabStop = false;
            // 
            // Lbl_Modelo
            // 
            this.Lbl_Modelo.AutoSize = true;
            this.Lbl_Modelo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modelo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Modelo.Location = new System.Drawing.Point(3, 153);
            this.Lbl_Modelo.Name = "Lbl_Modelo";
            this.Lbl_Modelo.Size = new System.Drawing.Size(95, 29);
            this.Lbl_Modelo.TabIndex = 1;
            this.Lbl_Modelo.Text = "Modelo";
            // 
            // Lbl_Marca
            // 
            this.Lbl_Marca.AutoSize = true;
            this.Lbl_Marca.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Marca.ForeColor = System.Drawing.Color.White;
            this.Lbl_Marca.Location = new System.Drawing.Point(4, 182);
            this.Lbl_Marca.Name = "Lbl_Marca";
            this.Lbl_Marca.Size = new System.Drawing.Size(53, 20);
            this.Lbl_Marca.TabIndex = 2;
            this.Lbl_Marca.Text = "Marca";
            // 
            // Lbl_Preco
            // 
            this.Lbl_Preco.AutoSize = true;
            this.Lbl_Preco.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Preco.ForeColor = System.Drawing.Color.White;
            this.Lbl_Preco.Location = new System.Drawing.Point(4, 231);
            this.Lbl_Preco.Name = "Lbl_Preco";
            this.Lbl_Preco.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Preco.TabIndex = 3;
            this.Lbl_Preco.Text = "Preço";
            // 
            // Lbl_Ano
            // 
            this.Lbl_Ano.AutoSize = true;
            this.Lbl_Ano.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ano.ForeColor = System.Drawing.Color.White;
            this.Lbl_Ano.Location = new System.Drawing.Point(4, 275);
            this.Lbl_Ano.Name = "Lbl_Ano";
            this.Lbl_Ano.Size = new System.Drawing.Size(38, 20);
            this.Lbl_Ano.TabIndex = 4;
            this.Lbl_Ano.Text = "Ano";
            // 
            // Lbl_Km
            // 
            this.Lbl_Km.AutoSize = true;
            this.Lbl_Km.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Km.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Km.ForeColor = System.Drawing.Color.White;
            this.Lbl_Km.Location = new System.Drawing.Point(178, 275);
            this.Lbl_Km.Name = "Lbl_Km";
            this.Lbl_Km.Size = new System.Drawing.Size(30, 20);
            this.Lbl_Km.TabIndex = 5;
            this.Lbl_Km.Text = "km";
            this.Lbl_Km.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pb_shield
            // 
            this.Pb_shield.BackColor = System.Drawing.Color.MediumPurple;
            this.Pb_shield.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.Pb_shield.IconColor = System.Drawing.Color.White;
            this.Pb_shield.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Pb_shield.IconSize = 26;
            this.Pb_shield.Location = new System.Drawing.Point(4, 3);
            this.Pb_shield.Name = "Pb_shield";
            this.Pb_shield.Size = new System.Drawing.Size(28, 26);
            this.Pb_shield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pb_shield.TabIndex = 6;
            this.Pb_shield.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Pb_UnicoDono);
            this.flowLayoutPanel1.Controls.Add(this.Pb_shield);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(201, 153);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(69, 29);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // Pb_UnicoDono
            // 
            this.Pb_UnicoDono.BackColor = System.Drawing.Color.Transparent;
            this.Pb_UnicoDono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pb_UnicoDono.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Pb_UnicoDono.IconColor = System.Drawing.Color.White;
            this.Pb_UnicoDono.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Pb_UnicoDono.IconSize = 26;
            this.Pb_UnicoDono.Location = new System.Drawing.Point(38, 3);
            this.Pb_UnicoDono.Name = "Pb_UnicoDono";
            this.Pb_UnicoDono.Size = new System.Drawing.Size(28, 26);
            this.Pb_UnicoDono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pb_UnicoDono.TabIndex = 7;
            this.Pb_UnicoDono.TabStop = false;
            // 
            // Lbl_Combustivel
            // 
            this.Lbl_Combustivel.AutoSize = true;
            this.Lbl_Combustivel.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Combustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Combustivel.ForeColor = System.Drawing.Color.White;
            this.Lbl_Combustivel.Location = new System.Drawing.Point(81, 275);
            this.Lbl_Combustivel.Name = "Lbl_Combustivel";
            this.Lbl_Combustivel.Size = new System.Drawing.Size(53, 20);
            this.Lbl_Combustivel.TabIndex = 9;
            this.Lbl_Combustivel.Text = "Marca";
            // 
            // CarroCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.Lbl_Combustivel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Lbl_Km);
            this.Controls.Add(this.Lbl_Ano);
            this.Controls.Add(this.Lbl_Preco);
            this.Controls.Add(this.Lbl_Marca);
            this.Controls.Add(this.Lbl_Modelo);
            this.Controls.Add(this.Pb_ImagemCarro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CarroCard";
            this.Size = new System.Drawing.Size(270, 300);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ImagemCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_shield)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_UnicoDono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_ImagemCarro;
        private System.Windows.Forms.Label Lbl_Modelo;
        private System.Windows.Forms.Label Lbl_Marca;
        private System.Windows.Forms.Label Lbl_Preco;
        private System.Windows.Forms.Label Lbl_Ano;
        private System.Windows.Forms.Label Lbl_Km;
        private FontAwesome.Sharp.IconPictureBox Pb_shield;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox Pb_UnicoDono;
        private System.Windows.Forms.Label Lbl_Combustivel;
    }
}
