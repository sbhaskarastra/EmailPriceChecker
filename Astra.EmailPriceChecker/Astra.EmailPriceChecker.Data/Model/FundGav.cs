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
    
    public partial class FundGav
    {
        public int Id { get; set; }
        public int FundId { get; set; }
        public System.DateTime GavDate { get; set; }
        public double Principal { get; set; }
        public double Interest { get; set; }
        public double Expenses { get; set; }
        public double Gav { get; set; }
        public int ISOCode { get; set; }
        public System.DateTime InsertDateTime { get; set; }
        public Nullable<double> Accrual { get; set; }
        public Nullable<decimal> NumberOfShares { get; set; }
    
        public virtual Funds Funds { get; set; }
    }
}
