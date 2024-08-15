using Microsoft.AspNetCore.Mvc;
using ModelSeding_Tekrar.Models.Tools;
namespace ModelSeding_Tekrar.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            List<Calisan> Kisi = new List<Calisan>() {

                    new(){ID=1,Ad="Veli",Soyad="Kurt",Yas="38" },
                    new(){ID=2,Ad="Zeki",Soyad="Çevik",Yas="25" },
                    new(){ID=3,Ad="Aslı",Soyad="Çekiç",Yas="55" },
                    new(){ID=4,Ad="Mine",Soyad="Su",Yas="44" }
            };
            return View(Kisi);


        }
    }
}
