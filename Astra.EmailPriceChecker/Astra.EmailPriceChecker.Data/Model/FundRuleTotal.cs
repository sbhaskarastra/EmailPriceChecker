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
    
    public partial class FundRuleTotal
    {
        public int Id { get; set; }
        public int FundRuleId { get; set; }
        public System.DateTime DateEntered { get; set; }
        public double GavAmount { get; set; }
        public double FundAmount { get; set; }
        public double PercentageAmount { get; set; }
    
        public virtual FundRule FundRule { get; set; }
    }
}
