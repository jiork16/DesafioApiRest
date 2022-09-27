using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class FundingShareValueModel
    {
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public int Fundingid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual FundingModel Funding { get; set; }
    }
}
