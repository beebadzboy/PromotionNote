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
    
    public partial class promo_note_header
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public promo_note_header()
        {
            this.promo_note_detail = new HashSet<promo_note_detail>();
        }
    
        public long id { get; set; }
        public string title { get; set; }
        public byte[] thumbnail { get; set; }
        public string description { get; set; }
        public string modified_by { get; set; }
        public System.DateTime modified_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<promo_note_detail> promo_note_detail { get; set; }
    }
}