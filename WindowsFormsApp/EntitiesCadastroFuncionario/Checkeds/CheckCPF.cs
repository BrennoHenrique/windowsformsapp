using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Exceptions;
using WindowsFormsApp.Entities.ManipulationFiles;

namespace WindowsFormsApp.Entities.Checkeds
{
    class CheckCPF
    {
        public static void Check(List<Funcionario> funcionarios, string cpf)
        {
            if (cpf.Length != 14)
                throw new DomainException("CPF informado de forma incorreta!");

            foreach (char item in cpf)
                if (item == ' ')
                    throw new DomainException("CPF informado de forma incorreta!");

            for (int contador = 0; contador < funcionarios.Count; contador++)
                if (cpf == funcionarios[contador].cpf)
                    throw new DomainException("CPF informado já existe!");
        }
    }
}
