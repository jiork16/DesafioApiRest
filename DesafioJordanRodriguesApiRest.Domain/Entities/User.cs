using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Domain.Entities
{
    public partial class User
    {
        public string firstname { get; set; }
        public string surname { get; set; }
        [Key]
        public int id { get; set; }
        public int? advisorid { get; set; }
        [ForeignKey("advisorid")]
        public User Advisor { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public int? currencyid { get; set; }
        [ForeignKey("currencyid")]
        public Currency Currency { get; set; }

        //public virtual User Advisor { get; set; }
        //public virtual Currency Currency { get; set; }
        //public virtual ICollection<Goal> Goals { get; set; }
        //public virtual ICollection<Goaltransactionfunding> Goaltransactionfundings { get; set; }
        //public virtual ICollection<Goaltransaction> Goaltransactions { get; set; }
        //public virtual ICollection<User> InverseAdvisor { get; set; }
    }
}
