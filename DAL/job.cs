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
    
    public partial class job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public job()
        {
            this.days_of_jobs = new HashSet<days_of_jobs>();
            this.requiers_to_jobs = new HashSet<requiers_to_jobs>();
            this.schedulings = new HashSet<scheduling>();
            this.score_of_jobs = new HashSet<score_of_jobs>();
        }
    
        public int id_job                       { get; set; }
        public Nullable<int> id_comp            { get; set; }
        public Nullable<int> id_city            { get; set; }
        public string        age_range         { get; set; }
        public Nullable<int> id_gender          { get; set; }
        public string        seniority_range { get; set; }
        public Nullable<int> amount                 { get; set; }
    
        public virtual city city { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<days_of_jobs> days_of_jobs { get; set; }
        public virtual gender gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<requiers_to_jobs> requiers_to_jobs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<scheduling> schedulings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<score_of_jobs> score_of_jobs { get; set; }
        public virtual company company { get; set; }
    }
}
