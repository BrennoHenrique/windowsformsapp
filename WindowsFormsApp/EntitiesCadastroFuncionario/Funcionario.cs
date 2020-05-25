using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Exceptions;

namespace WindowsFormsApp.Entities
{
    public class Funcionario
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public string Cargo { get; set; }
        public float salarioBruto { get; set; }
        public float desconto { get; set; }
        public float adicional { get; set; }
        public float salarioLiquido { get; set; }

        //TrÊs Sobrecargas do Construtor "Funcionario"

        // Construtor com 3 parametros
        public Funcionario(string nomeParam, string CPF, string cargo, float salarioBrutoParam)
        {
            if (nomeParam == string.Empty)
                throw new DomainException("Nome inválido!");
            if (cargo != "Gerente" && cargo != "Funcionario")
                throw new DomainException("Cargo informado inválido!");
            if (salarioBrutoParam <= 0)
                throw new DomainException("Salário inválido!");

            this.nome = nomeParam;
            this.Cargo = cargo;
            this.salarioBruto = salarioBrutoParam;
            this.cpf = CPF;
        }

        // Construtor vazio
        public Funcionario()
        {

        }

        // Construtor com cinco parametros
        public Funcionario(string nomeParam, string CPF, string cargo,
                          float salarioBrutoParam, float descontoParam, float adicionalParam) : this
                          (nomeParam, CPF, cargo, salarioBrutoParam)
        {
            this.adicional = adicionalParam;
            this.desconto = descontoParam;
        }


        // Sobrecarga do Metodo CalcularLiquido 
        // Sobrecarga= diferencia-se pela assinatura (parametros)
        // Executa ou um ou outro metodo. Vai depender dos parametros.
        public void CalcularLiquido(float salario, float desconto, float adicional)
        {
            this.salarioLiquido = ((salario - desconto) + adicional);
        }

        public void CalcularLiquido(float salario, float adicional)
        {
            this.salarioLiquido = (salario + adicional);
        }

        public virtual void CalculaBonus() => this.salarioLiquido += this.salarioLiquido * 0.01f;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Nome:" + this.nome);
            stringBuilder.AppendLine("CPF" + this.cpf);
            stringBuilder.AppendLine("Cargo: " + this.Cargo);
            stringBuilder.AppendLine($"Salário bruto: {this.salarioBruto}");
            stringBuilder.AppendLine($"Desconto: {this.desconto}");
            stringBuilder.AppendLine($"Adicional: {this.adicional}");
            stringBuilder.AppendLine($"Salário líquido: {this.salarioLiquido}");

            return stringBuilder.ToString();
        }
    }
}
