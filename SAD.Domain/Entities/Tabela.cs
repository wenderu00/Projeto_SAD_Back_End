using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Domain.Entities
{
    public class Tabela
    {
        public Tabela(IList<Projeto> projetos)
        {
            Projetos=projetos;
            Normalizacao = GerarNormalizacao();
            ProjetosNormalizados = NormalizarProjetos();
            IdealNegativa = GerarIdealNegativa();
            IdealPositiva = GerarIdealPositiva();
        }
        public IList<Projeto> Projetos { get; private set; }
        public Projeto Normalizacao { get; private set; }
        public IList<Projeto> ProjetosNormalizados { get; private set; }
        public Projeto IdealPositiva { get; private set; }
        public Projeto IdealNegativa { get; private set; }
        public Projeto GerarNormalizacao()
        {
            double a=0;
            double b = 0;
            double c = 0;
            double d = 0;
            double e = 0;
            double f = 0;
            double g = 0;
            double h = 0;
            foreach (Projeto projeto in Projetos)
            {
                a += Math.Pow(projeto.CriterioA, 2);
                b += Math.Pow(projeto.CriterioB, 2);
                c += Math.Pow(projeto.CriterioC, 2);
                d += Math.Pow(projeto.CriterioD, 2);
                e += Math.Pow(projeto.CriterioE, 2);
                f += Math.Pow(projeto.CriterioF, 2);
                g += Math.Pow(projeto.CriterioG, 2);
                h += Math.Pow(projeto.CriterioH, 2);
            }
            return new Projeto("normalização",Math.Sqrt(a), Math.Sqrt(b), Math.Sqrt(c), Math.Sqrt(d), Math.Sqrt(e), Math.Sqrt(f), Math.Sqrt(g), Math.Sqrt(h));
        }
        public IList<Projeto> NormalizarProjetos()
        {
            IList<Projeto> ProjetosNormalizados = new List<Projeto>();
            double peso = 0.125;
            foreach(Projeto projeto in Projetos)
            {
                ProjetosNormalizados.Add(
                    new Projeto(
                        projeto.Nome,
                        (projeto.CriterioA/Normalizacao.CriterioA)*peso,
                        (projeto.CriterioB/Normalizacao.CriterioB)*peso,
                        (projeto.CriterioC / Normalizacao.CriterioC) * peso,
                        (projeto.CriterioD/Normalizacao.CriterioD)*peso,
                        (projeto.CriterioE/Normalizacao.CriterioE)*peso,
                        (projeto.CriterioF / Normalizacao.CriterioF) * peso,
                        (projeto.CriterioG / Normalizacao.CriterioG) * peso,
                        (projeto.CriterioH / Normalizacao.CriterioH) * peso
                        ));
            }
            return ProjetosNormalizados;
        }
        public Projeto GerarIdealPositiva()
        {
            double a = ProjetosNormalizados[0].CriterioA;
            double b = ProjetosNormalizados[0].CriterioB;
            double c = ProjetosNormalizados[0].CriterioC;
            double d = ProjetosNormalizados[0].CriterioD;
            double e = ProjetosNormalizados[0].CriterioE;
            double f = ProjetosNormalizados[0].CriterioF;
            double g = ProjetosNormalizados[0].CriterioG;
            double h = ProjetosNormalizados[0].CriterioH;
            foreach (Projeto projeto in ProjetosNormalizados)
            {
                if (projeto.CriterioA > a)
                    a = projeto.CriterioA;
                if (projeto.CriterioB > b)
                    b = projeto.CriterioB;
                if (projeto.CriterioC > c)
                    c = projeto.CriterioC;
                if (projeto.CriterioD > d)
                    d = projeto.CriterioD;
                if (projeto.CriterioE > e)
                    e = projeto.CriterioE;
                if (projeto.CriterioF < f)
                    f = projeto.CriterioF;
                if (projeto.CriterioG < g)
                    g = projeto.CriterioG;
                if (projeto.CriterioH < h)
                    h = projeto.CriterioH;

            }

            return new Projeto("ideal positiva",a, b, c, d, e, f, g, h);
        }
        public Projeto GerarIdealNegativa()
        {
            double a = ProjetosNormalizados[0].CriterioA;
            double b = ProjetosNormalizados[0].CriterioB;
            double c = ProjetosNormalizados[0].CriterioC;
            double d = ProjetosNormalizados[0].CriterioD;
            double e = ProjetosNormalizados[0].CriterioE;
            double f = ProjetosNormalizados[0].CriterioF;
            double g = ProjetosNormalizados[0].CriterioG;
            double h = ProjetosNormalizados[0].CriterioH;
            foreach (Projeto projeto in ProjetosNormalizados)
            {
                if (projeto.CriterioA < a)
                    a = projeto.CriterioA;
                if (projeto.CriterioB < b)
                    b = projeto.CriterioB;
                if (projeto.CriterioC < c)
                    c = projeto.CriterioC;
                if (projeto.CriterioD < d)
                    d = projeto.CriterioD;
                if (projeto.CriterioE < e)
                    e = projeto.CriterioE;
                if (projeto.CriterioF > f)
                    f = projeto.CriterioF;
                if (projeto.CriterioG > g)
                    g = projeto.CriterioG;
                if (projeto.CriterioH > h)
                    h = projeto.CriterioH;

            }

            return new Projeto("ideal negativa",a, b, c, d, e, f, g, h);
        }
        public double GerarDMais(Projeto projetoNormalizado)
        {
            return Math.Sqrt(
                Math.Pow(projetoNormalizado.CriterioA - IdealPositiva.CriterioA, 2) +
                Math.Pow(projetoNormalizado.CriterioB - IdealPositiva.CriterioB, 2) +
                Math.Pow(projetoNormalizado.CriterioC - IdealPositiva.CriterioC, 2) +
                Math.Pow(projetoNormalizado.CriterioD - IdealPositiva.CriterioD, 2) +
                Math.Pow(projetoNormalizado.CriterioE - IdealPositiva.CriterioE, 2) +
                Math.Pow(projetoNormalizado.CriterioF - IdealPositiva.CriterioF, 2) +
                Math.Pow(projetoNormalizado.CriterioG - IdealPositiva.CriterioG, 2) +
                Math.Pow(projetoNormalizado.CriterioH - IdealPositiva.CriterioH, 2)
                );
        }
        public double GerarDMenos(Projeto projetoNormalizado)
        {
            return Math.Sqrt(
                Math.Pow(projetoNormalizado.CriterioA - IdealNegativa.CriterioA, 2) +
                Math.Pow(projetoNormalizado.CriterioB - IdealNegativa.CriterioB, 2) +
                Math.Pow(projetoNormalizado.CriterioC - IdealNegativa.CriterioC, 2) +
                Math.Pow(projetoNormalizado.CriterioD - IdealNegativa.CriterioD, 2) +
                Math.Pow(projetoNormalizado.CriterioE - IdealNegativa.CriterioE, 2) +
                Math.Pow(projetoNormalizado.CriterioF - IdealNegativa.CriterioF, 2) +
                Math.Pow(projetoNormalizado.CriterioG - IdealNegativa.CriterioG, 2) +
                Math.Pow(projetoNormalizado.CriterioH - IdealNegativa.CriterioH, 2)
                );
        }
        public double GerarDDefinitivo(Projeto projetoNormalizado)
        {
            var dmenos = GerarDMenos(projetoNormalizado);
            var dmais = GerarDMais(projetoNormalizado);
            return dmenos / (dmais + dmenos);
        }
        public IList<Projeto> OrdenarProjetosNormalizados()
        {
            return (IList<Projeto>)(from projeto in ProjetosNormalizados orderby GerarDDefinitivo(projeto) select projeto); ;
        }

    }
}
