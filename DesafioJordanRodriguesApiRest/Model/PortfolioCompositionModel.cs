using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class Portfoliocomposition
    {
        public double? Percentage { get; set; }
        public int Id { get; set; }
        public int Subcategoryid { get; set; }
        public int Portfolioid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual PortfolioModel Portfolio { get; set; }
        public virtual CompositionSubCategoryModel Subcategory { get; set; }
    }
}
