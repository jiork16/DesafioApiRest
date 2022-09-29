using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioJordanRodriguesApiRest.Application.Features
{
    public class GoalDetailResponse
    {
        public string TituloMeta { get; set; }
        public int Años { get; set; }
        public decimal InversionInicial { get; set; }
        public decimal AporteMensaul { get; set; }
        public decimal MontoObjetivo { get; set; }
        public string EntidadFinanciera { get; set; }
        public string PortafolioCompleto { get; set; }
        public string CategoriaMeta { get; set; }
        public decimal TotalAportes { get; set; }
        public decimal TotalRetiro { get; set; }
        public decimal PorcentajeCumplimientoMeta { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
