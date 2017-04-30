using Blog.BLL.DataServices;
using System.Web.Mvc;

namespace Blog.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MakaleRepository makaleRepository = new MakaleRepository();
            var makaleler = makaleRepository.GetList();
            return View(makaleler);
        }
    }
}