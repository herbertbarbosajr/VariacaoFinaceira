using ConquestOne.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.Application.Interfaces
{
    public interface IRequest<in T, out W> 
        where T : List<VariacaoEntity>
        where W : State
    {
        W Action(T command);
    }
}
