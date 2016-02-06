using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminPanelMVC.Controllers
{
    public class BootstrapUIController : Controller
    {
        // GET: BootstrapUI
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tabbed()
        {
            List<string> categories = new List<string>()
            {
                "Pizza","Sandwich"
            };
            Dictionary<string, string> fooDictionary = new Dictionary<string, string>();
            fooDictionary.Add("Burger", @"If you're still using an old, personal address that makes you look unprofessional--like cutiepie619@yahoo.com--dump it quick and get one that makes you look like the seasoned pro that you are.");
            fooDictionary.Add("Pizza", @"Really? Mowing lawns during summer vacations and babysitting are not confidence builders for your prospective employers.");
            fooDictionary.Add("Sandwich", @"Misspelled words, poor grammar, and typos will make you look totally unprofessional. Proofread your LinkedIn profile and résumé several times, and also have others proof it for you.");
            ViewBag.FooDictionary = fooDictionary;

            //foreach (KeyValuePair<string, string> item in fooDictionary)
            //{
            //    var a = item.Key;
            //    var b = item.Value;
            //}
            return View();
        }

        public ActionResult Breadcrumbs()
        {
            return View();
        }
        public ActionResult BC1()
        {
            return View();
        }
        public ActionResult BC2()
        {
            return View();
        }
    }
}