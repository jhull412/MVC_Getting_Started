using System.Web;
using System.Web.Mvc;

// http://www.asp.net/mvc/overview/getting-started/introduction/adding-a-controller

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        //
        // GET: /HelloWorld/Welcome/

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
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}