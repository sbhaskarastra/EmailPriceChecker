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
    
    public partial class TradeExtractionContact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TradeExtractionContact()
        {
            this.FundTradeExtractionTypeContact = new HashSet<FundTradeExtractionTypeContact>();
        }
    
        public int Id { get; set; }
        public string ContactEmailAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FundTradeExtractionTypeContact> FundTradeExtractionTypeContact { get; set; }
    }
}
