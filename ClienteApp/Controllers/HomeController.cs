using Microsoft.AspNetCore.Mvc;
 
namespace ClienteApp.Controllers

{

    public class HomeController : Controller

    {

        public IActionResult Index()

        {

            return View();

        }
 
        public IActionResult About()

        {

            ViewData["Message"] = "Sua aplicação de exemplo para ASP.NET Core MVC.";

            return View();

        }
 
        public IActionResult Contact()

        {

            ViewData["Message"] = "Sua página de contato.";

            return View();

        }
 
        [Route("erro")]

        public IActionResult Error()

        {

            return View();

        }

    }

}

 