using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RYWebsite.Models
{
    [SitecoreType(AutoMap= true)]
    public class Language
    {
        [SitecoreField("Language Name")]
        public string LangName { get; set; }
        [SitecoreField("Language code")]
        public string LangCode { get; set; }
    }
}