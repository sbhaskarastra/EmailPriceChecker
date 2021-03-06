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
    
    public partial class RiskExecutionTaskCreditShiftRun
    {
        public int Id { get; set; }
        public string Isin { get; set; }
        public string Description { get; set; }
        public string Cusip { get; set; }
        public decimal CreditSpread { get; set; }
        public decimal Recovery { get; set; }
        public decimal Wal { get; set; }
        public Nullable<decimal> PoolExpectedLossDifference { get; set; }
        public Nullable<decimal> SeniorExpectedLoss { get; set; }
        public Nullable<decimal> MezzExpectedLoss { get; set; }
        public Nullable<decimal> JuniorExpectedLoss { get; set; }
        public Nullable<decimal> SeniorExpectedPresentValueLoss { get; set; }
        public Nullable<decimal> MezzExpectedPresentValueLoss { get; set; }
        public Nullable<decimal> JuniorExpectedPresentValueLoss { get; set; }
        public Nullable<int> RiskExecutionTaskInputParameterRunId { get; set; }
        public Nullable<decimal> Position { get; set; }
        public Nullable<int> RiskPoolId { get; set; }
    
        public virtual RiskExecutionTaskInputParameterRun RiskExecutionTaskInputParameterRun { get; set; }
        public virtual RiskPool RiskPool { get; set; }
    }
}
