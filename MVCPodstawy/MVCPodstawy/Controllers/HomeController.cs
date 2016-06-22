using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPodstawy.Models;
namespace MVCPodstawy.Controllers
{
    public class HomeController : Controller
    {
        //Komentarze
        public ActionResult Index()
        {
            var lista = new List<Alb>
            {
            new Alb {Nazwa="Pierwsza",Zawartosc="Pierwsza Zawartosc"},
            new Alb {Nazwa="Druga ",Zawartosc="Druga Zawartosc" },
            new Alb {Nazwa="Trzecia", Zawartosc="Trzecia Zawartosc" }
            };

            ViewBag.AL = lista;


            return View();
        }

        //public string Index(string id)
        //{
        //    return "Witaj, " + id;
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //ViewBag.Test = 12;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}