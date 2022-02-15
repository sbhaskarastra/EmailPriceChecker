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
    
    public partial class FundRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FundRule()
        {
            this.FundRuleBreach = new HashSet<FundRuleBreach>();
            this.FundRuleTotal = new HashSet<FundRuleTotal>();
        }
    
        public int Id { get; set; }
        public int FundId { get; set; }
        public int RuleId { get; set; }
        public int Active { get; set; }
    
        public virtual Funds Funds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FundRuleBreach> FundRuleBreach { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FundRuleTotal> FundRuleTotal { get; set; }
        public virtual Rules Rules { get; set; }
    }
}
