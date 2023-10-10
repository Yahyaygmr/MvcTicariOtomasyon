using MvcTicariOtomasyon.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTicariOtomasyon.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        Context c = new Context();
        public ActionResult Index()
        {
            var urunler = c.Uruns.Where(x => x.Durum == true).ToList();

            return View(urunler);
        }
        [HttpGet]
        public ActionResult UrunEkle()
        {
            List<SelectListItem> kategori = (from x in c.Kategoris.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.KategoriAd,
                                                 Value = x.KategıriId.ToString()
                                             }).ToList();
            ViewBag.Kategori = kategori;
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Urun urun)
        {
            c.Uruns.Add(urun);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UrunSil(int id)
        {
            var urun = c.Uruns.Find(id);
            urun.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UrunGuncelle(int id)
        {
            List<SelectListItem> kategori = (from x in c.Kategoris.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.KategoriAd,
                                                 Value = x.KategıriId.ToString()
                                             }).ToList();
            ViewBag.Kategori = kategori;
            var urun = c.Uruns.Find(id);
            return View(urun);
        }
        [HttpPost]
        public ActionResult UrunGuncelle(Urun urun)
        {
            var value = c.Uruns.Find(urun.UrunId);
            value.UrunAd = urun.UrunAd;
            value.Durum = urun.Durum;
            value.AlisFiyat = urun.AlisFiyat;
            value.SatisFiyat = urun.SatisFiyat;
            value.Stok = urun.Stok;
            value.KategıriId = urun.KategıriId;
            value.Marka = urun.Marka;
            value.UrunGorsel = urun.UrunGorsel;
            c.SaveChanges();
            return View();
        }
    }
}