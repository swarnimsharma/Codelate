//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Portal.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class portal_for_interested_Candidate
    {
        public int pk_candidate_interested_id { get; set; }
        public string requirement_title_select { get; set; }
        public string requirement_title { get; set; }
        public Nullable<int> fk_user_id { get; set; }
        public System.DateTime requested_date { get; set; }
        public bool is_active { get; set; }
        public Nullable<int> fk_candidate_id { get; set; }
        public int status { get; set; }
        public Nullable<int> fk_vendor_id { get; set; }
    
        public virtual portal_user portal_user { get; set; }
        public virtual portal_recruiter_profile portal_recruiter_profile { get; set; }
    }
}