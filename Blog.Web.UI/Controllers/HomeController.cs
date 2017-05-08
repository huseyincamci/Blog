using Blog.BLL.DataServices;
using PagedList;
using System.Linq;
using System.Web.Mvc;

namespace Blog.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly MakaleRepository _makaleRepository;

        public HomeController()
        {
            _makaleRepository = new MakaleRepository();
        }

        public ActionResult Index(int sayfa = 1)
        {
            var makaleler = _makaleRepository.GetList().OrderByDescending(x => x.CreatedDate).ToPagedList(sayfa, 4);
            return View(makaleler);
        }
    }
}