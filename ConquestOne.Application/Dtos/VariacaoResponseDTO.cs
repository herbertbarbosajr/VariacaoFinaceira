using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquestOne.Application.Dtos
{
    public class VariacaoResponseDTO
    {
        public int Day{ get; set; }
        public string? Date { get; set; }
        public string? Value { get; set; }
        public string? VariationPreviousDate { get; set; }
        public string? VariationNextDate { get; set; }
    }
}
