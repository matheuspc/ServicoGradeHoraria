using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeAPI.Models
{
    public class GradeItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsAttended { get; set; }
        public string Horario { get; set; }
        public int Periodo { get; set; }
        public string Codigo { get; set; }
    }
}
