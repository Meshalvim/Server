//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class score_of_jobs
    {
        public int id_score_of_jobs { get; set; }
        public Nullable<int> id_job { get; set; }
        public Nullable<double> score_time { get; set; }
        public Nullable<double> score_gender { get; set; }
        public Nullable<double> score_age { get; set; }
        public Nullable<double> score_seniority { get; set; }
    
        public virtual job job { get; set; }
    }
}
