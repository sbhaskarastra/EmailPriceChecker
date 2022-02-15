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
    
    public partial class ShareSeriesPerformanceSummary
    {
        public int Id { get; set; }
        public int ShareSeriesId { get; set; }
        public System.DateTime SummaryDate { get; set; }
        public Nullable<decimal> NumberOfShares { get; set; }
        public decimal ShareSeriesNav { get; set; }
        public Nullable<decimal> ShareSeriesNavPerShare { get; set; }
        public decimal ShareSeriesGav { get; set; }
        public Nullable<decimal> ShareSeriesGavPerShare { get; set; }
        public decimal CrystalisedPerfromanceAmount { get; set; }
        public decimal UncrystalisedPerfromanceAmount { get; set; }
        public Nullable<decimal> CrystalisedPerfromancePerShare { get; set; }
        public Nullable<decimal> UncrystalisedPerfromancePerShare { get; set; }
        public System.DateTime InsertDateTime { get; set; }
        public int InsertedBy { get; set; }
        public Nullable<System.DateTime> ApprovedDateTime { get; set; }
        public Nullable<int> ApprovedBy { get; set; }
    
        public virtual ShareSeries ShareSeries { get; set; }
        public virtual Users Users { get; set; }
    }
}