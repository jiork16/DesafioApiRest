using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class CompositionSubCategoryModel
    {
        //public CompositionSubCategoryModel()
        //{
        //    Fundingcompositions = new HashSet<FundingCompositionModel>();
        //    Portfoliocompositions = new HashSet<Portfoliocomposition>();
        //}

        public string Name { get; set; }
        public string Uuid { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public int? Categoryid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual CompositionCategoryModel Category { get; set; }
        public virtual ICollection<FundingCompositionModel> Fundingcompositions { get; set; }
        public virtual ICollection<Portfoliocomposition> Portfoliocompositions { get; set; }
    }
}
