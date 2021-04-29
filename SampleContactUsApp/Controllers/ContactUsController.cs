using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleContactUsApp.Models;
using SampleContactUsApp.Utilities;
namespace SampleContactUsApp.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContactSave()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactSave(ContactUsForm contactUsForm)
        {
            if (ModelState.IsValid)
            {
                Utility utility = new Utility();
                utility.SaveData(contactUsForm);
                TempData["message"] = "ContactUs Data Saved Successfully";
                ModelState.Clear();
                return View();
            }
            else
            {
                return View(contactUsForm);
            }
        }


    }
}