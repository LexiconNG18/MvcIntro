using MvcIntro.Models;
using System.Web.Mvc;

namespace MvcIntro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Någonting intressant.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test(string id, string dag = "okänd", string humör = "okänd")
        {
            ViewBag.Message = $"The id is {id}, dag: {dag}, humör: {humör}";
            //return View();
            return View(new TestModel { Id = id, Dag = dag, Humör = humör });
        }
    }
}