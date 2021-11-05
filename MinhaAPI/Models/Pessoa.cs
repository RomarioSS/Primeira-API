using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaAPI.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public String Sobrenome { get; set; }
        public int Idade { get; set; }
        public int CPF { get; set; }
    }
}
