using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DaysDto
    {
        public int id_day { get; set; }
        public string name_day { get; set; }

        public DaysDto(int id_day, string name_day)
        {
            this.id_day = id_day;
            this.name_day = name_day;
        }
    }
}
