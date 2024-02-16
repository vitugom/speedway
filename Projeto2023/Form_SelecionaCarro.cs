using MySql.Data.MySqlClient;
using Projeto2023.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto2023
{
    public partial class Form_SelecionaCarro : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand cmd;
        private MySqlDataAdapter adaptador;
        private DataTable dataTable;
        public string carroSelecionado { get; set; }

        public Form_SelecionaCarro()
        {
            InitializeComponent();

            Conexao conecta = new Conexao();
            conexao = new MySqlConnection(conecta.strConexao);

            adaptador = new MySqlDataAdapter();
            dataTable = new DataTable();

            string query = "SELECT * FROM carro WHERE disponivel = @valorFiltrado";
            cmd = new MySqlCommand(query, conexao);
            cmd.Parameters.AddWithValue("@valorFiltrado", "S");
            adaptador.SelectCommand = cmd;
        }

        private void Form_SelecionaCarro_Load(object sender, EventArgs e)
        {
            CarregarDados(dataTable);
            Dgv_Carros.DataSource = dataTable;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close();
        }

        private void Dgv_Carros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object valorCelula = Dgv_Carros.Rows[e.RowIndex].Cells["id"].Value;

                if (valorCelula != null)
                {
                    carroSelecionado = valorCelula.ToString();

                }
                else
                {
                    MessageBox.Show("Nenhum carro selecionado");
                }
            }
        }

        private void Btn_Continuar_Click(object sender, EventArgs e)
        {
            if (carroSelecionado == "" || carroSelecionado == null)
            {
                MessageBox.Show("É necessário escolher um veículo para prosseguir");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
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


    }
}
