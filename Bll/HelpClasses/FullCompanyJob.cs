using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;

namespace Bll.HelpClasses
{
    public class FullCompanyJob
    {
        public CompanyDto Company { get; set; }
        public JobDto Job { get; set; }
        public ScoreOfJobDto scoreOfJob { get; set; }
        public List<RequiresJobDto> requires { get; set; }
    }
}