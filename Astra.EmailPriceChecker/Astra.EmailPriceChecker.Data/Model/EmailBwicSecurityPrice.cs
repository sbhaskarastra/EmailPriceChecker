//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Astra.EmailPriceChecker.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmailBwicSecurityPrice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmailBwicSecurityPrice()
        {
            this.EmailBwicSecurityLatestPrice = new HashSet<EmailBwicSecurityLatestPrice>();
        }
    
        public int Id { get; set; }
        public string Isin { get; set; }
        public string Price { get; set; }
        public System.DateTime InsertDateTime { get; set; }
        public string OriginalLine { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailBwicSecurityLatestPrice> EmailBwicSecurityLatestPrice { get; set; }
    }
}
