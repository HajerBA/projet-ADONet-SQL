//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace location
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicule()
        {
            this.Loue = new HashSet<Loue>();
        }
    
        public int ID_V { get; set; }
        public string IMMATRICULATION { get; set; }
        public string Couleur { get; set; }
        public Nullable<System.DateTime> Date_mise_en_service { get; set; }
        public int ID_Categ { get; set; }
        public int ID_marq { get; set; }
    
        public virtual Categorie Categorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loue> Loue { get; set; }
        public virtual Marque Marque { get; set; }
    }
}
