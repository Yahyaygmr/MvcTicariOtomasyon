using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTicariOtomasyon.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }

    }
}