using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    /// <summary>
    /// שמירת רשימת עדיפויות
    /// </summary>
    public class ListOfPriority
    {
        public int id { get; set; }//קוד ישות נוכחית
        public bool isEmpty = true;//האם הישות פנויה
        public int id_2 { get; set; }//קוד ישות מקבילה 
        public List<Priority> listScore; //רשימת ישויות מקבילות
  
        public ListOfPriority(int id)
        {
            this.id = id;
            listScore= new List<Priority>();
        }

        public ListOfPriority()
        {
        }
    }
}
