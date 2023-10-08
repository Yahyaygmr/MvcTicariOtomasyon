using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTicariOtomasyon.Models.Siniflar
{
    public class Departman
    {
        [Key]
        public int DepartmanId { get; set; }
        public string DepartmanAdi { get; set; }

        public ICollection<Personel> Personels { get; set; }
    }
}