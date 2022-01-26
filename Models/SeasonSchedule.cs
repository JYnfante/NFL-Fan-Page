using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HW4_Ynfante.Models
{
    public class SeasonSchedule
    {
        [Key]
        public int WeekId { get; set; }
        public string Date { get; set; }
        public string Vs { get; set; }
        public string TeamLogo { get; set; }
        public string Opponent { get; set; }
        public string Time { get; set; }
        public string Tv { get; set; }
    }
}
