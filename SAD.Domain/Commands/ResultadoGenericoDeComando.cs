using SAD.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Domain.Commands
{
    public class ResultadoGenericoDeComando :IResultadoDeComando
    {
        public ResultadoGenericoDeComando() { }
        public ResultadoGenericoDeComando(bool sucesso, string mensagem, object data)
        {
            Successo = sucesso;
            Mensagem = mensagem;
            Data = data;
        }
        public bool? Successo { get; set; }
        public string? Mensagem { get; set; }
        public object? Data { get; set; }
    }
}
