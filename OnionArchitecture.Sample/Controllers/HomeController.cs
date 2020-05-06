using System.Linq;
using System.Web.Mvc;
using OnionArchitecture.Sample.Models;
using Services.Interfaces;

namespace OnionArchitecture.Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _service;

        public HomeController(IUserService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            var users = _service.GetUsers();

            // TODO: This should get moved to a mapper class of some kind
            // but this is a small example
            var model = users.Select(x => new UserViewModel
            {
                DateCreated = x.DateCreated,
                Email = x.Email,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
