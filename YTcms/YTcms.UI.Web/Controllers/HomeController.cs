using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YTcms.EF.Model;
using YTcms.IBLL;

namespace YTcms.UI.Web.Controllers
{
  public class HomeController : Controller
  {
    private IUsersService usersService = BLLContainer.Container.Resolve<IUsersService>();
    public ActionResult Index()
    {
      List<dt_users> staff = usersService.GetModels(p => true).ToList();
      ViewBag.data = staff;
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}