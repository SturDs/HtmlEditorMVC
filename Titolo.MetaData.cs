using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VirtualFid.Helper;
using VirtualFid.Resources;

namespace VirtualFid.Models
{
    [MetadataType(typeof(TitoloMetaData))]
    public partial class Titolo
    {
        
    }

    public partial class TitoloMetaData
    {
        [AllowHtml]
        public string MyHtmlData { get; set; }
    }


}
