using MySql.Data.MySqlClient;
using Projeto2023.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Projeto2023
{
    public partial class Form_ExcluirCarro : Form
    {
        private MySqlConnection conexao;
        private MySqlCommand cmd;
        private MySqlDataAdapter adaptador;
        private DataTable dataTable;
        string carroSelecionado;
        public Form_ExcluirCarro()
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

        private void Form_ExcluirCarro_Load(object sender, EventArgs e)
        {
            CarregarDados(dataTable);
            Dgv_Carros.DataSource = dataTable;
            conexao.Close();
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

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("O item sera excluido permanentemente.", "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                conexao.Open();
                string queryExcluir = "DELETE FROM carro Where id = @id";
                MySqlCommand excluir = new MySqlCommand(queryExcluir, conexao);
                excluir.Parameters.AddWithValue("@id", carroSelecionado);
                excluir.ExecuteNonQuery();
                this.Close();

            }
            else
            {
                return;
            }

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
