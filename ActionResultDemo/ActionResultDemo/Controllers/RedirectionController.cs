using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ActionResultDemo.Controllers
{
    public class RedirectionController : Controller
    {
        public RedirectResult Index()
        {
            return Redirect("https://www.google.com");
        }


        //redirecttoactionresult
        public RedirectToActionResult GotoContent()
        {
            //same controller, different action
            //return RedirectToAction("Index");

            //different controller,different action
            return RedirectToAction("GetStudentdetails", "Content");
        }
    }
}