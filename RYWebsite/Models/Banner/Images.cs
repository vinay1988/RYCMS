using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RYWebsite.Models
{
    [SitecoreType(AutoMap = true)]
    public class Images
    {
        public string AltText { get; set; }
        public Image Image { get; set; }
     
    }
}