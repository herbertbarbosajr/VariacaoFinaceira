using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.InfraStructure.Queries
{
    public class SQLQuery
    {
        public IDbConnection SqlConnection()
        {
            return new SqlConnection("Data Source=DESKTOP-2NCEKK2;Initial Catalog=FinanceVariationDB;User ID=variationFinance;Password=123456");
        }
    }
}
