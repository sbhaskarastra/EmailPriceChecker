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
    
    public partial class SubscriptionRedemption
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubscriptionRedemption()
        {
            this.Trades = new HashSet<Trades>();
        }
    
        public int Id { get; set; }
        public int InvestorId { get; set; }
        public int ShareSeriesId { get; set; }
        public System.DateTime SettlementDate { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public int SubscriptionRedemptionTypeId { get; set; }
        public Nullable<decimal> SharePrice { get; set; }
        public Nullable<decimal> NumberOfShares { get; set; }
        public decimal Amount { get; set; }
        public Nullable<decimal> RetentionPercentage { get; set; }
        public int InsertedBy { get; set; }
        public System.DateTime InsertDateTime { get; set; }
    
        public virtual SubscriptionRedemptionType SubscriptionRedemptionType { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trades> Trades { get; set; }
    }
}
