using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
	public class ProjectsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
