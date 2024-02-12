using Microsoft.Data.Sqlite;
using System;
using System.IO;
using System.Windows.Forms;

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
            // Código que você deseja executar quando o rótulo é clicado
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

            // Crie a tabela se ela ainda não existir
            using (var cmd = new SqliteCommand
                ("CREATE TABLE IF NOT EXISTS RegistroInvestimento " +
                "(ID INTEGER PRIMARY KEY, dataCompra DATETIME," +
                " nomeAcaoFundo TEXT, valor DECIMAL, quantidadeCota INTEGER," +
                " valorTotal DECIMAL)", connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            var tratamentoDataCompra = dataCompraDateTimePicker.Value.ToString("dd-MM-yyyy HH:mm");
            // Converta os valores dos campos de texto para os tipos de dados adequados
            DateTime dataCompra = Convert.ToDateTime(tratamentoDataCompra);
            string nomeAcaoFundo = nomeAcaoFundoTextBox.Text;
            decimal valor = Convert.ToDecimal(valorAcaoFundoTextBox.Text);
            int quantidadeCota = Convert.ToInt32(quantidadeCotaTextBox.Text);
            decimal valorTotal = valor * quantidadeCota;

            // Query para inserir os dados no banco de dados
            string insertQuery = "INSERT INTO RegistroInvestimento" +
                "(dataCompra, nomeAcaoFundo, valor, quantidadeCota, valorTotal) " +
                "VALUES " +
                "(@dataCompra, @nomeAcaoFundo, @valor, @quantidadeCota, @valorTotal)";

            using (var cmd = new SqliteCommand(insertQuery, connection))
            {
                cmd.Parameters.AddWithValue("@dataCompra", dataCompra);
                cmd.Parameters.AddWithValue("@nomeAcaoFundo", nomeAcaoFundo.ToUpper().Trim());
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@quantidadeCota", quantidadeCota);
                cmd.Parameters.AddWithValue("@valorTotal", valorTotal);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Dados salvos com sucesso!");
        }
    }
}
