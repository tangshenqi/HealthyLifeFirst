//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HealthyLifeFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Leave
    {
        public string LeaveID { get; set; }
        public string LeaveType { get; set; }
        public double NumberOfDays { get; set; }
        public System.DateTime DateStart { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}