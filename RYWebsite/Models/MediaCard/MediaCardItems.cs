using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using System.Web.Script.Serialization;
using Glass.Mapper.Sc.Fields;

namespace RYWebsite.Models
{
    [SitecoreType(AutoMap = true)]
    public class MediaCardItem
    {
        public string Title { get; set; }
        public string Heading { get; set; }
        public string Content { get; set; }
        [ScriptIgnore]
        [SitecoreField("Button Text")]
        public string ButtonText { get; set; }
        [ScriptIgnore]
        [SitecoreField("Button Link")]
        public Link ButtonLink { get; set; }
        public Image Image { get; set; }
    }
}