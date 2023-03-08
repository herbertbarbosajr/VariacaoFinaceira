using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.Application.Interfaces
{
    public interface IFinanceVariationService
    {
        Task<string> Get();
    }
}
