using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Mvc;
using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Configuration.Attributes;


namespace RYWebsite.Models
{
    [SitecoreType(AutoMap = true)]
    public class FooterModel
    {
        public Image Logo { get; set; }

        [SitecoreField("Copyright Text")]
       public  string copyrightText { get; set; }

        [SitecoreChildren(InferType = true)]
        //public  List<FooterItems> Children { get; set; }
        public IEnumerable<FooterItems> Children { get; set; }

    }
}