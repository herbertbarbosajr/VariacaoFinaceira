using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.InfraStructure.Mappings
{
    public abstract class DefaultQuery
    {
        public string? Table { get; set; }
        public string? Query { get; set; }
        public object? Parameters { get; set;}
    }
}
