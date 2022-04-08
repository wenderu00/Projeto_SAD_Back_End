using SAD.Domain.Commands;
using SAD.Domain.Commands.Contracts;
using SAD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Domain.Handlers
{
    public class ManipuladorDeRanqueamento
    {
        public static IResultadoDeComando Handle(ComandoDeRanqueamento comando)
        {
            comando.Validar();
            if (!comando.IsValid )
                return new ResultadoGenericoDeComando(false, "Comando inválido", comando.Notifications);
            else if(comando.Projetos == null)
                return new ResultadoGenericoDeComando(false, "Projetos inválidos", comando.Projetos);
            var projetos = new List<Projeto>();
            foreach(var projeto in comando.Projetos)
            {
                projetos.Add(new Projeto(
                    projeto.Nome,
                    projeto.CriterioA,
                    projeto.CriterioB,
                    projeto.CriterioC,
                    projeto.CriterioD,
                    projeto.CriterioE,
                    projeto.CriterioF,
                    projeto.CriterioG,
                    projeto.CriterioH
                    ));
            }
            var tabela = new Tabela(projetos);
            var projetosOrdenados = tabela.OrdenarProjetosNormalizados();
            return new ResultadoGenericoDeComando(true, "Ranqueamento feito com sucesso", projetosOrdenados);
        }
        public static IResultadoDeComando HandleInvertido(ComandoDeRanqueamento comando)
        {
            comando.Validar();
            if (!comando.IsValid)
                return new ResultadoGenericoDeComando(false, "Comando inválido", comando.Notifications);
            else if (comando.Projetos == null)
                return new ResultadoGenericoDeComando(false, "Projetos inválidos", comando.Projetos);
            var projetos = new List<Projeto>();
            foreach (var projeto in comando.Projetos)
            {
                projetos.Add(new Projeto(
                    projeto.Nome,
                    projeto.CriterioA,
                    projeto.CriterioB,
                    projeto.CriterioC,
                    projeto.CriterioD,
                    projeto.CriterioE,
                    projeto.CriterioF,
                    projeto.CriterioG,
                    projeto.CriterioH
                    ));
            }
            var tabela = new Tabela(projetos);
            var projetosOrdenados = tabela.OrdenarProjetosNormalizadosInvertido();
            return new ResultadoGenericoDeComando(true, "Ranqueamento feito com sucesso", projetosOrdenados);
        }
    }
}
