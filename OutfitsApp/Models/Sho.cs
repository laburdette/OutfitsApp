//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OutfitsApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Sho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sho()
        {
            this.Outfits = new HashSet<Outfit>();
        }
    
        public int ShoeID { get; set; }
        [DisplayName("Brand")]
        public string ShoeBrand { get; set; }
        [DisplayName("Style")]
        public string ShoeStyle { get; set; }
        [DisplayName("Color")]
        public string ShoeColor { get; set; }
        [DisplayName("Season")]
        public string ShoeSeason { get; set; }
        [DisplayName("Occasion")]
        public string ShoeOccasion { get; set; }
        [DisplayName("")]
        public string ShoePhoto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Outfit> Outfits { get; set; }
    }
}