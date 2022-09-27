﻿using System;
using System.Collections.Generic;

#nullable disable
namespace DesafioJordanRodriguesApiRest.Domain.Entities
{
    public partial class Compositioncategory
    {
        public Compositioncategory()
        {
            Compositionsubcategories = new HashSet<Compositionsubcategory>();
        }

        public string Name { get; set; }
        public string Uuid { get; set; }
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual ICollection<Compositionsubcategory> Compositionsubcategories { get; set; }
    }
}
