using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Domain.Entities
{
    public partial class Portfolio
    {
        //public Portfolio()
        //{
        //    Goals = new HashSet<Goal>();
        //    Portfoliocompositions = new HashSet<Portfoliocomposition>();
        //    Portfoliofundings = new HashSet<Portfoliofunding>();
        //}

        public double maxrangeyear { get; set; }
        public double minrangeyear { get; set; }
        public string uuid { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int id { get; set; }
        public int financialentityid { get; set; }
        public int risklevelid { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public bool isdefault { get; set; }
        public string profitability { get; set; }
        public int? investmentstrategyid { get; set; }
        public string version { get; set; }
        public string extraprofitabilitycurrencycode { get; set; }
        public double estimatedprofitability { get; set; }
        public double bpcomission { get; set; }

        public virtual Financialentity Financialentity { get; set; }
        public virtual Investmentstrategy Investmentstrategy { get; set; }
        public virtual Risklevel Risklevel { get; set; }
        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<Portfoliocomposition> Portfoliocompositions { get; set; }
        public virtual ICollection<Portfoliofunding> Portfoliofundings { get; set; }
    }
}
