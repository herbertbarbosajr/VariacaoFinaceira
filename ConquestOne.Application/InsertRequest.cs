using ConquestOne.Application.Interfaces;
using ConquestOne.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.Application
{
    public class InsertRequest : IRequest<List<VariacaoEntity>, State> 
    {
        private readonly IFinanceRepository _financeRepository;

        public InsertRequest(IFinanceRepository financeRepository)
        {
            _financeRepository = financeRepository;
        }

        public State Action (List<VariacaoEntity> entities)
        {
            try
            {
                foreach(var item in entities)
                {
                    var variacao = new VariacaoEntity(item.Date, item.Value, item.VariationPreviousDate, item.VariationNextDate);
                    _financeRepository.InsertVariacao(item);
                }

                return new State(200, "Dados inseridos com sucesso!", entities);              
            }
            catch(Exception ex)
            {
                return new State(500, ex.Message, null);
            }
            return new State(400, "Houve um erro ao tentar inserir os dados, por favor tente novamente!", null);
        }
    }
}
