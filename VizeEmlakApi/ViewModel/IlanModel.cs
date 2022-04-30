using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VizeEmlakApi.ViewModel
{
    public class IlanModel
    {
        public int IlanId { get; set; }
        public string IlanBaslik { get; set; }
        public Nullable<decimal> IlanFiyat { get; set; }
        public Nullable<int> IlanKatId { get; set; }
        public string IlanKatAdi { get; set; }
        public string IlanOda { get; set; }
        public Nullable<int> IlanKatsayısı { get; set; }
        public string IlanAdres { get; set; }
        public Nullable<int> IlanM2 { get; set; }
        public string IlanDurum { get; set; }
        public Nullable<System.DateTime> IlanTarih { get; set; }
        public Nullable<int> IlanBulKat { get; set; }
        public string IlanFoto { get; set; }
        public Nullable<int> IlanUyeId { get; set; }
        public string IlanUyeAdi { get; set; }
        public string IlanUyeTelefon { get; set; }
    }
}