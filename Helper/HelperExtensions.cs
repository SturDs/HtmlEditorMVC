using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;

namespace MyRichTextMVC.Helper
{
    public static class HelperExtensions
    {
        public static MvcHtmlString Word(this HtmlHelper html, myWordParam oWord)
        {
            return html.Partial("~/Views/Shared/_Word.cshtml", oWord);
        }
    } 
    
    /* Here is just simple few properties so you can add them more as you wish to  */
    public class myWordParam
    {
        //--- Name ID of the object
        public string NameID { get; set; }
        
        //--- Content in HTML
        public string Content { get; set; }
        
        //--- size of the HTML Editor
        public string Width { get; set; }
        public string Height { get; set; }

        public myWordParam(string NameID, string Content, string Width, string Height)
        {
            this.NameID = NameID;
            this.Content = Content;
            this.Width = Width;
            this.Height = Height;
        }
    }
}
