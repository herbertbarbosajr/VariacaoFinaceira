using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.Domain.Entities
{
    public class VariacaoEntity
    {
        public VariacaoEntity( DateTime date, double value, double variationPreviousDate, double variationFirstDate )
        {
            Date = date;
            Value = value;
            VariationPreviousDate = variationPreviousDate;
            VariationFirstDate = variationFirstDate;
        }
        public VariacaoEntity()
        {

        }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public double VariationPreviousDate { get; set; }
        public double VariationFirstDate { get; set; }
        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
