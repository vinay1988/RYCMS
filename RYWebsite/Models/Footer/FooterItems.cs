using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace RYWebsite.Models
{
    [SitecoreType(AutoMap = true)]
    public class FooterItems
    {
        public string Title { get; set; }

        public Link Link { get; set; }

        [SitecoreField("Show in Navigation")]
        public bool ShowinNavigation { get; set; }
    }
}