using Flunt.Notifications;
using Flunt.Validations;
using SAD.Domain.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Domain.Commands
{
    public class ComandoCriarProjeto : Notifiable<Notification>, IComando
    {
        public ComandoCriarProjeto() { }
        public ComandoCriarProjeto(string nome, double a, double b, double c, double d, double e, double f, double g, double h)
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
        public string Nome { get;  set; }
        public double CriterioA { get;  set; }
        public double CriterioB { get;  set; }
        public double CriterioC { get;  set; }
        public double CriterioD { get;  set; }
        public double CriterioE { get;  set; }
        public double CriterioF { get;  set; }
        public double CriterioG { get;  set; }
        public double CriterioH { get;  set; }
        public void Validar()
        {
            AddNotifications(new Contract<bool>()
                .Requires()
                .IsNotNullOrEmpty(Nome, "Nome inválido")
                .IsGreaterOrEqualsThan(CriterioA,0,"Critério A não pode ser negativo")
                .IsGreaterOrEqualsThan(CriterioB, 0, "Critério B não pode ser negativo")
                .IsGreaterOrEqualsThan(CriterioC, 0, "Critério C não pode ser negativo")
                .IsGreaterOrEqualsThan(CriterioD, 0, "Critério D não pode ser negativo")
                .IsGreaterOrEqualsThan(CriterioE, 0, "Critério E não pode ser negativo")
                .IsGreaterOrEqualsThan(CriterioF, 0, "Critério F não pode ser negativo")
                .IsGreaterOrEqualsThan(CriterioG, 0, "Critério G não pode ser negativo")
                .IsGreaterOrEqualsThan(CriterioH, 0, "Critério H não pode ser negativo"));

        }
    }
}
