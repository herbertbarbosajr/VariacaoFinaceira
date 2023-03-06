using ConquestOne.Application.Dtos;
using ConquestOne.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.Application.Interfaces
{
    public interface IFinanceRepository
    {
        Task<List<VariacaoAnalyticsDTO>> Get();
        void InsertVariacao(VariacaoEntity variacaoDto);
        IEnumerable<VariacaoResponseDTO> Get30Days();
    }
}
