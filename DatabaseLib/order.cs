//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public int order_id { get; set; }
        public Nullable<int> extracted_info { get; set; }
        public Nullable<int> payment_info { get; set; }
        public string raw_text { get; set; }
        public int order_status { get; set; }
        public Nullable<int> created_by { get; set; }
        public System.DateTime created_on { get; set; }
    
        public virtual extracted_infos extracted_infos { get; set; }
        public virtual payment payment { get; set; }
        public virtual status status { get; set; }
        public virtual user user { get; set; }
    }
}