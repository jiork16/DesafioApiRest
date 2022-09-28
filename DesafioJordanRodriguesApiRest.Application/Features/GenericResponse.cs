using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioJordanRodriguesApiRest.Application.Features
{
    public class GenericResponse
    {
        public int Id { get; set; }
        public string UserName  { get; set; }
        public string UserNameAdvisor { get; set; }
        public DateTime CreateDate { get; set; }
    }
    public class SumariResponse
    {
        public decimal Balance { get; set; }
        public decimal Aportes { get; set; }
        public DateTime Date { get; set; }
        public int Userid { get; set; }
    }
    public class GoalResponse
    {
        public string TituloMeta { get; set; }
        public int Años { get; set; }
        public decimal InversionInicial { get; set; }
        public decimal AporteMensaul { get; set; }
        public decimal MontoObjetivo { get; set; }
        public string EntidadFinanciera { get; set; }
        public string PortafolioCompleto { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
