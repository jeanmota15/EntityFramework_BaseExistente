using System;
using System.Collections.Generic;

namespace Infra.Data.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
