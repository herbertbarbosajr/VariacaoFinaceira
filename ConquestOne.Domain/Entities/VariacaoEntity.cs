using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.Domain.Entities
{
    public class VariacaoEntity
    {
        public VariacaoEntity( DateTime date, double value, double variationPreviousDate, double variationNextDate )
        {
            Date = date;
            Value = value;
            VariationPreviousDate = variationPreviousDate;
            VariationNextDate = variationNextDate;
        }
        public VariacaoEntity()
        {

        }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public double VariationPreviousDate { get; set; }
        public double VariationNextDate { get; set; }
        public void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}
