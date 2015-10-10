using System;
using System.Collections.Generic;

namespace Infra.Data.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            Endereco = new List<Endereco>();
        }

        public int PessoaId { get; set; }
        public string Apelido { get; set; }
        public string Teste { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual ICollection<Endereco> Endereco { get; set; }
    }
}
