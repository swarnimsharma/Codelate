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
    
    public partial class portal_recruiter_profile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public portal_recruiter_profile()
        {
            this.portal_for_interested_Candidate = new HashSet<portal_for_interested_Candidate>();
        }
    
        public int pk_resource_profile_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email_id { get; set; }
        public string contact_no { get; set; }
        public Nullable<int> fk_state_id { get; set; }
        public Nullable<int> fk_city_id { get; set; }
        public Nullable<int> fk_country_id { get; set; }
        public bool is_active { get; set; }
        public bool is_deleted { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public Nullable<System.DateTime> updated_date { get; set; }
        public string minimum_tenure { get; set; }
        public Nullable<int> fk_experience_level { get; set; }
        public string expertise_profession { get; set; }
        public string availablity { get; set; }
        public string about_us { get; set; }
        public string profile_pic { get; set; }
        public Nullable<int> fk_vendor_id { get; set; }
        public Nullable<int> job_type { get; set; }
    
        public virtual portal_city portal_city { get; set; }
        public virtual portal_country portal_country { get; set; }
        public virtual portal_experience portal_experience { get; set; }
        public virtual portal_state portal_state { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<portal_for_interested_Candidate> portal_for_interested_Candidate { get; set; }
    }
}
