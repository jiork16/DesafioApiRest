using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class FundingModel
    {
        //public FundingModel()
        //{
        //    Fundingcompositions = new HashSet<FundingCompositionModel>();
        //    Fundingsharevalues = new HashSet<FundingShareValueModel>();
        //    Goaltransactionfundings = new HashSet<GoalTransactionFundingModel>();
        //    Portfoliofundings = new HashSet<PortfolioFundingModel>();
        //}

        public string Title { get; set; }
        public string Description { get; set; }
        public string Uuid { get; set; }
        public int Id { get; set; }
        public int Financialentityid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Mnemonic { get; set; }
        public bool Isbox { get; set; }
        public string Yahoomnemonic { get; set; }
        public string Cmfurl { get; set; }
        public int? Currencyid { get; set; }
        public bool Hassharevalue { get; set; }

        public virtual CurrencyModel Currency { get; set; }
        public virtual FinancialentityModel Financialentity { get; set; }
        public virtual ICollection<FundingCompositionModel> Fundingcompositions { get; set; }
        public virtual ICollection<FundingShareValueModel> Fundingsharevalues { get; set; }
        public virtual ICollection<GoalTransactionFundingModel> Goaltransactionfundings { get; set; }
        public virtual ICollection<PortfolioFundingModel> Portfoliofundings { get; set; }
    }
}
