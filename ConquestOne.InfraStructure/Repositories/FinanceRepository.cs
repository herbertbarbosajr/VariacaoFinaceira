using ConquestOne.Application.Dtos;
using ConquestOne.Application.Interfaces;
using ConquestOne.Domain.Entities;
using ConquestOne.InfraStructure.Queries;
using Dapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConquestOne.InfraStructure.Repositories
{
    public class FinanceRepository : IFinanceRepository
    {
        private readonly IFinanceVariationService _financeService;
        private readonly IDbConnection _connection;

      
        public FinanceRepository(IFinanceVariationService financeService, 
            SQLQuery query)
        {
            _financeService = financeService;
            _connection = query.SqlConnection();
        }

        public async Task<List<VariacaoAnalyticsDTO>> Get()
        {
            var jsonFull = _financeService.Get();

            var json = JsonConvert.DeserializeObject<VariacaoDTO>(await jsonFull);

            List<VariacaoAnalyticsDTO> vaDTO = new List<VariacaoAnalyticsDTO>();
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);

            var timestamp = json.Chart.Result[0].Timestamp[0];

            for (int i = 0; i < json.Chart.Result[0].Timestamp.Count; i++)
            {
                var valueFirstDate = json.Chart.Result[0].Indicators.Quote[0].Open[0];
                var valueToday = json.Chart.Result[0].Indicators.Quote[0].Open[i];

                VariacaoAnalyticsDTO vAnalyticsdto = new VariacaoAnalyticsDTO();

                var date = dateTime.AddSeconds(json.Chart.Result[0].Timestamp[i]).ToLocalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffffff");
                vAnalyticsdto.Date = Convert.ToDateTime(date);
                vAnalyticsdto.Value = Math.Round(valueToday, 2);
                if (i > 0)
                {
                    var valuePreviousDate = json.Chart.Result[0].Indicators.Quote[0].Open[i - 1];
                    vAnalyticsdto.VariationPreviousDate = Math.Round(((valueToday / valuePreviousDate) - 1) * 100, 2);
                    vAnalyticsdto.VariationFirstDate = Math.Round(((valueToday / valueFirstDate) - 1) * 100, 2);
                }
                else
                {
                    vAnalyticsdto.VariationPreviousDate = 0;
                    vAnalyticsdto.VariationFirstDate = 0;
                }

                vaDTO.Add(vAnalyticsdto);
            }

            return vaDTO;

        }

        public IEnumerable<VariacaoResponseDTO> Get30Days()
        {
            var query = new QueryRequest().Get30Days();

            try
            {
                return _connection.Query<VariacaoResponseDTO>(query.Query) as List<VariacaoResponseDTO>;
            }
            catch
            {
                throw new Exception("Falha ao recuperar historico.");
            }
        }

        public void InsertVariacao(VariacaoEntity variacaoDto)
        {
            _connection.Open();

            try
            {
                var query = new QueryResponse().InsertVariationQuery(variacaoDto);
                _connection.Execute(query.Query, query.Parameters);
            }
            catch
            {
                throw new Exception("Erro ao inserir dados.");
            }

            _connection.Close();
        }
    }
}
