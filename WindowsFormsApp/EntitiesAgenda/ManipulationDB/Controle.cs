using System;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace WindowsFormsApp.EntitiesAgenda.ManipulationDB
{
    class Controle
    {
        Conexao conexao = new Conexao();
        SqlCommand command = new SqlCommand();
        private String menssagem;

        public String Menssagem
        {
            get { return menssagem; }
            set { menssagem = value; }
        }
        
        //Função utilizada para retornar as pessoas contidas no banco de dados
        public List<Pessoa> LoadForms()
        {
            List<Pessoa> Pessoas = new List<Pessoa>();
            Pessoa pessoa;

            command.CommandText = $"SELECT * FROM {Conexao.Tabela}";

            command.Connection = conexao.Conectar();
            SqlDataReader rows = command.ExecuteReader();

            while (rows.Read())
            {
                var nome = rows[1].ToString();
                var endereco = rows[2].ToString();
                var telefone = rows[3].ToString();
                var email = rows[4].ToString();

                pessoa = new Pessoa(nome, endereco, telefone, email);
                Pessoas.Add(pessoa);
            }

            conexao.Desconectar();
            command.Connection.Close();

            return Pessoas;
        }

        public void InsertInAgenda(string nome, string endereco, string telefone, string email)
        {
            command.CommandText = $"INSERT INTO {Conexao.Tabela} VALUES (@nome, @endereco," +
                                  "@telefone, @email)";

            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@endereco", endereco);
            command.Parameters.AddWithValue("@telefone", telefone);
            command.Parameters.AddWithValue("@email", email);

            Execute(command);
        }

        public void UpdateInAgenda(string nome, string endereco, string telefone, string email, Pessoa pessoa)
        {
            command.CommandText = $"UPDATE {Conexao.Tabela} SET {Conexao.Nome}=@nome, {Conexao.Endereco}=@endereco, " +
                                  $"{Conexao.Telefone}=@telefone, {Conexao.Email}=@email " +
                                  $"WHERE {Conexao.Nome}=@nomeParam AND {Conexao.Endereco}=@enderecoParam " +
                                  $"AND {Conexao.Telefone}=@telefoneParam AND {Conexao.Email}=@emailParam";

            command.Parameters.AddWithValue("@nomeParam", nome);
            command.Parameters.AddWithValue("@enderecoParam", endereco);
            command.Parameters.AddWithValue("@telefoneParam", telefone);
            command.Parameters.AddWithValue("@emailParam", email);

            command.Parameters.AddWithValue("@nome", pessoa.Nome);
            command.Parameters.AddWithValue("@endereco", pessoa.Endereco);
            command.Parameters.AddWithValue("@telefone", pessoa.Telefone);
            command.Parameters.AddWithValue("@email", pessoa.Email);

            Execute(command);
        }

        public void DeleteInAgenda(string nome, string endereco, string telefone, string email)
        {
            command.CommandText = $"DELETE FROM {Conexao.Tabela} WHERE {Conexao.Nome}=@nome AND {Conexao.Endereco}=@endereco " +
                                  $"AND {Conexao.Telefone}=@telefone AND {Conexao.Email}=@email";

            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@endereco", endereco);
            command.Parameters.AddWithValue("@telefone", telefone);
            command.Parameters.AddWithValue("@email", email);

            Execute(command);
        }

        private void Execute(SqlCommand command)
        {
            menssagem = "";

            try
            {
                command.Connection = conexao.Conectar();
                command.ExecuteNonQuery();

                command.Connection.Close();
                conexao.Desconectar();
            }
            catch
            {
                menssagem = "Não foi possível realizar o procedimento no banco de dados!";
                command.Connection.Close();
                conexao.Desconectar();
            }
        }
    }
}
