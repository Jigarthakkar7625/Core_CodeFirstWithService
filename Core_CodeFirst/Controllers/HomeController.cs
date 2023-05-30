using Core_CodeFirst.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Core_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IEmployees _employees;

        private readonly ITransient _transient1;
        private readonly ITransient _transient2;


        private readonly IScoped _scoped1;
        private readonly IScoped _scoped2;


        private readonly ISingoleton _singoleton1;
        private readonly ISingoleton _singoleton2;


        public HomeController(ILogger<HomeController> logger, IEmployees employees, ITransient transient1, ITransient transient2, IScoped scoped1, IScoped scoped2, ISingoleton singoleton1, ISingoleton singoleton2)
        {
            _logger = logger;
            _employees = employees;

            _transient1 = transient1;
            _transient2 = transient2;
            
            _scoped1 = scoped1;
            _scoped2 = scoped2;
            
            _singoleton1 = singoleton1;
            _singoleton2 = singoleton2;



        }

        public IActionResult Index()
        {
            var a = _employees.GetAllEmployee();
            return View();
        }

        public IActionResult DependancyInjectionIndex()
        {
            ViewBag.transient1 = _transient1.GetOperationID().ToString();
            ViewBag.transient2 = _transient2.GetOperationID().ToString();

            ViewBag.scoped1 = _scoped1.GetOperationID().ToString();
            ViewBag.scoped2 = _scoped2.GetOperationID().ToString();


            ViewBag.singoleton1 = _singoleton1.GetOperationID().ToString();
            ViewBag.singoleton2 = _singoleton2.GetOperationID().ToString();


            //var a = _employees.GetAllEmployee();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}