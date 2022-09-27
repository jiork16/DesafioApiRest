using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class InvestmentStrategyModel
    {
        //public InvestmentStrategyModel()
        //{
        //    Portfolios = new HashSet<PortfolioModel>();
        //}

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string[] Features { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int Financialentityid { get; set; }
        public bool Isvisible { get; set; }
        public bool Isdefault { get; set; }
        public string Shorttitle { get; set; }
        public int? Investmentstrategytypeid { get; set; }
        public string Iconurl { get; set; }
        public bool Isrecommended { get; set; }
        public string Recommendedfor { get; set; }
        public int Displayorder { get; set; }

        public virtual FinancialentityModel Financialentity { get; set; }
        public virtual InvestmentStrategyTypeModel Investmentstrategytype { get; set; }
        public virtual ICollection<PortfolioModel> Portfolios { get; set; }
    }
}
