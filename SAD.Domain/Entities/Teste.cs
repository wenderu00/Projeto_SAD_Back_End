using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Domain.Entities
{
    public class Teste
    {
        public Teste() { }
        public Teste(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
    }
}
