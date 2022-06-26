using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    /// <summary>
    /// שמירת ניקוד
    /// </summary>
   public class Priority
    {

        public int id;
        public double score;


        public Priority(int id, double score)
        {
            this.id = id;
            this.score = score;
        }

        public Priority(int id_candidate)
        {
           id = id_candidate;
        }

        public Priority()
        {
        }
    }
}
