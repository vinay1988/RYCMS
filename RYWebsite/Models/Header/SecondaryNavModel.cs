using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RYWebsite.Models
{
    [SitecoreType(AutoMap = true)]
    public class SecondaryNavModel
    {
        [SitecoreField("Login Text")]
        public string Login { get; set; }
        [SitecoreField("Available Languages")]
        public string AvailLang { get; set; }

        public IEnumerable<Language> LanguageList { get; set; }
    }
}