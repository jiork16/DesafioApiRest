using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioJordanRodriguesApiRest.Application.Features
{
    public class CurrencyResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Uuid { get; set; }
        public string Yahoomnemonic { get; set; }
        public string Currencycode { get; set; }
        public string Digitsinfo { get; set; }
        public string Display { get; set; }
        public string Locale { get; set; }
        public string Serverformatnumber { get; set; }
    }
}
