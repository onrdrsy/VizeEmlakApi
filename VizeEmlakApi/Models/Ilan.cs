//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VizeEmlakApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ilan
    {
        public int IlanId { get; set; }
        public string IlanBaslik { get; set; }
        public Nullable<decimal> IlanFiyat { get; set; }
        public Nullable<int> IlanKatId { get; set; }
        public string IlanOda { get; set; }
        public Nullable<int> IlanKatsayısı { get; set; }
        public string IlanAdres { get; set; }
        public Nullable<int> IlanM2 { get; set; }
        public string IlanDurum { get; set; }
        public Nullable<System.DateTime> IlanTarih { get; set; }
        public Nullable<int> IlanBulKat { get; set; }
        public string IlanFoto { get; set; }
        public Nullable<int> IlanUyeId { get; set; }
    
        public virtual Kategori Kategori { get; set; }
        public virtual Uyeler Uyeler { get; set; }
    }
}
