using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Domain.Entities
{
    public partial class Risklevel
    {
        //public Risklevel()
        //{
        //    Goals = new HashSet<Goal>();
        //    Portfolios = new HashSet<Portfolio>();
        //}

        public int id { get; set; }
        public string title { get; set; }
        public string code { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }

        public virtual ICollection<Goal> Goals { get; set; }
        public virtual ICollection<Portfolio> Portfolios { get; set; }
    }
}
