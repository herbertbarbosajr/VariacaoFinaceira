using ConquestOne.Application.Dtos;
using ConquestOne.Application.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.InfraStructure.Services
{
    public class FinanceVariationService : IFinanceVariationService
    {
        public async Task<string> Get()
        {
            string yahooFinance = "https://query2.finance.yahoo.com/v8/finance/chart/PETR4.SA?symbol=PETR4.SA&period1=1675814400&period2=9999999999&interval=1d";

            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(yahooFinance);

            var data = await response.Content.ReadAsStringAsync();

            var json = JsonConvert.DeserializeObject<VariacaoDTO>(data);

            return data;
        }
    }
}
