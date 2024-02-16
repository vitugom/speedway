using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto2023
{
    public partial class VendaRealizadaCard : UserControl
    {
        public VendaRealizadaCard()
        {
            InitializeComponent();
        }
        public string Modelo
        {
            get { return Lbl_Modelo.Text; }
            set { Lbl_Modelo.Text = value; }
        }

        public string Marca
        {
            get { return Lbl_Marca.Text; }
            set { Lbl_Marca.Text = value; }
        }

        public string Combustivel
        {
            get { return Lbl_Combustivel.Text; }
            set { Lbl_Combustivel.Text = value; }
        }

        public string Preco
        {
            get { return Lbl_Preco.Text; }
            set { Lbl_Preco.Text = value; }
        }

        public string Km
        {
            get { return Lbl_Km.Text; }
            set { Lbl_Km.Text = value; }
        }

        public string Ano
        {
            get { return Lbl_Ano.Text; }
            set { Lbl_Ano.Text = value; }
        }

        public Image ImagemCarro
        {
            get { return Pb_ImagemCarro.Image; }
            set { Pb_ImagemCarro.Image = value; }
        }

        public string NomeCliente
        {
            get { return Lbl_NomeCliente.Text; }
            set { Lbl_NomeCliente.Text = value; }
        }

        public string Cpf
        {
            get { return lbl_cpf.Text; }
            set { lbl_cpf.Text = value; }
        }

        public string Telefone
        {
            get { return Lbl_Telefone.Text; }
            set { Lbl_Telefone.Text = value; }
        }

        public string CEP
        {
            get { return Lbl_Cep.Text ; }
            set { Lbl_Cep.Text = value; }
        }

        public string NumeroResidencial
        {
            get { return Lbl_Num.Text; }
            set { Lbl_Num.Text = value; }
        }

        public string Vendedor
        {
            get { return Lbl_VendedorNome.Text; }
            set { Lbl_VendedorNome.Text = value; }
        }
    }
}
