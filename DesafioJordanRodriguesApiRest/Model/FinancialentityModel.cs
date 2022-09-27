using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class FinancialentityModel
    {
        //public FinancialentityModel()
        //{
        //    Fundings = new HashSet<FundingModel>();
        //    Goals = new HashSet<GoalModel>();
        //    Goaltransactions = new HashSet<GoalTransactionModel>();
        //    Investmentstrategies = new HashSet<InvestmentStrategyModel>();
        //    Investmentstrategytypes = new HashSet<InvestmentStrategyTypeModel>();
        //    Portfolios = new HashSet<PortfolioModel>();
        //}

        public string Logo { get; set; }
        public string Title { get; set; }
        public string Uuid { get; set; }
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Description { get; set; }
        public int? Defaultcurrencyid { get; set; }

        public virtual CurrencyModel Defaultcurrency { get; set; }
        public virtual ICollection<FundingModel> Fundings { get; set; }
        public virtual ICollection<GoalModel> Goals { get; set; }
        public virtual ICollection<GoalTransactionModel> Goaltransactions { get; set; }
        public virtual ICollection<InvestmentStrategyModel> Investmentstrategies { get; set; }
        public virtual ICollection<InvestmentStrategyTypeModel> Investmentstrategytypes { get; set; }
        public virtual ICollection<PortfolioModel> Portfolios { get; set; }
    }
}
