using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RYWebsite.Models
{
    [SitecoreType(AutoMap = true)]
    public class Banner
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public string LinkText { get; set; }
        public Link LinkButton { get; set; }
        [SitecoreChildren(InferType = true)]
        //public  List<FooterItems> Children { get; set; }
        public IEnumerable<Images> Children { get; set; }

    }
}