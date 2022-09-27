using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class CurrencyIndicatorModel
    {
        public int Id { get; set; }
        public int Sourcecurrencyid { get; set; }
        public int Destinationcurrencyid { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Requestdate { get; set; }
        public double Ask { get; set; }
        public double Bid { get; set; }

        public virtual CurrencyModel Destinationcurrency { get; set; }
        public virtual CurrencyModel Sourcecurrency { get; set; }
    }
}
