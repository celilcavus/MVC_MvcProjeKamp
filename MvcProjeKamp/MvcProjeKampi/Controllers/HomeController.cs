using System.Web.Mvc;
namespace MvcProjeKampi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home        
        
        public HomeController()
        {
             
        }
        public ActionResult Index()
        {
          
            return View();
        }
    }
}