using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Domain.Entities
{
    public partial class Financialentity
    {
        //public Financialentity()
        //{
        //    Fundings = new HashSet<Funding>();
        //    Goals = new HashSet<Goal>();
        //    Goaltransactions = new HashSet<Goaltransaction>();
        //    Investmentstrategies = new HashSet<Investmentstrategy>();
        //    Investmentstrategytypes = new HashSet<Investmentstrategytype>();
        //    Portfolios = new HashSet<Portfolio>();
        //}

        public string logo { get; set; }
        public string title { get; set; }
        public string uuid { get; set; }
        [Key]
        public int id { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public string description { get; set; }
        public int? defaultcurrencyid { get; set; }

        public virtual Currency Defaultcurrency { get; set; }
        public virtual ICollection<Funding> Fundings { get; set; }
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<Goaltransaction> Goaltransactions { get; set; }
        public virtual ICollection<Investmentstrategy> Investmentstrategies { get; set; }
        public virtual ICollection<Investmentstrategytype> Investmentstrategytypes { get; set; }
        public virtual ICollection<Portfolio> Portfolios { get; set; }
    }
}
