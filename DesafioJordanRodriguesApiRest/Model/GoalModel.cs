using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class GoalModel
    {
        //public GoalModel()
        //{
        //    Goaltransactionfundings = new HashSet<GoalTransactionFundingModel>();
        //    Goaltransactions = new HashSet<GoalTransactionModel>();
        //}

        public string Title { get; set; }
        public int Years { get; set; }
        public int Initialinvestment { get; set; }
        public int Monthlycontribution { get; set; }
        public int Targetamount { get; set; }
        public int Id { get; set; }
        public int Userid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int Goalcategoryid { get; set; }
        public int? Risklevelid { get; set; }
        public int? Portfolioid { get; set; }
        public int? Financialentityid { get; set; }
        public int? Currencyid { get; set; }
        public int? Displaycurrencyid { get; set; }

        public virtual CurrencyModel Currency { get; set; }
        public virtual CurrencyModel Displaycurrency { get; set; }
        public virtual FinancialentityModel Financialentity { get; set; }
        public virtual GoalCategoryModel Goalcategory { get; set; }
        public virtual PortfolioModel Portfolio { get; set; }
        public virtual RisklevelModel Risklevel { get; set; }
        public virtual UserModel User { get; set; }
        public virtual ICollection<GoalTransactionFundingModel> Goaltransactionfundings { get; set; }
        public virtual ICollection<GoalTransactionModel> Goaltransactions { get; set; }
    }
}
