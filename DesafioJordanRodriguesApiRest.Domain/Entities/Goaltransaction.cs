using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Domain.Entities
{
    public partial class Goaltransaction
    {
        //public Goaltransaction()
        //{
        //    Goaltransactionfundings = new HashSet<Goaltransactionfunding>();
        //}

        public string type { get; set; }
        public double? amount { get; set; }
        public DateTime date { get; set; }
        public int id { get; set; }
        [ForeignKey("goalid")]
        public int? goalid { get; set; }
        public Goal Goal { get; set; }

        [ForeignKey("ownerid")]
        public int ownerid { get; set; }
        public User User { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public bool isprocessed { get; set; }
        public bool all { get; set; }
        public string state { get; set; }
        [ForeignKey("financialentityid")]
        public int? financialentityid { get; set; }
        public Financialentity financialentity { get; set; }
        [ForeignKey("currencyid")]
        public int currencyid { get; set; }
        public Currency Currency { get; set; }
        public double cost { get; set; }

        //public virtual Currency Currency { get; set; }
        //public virtual Financialentity Financialentity { get; set; }
        //public virtual Goal Goal { get; set; }
        //public virtual User Owner { get; set; }
        //public virtual ICollection<Goaltransactionfunding> Goaltransactionfundings { get; set; }
    }
}
