using MySql.Data.MySqlClient;
using Projeto2023.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Projeto2023
{
    public partial class Form_Vendas : Form
    {
        public Form_Vendas()
        {
            InitializeComponent();
        }
        private void Form_Vendas_Load(object sender, EventArgs e)
        {
            Conexao conecta = new Conexao();
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(conecta.strConexao))
                {
                    conexao.Open();

                    string query = "SELECT V.*, C.* From venda V INNER JOIN carro C on V.id_carro = C.id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Lbl_venda0.Visible = true;
                            }
                            else
                            {
                                while (reader.Read())
                                {
                                    Lbl_venda0.Visible = false;
                                    string NomeCliente = reader["nome_cliente"].ToString();
                                    string Telefone = reader["telefone"].ToString();
                                    string Cpf = reader["cpf"].ToString();
                                    string CEP = reader["cep"].ToString();
                                    string NumeroCasa = reader["numero"].ToString();
                                    string NomeVendedor = reader["nome_vendedor"].ToString();

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

                                    VendaRealizadaCard c = new VendaRealizadaCard();                                 
                                    c.Modelo = modelo;
                                    c.Marca = marca;
                                    c.Combustivel = combustivel;
                                    c.Preco = "R$ " + preco;
                                    c.Km = km + " KM";
                                    c.Ano = ano;
                                    c.ImagemCarro = imagem;

                                    c.NomeCliente = NomeCliente;
                                    c.Vendedor = NomeVendedor;
                                    c.Cpf = Cpf;
                                    c.CEP = CEP;
                                    c.NumeroResidencial = NumeroCasa;
                                    c.Telefone = Telefone;

                                    Fpnl_VendasRealizadas.Controls.Add(c);
                                }
                                conexao.Close();
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao puxar dados do banco de dados: " + ex.Message);
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


    }
}
