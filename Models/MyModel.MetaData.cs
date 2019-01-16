using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyRichTextMVC.Helper;

namespace MyRichTextMVC.Models
{
    [MetadataType(typeof(MyModelMetaData))]
    public partial class MyModel
    {
        
    }

    public partial class MyModelMetaData
    {
        [Display(Name = "My Html Data")]
        [AllowHtml] 
        public string MyHtmlData { get; set; }
    }


}
