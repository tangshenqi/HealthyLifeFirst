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
    
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.Order = new HashSet<Order>();
            this.Sourcing = new HashSet<Sourcing>();
        }
    
        public string ItemID { get; set; }
        public string ItemType { get; set; }
        public string ItemMainCategory { get; set; }
        public string ItemSubCategory { get; set; }
        public string ItemBrand { get; set; }
        public string ItemDescription { get; set; }
        public string ActiveIngredient { get; set; }
        public string StorageBelowTemp { get; set; }
        public string IsSunlightSensitive { get; set; }
        public string DosageFrequency { get; set; }
        public string CauseDrowsiness { get; set; }
        public string CauseGastric { get; set; }
        public double SalePrice { get; set; }
        public string Remarks { get; set; }
        public string ByCourse { get; set; }
    
        public virtual Inventory Inventory { get; set; }
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sourcing> Sourcing { get; set; }
    }
}
