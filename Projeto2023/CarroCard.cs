using System.Drawing;
using System.Windows.Forms;

namespace Projeto2023
{
    public partial class CarroCard : UserControl
    {
        public CarroCard()
        {
            InitializeComponent();
            Lbl_Marca.Text = "";
            Lbl_Preco.Text = "";
            Lbl_Km.Text = "";
            Lbl_Modelo.Text = "";
            Lbl_Ano.Text = "";

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

        public bool IconBlindado
        {
            get { return Pb_shield.Visible; }
            set { Pb_shield.Visible = value; }
        }

        public bool IconUnicoDono
        {
            get { return Pb_UnicoDono.Visible; }
            set { Pb_UnicoDono.Visible = value; }
        }

    }
}
 