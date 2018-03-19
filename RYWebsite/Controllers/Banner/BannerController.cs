using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;
using RYWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Data.Templates;
using Sitecore.Data.Managers;
using Sitecore.Data;
using Sitecore.Data.Items;

namespace RYWebsite.Controllers.Banner
{
    public class BannerController : Controller
    {
        SitecoreContext _context;
        //RenderingContext _renderingContext;
        IRenderingContext _renderingContext;

        public BannerController()
        {
            _context = new SitecoreContext();
            //_renderingContext = new RenderingContext();
            _renderingContext = new RenderingContextMvcWrapper();
        }
        
        // GET: Banner
        public ActionResult Index()
        {
            //Template template = TemplateManager.GetTemplate(new Sitecore.Data.ID("{03FADF59-F22D-48C6-B13F-48A9B7281BC2}"), Sitecore.Context.Database);

            Database database = Sitecore.Context.Database;
            Item myItem = database.GetItem(new Sitecore.Data.ID("{42CDF7FF-6D07-4FC3-A609-D2FF4EF1181A}"));
            var fieldValue = myItem.Fields["Title"].Value;

            string desc = myItem.Fields["Desc"].Value;
            string Title = myItem.Fields["Title"].Value;
            string LinkText = myItem.Fields["LinkText"].Value;
            //template.GetField("LinkText").DefaultValue;
           // string desc = template.GetField("Desc").DefaultValue;
            //TemplateField[] allFields = template.GetFields(false);

            var model = _context.GetItem<RYWebsite.Models.Banner>(new Guid(_renderingContext.GetDataSource()));
            model.Desc = desc;
            model.Title = Title;
            model.LinkText = LinkText;
            return View(model);
        }
    }
}