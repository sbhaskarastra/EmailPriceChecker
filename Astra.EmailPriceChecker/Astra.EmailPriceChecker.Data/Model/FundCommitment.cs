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
    
    public partial class FundCommitment
    {
        public int Id { get; set; }
        public int FundId { get; set; }
        public decimal Amount { get; set; }
        public int PayReceive { get; set; }
        public string Comments { get; set; }
        public System.DateTime InsertDateTime { get; set; }
        public int UserId { get; set; }
    
        public virtual FundCommitmentPayReceive FundCommitmentPayReceive { get; set; }
        public virtual Funds Funds { get; set; }
        public virtual Users Users { get; set; }
    }
}