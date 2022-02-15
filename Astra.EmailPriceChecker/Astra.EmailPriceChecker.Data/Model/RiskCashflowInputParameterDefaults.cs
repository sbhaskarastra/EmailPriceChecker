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
    
    public partial class RiskCashflowInputParameterDefaults
    {
        public int Id { get; set; }
        public string Isin { get; set; }
        public Nullable<decimal> SpreadShift { get; set; }
        public Nullable<decimal> SpreadMultiplier { get; set; }
        public Nullable<decimal> RecoveryShift { get; set; }
        public Nullable<decimal> RecoveryMultiplier { get; set; }
        public Nullable<decimal> Recovery { get; set; }
        public int SecurityMasterId { get; set; }
    
        public virtual SecurityMaster SecurityMaster { get; set; }
    }
}