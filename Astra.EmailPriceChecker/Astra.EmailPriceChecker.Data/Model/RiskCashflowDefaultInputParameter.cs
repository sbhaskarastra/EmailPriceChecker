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
    
    public partial class RiskCashflowDefaultInputParameter
    {
        public int Id { get; set; }
        public string Isin { get; set; }
        public System.DateTime SettleDate { get; set; }
        public Nullable<decimal> MortgageFaceAmount { get; set; }
        public string ScenarioName { get; set; }
        public string AssumptionName { get; set; }
        public string MortgagePrepaySpeed { get; set; }
        public string MortgagePrepayType { get; set; }
        public string PrepaySpeedVector { get; set; }
        public string DefaultPercent { get; set; }
        public string DefaultType { get; set; }
        public string DefaultSpeedVector { get; set; }
        public string LossSeverity { get; set; }
        public string RecoveryLag { get; set; }
        public string ApplyForwardRate { get; set; }
        public string InsuranceWarp { get; set; }
        public string MortgageIndexUsedSubPerSettle { get; set; }
        public string AlloyDynamicCashflowCalculations { get; set; }
        public Nullable<decimal> SpreadAdjuster { get; set; }
        public Nullable<decimal> RecoveryAdjuster { get; set; }
        public Nullable<decimal> SpreadMultiplier { get; set; }
        public Nullable<decimal> RecoveryMultiplier { get; set; }
        public Nullable<decimal> Recovery { get; set; }
    }
}