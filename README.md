# RichTextHtmlEditorMVC
This is a Rich Text HTML Editor in MVC Razor

It easy to use and custom as you like.

Just you need to write this below in your Razor file:
        @HelperExtensions.Word(Html, new myWordParam("MyHtmlData", Model.MyHtmlData, "100%", "400px"))

I used HelperExtensions to create:
        public static MvcHtmlString Word(this HtmlHelper html, myWordParam oWord)
        {
            return html.Partial("~/Views/Shared/_Word.cshtml", oWord);
        }
        
The Editor in HTML with few buttons are in "_Word.cshtml".

...and here is how to get it on your Controller:

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
