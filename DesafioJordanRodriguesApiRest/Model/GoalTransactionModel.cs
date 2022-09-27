using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class GoalTransactionModel
    {
        //public GoalTransactionModel()
        //{
        //    Goaltransactionfundings = new HashSet<GoalTransactionFundingModel>();
        //}

        public string Type { get; set; }
        public double? Amount { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public int? Goalid { get; set; }
        public int Ownerid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public bool Isprocessed { get; set; }
        public bool All { get; set; }
        public string State { get; set; }
        public int? Financialentityid { get; set; }
        public int Currencyid { get; set; }
        public double Cost { get; set; }

        public virtual CurrencyModel Currency { get; set; }
        public virtual FinancialentityModel Financialentity { get; set; }
        public virtual GoalModel Goal { get; set; }
        public virtual UserModel Owner { get; set; }
        public virtual ICollection<GoalTransactionFundingModel> Goaltransactionfundings { get; set; }
    }
}
