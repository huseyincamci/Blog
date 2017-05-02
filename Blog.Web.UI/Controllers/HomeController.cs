using Blog.BLL.DataServices;
using System.Linq;
using System.Web.Mvc;

namespace Blog.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private MakaleRepository _makaleRepository;

        public HomeController()
        {
            _makaleRepository = new MakaleRepository();
        }

        public ActionResult Index()
        {
            var makaleler = _makaleRepository.GetList().OrderByDescending(x => x.CreatedDate);
            return View(makaleler);
        }
    }
}