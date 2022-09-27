using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class PortfolioFundingModel
    {
        public double Percentage { get; set; }
        public int Id { get; set; }
        public int Fundingid { get; set; }
        public int Portfolioid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual FundingModel Funding { get; set; }
        public virtual PortfolioModel Portfolio { get; set; }
    }
}
