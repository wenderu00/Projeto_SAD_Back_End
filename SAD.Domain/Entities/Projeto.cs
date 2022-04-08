using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Domain.Entities
{
    public class Projeto
    {
        public Projeto() { }
        public Projeto(string nome,double a, double b, double c, double d, double e, double f, double g, double h)
        {
            Nome = nome;
            CriterioA = a;
            CriterioB = b;
            CriterioC = c;
            CriterioD = d;
            CriterioE = e;
            CriterioF = f;
            CriterioG = g;
            CriterioH = h;
        }
        public string Nome { get; private set; }
        public double CriterioA { get; private set; }
        public double CriterioB { get; private set; }
        public double CriterioC { get; private set; }
        public double CriterioD { get; private set; }
        public double CriterioE { get; private set; }
        public double CriterioF { get; private set; }
        public double CriterioG { get; private set; }
        public double CriterioH { get; private set; }
    }
}
