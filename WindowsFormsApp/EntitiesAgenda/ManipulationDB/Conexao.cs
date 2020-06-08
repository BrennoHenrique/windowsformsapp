using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp.EntitiesAgenda.ManipulationDB
{
    class Conexao
    {
        //Tabela do banco de dados
        public const string Tabela = "tblAgenda";

        //Colunas da tabela
        public const string Nome = "Nome_Agenda";
        public const string Endereco = "Endereco_Agenda";
        public const string Telefone = "Telefone_Agenda";
        public const string Email = "Email_Agenda";

        private SqlConnection conexao = new SqlConnection();

        public Conexao()
        {
            this.conexao.ConnectionString = "Data Source = NOTEBOOK-BRENNO; Initial Catalog" +
                                            " = DBAgenda; Integrated Security = True";
        }

        public SqlConnection Conectar()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                this.conexao.Open();
            }

            return this.conexao;
        }

        public void Desconectar()
        {
            if (conexao.State == ConnectionState.Open)
            {
                this.conexao.Close();
            }
        }
    }
}
