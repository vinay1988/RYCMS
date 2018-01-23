//using Glass.Mapper.Sc.Configuration.Attributes;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using RYWebsite.Models;

//namespace RYWebsite.Models
//{
//    [SitecoreType(AutoMap = true)]
//    public class HeaderModel
//    {
//        public string Logo { get; set; }
//        public string DataSource { get; set; }

//        [SitecoreField("Search Text")]
//        public string SearchText { get; set; }

//        [SitecoreField("Placeholder Text")]
//        public string PlaceholderText { get; set; }
        
//        [SitecoreField("Log in Text")]
//        public string LoginText { get; set; }

//        [SitecoreField("Available Langaugaes")]
//        public string AvailableLangaugaes { get; set; }


//        //public string Title { get; set; } 

//        //public string description { get; set; }
//        //[SitecoreField("Show in Navigation")]
//        //public bool ShowinNavigation { get; set; }
//        //[SitecoreChildren(InferType = true)]
//        //public virtual IEnumerable<SitecoreItem> ChildElements { get; set; }
//    }
//}