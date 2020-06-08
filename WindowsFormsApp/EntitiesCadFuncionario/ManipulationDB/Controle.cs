using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.EntitiesCadFuncionario;

namespace WindowsFormsApp.EntitiesCadFuncionario.ManipulationDB
{
    class Controle
    {
        Conexao conexao = new Conexao();
        SqlCommand command = new SqlCommand();

        public List<Funcionario> SelectAllFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            command.CommandText = "SELECT * FROM tblFuncionario";

            command.Connection = conexao.Conectar();
            SqlDataReader rows = command.ExecuteReader();

            while (rows.Read())
            {
                Funcionario funcionario;

                var nome = rows[1].ToString();
                var cpf = rows[2].ToString();
                var cargo = rows[3].ToString();
                var salarioBruto = rows[4].ToString();
                var desconto = rows[5].ToString();
                var adicional = rows[6].ToString();

                if (cargo == "Funcionario")
                {
                    funcionario = new Funcionario(nome, cpf, cargo, float.Parse(salarioBruto),
                                                  float.Parse(desconto), float.Parse(adicional));
                }
                else
                {
                    funcionario = new Gerente(nome, cpf, cargo, float.Parse(salarioBruto),
                                                  float.Parse(desconto), float.Parse(adicional));
                }

                funcionario.CalcularLiquido(float.Parse(salarioBruto), float.Parse(desconto),
                                            float.Parse(adicional));
                funcionario.CalculaBonus();

                funcionarios.Add(funcionario);
            }

            return funcionarios;
        }

        public void DeleteFuncionario(string cpf)
        {
            command.CommandText = "DELETE FROM tblFuncionario WHERE CPF=@cpf";
            command.Parameters.AddWithValue("@cpf", cpf);

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();
            }
            catch
            {
                conexao.Desconectar();
            }
        }
    }
}
