using Microsoft.AspNetCore.Mvc;
using SicilNumarasiMaasHesabiWebApplication.Models;
using System.Diagnostics;

namespace SicilNumarasiMaasHesabiWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(SicilNumarasi sicilNumarasi)
        {
            var sicil_numarasi = sicilNumarasi.SicilNo;
            var calisma_saati = sicilNumarasi.CalismaSaati;
            var saatlik_ucret = sicilNumarasi.SaatlikUcret;
            var hesaplama = calisma_saati * saatlik_ucret;
            ViewBag.Message = "Maaşınız : " +hesaplama;
            return View("sicilNumarasi");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}