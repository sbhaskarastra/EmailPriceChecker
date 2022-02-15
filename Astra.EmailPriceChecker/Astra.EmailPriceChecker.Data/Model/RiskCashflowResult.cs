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
    
    public partial class RiskCashflowResult
    {
        public int Id { get; set; }
        public int RiskCashflowExecutionRunId { get; set; }
        public string Isin { get; set; }
        public decimal Spread0 { get; set; }
        public decimal PresentValue { get; set; }
        public Nullable<decimal> SpreadShiftUpVariance { get; set; }
        public decimal SpreadShiftDownVariance { get; set; }
        public Nullable<decimal> SpreadMultiplierVariance { get; set; }
        public decimal RecoveryShiftDownVariance { get; set; }
        public int SecurityMasterId { get; set; }
    
        public virtual RiskCashflowExecutionRun RiskCashflowExecutionRun { get; set; }
        public virtual SecurityMaster SecurityMaster { get; set; }
    }
}
