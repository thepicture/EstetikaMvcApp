//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Estetika
{
    using System;
    using System.Collections.Generic;
    
    public partial class Variant
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Variant()
        {
            this.Otvet = new HashSet<Otvet>();
        }
    
        public int ID_Variant { get; set; }
        public int ID_Vopros { get; set; }
        public string Tekst { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Otvet> Otvet { get; set; }
        public virtual Vopros Vopros { get; set; }
    }
}