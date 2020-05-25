using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Exceptions;

namespace WindowsFormsApp.EntitiesAgenda
{
    class Pessoa
    {
        public string Nome { get; protected internal set; }
        public string Endereco { get; protected internal set; }
        public string Telefone { get; protected internal set; }
        public string Email { get; protected internal set; }

        public Pessoa(string nome, string endereco, string telefone, string email)
        {
            if (nome.Length < 3)
                throw new DomainException("Nome inválido!");
            if (endereco.Length < 3)
                throw new DomainException("Endereço inválido");
            if (telefone.Length < 3)
                throw new DomainException("Telefone inválido"); 
            if (email.Length < 3)
                throw new DomainException("E-mail inválido");
           
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }

        public Pessoa() { }
    }
}
