namespace Projeto2023
{
    partial class Form_RealizaVenda
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
            this.Lbl_NomeCliente = new System.Windows.Forms.Label();
            this.Txt_NomeCliente = new System.Windows.Forms.TextBox();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Cpf = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Cpf = new System.Windows.Forms.Label();
            this.Lbl_Profissao = new System.Windows.Forms.Label();
            this.Txt_Profissao = new System.Windows.Forms.TextBox();
            this.Gb_DadosCliente = new System.Windows.Forms.GroupBox();
            this.Gb_Endereco = new System.Windows.Forms.GroupBox();
            this.Btn_PesquisaCep = new FontAwesome.Sharp.IconButton();
            this.Txt_Numero = new System.Windows.Forms.TextBox();
            this.Txt_Cep = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Lbl_Numero = new System.Windows.Forms.Label();
            this.Lbl_estado = new System.Windows.Forms.Label();
            this.Lbl_Cep = new System.Windows.Forms.Label();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Lbl_Cidade = new System.Windows.Forms.Label();
            this.Lbl_Logradouro = new System.Windows.Forms.Label();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Txt_Logradouro = new System.Windows.Forms.MaskedTextBox();
            this.Txt_Bairro = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_NomeVendedor = new System.Windows.Forms.Label();
            this.Txt_NomeVendedor = new System.Windows.Forms.TextBox();
            this.Btn_RealizarVenda = new FontAwesome.Sharp.IconButton();
            this.Pnl_CarroSelecionado = new System.Windows.Forms.Panel();
            this.Gb_DadosCliente.SuspendLayout();
            this.Gb_Endereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_NomeCliente
            // 
            this.Lbl_NomeCliente.AutoSize = true;
            this.Lbl_NomeCliente.Location = new System.Drawing.Point(15, 27);
            this.Lbl_NomeCliente.Name = "Lbl_NomeCliente";
            this.Lbl_NomeCliente.Size = new System.Drawing.Size(35, 13);
            this.Lbl_NomeCliente.TabIndex = 2;
            this.Lbl_NomeCliente.Text = "Nome";
            // 
            // Txt_NomeCliente
            // 
            this.Txt_NomeCliente.Location = new System.Drawing.Point(18, 44);
            this.Txt_NomeCliente.Name = "Txt_NomeCliente";
            this.Txt_NomeCliente.Size = new System.Drawing.Size(184, 20);
            this.Txt_NomeCliente.TabIndex = 3;
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Location = new System.Drawing.Point(15, 67);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Telefone.TabIndex = 4;
            this.Lbl_Telefone.Text = "Telefone";
            // 
            // Txt_telefone
            // 
            this.Txt_telefone.Location = new System.Drawing.Point(18, 84);
            this.Txt_telefone.Mask = "(99) 00000-0000";
            this.Txt_telefone.Name = "Txt_telefone";
            this.Txt_telefone.Size = new System.Drawing.Size(126, 20);
            this.Txt_telefone.TabIndex = 5;
            // 
            // Txt_Cpf
            // 
            this.Txt_Cpf.Location = new System.Drawing.Point(18, 123);
            this.Txt_Cpf.Mask = "000,000,000-00";
            this.Txt_Cpf.Name = "Txt_Cpf";
            this.Txt_Cpf.Size = new System.Drawing.Size(126, 20);
            this.Txt_Cpf.TabIndex = 6;
            // 
            // Lbl_Cpf
            // 
            this.Lbl_Cpf.AutoSize = true;
            this.Lbl_Cpf.Location = new System.Drawing.Point(15, 107);
            this.Lbl_Cpf.Name = "Lbl_Cpf";
            this.Lbl_Cpf.Size = new System.Drawing.Size(27, 13);
            this.Lbl_Cpf.TabIndex = 7;
            this.Lbl_Cpf.Text = "CPF";
            // 
            // Lbl_Profissao
            // 
            this.Lbl_Profissao.AutoSize = true;
            this.Lbl_Profissao.Location = new System.Drawing.Point(15, 146);
            this.Lbl_Profissao.Name = "Lbl_Profissao";
            this.Lbl_Profissao.Size = new System.Drawing.Size(50, 13);
            this.Lbl_Profissao.TabIndex = 8;
            this.Lbl_Profissao.Text = "Profissão";
            // 
            // Txt_Profissao
            // 
            this.Txt_Profissao.Location = new System.Drawing.Point(18, 162);
            this.Txt_Profissao.Name = "Txt_Profissao";
            this.Txt_Profissao.Size = new System.Drawing.Size(126, 20);
            this.Txt_Profissao.TabIndex = 9;
            // 
            // Gb_DadosCliente
            // 
            this.Gb_DadosCliente.Controls.Add(this.Lbl_NomeCliente);
            this.Gb_DadosCliente.Controls.Add(this.Txt_Profissao);
            this.Gb_DadosCliente.Controls.Add(this.Txt_NomeCliente);
            this.Gb_DadosCliente.Controls.Add(this.Lbl_Profissao);
            this.Gb_DadosCliente.Controls.Add(this.Lbl_Telefone);
            this.Gb_DadosCliente.Controls.Add(this.Lbl_Cpf);
            this.Gb_DadosCliente.Controls.Add(this.Txt_telefone);
            this.Gb_DadosCliente.Controls.Add(this.Txt_Cpf);
            this.Gb_DadosCliente.Location = new System.Drawing.Point(59, 149);
            this.Gb_DadosCliente.Name = "Gb_DadosCliente";
            this.Gb_DadosCliente.Size = new System.Drawing.Size(219, 193);
            this.Gb_DadosCliente.TabIndex = 10;
            this.Gb_DadosCliente.TabStop = false;
            this.Gb_DadosCliente.Text = "Dados  pessoais do cliente";
            // 
            // Gb_Endereco
            // 
            this.Gb_Endereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_Endereco.Controls.Add(this.Btn_PesquisaCep);
            this.Gb_Endereco.Controls.Add(this.Txt_Numero);
            this.Gb_Endereco.Controls.Add(this.Txt_Cep);
            this.Gb_Endereco.Controls.Add(this.Txt_Estado);
            this.Gb_Endereco.Controls.Add(this.Lbl_Numero);
            this.Gb_Endereco.Controls.Add(this.Lbl_estado);
            this.Gb_Endereco.Controls.Add(this.Lbl_Cep);
            this.Gb_Endereco.Controls.Add(this.Txt_Cidade);
            this.Gb_Endereco.Controls.Add(this.Lbl_Cidade);
            this.Gb_Endereco.Controls.Add(this.Lbl_Logradouro);
            this.Gb_Endereco.Controls.Add(this.Lbl_Bairro);
            this.Gb_Endereco.Controls.Add(this.Txt_Logradouro);
            this.Gb_Endereco.Controls.Add(this.Txt_Bairro);
            this.Gb_Endereco.Location = new System.Drawing.Point(295, 149);
            this.Gb_Endereco.Name = "Gb_Endereco";
            this.Gb_Endereco.Size = new System.Drawing.Size(248, 193);
            this.Gb_Endereco.TabIndex = 11;
            this.Gb_Endereco.TabStop = false;
            this.Gb_Endereco.Text = "Endereço do cliente";
            // 
            // Btn_PesquisaCep
            // 
            this.Btn_PesquisaCep.ForeColor = System.Drawing.Color.GreenYellow;
            this.Btn_PesquisaCep.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.Btn_PesquisaCep.IconColor = System.Drawing.Color.Lime;
            this.Btn_PesquisaCep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_PesquisaCep.IconSize = 20;
            this.Btn_PesquisaCep.Location = new System.Drawing.Point(150, 40);
            this.Btn_PesquisaCep.Name = "Btn_PesquisaCep";
            this.Btn_PesquisaCep.Size = new System.Drawing.Size(25, 23);
            this.Btn_PesquisaCep.TabIndex = 15;
            this.Btn_PesquisaCep.UseVisualStyleBackColor = true;
            this.Btn_PesquisaCep.Click += new System.EventHandler(this.Btn_PesquisaCep_Click);
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.Location = new System.Drawing.Point(168, 85);
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Size = new System.Drawing.Size(74, 20);
            this.Txt_Numero.TabIndex = 14;
            // 
            // Txt_Cep
            // 
            this.Txt_Cep.Location = new System.Drawing.Point(18, 43);
            this.Txt_Cep.Mask = "00000-000";
            this.Txt_Cep.Name = "Txt_Cep";
            this.Txt_Cep.Size = new System.Drawing.Size(126, 20);
            this.Txt_Cep.TabIndex = 13;
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.Location = new System.Drawing.Point(168, 162);
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.ReadOnly = true;
            this.Txt_Estado.Size = new System.Drawing.Size(39, 20);
            this.Txt_Estado.TabIndex = 11;
            // 
            // Lbl_Numero
            // 
            this.Lbl_Numero.AutoSize = true;
            this.Lbl_Numero.Location = new System.Drawing.Point(165, 68);
            this.Lbl_Numero.Name = "Lbl_Numero";
            this.Lbl_Numero.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Numero.TabIndex = 11;
            this.Lbl_Numero.Text = "Número";
            // 
            // Lbl_estado
            // 
            this.Lbl_estado.AutoSize = true;
            this.Lbl_estado.Location = new System.Drawing.Point(165, 146);
            this.Lbl_estado.Name = "Lbl_estado";
            this.Lbl_estado.Size = new System.Drawing.Size(40, 13);
            this.Lbl_estado.TabIndex = 10;
            this.Lbl_estado.Text = "Estado";
            // 
            // Lbl_Cep
            // 
            this.Lbl_Cep.AutoSize = true;
            this.Lbl_Cep.Location = new System.Drawing.Point(15, 27);
            this.Lbl_Cep.Name = "Lbl_Cep";
            this.Lbl_Cep.Size = new System.Drawing.Size(28, 13);
            this.Lbl_Cep.TabIndex = 2;
            this.Lbl_Cep.Text = "CEP";
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(18, 162);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.ReadOnly = true;
            this.Txt_Cidade.Size = new System.Drawing.Size(126, 20);
            this.Txt_Cidade.TabIndex = 9;
            // 
            // Lbl_Cidade
            // 
            this.Lbl_Cidade.AutoSize = true;
            this.Lbl_Cidade.Location = new System.Drawing.Point(15, 146);
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            this.Lbl_Cidade.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Cidade.TabIndex = 8;
            this.Lbl_Cidade.Text = "Cidade";
            // 
            // Lbl_Logradouro
            // 
            this.Lbl_Logradouro.AutoSize = true;
            this.Lbl_Logradouro.Location = new System.Drawing.Point(15, 67);
            this.Lbl_Logradouro.Name = "Lbl_Logradouro";
            this.Lbl_Logradouro.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Logradouro.TabIndex = 4;
            this.Lbl_Logradouro.Text = "Logradouro";
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Location = new System.Drawing.Point(15, 107);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Bairro.TabIndex = 7;
            this.Lbl_Bairro.Text = "Bairro";
            // 
            // Txt_Logradouro
            // 
            this.Txt_Logradouro.Location = new System.Drawing.Point(18, 84);
            this.Txt_Logradouro.Name = "Txt_Logradouro";
            this.Txt_Logradouro.ReadOnly = true;
            this.Txt_Logradouro.Size = new System.Drawing.Size(126, 20);
            this.Txt_Logradouro.TabIndex = 5;
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(18, 123);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.ReadOnly = true;
            this.Txt_Bairro.Size = new System.Drawing.Size(126, 20);
            this.Txt_Bairro.TabIndex = 6;
            // 
            // Lbl_NomeVendedor
            // 
            this.Lbl_NomeVendedor.AutoSize = true;
            this.Lbl_NomeVendedor.Location = new System.Drawing.Point(56, 357);
            this.Lbl_NomeVendedor.Name = "Lbl_NomeVendedor";
            this.Lbl_NomeVendedor.Size = new System.Drawing.Size(98, 13);
            this.Lbl_NomeVendedor.TabIndex = 10;
            this.Lbl_NomeVendedor.Text = "Nome do vendedor";
            // 
            // Txt_NomeVendedor
            // 
            this.Txt_NomeVendedor.Location = new System.Drawing.Point(59, 373);
            this.Txt_NomeVendedor.Name = "Txt_NomeVendedor";
            this.Txt_NomeVendedor.Size = new System.Drawing.Size(126, 20);
            this.Txt_NomeVendedor.TabIndex = 10;
            // 
            // Btn_RealizarVenda
            // 
            this.Btn_RealizarVenda.BackColor = System.Drawing.Color.MediumPurple;
            this.Btn_RealizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_RealizarVenda.ForeColor = System.Drawing.Color.White;
            this.Btn_RealizarVenda.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.Btn_RealizarVenda.IconColor = System.Drawing.Color.White;
            this.Btn_RealizarVenda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_RealizarVenda.IconSize = 30;
            this.Btn_RealizarVenda.Location = new System.Drawing.Point(417, 357);
            this.Btn_RealizarVenda.Name = "Btn_RealizarVenda";
            this.Btn_RealizarVenda.Size = new System.Drawing.Size(126, 36);
            this.Btn_RealizarVenda.TabIndex = 12;
            this.Btn_RealizarVenda.Text = "Realizar Venda";
            this.Btn_RealizarVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_RealizarVenda.UseVisualStyleBackColor = false;
            this.Btn_RealizarVenda.Click += new System.EventHandler(this.Btn_RealizarVenda_Click);
            // 
            // Pnl_CarroSelecionado
            // 
            this.Pnl_CarroSelecionado.Location = new System.Drawing.Point(59, 22);
            this.Pnl_CarroSelecionado.Name = "Pnl_CarroSelecionado";
            this.Pnl_CarroSelecionado.Size = new System.Drawing.Size(484, 121);
            this.Pnl_CarroSelecionado.TabIndex = 13;
            // 
            // Form_RealizaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(599, 411);
            this.Controls.Add(this.Pnl_CarroSelecionado);
            this.Controls.Add(this.Btn_RealizarVenda);
            this.Controls.Add(this.Txt_NomeVendedor);
            this.Controls.Add(this.Lbl_NomeVendedor);
            this.Controls.Add(this.Gb_Endereco);
            this.Controls.Add(this.Gb_DadosCliente);
            this.Name = "Form_RealizaVenda";
            this.Text = "Form_RealizaVenda";
            this.Gb_DadosCliente.ResumeLayout(false);
            this.Gb_DadosCliente.PerformLayout();
            this.Gb_Endereco.ResumeLayout(false);
            this.Gb_Endereco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_NomeCliente;
        private System.Windows.Forms.TextBox Txt_NomeCliente;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.MaskedTextBox Txt_telefone;
        private System.Windows.Forms.MaskedTextBox Txt_Cpf;
        private System.Windows.Forms.Label Lbl_Cpf;
        private System.Windows.Forms.Label Lbl_Profissao;
        private System.Windows.Forms.TextBox Txt_Profissao;
        private System.Windows.Forms.GroupBox Gb_DadosCliente;
        private System.Windows.Forms.GroupBox Gb_Endereco;
        private System.Windows.Forms.Label Lbl_Numero;
        private System.Windows.Forms.Label Lbl_estado;
        private System.Windows.Forms.Label Lbl_Cep;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.Label Lbl_Cidade;
        private System.Windows.Forms.Label Lbl_Logradouro;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.MaskedTextBox Txt_Logradouro;
        private System.Windows.Forms.MaskedTextBox Txt_Bairro;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.MaskedTextBox Txt_Cep;
        private System.Windows.Forms.Label Lbl_NomeVendedor;
        private System.Windows.Forms.TextBox Txt_NomeVendedor;
        private FontAwesome.Sharp.IconButton Btn_RealizarVenda;
        private System.Windows.Forms.Panel Pnl_CarroSelecionado;
        private System.Windows.Forms.TextBox Txt_Numero;
        private FontAwesome.Sharp.IconButton Btn_PesquisaCep;
    }
}