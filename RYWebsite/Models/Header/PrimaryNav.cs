using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace RYWebsite.Models
{
    [SitecoreType(AutoMap =true)]
    public class PrimaryNav
    {
        public string Title { get; set; }
        public string Description { get; set; }
        //[SitecoreField("Show in Navigation")]
        //public string ShowinNav { get; set; }
        [SitecoreChildren(InferType = true)]
        public IEnumerable<SitecoreItem> NavItems { get; set; }
    }
}