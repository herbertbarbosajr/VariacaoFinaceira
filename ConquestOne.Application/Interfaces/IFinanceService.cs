using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.Application.Interfaces
{
    public interface IFinanceService
    {
        Task<string> Get();
    }
}
