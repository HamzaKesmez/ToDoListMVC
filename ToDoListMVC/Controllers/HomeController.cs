using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoListMVC.Models;

namespace ToDoListMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Listele()
        {
            Contex db =new Contex();
            ViewBag.List = db.Lists.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Kaydet(List l)
        {
            Contex db = new Contex();
            db.Lists.Add(l);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }
        [HttpPost]
        public ActionResult Duzenle(List D)
        {
            Contex db = new Contex();
            List KL = db.Lists.FirstOrDefault(x => x.id == D.id);
            KL.Title = D.Title;
            KL.Description = D.Description;
            db.SaveChanges();
            return RedirectToAction("Listele");
        }

        public ActionResult Sil(int id)
        {
            Contex db = new Contex();
            List silinecek = db.Lists.FirstOrDefault(x => x.id == id);
            db.Lists.Remove(silinecek);
            db.SaveChanges();
            return RedirectToAction("Listele");
        }

    }
}
