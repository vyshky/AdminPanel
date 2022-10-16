using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
	public class SettingsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
