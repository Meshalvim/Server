using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class RequestResult
    {
        public Object data { get; set; }
        public string message { get; set; }
        public bool status { get; set; }
    }
}
