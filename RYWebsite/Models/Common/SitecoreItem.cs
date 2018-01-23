using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace RYWebsite.Models
{
    [SitecoreType(AutoMap =true)]
    public class SitecoreItem
    {
        public virtual Guid Id { get; set; }

        [ScriptIgnore]
        public string Content
        {
            get;
            set;
        }

        [ScriptIgnore]
        [SitecoreField("__created by")]
        public virtual string CreatedBy
        {
            get;
            set;
        }

        [ScriptIgnore]
        [SitecoreField("__created")]
        public virtual DateTime CreatedDate
        {
            get;
            set;
        }

        [ScriptIgnore]
        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        public virtual string DisplayName
        {
            get;
            set;
        }

        [ScriptIgnore]
        public bool HasRendering
        {
            get
            {
                return Renderings != null;
            }
        }

        [ScriptIgnore]
        public virtual string IndexLanguage
        {
            get;
            set;
        }

        [ScriptIgnore]
        public bool IsLatestVersion
        {
            get;
            set;
        }

        [ScriptIgnore]
        public ID ItemId
        {
            get;
            set;
        }

        public virtual string Name
        {
            get;
            set;
        }

        [ScriptIgnore]
        public virtual SitecoreItem Parent
        {
            get;
            set;
        }

        //[ScriptIgnore]
        //public virtual SitecoreItem Children
        //{
        //    get;
        //    set;
        //}

        [ScriptIgnore]
        public virtual string ParsedLanguage
        {
            get;
            set;
        }

        [ScriptIgnore]

        public virtual string Path
        {
            get;
            set;
        }

        [ScriptIgnore]
        [SitecoreField("__Renderings")]
        public virtual string Renderings
        {
            get;
            set;
        }

        [ScriptIgnore]
        public IEnumerable<ID> Semantics
        {
            get;
            set;
        }

        [ScriptIgnore]
        [TypeConverter(typeof(Guid))]
        public virtual Guid TemplateId
        {
            get;
            set;
        }

        [ScriptIgnore]
        public virtual string TemplateName
        {
            get;
            set;
        }

        [ScriptIgnore]
        [SitecoreField("__updated")]
        public virtual DateTime UpdatedDate
        {
            get;
            set;
        }

        public virtual string Url
        {
            get;
            set;
        }

        public virtual int Version { get; set; }

        [ScriptIgnore]
        [SitecoreField("Show in Navigation")]
        public bool ShowinNav { get; set; }

    }
}