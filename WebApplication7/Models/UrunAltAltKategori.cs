//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication7.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UrunAltAltKategori
    {
        public UrunAltAltKategori()
        {
            this.UrunAltAltAltKategori = new HashSet<UrunAltAltAltKategori>();
        }
    
        public long AltAltKategoriID { get; set; }
        public long AltKategori { get; set; }
        public string Adi { get; set; }
        public System.Guid RowGuid { get; set; }
        public System.DateTime GuncellemeTarihi { get; set; }
    
        public virtual ICollection<UrunAltAltAltKategori> UrunAltAltAltKategori { get; set; }
        public virtual UrunAltKategori UrunAltKategori { get; set; }
    }
}
