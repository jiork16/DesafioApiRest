using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class UserModel
    {
        public string firstname { get; set; }
        public string durname { get; set; }
        public int id { get; set; }
        public int? advisorid { get; set; }
        public UserModel advisor { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }
        public int? currencyid { get; set; }
        public CurrencyModel Currency { get; set; }


        //public virtual User Advisor { get; set; }
        //public virtual Currency Currency { get; set; }
        //public virtual ICollection<Goal> Goals { get; set; }
        //public virtual ICollection<Goaltransactionfunding> Goaltransactionfundings { get; set; }
        //public virtual ICollection<Goaltransaction> Goaltransactions { get; set; }
        //public virtual ICollection<User> InverseAdvisor { get; set; }
    }
}
