using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp.EntitiesCadFuncionario.ManipulationDB
{
    class Conexao
    {
        private SqlConnection conexao = new SqlConnection();

        public Conexao()
        {
            this.conexao.ConnectionString = "Data Source = NOTEBOOK-BRENNO; Initial Catalog" +
                                            " = DBFuncionario; Integrated Security = True";
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
