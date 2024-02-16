namespace Projeto2023
{
    partial class CarroVendaCard
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
            this.Pb_ImagemVenda = new System.Windows.Forms.PictureBox();
            this.Lbl_Modelo = new System.Windows.Forms.Label();
            this.Lbl_Marca = new System.Windows.Forms.Label();
            this.Lbl_Preco = new System.Windows.Forms.Label();
            this.Lbl_Km = new System.Windows.Forms.Label();
            this.Lbl_Ano = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ImagemVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_ImagemVenda
            // 
            this.Pb_ImagemVenda.Location = new System.Drawing.Point(4, 4);
            this.Pb_ImagemVenda.Name = "Pb_ImagemVenda";
            this.Pb_ImagemVenda.Size = new System.Drawing.Size(128, 114);
            this.Pb_ImagemVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_ImagemVenda.TabIndex = 0;
            this.Pb_ImagemVenda.TabStop = false;
            // 
            // Lbl_Modelo
            // 
            this.Lbl_Modelo.AutoSize = true;
            this.Lbl_Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modelo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Modelo.Location = new System.Drawing.Point(139, 4);
            this.Lbl_Modelo.Name = "Lbl_Modelo";
            this.Lbl_Modelo.Size = new System.Drawing.Size(83, 25);
            this.Lbl_Modelo.TabIndex = 1;
            this.Lbl_Modelo.Text = "Modelo";
            // 
            // Lbl_Marca
            // 
            this.Lbl_Marca.AutoSize = true;
            this.Lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Marca.ForeColor = System.Drawing.Color.White;
            this.Lbl_Marca.Location = new System.Drawing.Point(140, 29);
            this.Lbl_Marca.Name = "Lbl_Marca";
            this.Lbl_Marca.Size = new System.Drawing.Size(53, 20);
            this.Lbl_Marca.TabIndex = 2;
            this.Lbl_Marca.Text = "Marca";
            // 
            // Lbl_Preco
            // 
            this.Lbl_Preco.AutoSize = true;
            this.Lbl_Preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Preco.ForeColor = System.Drawing.Color.White;
            this.Lbl_Preco.Location = new System.Drawing.Point(140, 98);
            this.Lbl_Preco.Name = "Lbl_Preco";
            this.Lbl_Preco.Size = new System.Drawing.Size(50, 20);
            this.Lbl_Preco.TabIndex = 3;
            this.Lbl_Preco.Text = "Preco";
            // 
            // Lbl_Km
            // 
            this.Lbl_Km.AutoSize = true;
            this.Lbl_Km.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Km.ForeColor = System.Drawing.Color.White;
            this.Lbl_Km.Location = new System.Drawing.Point(390, 9);
            this.Lbl_Km.Name = "Lbl_Km";
            this.Lbl_Km.Size = new System.Drawing.Size(32, 20);
            this.Lbl_Km.TabIndex = 4;
            this.Lbl_Km.Text = "KM";
            // 
            // Lbl_Ano
            // 
            this.Lbl_Ano.AutoSize = true;
            this.Lbl_Ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Ano.ForeColor = System.Drawing.Color.White;
            this.Lbl_Ano.Location = new System.Drawing.Point(141, 49);
            this.Lbl_Ano.Name = "Lbl_Ano";
            this.Lbl_Ano.Size = new System.Drawing.Size(34, 18);
            this.Lbl_Ano.TabIndex = 5;
            this.Lbl_Ano.Text = "Ano";
            // 
            // CarroVendaCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.Lbl_Ano);
            this.Controls.Add(this.Lbl_Km);
            this.Controls.Add(this.Lbl_Preco);
            this.Controls.Add(this.Lbl_Marca);
            this.Controls.Add(this.Lbl_Modelo);
            this.Controls.Add(this.Pb_ImagemVenda);
            this.Name = "CarroVendaCard";
            this.Size = new System.Drawing.Size(484, 121);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_ImagemVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_ImagemVenda;
        private System.Windows.Forms.Label Lbl_Modelo;
        private System.Windows.Forms.Label Lbl_Marca;
        private System.Windows.Forms.Label Lbl_Preco;
        private System.Windows.Forms.Label Lbl_Km;
        private System.Windows.Forms.Label Lbl_Ano;
    }
}
