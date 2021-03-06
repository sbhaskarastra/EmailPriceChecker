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
    
    public partial class ScheduledCashFlow
    {
        public int Id { get; set; }
        public string ISIN { get; set; }
        public int TradeReference { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        public System.DateTime LastUpdateTime { get; set; }
        public string UpdatedBy { get; set; }
        public int IsoCode { get; set; }
        public Nullable<int> PNR { get; set; }
        public Nullable<int> TradeId { get; set; }
        public Nullable<bool> Reconciled { get; set; }
    
        public virtual Trades Trades { get; set; }
    }
}
