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
    
    public partial class Kullanicilar
    {
        public long ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public Nullable<System.DateTime> GüncellemeZamani { get; set; }
        public string Telefon { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string Ulke { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public Nullable<bool> Cinsiyet { get; set; }
        public Nullable<bool> TelefonListesinde { get; set; }
        public Nullable<bool> EmailListesinde { get; set; }
        public string Adres { get; set; }
    }
}
