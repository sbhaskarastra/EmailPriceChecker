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
    
    public partial class RiskCashflowExecution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RiskCashflowExecution()
        {
            this.RiskCashflowExecutionRun = new HashSet<RiskCashflowExecutionRun>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> ExecutionStartTime { get; set; }
        public Nullable<System.DateTime> ExecutionEndTime { get; set; }
        public System.DateTime InsertDateTime { get; set; }
        public int StatusId { get; set; }
        public int UserId { get; set; }
    
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiskCashflowExecutionRun> RiskCashflowExecutionRun { get; set; }
    }
}
