using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Projeto2023.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace Projeto2023
{
    public partial class Form_RealizaVenda : Form
    {
        Conexao conecta = new Conexao();

        Form_SelecionaCarro s = new Form_SelecionaCarro();

        public Form_RealizaVenda()
        {
            InitializeComponent();

            s.ShowDialog();
            if (s.DialogResult == DialogResult.Cancel) 
            {
                MessageBox.Show("Operação cancelada");
            }
            else 
            {
                try
                {
                    using (MySqlConnection conexao = new MySqlConnection(conecta.strConexao))
                    {
                        conexao.Open();


                        string query = "SELECT * FROM carro WHERE id = @valorFiltrado";

                        using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                        {

                            cmd.Parameters.AddWithValue("@valorFiltrado", s.carroSelecionado);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string modelo = reader["modelo"].ToString();
                                    string marca = reader["marca"].ToString();
                                    string combustivel = reader["combustivel"].ToString();
                                    string preco = reader["preco"].ToString();
                                    string km = reader["km"].ToString();
                                    string ano = reader["ano"].ToString();
                                    byte[] imagemBanco = (byte[])reader["imagem"];
                                    string blindado = reader["blindado"].ToString();
                                    string unicoDono = reader["unico_dono"].ToString();


                                    Image imagem = ConverteImagem(imagemBanco);

                                    CarroVendaCard c = new CarroVendaCard();
                                    c.Modelo = modelo;
                                    c.Marca = marca;
                                    c.Preco = "R$ " + preco;
                                    c.Km = km + " KM";
                                    c.Ano = ano;
                                    c.ImagemCarro = imagem;
                                    Pnl_CarroSelecionado.Controls.Add(c);
                                }
                                conexao.Close();
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao puxar dados do banco de dados: " + ex.Message);
                }
            }
        }

        private void Btn_RealizarVenda_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_NomeCliente.Text) || string.IsNullOrEmpty(Txt_telefone.Text) || string.IsNullOrEmpty(Txt_Cpf.Text) || string.IsNullOrEmpty(Txt_Profissao.Text) || string.IsNullOrEmpty(Txt_Cep.Text) || string.IsNullOrEmpty(Txt_Logradouro.Text) || string.IsNullOrEmpty(Txt_Bairro.Text) || string.IsNullOrEmpty(Txt_Cidade.Text) || string.IsNullOrEmpty(Txt_Numero.Text) || string.IsNullOrEmpty(Txt_Estado.Text) || string.IsNullOrEmpty(Txt_NomeVendedor.Text))
            {
                MessageBox.Show("É necessário preencher todos os campos");
            }
            else
            {
                RealizaVenda();
                DialogResult result = MessageBox.Show("Venda realizada com sucesso.", "Operação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();

                }
            }
        }

        private void Btn_PesquisaCep_Click(object sender, EventArgs e)
        {
            string Cep;
            Cep = Txt_Cep.Text;
            string urlApi = "https://viacep.com.br/ws/" + Cep + "/json/";

            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(urlApi).Result;
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    BuscaCep buscaCep = JsonConvert.DeserializeObject<BuscaCep>(result);

                    if (buscaCep.erro == "true")
                    {
                        MessageBox.Show("CEP Invalido");
                        Txt_Logradouro.Text = "";
                        Txt_Bairro.Text = "";
                        Txt_Cidade.Text = "";
                        Txt_Estado.Text = "";

                    }
                    else
                    {
                        Txt_Logradouro.Text = buscaCep.logradouro;
                        Txt_Bairro.Text = buscaCep.bairro;
                        Txt_Cidade.Text = buscaCep.cidade;
                        Txt_Estado.Text = buscaCep.estado;
                    }

                }
                else
                {
                    MessageBox.Show("Erro ao conectar com API");
                }
            }

        }

        private void RealizaVenda()
        {
            try
            {
                string cpf = formataCPF(Txt_Cpf.Text);
                string cep = formataCEP(Txt_Cep.Text);
                string telefone = formataTelefone(Txt_telefone.Text);

                using (MySqlConnection conexao = new MySqlConnection(conecta.strConexao))
                {
                    conexao.Open();

                    string InsereDados = "INSERT INTO venda (id_carro, nome_cliente, telefone, cpf, profissao, cep, logradouro, bairro, cidade, numero, estado, nome_vendedor)" +
                                   " VALUES (@id_carro, @nome_cliente, @telefone, @cpf, @profissao, @cep, @logradouro, @bairro, @cidade, @numero, @estado, @nome_vendedor)";

                    using (MySqlCommand inserir = new MySqlCommand(InsereDados, conexao))
                    {
                        inserir.Parameters.AddWithValue("@id_carro", s.carroSelecionado);
                        inserir.Parameters.AddWithValue("@nome_cliente", Txt_NomeCliente.Text);
                        inserir.Parameters.AddWithValue("@telefone", telefone);
                        inserir.Parameters.AddWithValue("@cpf", cpf);
                        inserir.Parameters.AddWithValue("@profissao", Txt_Profissao.Text);
                        inserir.Parameters.AddWithValue("@cep", cep);
                        inserir.Parameters.AddWithValue("@logradouro", Txt_Logradouro.Text);
                        inserir.Parameters.AddWithValue("@bairro", Txt_Bairro.Text);
                        inserir.Parameters.AddWithValue("@cidade", Txt_Cidade.Text);
                        inserir.Parameters.AddWithValue("@numero", Txt_Numero.Text);
                        inserir.Parameters.AddWithValue("@estado", Txt_Estado.Text);
                        inserir.Parameters.AddWithValue("@nome_vendedor", Txt_NomeVendedor.Text);

                        inserir.ExecuteNonQuery();

                    }

                    string updateCarro = "UPDATE carro SET disponivel = @disponivel WHERE id = @ID";

                    using (MySqlCommand update = new MySqlCommand(updateCarro, conexao))
                    {
                        update.Parameters.AddWithValue("@disponivel", "N");
                        update.Parameters.AddWithValue("@ID", s.carroSelecionado);

                        update.ExecuteNonQuery();
                    }

                        conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar no banco de dados: " + ex.Message);
            }
        }

        private Image ConverteImagem(byte[] array)
        {
            using (MemoryStream ms = new MemoryStream(array))
            {
                Image imagem = Image.FromStream(ms);
                return imagem;
            }
        }

       private string formataCEP(string CEP)
        {
            return CEP.Replace("-","").Trim();
        }

        private string formataTelefone(string Telefone)
        {
            char[] caracteresParaRemover = { '(', ')', '-' };
            foreach (char  c in caracteresParaRemover)
            {
                Telefone = Telefone.Replace(c.ToString(),"").Trim();
            }
            return Telefone;
        }

        private string formataCPF(string cpf)
        {
            char[] caracteresParaRemover = { '.', '-' };
            foreach (char c in caracteresParaRemover)
            {
                cpf = cpf.Replace(c.ToString(), "").Trim();
            }
            return cpf;
        }
    }
}
