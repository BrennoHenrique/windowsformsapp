using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.Exceptions;

namespace WindowsFormsApp.EntitiesAgenda
{
    class AgendaEntitie
    {
        private bool ListOrder { get; set; } = false;
        private List<Pessoa> Pessoas { get; set; } = new List<Pessoa>();

        public void AddPessoa(string nome, string endereco, string telefone, string email)
        {
            Pessoa pessoa = new Pessoa(nome, endereco, telefone, email);
            this.Pessoas.Add(pessoa);
        }

        public void EditarPessoa(Pessoa pessoa, int index)
        {
            if (index != -1)
            {
                this.Pessoas[index].Nome = pessoa.Nome;
                this.Pessoas[index].Endereco = pessoa.Endereco;
                this.Pessoas[index].Telefone = pessoa.Telefone;
                this.Pessoas[index].Email = pessoa.Email;
            }
            else
                throw new DomainException("Erro desconhecido [AgendaEntitie.EditarPessoa(index: int = -1)]");
        }

        public void OrdenaListaPessoa()
        {
            if (!this.ListOrder)
            {
                this.Pessoas = this.Pessoas.OrderBy(item => item.Nome).ToList();
                this.ListOrder = true;
            }
            else
            {
                this.Pessoas = this.Pessoas.OrderBy(item => item.Nome).ToList();

                for (int indiceMaior = this.Pessoas.Count - 1, indiceMenor = 0; indiceMenor < this.Pessoas.Count / 2; indiceMaior--, indiceMenor++)
                {
                    var aux = this.Pessoas[indiceMenor];
                    this.Pessoas[indiceMenor] = this.Pessoas[indiceMaior];
                    this.Pessoas[indiceMaior] = aux;
                }
                this.ListOrder = false;
            }
        }

        public void ExcluirPessoa(int index) => this.Pessoas.RemoveAt(index);

        public Pessoa RetornaPessoa(int index)
        {
            return this.Pessoas[index];
        }

        public int RetornaTamanhoLista()
        {
            return this.Pessoas.Count;
        }
    }
}
