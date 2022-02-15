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
    
    public partial class Rules
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rules()
        {
            this.FundRule = new HashSet<FundRule>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public int RuleTypeId { get; set; }
        public Nullable<double> MaxPercentageExposureIssuers { get; set; }
        public Nullable<int> MaxPercentageExposureNumberOfIssuers { get; set; }
        public Nullable<double> MaxPercentageExposureNonFinancialCorporate { get; set; }
        public Nullable<double> MaxPercentageExposureCounterParty { get; set; }
        public Nullable<int> MaxPercentageExposureNumberOfCounterparties { get; set; }
        public Nullable<double> MaxPercentageEmergingMarkets { get; set; }
        public Nullable<int> MaxPercentageEquitySecurities { get; set; }
        public Nullable<int> MaxPercentageCommodityAssets { get; set; }
        public Nullable<double> MaxPercentageSecurityConcentration { get; set; }
        public Nullable<int> MaxPercentageSecurityConcentrationNumberOfSecurities { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FundRule> FundRule { get; set; }
        public virtual RuleType RuleType { get; set; }
    }
}
