using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Domain.Entities
{
    public partial class Goal
    {
        //public Goal()
        //{
        //    Goaltransactionfundings = new HashSet<Goaltransactionfunding>();
        //    Goaltransactions = new HashSet<Goaltransaction>();
        //}

        public string title { get; set; }
        public int years { get; set; }
        public int initialinvestment { get; set; }
        public int monthlycontribution { get; set; }
        public int targetamount { get; set; }
        public int id { get; set; }
        [ForeignKey("advisorid")]
        public int userid { get; set; }
        public User User { get; set; }

        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        [ForeignKey("goalcategoryid")]
        public int goalcategoryid { get; set; }
        public Goalcategory Goalcategory { get; set; }

        [ForeignKey("risklevelid")]
        public int? risklevelid { get; set; }
        public Risklevel Risklevel { get; set; }

        [ForeignKey("portfolioid")]
        public int? portfolioid { get; set; }
        public Portfolio Portfolio { get; set; }

        [ForeignKey("financialentityid")]
        public int? financialentityid { get; set; }
        public Financialentity Financialentity { get; set; }

        [ForeignKey("currencyid")]
        public int? currencyid { get; set; }
        public Currency Currency { get; set; }

        [ForeignKey("displaycurrencyid")]
        public int? displaycurrencyid { get; set; }
        public Currency Displaycurrency { get; set; }

        //public virtual Currency Currency { get; set; }
        //public virtual Currency Displaycurrency { get; set; }
        //public virtual Financialentity Financialentity { get; set; }
        //public virtual Goalcategory Goalcategory { get; set; }
        //public virtual Portfolio Portfolio { get; set; }
        //public virtual Risklevel Risklevel { get; set; }
        //public virtual User User { get; set; }
        //public virtual ICollection<Goaltransactionfunding> Goaltransactionfundings { get; set; }
        //public virtual ICollection<Goaltransaction> Goaltransactions { get; set; }
    }
}
