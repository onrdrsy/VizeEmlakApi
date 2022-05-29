using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VizeEmlakApi.Models;
using VizeEmlakApi.ViewModel;

namespace VizeEmlakApi.Auth
{
    public class UyeService
    { 
        DBEmlakEntities db = new DBEmlakEntities();

        public UyelerModel UyeOturumAc(string mail, string parola)
        {
            UyelerModel uye = db.Uyeler.Where(s => s.UyeMail == mail && s.UyeParola == parola).Select(x => new UyelerModel() {

                UyeId = x.UyeId,
                UyeAd = x.UyeAd,
                UyeSoyad = x.UyeSoyad,
                UyeTelefon = x.UyeTelefon,
                UyeMail = x.UyeMail,
                UyeParola = x.UyeParola,
                UyeYetki = x.UyeYetki,
                UyeKayTar = x.UyeKayTar

            }).SingleOrDefault();
            return uye;        
        }
    }
}