//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uhanov.DataFolder
{
    using System;
    using System.Collections.Generic;
    
    public partial class Adress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adress()
        {
            this.Reader = new HashSet<Reader>();
        }
    
        public int IdAdress { get; set; }
        public int IndexAdress { get; set; }
        public int IdRegion { get; set; }
        public int IdCity { get; set; }
        public int IdStreet { get; set; }
        public int HouseAdress { get; set; }
        public string BuildingHouse { get; set; }
        public int AppartmentHouse { get; set; }
    
        public virtual City City { get; set; }
        public virtual Region Region { get; set; }
        public virtual Street Street { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reader> Reader { get; set; }
    }
}
