        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public async Task<ActionResult> Create(Titolo titolo)
        {
            ViewBag.ToDo = "Create";

            //--- Content of the HTML Editor we have created in this tutorial
            string contentOfHTMLEditor = titolo.MyHtmlData;

            return View(titolo);
        }
