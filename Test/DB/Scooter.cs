//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Scooter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Scooter()
        {
            this.ScooterPhoto = new HashSet<ScooterPhoto>();
            this.ScooterTariff = new HashSet<ScooterTariff>();
        }
    
        public int ID { get; set; }
        public string ModelName { get; set; }
        public byte MaxSpeedInKm { get; set; }
        public byte MaxLoadInKg { get; set; }
        public byte Weight { get; set; }
        public short MiliageOnASingleCharge { get; set; }
        public short ManufacturerID { get; set; }
    
        public virtual Manufacturer Manufacturer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScooterPhoto> ScooterPhoto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScooterTariff> ScooterTariff { get; set; }
    }
}