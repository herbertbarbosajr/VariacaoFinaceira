using ConquestOne.Domain.Entities;
using ConquestOne.InfraStructure.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.InfraStructure.Queries
{
    public class QueryResponse : DefaultQuery
    {
        public QueryMain InsertVariationQuery(VariacaoEntity variacaoEntity)
        {
            this.Table = Mapping.GetYahooFinanceTable();
            this.Query = $@"
                INSERT INTO {this.Table}
                VALUES
                (
                    @Date,
                    @Value,
                    @Variation_Previous_Date,
                    @Variation_First_Date
                )
            ";

            this.Parameters = new
            {
                Date = variacaoEntity.Date,
                Value = variacaoEntity.Value,
                Variation_Previous_Date = variacaoEntity.VariationPreviousDate,
                Variation_First_Date = variacaoEntity.VariationFirstDate
            };

            return new QueryMain(this.Query, this.Parameters);
        }
    }
}
