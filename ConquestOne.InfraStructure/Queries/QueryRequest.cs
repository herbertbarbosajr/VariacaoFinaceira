using ConquestOne.InfraStructure.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.InfraStructure.Queries
{
    public class QueryRequest : DefaultQuery
    {
        public QueryMain Get30Days() {

            this.Table = Mapping.GetYahooFinanceTable();
            this.Query = $@"
                SELECT 
                PET.[ID] AS [Dia],
                CONVERT(VARCHAR(10), PET.[CL_DATE], 103) AS [DATE],
                CONCAT('R$', PET.[CL_VALUE]) AS [Value],
                CONCAT(PET.[CL_VARIATION_PREVIOUS_DATE], '%') AS [VariationPreviousDate],
                CONCAT(PET.[CL_VARIATION_FIRST_DATE], '%') AS [VariationFirstDate]
                FROM {this.Table} AS PET
            ";

            return new QueryMain(this.Query, null);
        }
    }
}
