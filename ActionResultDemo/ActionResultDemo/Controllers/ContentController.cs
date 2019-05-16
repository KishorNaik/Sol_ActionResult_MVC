using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActionResultDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActionResultDemo.Controllers
{
    public class ContentController : Controller
    {
        //ViewResult
        public ViewResult Index()
        {
            return View();
        }


        //partialViewResult
        public PartialViewResult AddressList()
        {
            return PartialView("_Address");
        }

        //contentresullt
        public ContentResult GetName()
        {
            return Content("<h3> Namrata Korgaonkar </h3>");
        }

        //emptyresult
        public EmptyResult Nothing()
        {
            return new EmptyResult();
        }

        public ActionResult GetEmployee()
        {
            try
            {
                //some checks

            }
            catch
            {

            }
            return null;
        }

        //fileresult
        public FileResult GetFile()
        {
            string FilePath = "C:\\testforfile.txt";
            var Bytes = System.IO.File.ReadAllBytes(FilePath);
            return this.File(Bytes,"Text/Plain","Test.txt");

        }

        //jsonresult
        public JsonResult GetStudentdetails()
        {
            //single object
            var student = new Student() { FirstName = "Namrata", LastName = "K", Age = 33 };

            //list object
            //var StudentList = new List<Student>()
            //{
            //    new Student {FirstName="Tripti",LastName="Vyas",Age=24},
            //    new Student{FirstName="Pooja",LastName="Patil", Age=24}
            //};

            return Json(student);
        }

    }
}