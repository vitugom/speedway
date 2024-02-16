using MySql.Data.MySqlClient;
using Projeto2023.Classes;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Projeto2023
{
    public partial class Form_AdicionaCarro : Form
    {
        Conexao conecta = new Conexao();

        string Blindado;
        string Imagem;
        string UnicoDono = "Não";

        public Form_AdicionaCarro()
        {
            InitializeComponent();

            Dtp_AnoCarro.Format = DateTimePickerFormat.Custom;
            Dtp_AnoCarro.CustomFormat = "yyyy";
            Dtp_AnoCarro.ShowUpDown = true;



            Pb_ImagemCarro.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Btn_AbrirImagem_Click(object sender, EventArgs e)
        {
            SeletorImagem.Title = "Selecione uma imagem para o Carro";
            SeletorImagem.Filter = "All files (*.*)|*.*";
            SeletorImagem.CheckFileExists = true;
            SeletorImagem.CheckPathExists = true;
            SeletorImagem.ShowDialog();
            Imagem = SeletorImagem.FileName;
            Pb_ImagemCarro.ImageLocation = Imagem;
        }

        private void Btn_RegistrarCarro_Click(object sender, EventArgs e)
        {
            if(Cb_Marca.SelectedIndex == -1 || (!Rdb_sim.Checked && !Rdb_Nao.Checked) || string.IsNullOrEmpty(Txt_Modelo.Text) || string.IsNullOrEmpty(Txt_Preco.Text) || string.IsNullOrEmpty(Txt_Km.Text) || Lb_Combustivel.SelectedIndex == -1 || Pb_ImagemCarro.Image == null)
            {
                MessageBox.Show("É necessario preencher todas as informações");
                return;
            }

            SalvarCarro();
            DialogResult result = MessageBox.Show("Carro cadastrado com sucesso.", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();

            }
        }

        private void Rdb_sim_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_sim.Checked) 
            {
                Blindado = "Sim";
            }
        }

        private void Rdb_Nao_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Nao.Checked)
            {
                Blindado = "Não";
            }
        }

        private void CB_UnicoDono_CheckedChanged(object sender, EventArgs e)
        {
            if (!CB_UnicoDono.Checked)
            {
                UnicoDono = "Não";
            }
            if (CB_UnicoDono.Checked)
            {
                UnicoDono = "Sim";
            }
        }



        private void SalvarCarro()
        {
            string preco = Txt_Preco.Text;

            string precoFormatado = FormataPreco(preco);

            decimal.TryParse(precoFormatado, out decimal valorDecimal);

            byte[] imagemDados = PreparaImagem(Pb_ImagemCarro.Image, 300, 200);

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conecta.strConexao))
                {
                    conexao.Open();

                    string query = "INSERT INTO carro (marca, modelo, blindado, unico_dono, km, combustivel, ano, preco, disponivel, imagem)" +
                                   " VALUES (@marca, @modelo, @blindado, @unico_dono, @km, @combustivel, @ano, @preco, @disponivel, @imagem)";

                    using (MySqlCommand inserir = new MySqlCommand(query, conexao))
                    {
                        inserir.Parameters.AddWithValue("@marca", Cb_Marca.SelectedItem.ToString());
                        inserir.Parameters.AddWithValue("@modelo", Txt_Modelo.Text);
                        inserir.Parameters.AddWithValue("@blindado", Blindado);
                        inserir.Parameters.AddWithValue("@unico_dono", UnicoDono);
                        inserir.Parameters.AddWithValue("@km", Txt_Km.Text);
                        inserir.Parameters.AddWithValue("@combustivel", Lb_Combustivel.SelectedItem.ToString());
                        inserir.Parameters.AddWithValue("@ano", Dtp_AnoCarro.Value.Year);
                        inserir.Parameters.AddWithValue("@preco", valorDecimal);
                        inserir.Parameters.AddWithValue("@disponivel", "S");
                        inserir.Parameters.AddWithValue("@imagem", imagemDados);

                        inserir.ExecuteNonQuery();

                    }
                    conexao.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao salvar no banco de dados: " + ex.Message);
            }
        }

        private byte[] PreparaImagem(Image imagemOriginal, int largura, int altura)
        {
            using (Bitmap imagemRedimensionada = new Bitmap(largura, altura))
            {
                using (Graphics g = Graphics.FromImage(imagemRedimensionada))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(imagemOriginal, 0, 0, largura, altura);
                }

                using (MemoryStream ms = new MemoryStream())
                {
                    imagemRedimensionada.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
        }

        private string FormataPreco(string valor)
        {
            return valor.Replace("R$", "").Trim();
        }


    }
}
