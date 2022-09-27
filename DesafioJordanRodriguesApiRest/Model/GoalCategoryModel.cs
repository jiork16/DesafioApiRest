using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class GoalCategoryModel
    {
        //public GoalCategoryModel()
        //{
        //    Goals = new HashSet<GoalModel>();
        //}

        public string Code { get; set; }
        public string Uuid { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual ICollection<GoalModel> Goals { get; set; }
    }
}
