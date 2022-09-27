using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioJordanRodriguesApiRest.Application.Features
{
   public class UserResponse

    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
        public int? Advisorid { get; set; }
        public UserResponse Advisor { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int? Currencyid { get; set; }
        public CurrencyResponse Currency { get; set; }
    }
}
