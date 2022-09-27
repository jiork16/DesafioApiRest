using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class RisklevelModel
    {
        //public RisklevelModel()
        //{
        //    Goals = new HashSet<GoalModel>();
        //    Portfolios = new HashSet<PortfolioModel>();
        //}

        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual ICollection<GoalModel> Goals { get; set; }
        public virtual ICollection<PortfolioModel> Portfolios { get; set; }
    }
}
