//using Glass.Mapper.Sc;
//using Glass.Mapper.Sc.Web;
//using System.Web.Mvc;
//using Glass.Mapper.Sc.Web.Mvc;
//using RYWebsite.Models;
//using System;

//namespace RYWebsite.Controllers.Header
//{
//    public class HeaderController : Controller
//    {
//        SitecoreContext _context;
//        IRenderingContext _renderingContext;
        
//        public HeaderController()
//        {
//            _context = new SitecoreContext();
//            _renderingContext = new RenderingContextMvcWrapper();
//        }
//        public ActionResult Header()
//        {
//            var HeaderModel = _context.GetItem<HeaderModel>(new Guid(_renderingContext.GetDataSource()));
//            return View(HeaderModel);
//        }
//    }
//}