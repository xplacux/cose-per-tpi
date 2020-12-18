using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Placucci.Gabriele._5H.PrimaWeb.Models;

namespace Placucci.Gabriele._5H.PrimaWeb.Controllers
{
    public class HomeController : Controller
    {

       static List<Prenotazione> prenotazioni = new List<Prenotazione>();

        public IActionResult Index()
        {
            //istanzio un contest
            var db = new PrenotazioneContext();
            
            // aggiungo un record alla taballa prenotazioni
                
                db.Prenotazioni.Add(new Prenotazione { Nome = "kevin", Email="lulu@gmail.com" });
                db.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult Prenota() //non ha parametri
        {
            return View();
        }

        [HttpPost]
        public IActionResult Prenota(Prenotazione p) //come valore ha 'p', p è una prenotazione, della classe prenota, che contiene nome ed email
        {
           prenotazioni.Add(p);

            return View("Grazie" , prenotazioni); //se va tutto bene richiama 'Grazie' , altrimenti ci ri porta a 'p' (prenota)
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
