namespace Projeto2023
{
    partial class Form_MenuPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MenuPrincipal));
            this.Pnl_MenuLateral = new System.Windows.Forms.Panel();
            this.Btn_RealizaVenda = new FontAwesome.Sharp.IconButton();
            this.Btn_CadastrarCarro = new FontAwesome.Sharp.IconButton();
            this.Btn_Vendas = new FontAwesome.Sharp.IconButton();
            this.Btn_CarrosDisponiveis = new FontAwesome.Sharp.IconButton();
            this.Pnl_MarcaLoja = new System.Windows.Forms.Panel();
            this.Lbl_MarcaLoja = new System.Windows.Forms.Label();
            this.Pnl_Conteudo = new System.Windows.Forms.Panel();
            this.Pnl_MenuLateral.SuspendLayout();
            this.Pnl_MarcaLoja.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_MenuLateral
            // 
            this.Pnl_MenuLateral.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Pnl_MenuLateral.Controls.Add(this.Btn_RealizaVenda);
            this.Pnl_MenuLateral.Controls.Add(this.Btn_CadastrarCarro);
            this.Pnl_MenuLateral.Controls.Add(this.Btn_Vendas);
            this.Pnl_MenuLateral.Controls.Add(this.Btn_CarrosDisponiveis);
            this.Pnl_MenuLateral.Controls.Add(this.Pnl_MarcaLoja);
            this.Pnl_MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_MenuLateral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_MenuLateral.ForeColor = System.Drawing.Color.White;
            this.Pnl_MenuLateral.Location = new System.Drawing.Point(0, 0);
            this.Pnl_MenuLateral.Name = "Pnl_MenuLateral";
            this.Pnl_MenuLateral.Size = new System.Drawing.Size(185, 450);
            this.Pnl_MenuLateral.TabIndex = 0;
            // 
            // Btn_RealizaVenda
            // 
            this.Btn_RealizaVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_RealizaVenda.FlatAppearance.BorderSize = 0;
            this.Btn_RealizaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RealizaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RealizaVenda.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.Btn_RealizaVenda.IconColor = System.Drawing.Color.White;
            this.Btn_RealizaVenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_RealizaVenda.IconSize = 30;
            this.Btn_RealizaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_RealizaVenda.Location = new System.Drawing.Point(0, 343);
            this.Btn_RealizaVenda.Name = "Btn_RealizaVenda";
            this.Btn_RealizaVenda.Size = new System.Drawing.Size(185, 81);
            this.Btn_RealizaVenda.TabIndex = 5;
            this.Btn_RealizaVenda.Text = "Realizar venda";
            this.Btn_RealizaVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_RealizaVenda.UseVisualStyleBackColor = true;
            this.Btn_RealizaVenda.Click += new System.EventHandler(this.Btn_RealizaVenda_Click);
            // 
            // Btn_CadastrarCarro
            // 
            this.Btn_CadastrarCarro.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_CadastrarCarro.FlatAppearance.BorderSize = 0;
            this.Btn_CadastrarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CadastrarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CadastrarCarro.IconChar = FontAwesome.Sharp.IconChar.CarSide;
            this.Btn_CadastrarCarro.IconColor = System.Drawing.Color.White;
            this.Btn_CadastrarCarro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_CadastrarCarro.IconSize = 30;
            this.Btn_CadastrarCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CadastrarCarro.Location = new System.Drawing.Point(0, 262);
            this.Btn_CadastrarCarro.Name = "Btn_CadastrarCarro";
            this.Btn_CadastrarCarro.Size = new System.Drawing.Size(185, 81);
            this.Btn_CadastrarCarro.TabIndex = 4;
            this.Btn_CadastrarCarro.Text = "Novo Carro";
            this.Btn_CadastrarCarro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_CadastrarCarro.UseVisualStyleBackColor = true;
            this.Btn_CadastrarCarro.Click += new System.EventHandler(this.Btn_CadastrarCarro_Click);
            // 
            // Btn_Vendas
            // 
            this.Btn_Vendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Vendas.FlatAppearance.BorderSize = 0;
            this.Btn_Vendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Vendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Vendas.IconChar = FontAwesome.Sharp.IconChar.List;
            this.Btn_Vendas.IconColor = System.Drawing.Color.White;
            this.Btn_Vendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Vendas.IconSize = 30;
            this.Btn_Vendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Vendas.Location = new System.Drawing.Point(0, 181);
            this.Btn_Vendas.Name = "Btn_Vendas";
            this.Btn_Vendas.Size = new System.Drawing.Size(185, 81);
            this.Btn_Vendas.TabIndex = 3;
            this.Btn_Vendas.Text = "Vendas";
            this.Btn_Vendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Vendas.UseVisualStyleBackColor = true;
            this.Btn_Vendas.Click += new System.EventHandler(this.Btn_Vendas_Click);
            // 
            // Btn_CarrosDisponiveis
            // 
            this.Btn_CarrosDisponiveis.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_CarrosDisponiveis.FlatAppearance.BorderSize = 0;
            this.Btn_CarrosDisponiveis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CarrosDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CarrosDisponiveis.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.Btn_CarrosDisponiveis.IconColor = System.Drawing.Color.White;
            this.Btn_CarrosDisponiveis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_CarrosDisponiveis.IconSize = 30;
            this.Btn_CarrosDisponiveis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CarrosDisponiveis.Location = new System.Drawing.Point(0, 100);
            this.Btn_CarrosDisponiveis.Name = "Btn_CarrosDisponiveis";
            this.Btn_CarrosDisponiveis.Size = new System.Drawing.Size(185, 81);
            this.Btn_CarrosDisponiveis.TabIndex = 2;
            this.Btn_CarrosDisponiveis.Text = "Carros disponiveis";
            this.Btn_CarrosDisponiveis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_CarrosDisponiveis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_CarrosDisponiveis.UseVisualStyleBackColor = true;
            this.Btn_CarrosDisponiveis.Click += new System.EventHandler(this.Btn_CarrosDisponiveis_Click);
            // 
            // Pnl_MarcaLoja
            // 
            this.Pnl_MarcaLoja.Controls.Add(this.Lbl_MarcaLoja);
            this.Pnl_MarcaLoja.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_MarcaLoja.Location = new System.Drawing.Point(0, 0);
            this.Pnl_MarcaLoja.Name = "Pnl_MarcaLoja";
            this.Pnl_MarcaLoja.Size = new System.Drawing.Size(185, 100);
            this.Pnl_MarcaLoja.TabIndex = 0;
            // 
            // Lbl_MarcaLoja
            // 
            this.Lbl_MarcaLoja.AutoSize = true;
            this.Lbl_MarcaLoja.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_MarcaLoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MarcaLoja.ForeColor = System.Drawing.Color.White;
            this.Lbl_MarcaLoja.Location = new System.Drawing.Point(24, 38);
            this.Lbl_MarcaLoja.Name = "Lbl_MarcaLoja";
            this.Lbl_MarcaLoja.Size = new System.Drawing.Size(132, 25);
            this.Lbl_MarcaLoja.TabIndex = 0;
            this.Lbl_MarcaLoja.Text = "SPEEDWAY";
            this.Lbl_MarcaLoja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_Conteudo
            // 
            this.Pnl_Conteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Conteudo.Location = new System.Drawing.Point(185, 0);
            this.Pnl_Conteudo.Name = "Pnl_Conteudo";
            this.Pnl_Conteudo.Size = new System.Drawing.Size(615, 450);
            this.Pnl_Conteudo.TabIndex = 1;
            // 
            // Form_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pnl_Conteudo);
            this.Controls.Add(this.Pnl_MenuLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_MenuPrincipal";
            this.Text = "SPEEDWAY";
            this.Load += new System.EventHandler(this.Form_MenuPrincipal_Load);
            this.Pnl_MenuLateral.ResumeLayout(false);
            this.Pnl_MarcaLoja.ResumeLayout(false);
            this.Pnl_MarcaLoja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_MenuLateral;
        private System.Windows.Forms.Panel Pnl_MarcaLoja;
        private System.Windows.Forms.Label Lbl_MarcaLoja;
        private FontAwesome.Sharp.IconButton Btn_CarrosDisponiveis;
        private FontAwesome.Sharp.IconButton Btn_Vendas;
        private FontAwesome.Sharp.IconButton Btn_CadastrarCarro;
        private FontAwesome.Sharp.IconButton Btn_RealizaVenda;
        private System.Windows.Forms.Panel Pnl_Conteudo;
    }
}

