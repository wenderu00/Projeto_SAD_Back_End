using Flunt.Notifications;
using Flunt.Validations;
using SAD.Domain.Commands.Contracts;
using SAD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Domain.Commands
{
    public class ComandoDeRanqueamento : Notifiable<Notification>, IComando
    {
        public ComandoDeRanqueamento() { }
        public ComandoDeRanqueamento(IList<ComandoCriarProjeto> projetos) {
            Projetos=projetos;
        }
        public IList<ComandoCriarProjeto> Projetos { get; set; }
        public void Validar()
        {
            if(Projetos==null)
                AddNotifications(new Contract<bool>().Requires().IsNotNull(Projetos, "A lista de projetos é inválida"));
            else
            {
                foreach(var projeto in Projetos)
                {
                    projeto.Validar();
                    AddNotifications(projeto.Notifications);
                }
                AddNotifications(new Contract<bool>().Requires().IsGreaterThan(Projetos.Count,0, "A lista de projetos está vázia"));
            }
        }
    }
}
