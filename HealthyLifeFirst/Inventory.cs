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
    
    public partial class Inventory
    {
        public string ItemID { get; set; }
        public double QuantityBalance { get; set; }
        public double QuantityOnOrder { get; set; }
        public string UnitOfMeasure { get; set; }
        public string Location { get; set; }
    
        public virtual Item Item { get; set; }
    }
}
