using MySql.Data.MySqlClient;
using Projeto2023.Classes;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Projeto2023
{
    public partial class Form_EditarCarro : Form
    {
        Conexao conecta = new Conexao();
        private MySqlConnection conexao;
        private MySqlCommand cmd;
        private MySqlDataAdapter adaptador;
        private DataTable dataTable;
        string carroSelecionado;
        string img;
        string UnicoDono = "Não";
        string Blindado;
        public Form_EditarCarro()
        {
            InitializeComponent();

            Dtp_AnoCarro.Format = DateTimePickerFormat.Custom;
            Dtp_AnoCarro.CustomFormat = "yyyy";
            Dtp_AnoCarro.ShowUpDown = true;
            
            conexao = new MySqlConnection(conecta.strConexao);

            adaptador = new MySqlDataAdapter();
            dataTable = new DataTable();

            string query = "SELECT * FROM carro WHERE disponivel = @valorFiltrado";
            cmd = new MySqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@valorFiltrado", "S");
            adaptador.SelectCommand = cmd;
        }

        private void Form_EditarCarro_Load(object sender, EventArgs e)
        {
            CarregarDados(dataTable);
            Dgv_Carros.DataSource = dataTable;
            Dgv_Carros.Columns["id"].Visible = false;

            Dgv_Carros.CellClick += Dgv_Carros_CellClick;
            conexao.Close();
        }

        private void Btn_AbrirImagem_Click(object sender, EventArgs e)
        {
            SeletorImagem.Title = "Selecione uma imagem para o Carro";
            SeletorImagem.Filter = "All files (*.*)|*.*";
            SeletorImagem.CheckFileExists = true;
            SeletorImagem.CheckPathExists = true;
            SeletorImagem.ShowDialog();
            img = SeletorImagem.FileName;
            Pb_ImagemCarro.ImageLocation = img;
        }

        private void Btn_RegistrarCarro_Click(object sender, EventArgs e)
        {
            if (Cb_Marca.SelectedIndex == -1 || (!Rdb_sim.Checked && !Rdb_Nao.Checked) || string.IsNullOrEmpty(Txt_Modelo.Text) || string.IsNullOrEmpty(Txt_Preco.Text) || string.IsNullOrEmpty(Txt_Km.Text) || Lb_Combustivel.SelectedIndex == -1 || Pb_ImagemCarro.Image == null)
            {
                MessageBox.Show("É necessario preencher todas as informações");
                return;
            }
            if (string.IsNullOrEmpty(carroSelecionado))
            {
                MessageBox.Show("É preciso escolher um carro para atualizar");
                return;
            }

            SalvarCarro();

            DialogResult result = MessageBox.Show("O carro foi atualizado com sucesso.", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();

            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_Carros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {

                if (e.RowIndex >= 0 && e.RowIndex < Dgv_Carros.Rows.Count)
                {
                    DataGridViewRow row = Dgv_Carros.Rows[e.RowIndex];
   

                    carroSelecionado = row.Cells["id"].Value.ToString();
                    Cb_Marca.Text = row.Cells["marca"].Value.ToString();
                    Txt_Modelo.Text = row.Cells["modelo"].Value.ToString();
                    Txt_Km.Text = row.Cells["km"].Value.ToString();
                    Txt_Preco.Text = row.Cells["preco"].Value.ToString();
                    SelecionaItemListBox(row.Cells["combustivel"].Value.ToString());

                    if(row.Cells["blindado"].Value.ToString() == "Sim")
                    {
                        Rdb_sim.Checked = true;
                    }
                    else
                    {
                        Rdb_Nao.Checked = true;
                    }

                    if (row.Cells["unico_dono"].Value.ToString() == "Sim")
                    {
                        CB_UnicoDono.Checked = true;
                    }

                    if (int.TryParse(row.Cells["ano"].Value.ToString(), out int ano))
                    {
                        Dtp_AnoCarro.Value = new DateTime(ano, 1, 1);
                    }

                    if (row.Cells["imagem"].Value != null && row.Cells["imagem"].Value is byte[] imageData)
                    {
                        Image image = ConverteImagem(imageData);

                        Pb_ImagemCarro.Image = image;
                    }
                }
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





        //Metodos
        private void SelecionaItemListBox(string valor)
        {
            for (int i = 0; i < Lb_Combustivel.Items.Count; i++)
            {
                if (Lb_Combustivel.Items[i].ToString() == valor)
                {
                    Lb_Combustivel.SelectedIndex = i;
                    return;
                }
            }
            Lb_Combustivel.SelectedIndex = -1;
        }


        private void CarregarDados(DataTable tabela)
        {
            try
            {
                conexao.Open();
                adaptador.Fill(tabela);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally
            {
                if (conexao.State == ConnectionState.Open)
                    conexao.Close();
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

                    string query = "UPDATE carro SET marca = @marca, modelo = @modelo, blindado = @blindado, unico_dono = @unico_dono, km = @km, combustivel = @combustivel, ano = @ano, preco = @preco, imagem = @imagem WHERE id = @id";

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
                        inserir.Parameters.AddWithValue("@imagem", imagemDados);
                        inserir.Parameters.AddWithValue("@id", carroSelecionado);

                        inserir.ExecuteNonQuery();

                    }
                    conexao.Close();
                }
            }
            catch (Exception ex)
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

        private Image ConverteImagem(byte[] array)
        {
            using (MemoryStream ms = new MemoryStream(array))
            {
                Image imagem = Image.FromStream(ms);
                return imagem;
            }
        }
    }
}
