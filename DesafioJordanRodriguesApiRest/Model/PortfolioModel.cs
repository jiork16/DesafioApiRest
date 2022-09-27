using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class PortfolioModel
    {
    //    public PortfolioModel()
    //    {
    //        Goals = new HashSet<GoalModel>();
    //        Portfoliocompositions = new HashSet<Portfoliocomposition>();
    //        Portfoliofundings = new HashSet<PortfolioFundingModel>();
    //    }

        public double Maxrangeyear { get; set; }
        public double Minrangeyear { get; set; }
        public string Uuid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public int Financialentityid { get; set; }
        public int Risklevelid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Isdefault { get; set; }
        public string Profitability { get; set; }
        public int? Investmentstrategyid { get; set; }
        public string Version { get; set; }
        public string Extraprofitabilitycurrencycode { get; set; }
        public double Estimatedprofitability { get; set; }
        public double Bpcomission { get; set; }

        public virtual FinancialentityModel Financialentity { get; set; }
        public virtual InvestmentStrategyModel Investmentstrategy { get; set; }
        public virtual RisklevelModel Risklevel { get; set; }
        public virtual ICollection<GoalModel> Goals { get; set; }
        public virtual ICollection<Portfoliocomposition> Portfoliocompositions { get; set; }
        public virtual ICollection<PortfolioFundingModel> Portfoliofundings { get; set; }
    }
}
