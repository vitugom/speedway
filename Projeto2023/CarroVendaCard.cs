using System.Drawing;
using System.Windows.Forms;

namespace Projeto2023
{
    public partial class CarroVendaCard : UserControl
    {
        public CarroVendaCard()
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
            get { return Pb_ImagemVenda.Image; }
            set { Pb_ImagemVenda.Image = value; }
        }

    }
}

