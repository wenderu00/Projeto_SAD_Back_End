using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD.Domain.Commands.Contracts
{
    public interface IComando
    {
        void Validar();
    }
}
