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
    
    public partial class candidate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public candidate()
        {
            this.days_of_candidates = new HashSet<days_of_candidates>();
            this.favorite_req = new HashSet<favorite_req>();
            this.schedulings = new HashSet<scheduling>();
        }
    
        public int id_candidate { get; set; }
        public string Id_number { get; set; }
        public string name_ { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public Nullable<int> id_city { get; set; }
        public Nullable<int> id_gender { get; set; }
        public Nullable<int> age { get; set; }
        public Nullable<double> seniority { get; set; }
        public Nullable<int> price { get; set; }
        public string password_ { get; set; }
    
        public virtual city city { get; set; }
        public virtual gender gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<days_of_candidates> days_of_candidates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<favorite_req> favorite_req { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<scheduling> schedulings { get; set; }
    }
}
