using System;
using System.Windows.Forms;

namespace Projeto2023
{

    public partial class Form_MenuPrincipal : Form
    {
        public Form_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form_MenuPrincipal_Load(object sender, EventArgs e)
        {
            Form_CarrosDisponiveis carroDisponiveis = new Form_CarrosDisponiveis();
            carroDisponiveis.TopLevel = false;
            carroDisponiveis.FormBorderStyle = FormBorderStyle.None;
            Pnl_Conteudo.Controls.Add(carroDisponiveis);
            carroDisponiveis.Dock = DockStyle.Fill;
            carroDisponiveis.Show();
        }

        private void Btn_CadastrarCarro_Click(object sender, EventArgs e)
        {
            Pnl_Conteudo.Controls.Clear();
            Form_AdicionaCarro carro = new Form_AdicionaCarro();
            carro.TopLevel = false;
            carro.FormBorderStyle = FormBorderStyle.None;
            Pnl_Conteudo.Controls.Add(carro);
            carro.Dock = DockStyle.Fill;
            carro.Show();
        }

        private void Btn_CarrosDisponiveis_Click(object sender, EventArgs e)
        {
            Pnl_Conteudo.Controls.Clear();
            Form_CarrosDisponiveis carroDisponiveis = new Form_CarrosDisponiveis();
            carroDisponiveis.TopLevel = false;
            carroDisponiveis.FormBorderStyle = FormBorderStyle.None;
            Pnl_Conteudo.Controls.Add(carroDisponiveis);
            carroDisponiveis.Dock = DockStyle.Fill;
            carroDisponiveis.Show();
        }

        private void Btn_Vendas_Click(object sender, EventArgs e)
        {
            Pnl_Conteudo.Controls.Clear();
            Form_Vendas MostraVendas = new Form_Vendas();
            MostraVendas.TopLevel = false;
            MostraVendas.FormBorderStyle = FormBorderStyle.None;
            Pnl_Conteudo.Controls.Add(MostraVendas);
            MostraVendas.Dock = DockStyle.Fill;
            MostraVendas.Show();
        }

        private void Btn_RealizaVenda_Click(object sender, EventArgs e)
        {

            Pnl_Conteudo.Controls.Clear();
            Form_RealizaVenda venda = new Form_RealizaVenda();
            venda.TopLevel = false;
            venda.FormBorderStyle = FormBorderStyle.None;
            Pnl_Conteudo.Controls.Add(venda);
            venda.Dock = DockStyle.Fill;
            venda.Show();
            
        }
    }
}

