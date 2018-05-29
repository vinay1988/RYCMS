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
    public class ExecutiveItem
    {
        public string Title { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public Image Image { get; set; }
    }
}