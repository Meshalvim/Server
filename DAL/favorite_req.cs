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
    
    public partial class favorite_req
    {
        public int id_candidate { get; set; }
        public int id_req { get; set; }
        public Nullable<int> num_priority { get; set; }
    
        public virtual candidate candidate { get; set; }
        public virtual requirement requirement { get; set; }
    }
}
