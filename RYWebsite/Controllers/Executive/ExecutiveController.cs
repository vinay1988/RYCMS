using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Glass.Mapper.Sc.Web.Mvc;
using RYWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RYWebsite.Controllers
{
    public class ExecutiveController : Controller
    {
        SitecoreContext _context;
        //RenderingContext _renderingContext;
        IRenderingContext _renderingContext;

        public ExecutiveController()
        {
            _context = new SitecoreContext();
            //_renderingContext = new RenderingContext();
            _renderingContext = new RenderingContextMvcWrapper();
        }

        // GET: Executive
        public ActionResult Index()
        {

          var xyz=   _context.GetCurrentItem<ExecutiveModel>();
            var model = _context.GetItem<ExecutiveModel>(new Guid(_renderingContext.GetDataSource()));

            

            model.BannerImage = xyz.BannerImage;
            model.Description = xyz.Description;
            return View(model);
        }
    }
}