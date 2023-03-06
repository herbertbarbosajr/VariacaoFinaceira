using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.Application.Dtos
{
    public class VariacaoAnalyticsDTO
    {
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public double VariationPreviousDate { get; set; }
        public double VariationNextDate { get; set; }
    }
}
