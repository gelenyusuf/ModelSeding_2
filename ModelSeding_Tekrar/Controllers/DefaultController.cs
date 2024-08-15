using Microsoft.AspNetCore.Mvc;
using ModelSeding_Tekrar.Models.PageVM;
using ModelSeding_Tekrar.Models.Tools;

namespace ModelSeding_Tekrar.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {

            List<Calisan> Calisan = new List<Calisan>() {

                             new(){ ID=1,Ad="Mete", Soyad="Kara",Yas="19" },
                             new(){ ID=2,Ad="Deniz", Soyad="Demir",Yas="65" },
                             new(){ ID=3,Ad="Pırıl", Soyad="Cakar",Yas="26" }

            };

            Yonetici y = new Yonetici() { 
              ID = 1,
              Ad="Mehmet",
              Soyad="Çakır",
              Departman = "Yazılım"
            };
            GetCalisan gc = new()
            {
               Calisanlar = Calisan,
               Yonetici = y
            };

            return View(gc);
        }
    }
}
