using System.Web;
using System.Web.Mvc;

// http://www.asp.net/mvc/overview/getting-started/introduction/adding-a-controller

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        // /HelloWorld/Welcome?name=Justin&numtimes=10
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
        //  /HelloWorld/Welcome?name=Scott&numtimes=4
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        // /HelloWorld/Welcome/3?name=Rick
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        //}

        // /HelloWorld/Welcome/Scott/3
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        //}
    }
}