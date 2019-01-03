using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcday2.Controllers
{
    public class homeController : Controller
    {
        public ActionResult newemployee()
        {
            List<SelectListItem> cities = new List<SelectListItem>();
            cities.Add(new SelectListItem { Text = "select", Value = "" });
            cities.Add(new SelectListItem { Text = "bang", Value = "bang" });
            cities.Add(new SelectListItem { Text = "chennai", Value = "chennai" });
            ViewBag.cities = cities;

            return View();
        }
        [HttpPost]
        public ActionResult newemployee(string empname,string empcity,
            string empgender,HttpPostedFileBase empimage)
        {
            string address = "/images/" + Guid.NewGuid() + ".jpg";

            empimage.SaveAs(Server.MapPath(address));
            ViewBag.address = address;
            ViewBag.msg = "Employee added";

            List<SelectListItem> cities = new List<SelectListItem>();
            cities.Add(new SelectListItem { Text = "select", Value = "" });
            cities.Add(new SelectListItem { Text = "bang", Value = "bang" });
            cities.Add(new SelectListItem { Text = "chennai", Value = "chennai" });
            ViewBag.cities = cities;

            ModelState.Clear();
            return View();
        }

    }
}