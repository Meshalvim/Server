using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    /// <summary>
    /// רשימת עדיפויות עבור כל משרה
    /// </summary>
    public class PriorityOfJob:ListOfPriority
    {
        public int index { get; set; }
        public bool isEmpty = true;//האם המשרה פנויה

        public PriorityOfJob(int id_job) : base(id_job) { 

        }

        

    }
}
