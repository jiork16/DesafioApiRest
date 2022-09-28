using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Domain.Entities
{
    public partial class Goalcategory
    {
        public Goalcategory()
        {
            Goals = new HashSet<Goal>();
        }

        public string code { get; set; }
        public string uuid { get; set; }
        public string title { get; set; }
        public int id { get; set; }
        public DateTime created { get; set; }
        public DateTime modified { get; set; }

        public virtual ICollection<Goal> Goals { get; set; }
    }
}
