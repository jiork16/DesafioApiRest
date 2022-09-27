using System;
using System.Collections.Generic;

#nullable disable
namespace DesafioJordanRodriguesApiRest.Model
{
    public partial class CompositionCategoryModel
    {
        //public CompositionCategoryModel()
        //{
        //    Compositionsubcategories = new HashSet<CompositionSubCategoryModel>();
        //}

        public string Name { get; set; }
        public string Uuid { get; set; }
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual ICollection<CompositionSubCategoryModel> Compositionsubcategories { get; set; }
    }
}
