using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.InfraStructure.Mappings
{
    public class QueryMain
    {
        public QueryMain(string? query, object? parameters)
        {
            Query = query;
            Parameters = parameters;
        }
        public string? Query { get; set; }
        public object? Parameters { get; set; }
    }
}
