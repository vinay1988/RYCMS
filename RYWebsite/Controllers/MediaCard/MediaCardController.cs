using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RYWebsite.Models;
using Sitecore.Data.Templates;
using Sitecore.Data.Managers;

namespace RYWebsite.Controllers
{
    public class MediaCardController : Controller
    {
        SitecoreContext _context;
        //RenderingContext _renderingContext;
        IRenderingContext _renderingContext;
        // GET: MediaCard

        public MediaCardController()
        {
            _context = new SitecoreContext();
            //_renderingContext = new RenderingContext();
            _renderingContext = new RenderingContextMvcWrapper();
        }
        public ActionResult Index()
        {
            //var ds = _renderingContext.GetDataSource();
         

          

            var model = _context.GetItem<MediaCardModel>(new Guid(_renderingContext.GetDataSource()));
           
            return View(model);
        }
    }
}