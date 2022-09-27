using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class GoalTransactionFundingModel
    {
        public double Percentage { get; set; }
        public double? Amount { get; set; }
        public double? Quotas { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public int Fundingid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int? Transactionid { get; set; }
        public string State { get; set; }
        public string Type { get; set; }
        public int Goalid { get; set; }
        public int Ownerid { get; set; }
        public double Cost { get; set; }

        public virtual FundingModel Funding { get; set; }
        public virtual GoalModel Goal { get; set; }
        public virtual UserModel Owner { get; set; }
        public virtual GoalTransactionModel Transaction { get; set; }
    }
}
