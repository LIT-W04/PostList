using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    //Flavor
    //Price
    //IsWithCone -- boolean

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void SubmitFlavors(List<string> flavors)
        {
            string all = String.Join("<br />", flavors);
            Response.Write($"<h2>{all}</h2>");
        }

        public ActionResult ShowAddPeople()
        {
            return View();
        }

        [HttpPost]
        public void SubmitPeople(List<Person> people)
        {
            string all = String.Join("<br />",
                people.Select(p => $"{p.FirstName} - {p.LastName} - {p.Age}"));
            Response.Write($"<h2>{all}</h2>");
        }

        public ActionResult AddIceCreams()
        {
            return View();
        }

        [HttpPost]
        public void AddIceCreams(List<IceCream> iceCreams)
        {
            string all = String.Join("<br />",
               iceCreams.Select(i => $"{i.Flavor} - {i.Price.ToString("C")} - {i.IsWithCone}"));
            Response.Write($"<h2>{all}</h2>");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class IceCream
    {
        public string Flavor { get; set; }
        public decimal Price { get; set; }
        public bool IsWithCone { get; set; }
    }
}