using MySql.Data.MySqlClient;
using Projeto2023.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Projeto2023
{
    public partial class Form_CarrosDisponiveis : Form
    {
        Conexao conecta = new Conexao();

        public Form_CarrosDisponiveis()
        {
            InitializeComponent();
        }

        private void Form_CarrosDisponiveis_Load(object sender, EventArgs e)
        {
        try
        {        
        using (MySqlConnection conexao = new MySqlConnection(conecta.strConexao))
        {     
        conexao.Open();
           
        string query = "SELECT * FROM carro WHERE disponivel = @valorFiltrado";

        using (MySqlCommand cmd = new MySqlCommand(query, conexao))
        {

        cmd.Parameters.AddWithValue("@valorFiltrado", "S");

        using (MySqlDataReader reader  = cmd.ExecuteReader())
        {
        if (!reader.HasRows)
        {
            Lbl_Carros0.Visible = true;
        }
        else
        {
            while (reader.Read())
        {
        Lbl_Carros0.Visible = false;
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

                                    CarroCard c = new CarroCard();
                                    if (blindado == "Sim")
                                    {
                                        c.IconBlindado = true;

                                    }
                                    else
                                    {
                                        c.IconBlindado = false;
                                    }
                                    if (unicoDono == "Sim")
                                    {
                                        c.IconUnicoDono = true;
                                    }
                                    else
                                    {
                                        c.IconUnicoDono = false;
                                    }
                                    c.Modelo = modelo;
                                    c.Marca = marca;
                                    c.Combustivel = combustivel;
                                    c.Preco = "R$ " + preco;
                                    c.Km = km + " KM";
                                    c.Ano = ano;
                                    c.ImagemCarro = imagem;
                                    Flp_ContainerCarro.Controls.Add(c);
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

        private void excluirCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ExcluirCarro excluirCarro = new Form_ExcluirCarro();
            excluirCarro.ShowDialog();
        }

        private void editarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_EditarCarro editarCarro = new Form_EditarCarro();
            editarCarro.ShowDialog();
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
