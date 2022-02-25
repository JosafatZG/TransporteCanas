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
    
    public partial class WorkTrip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkTrip()
        {
            this.Assignments = new HashSet<Assignment>();
        }
    
        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdDestination { get; set; }
        public int IdOrigin { get; set; }
        public decimal Price { get; set; }
        public decimal MotoristPayment { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Assignment> Assignments { get; set; }
        public virtual Client Client { get; set; }
        public virtual DestinationPlace DestinationPlace { get; set; }
        public virtual OriginPlace OriginPlace { get; set; }
    }
}
