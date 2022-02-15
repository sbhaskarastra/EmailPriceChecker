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
    
    public partial class ShareSeries
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShareSeries()
        {
            this.ShareSeriesAmount = new HashSet<ShareSeriesAmount>();
            this.ShareSeriesInvestor = new HashSet<ShareSeriesInvestor>();
            this.ShareSeriesPerformanceSummary = new HashSet<ShareSeriesPerformanceSummary>();
            this.ShareSeriesSummary = new HashSet<ShareSeriesSummary>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public int ShareClassId { get; set; }
        public decimal NavPerUnit { get; set; }
        public decimal GavPerUnit { get; set; }
        public System.DateTime InsertDateTime { get; set; }
        public System.DateTime EffectiveFrom { get; set; }
        public int InsertedBy { get; set; }
        public Nullable<int> Active { get; set; }
        public Nullable<int> ActiveSummary { get; set; }
    
        public virtual ShareClass ShareClass { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShareSeriesAmount> ShareSeriesAmount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShareSeriesInvestor> ShareSeriesInvestor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShareSeriesPerformanceSummary> ShareSeriesPerformanceSummary { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShareSeriesSummary> ShareSeriesSummary { get; set; }
    }
}
