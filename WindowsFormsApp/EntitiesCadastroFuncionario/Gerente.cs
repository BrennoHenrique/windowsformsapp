using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Entities
{
    class Gerente : Funcionario
    {
        public Gerente() : base() { }
        public Gerente(string nome, string CPF, string cargo, float salarioBrutoParam) 
                      : base(nome, CPF, cargo, salarioBrutoParam) { }
        public Gerente(string nomeParam, string CPF, string cargo,
                       float salarioBrutoParam, float descontoParam, float adicionalParam) 
                      : base(nomeParam, CPF, cargo, salarioBrutoParam, descontoParam, adicionalParam) { }

        public override void CalculaBonus()
        {
            this.salarioLiquido += this.salarioLiquido * 0.02f;
        }

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
