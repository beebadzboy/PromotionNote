//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.DBModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class promo_note_detail
    {
        public long id { get; set; }
        public long header_id { get; set; }
        public int row_number { get; set; }
        public byte[] promo_file { get; set; }
        public string modified_by { get; set; }
        public System.DateTime modified_date { get; set; }
    
        public virtual promo_note_header promo_note_header { get; set; }
    }
}
