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
    
    public partial class portal_vendor_price_plan
    {
        public int pk_vendor_plan_price_id { get; set; }
        public Nullable<double> per_candidate_listing_price { get; set; }
        public Nullable<double> per_interest_received_price { get; set; }
        public Nullable<double> per_leads_access_price { get; set; }
        public Nullable<double> per_technology_price { get; set; }
        public Nullable<bool> is_active { get; set; }
        public Nullable<bool> is_deleted { get; set; }
    }
}
