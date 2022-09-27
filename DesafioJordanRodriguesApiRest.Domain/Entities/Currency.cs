using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Domain.Entities
{
    public partial class Currency
    {
        //public Currency()
        //{
        //    CurrencyindicatorDestinationcurrencies = new HashSet<Currencyindicator>();
        //    CurrencyindicatorSourcecurrencies = new HashSet<Currencyindicator>();
        //    Financialentities = new HashSet<Financialentity>();
        //    Fundings = new HashSet<Funding>();
        //    GoalCurrencies = new HashSet<Goal>();
        //    GoalDisplaycurrencies = new HashSet<Goal>();
        //    Goaltransactions = new HashSet<Goaltransaction>();
        //    Users = new HashSet<User>();
        //}

        public int id { get; set; }
        public string name { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public string uuid { get; set; }
        public string yahoomnemonic { get; set; }
        public string currencycode { get; set; }
        public string digitsinfo { get; set; }
        public string display { get; set; }
        public string locale { get; set; }
        public string serverformatnumber { get; set; }

        //public virtual ICollection<Currencyindicator> CurrencyindicatorDestinationcurrencies { get; set; }
        //public virtual ICollection<Currencyindicator> CurrencyindicatorSourcecurrencies { get; set; }
        //public virtual ICollection<Financialentity> Financialentities { get; set; }
        //public virtual ICollection<Funding> Fundings { get; set; }
        //public virtual ICollection<Goal> GoalCurrencies { get; set; }
        //public virtual ICollection<Goal> GoalDisplaycurrencies { get; set; }
        //public virtual ICollection<Goaltransaction> Goaltransactions { get; set; }
        //public virtual ICollection<User> Users { get; set; }
    }
}
