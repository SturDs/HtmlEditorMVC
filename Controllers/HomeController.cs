using MyRichTextMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyRichTextMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyModel myModel = new MyModel();

            return View(myModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(MyModel myModel)
        {
            //--- Content of the HTML Editor we have created in this tutorial
            ViewBag.contentOfHTMLEditor = myModel.MyHtmlData;

            return View(myModel);
        }
    }
}