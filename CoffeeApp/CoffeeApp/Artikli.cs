//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Artikli
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artikli()
        {
            this.Order_details = new HashSet<Order_detail>();
        }
    
        public int ID_Pica { get; set; }
        public string Naziv_Pica { get; set; }
        public string Kolicina { get; set; }
        public double Cijena { get; set; }
        public int Dostupno_Komada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_detail> Order_details { get; set; }
    }
}
