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
    
    public partial class FundProperty
    {
        public int Id { get; set; }
        public int FundId { get; set; }
        public int FundPropertyDescriptionId { get; set; }
        public string Value { get; set; }
    
        public virtual Funds Funds { get; set; }
        public virtual FundPropertyDescription FundPropertyDescription { get; set; }
    }
}
