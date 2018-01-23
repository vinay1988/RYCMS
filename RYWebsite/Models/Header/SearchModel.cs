using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RYWebsite.Models
{
    [SitecoreType (AutoMap = true)]
    public class SearchModel
    {
        [SitecoreField("Placeholder Text")]
        public string PlaceholderText { get; set; }
    }
}