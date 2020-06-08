using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.EntitiesCadFuncionario.ManipulationDB
{
    class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand command = new SqlCommand();

        public Cadastro(string nome, string cpf, string cargo, float salarioBruto, float desconto, float adicional)
        {
            command.CommandText = "INSERT INTO tblFuncionario VALUES (@nome, @cpf, @cargo, @salarioBruto, @desconto, @adicional)";

            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@cpf", cpf);
            command.Parameters.AddWithValue("@cargo", cargo);
            command.Parameters.AddWithValue("@salarioBruto", salarioBruto);
            command.Parameters.AddWithValue("@desconto", desconto);
            command.Parameters.AddWithValue("@adicional", adicional);

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
                conexao.Desconectar();
            }
            catch
            {
                conexao.Desconectar();
            }
        }
    }
}
