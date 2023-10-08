using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTicariOtomasyon.Models.Siniflar
{
    public class Kategori
    {
        [Key]
        public int KategıriId { get; set; }
        public string KategoriAd { get; set; }
    }
}