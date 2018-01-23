using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System.Web.Script.Serialization;

namespace RYWebsite.Models
{
    [SitecoreType(AutoMap = true)]
    public class MediaCardModel
    {

        [SitecoreChildren(InferType = true)]
        //public  List<FooterItems> Children { get; set; }
        public IEnumerable<MediaCardItem> Children { get; set; }

    }
}