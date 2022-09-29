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

        public string title { get; set; }
        public int years { get; set; }
        public int initialinvestment { get; set; }
        public int monthlycontribution { get; set; }
        public int targetamount { get; set; }
        public int id { get; set; }
        public int userid { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public int goalcategoryid { get; set; }
        public int? risklevelid { get; set; }
        public int? portfolioid { get; set; }
        public int? financialentityid { get; set; }
        public int? currencyid { get; set; }
        public int? displaycurrencyid { get; set; }

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
