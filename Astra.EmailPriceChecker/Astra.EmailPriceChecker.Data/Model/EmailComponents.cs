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
    
    public partial class EmailComponents
    {
        public int Id { get; set; }
        public int EmailId { get; set; }
        public int EmailComponentId { get; set; }
    
        public virtual Email Email { get; set; }
        public virtual EmailComponent EmailComponent { get; set; }
    }
}
