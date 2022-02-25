//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Transportes_Canas
{
    using System;
    using System.Collections.Generic;
    
    public partial class VehicleModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehicleModel()
        {
            this.Trucks = new HashSet<Truck>();
            this.TruckBoxes = new HashSet<TruckBox>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdVehicleBrand { get; set; }
    
        public virtual VehicleBrand VehicleBrand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Truck> Trucks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TruckBox> TruckBoxes { get; set; }
    }
}