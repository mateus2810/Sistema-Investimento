using Microsoft.Data.Sqlite;

namespace InvestmentSistem
{
    public partial class Form1 : Form
    {
        private SqliteConnection connection;
        public Form1()
        {
            InitializeComponent();
            InicializarBD();
        }

        private void tipoLabel_Click(object sender, EventArgs e)
        {

        }

        public void InicializarBD()
        {
            
            // Obtenha o diretório base do aplicativo (onde o executável está localizado)
            string diretorioBase = AppDomain.CurrentDomain.BaseDirectory;

            // Adicione as pastas ao caminho do banco de dados
            string nomeDoArquivo = "BancoDadosInvestimento.db";
            string caminhoDoBancoDeDados = Path.Combine(diretorioBase, nomeDoArquivo);

            string connectionString = $"Data Source={caminhoDoBancoDeDados}";

            connection = new SqliteConnection(connectionString);

            connection.Open();

            // Crie a tabela se ela ainda não existir'
            using (var cmd = new SqliteCommand
                ("CREATE TABLE IF NOT EXISTS RegistroInvestimento " +
                "(ID INTEGER PRIMARY KEY, dataCompra DATETIME," +
                " nomeAcaoFundo TEXT, valor DECIMAL, quantidadeCota INTEGER," +
                "valorTotal DECIMAL)", connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            decimal valorTotal = Convert.ToInt32(quantidadeCotaTextBox) * Convert.ToInt32(valorAcaoFundoTextBox);

            string insertQuery = "INSERT INTO RegistroInvestimento" +
                "(dataCompra, nomeAcaoFundo, valor, quantidadeCota, valorTotal) " +
                "VALUES " +
                "(@dataCompra, @nomeAcaoFundo, @valor, @quantidadeCota, @valorTotal)";

            using (var cmd = new SqliteCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@dataCompra", dataCompraLabel);
                cmd.Parameters.AddWithValue("@nomeAcaoFundo", nomeAcaoFundoLabel);
                cmd.Parameters.AddWithValue("@valor", valorAcaoFundoTextBox);
                cmd.Parameters.AddWithValue("@quantidadeCota", quantidadeCotaTextBox);
                cmd.Parameters.AddWithValue("@valorTotal", valorTotal);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Dados salvos com sucesso!");
        }
    }
}