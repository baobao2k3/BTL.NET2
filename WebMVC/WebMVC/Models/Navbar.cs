using Microsoft.AspNetCore.Mvc;
using WebMVC.Data;

namespace WebMVC.Models
{
	public class Navbar: ViewComponent
	{
		private readonly WebMVCContext _context;

		public Navbar(WebMVCContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
