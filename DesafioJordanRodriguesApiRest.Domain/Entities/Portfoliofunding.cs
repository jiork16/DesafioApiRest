﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DesafioJordanRodriguesApiRest.Domain.Entities
{
    public partial class Portfoliofunding
    {
        public double Percentage { get; set; }
        public int Id { get; set; }
        public int Fundingid { get; set; }
        public int Portfolioid { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public virtual Funding Funding { get; set; }
        public virtual Portfolio Portfolio { get; set; }
    }
}
