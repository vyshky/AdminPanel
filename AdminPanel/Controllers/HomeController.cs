using AdminPanel.Models;
using AdminPanel.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRunnerService _service;

        public HomeController(ILogger<HomeController> logger, IRunnerService service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var view = await _service.GetFinishedTests();            
            return View(view);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}