using Microsoft.Data.Sqlite;

namespace InvestmentSistem
{
    public partial class Form1 : Form
    {
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
            SqliteConnection connection;
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
    }
}