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
    
    public partial class AccrualDescription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccrualDescription()
        {
            this.AccrualPayment = new HashSet<AccrualPayment>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public int AccrualGroupId { get; set; }
    
        public virtual AccrualGroup AccrualGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccrualPayment> AccrualPayment { get; set; }
    }
}