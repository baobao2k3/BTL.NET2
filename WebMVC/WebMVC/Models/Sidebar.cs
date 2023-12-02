using Microsoft.AspNetCore.Mvc;
using WebMVC.Data;

namespace WebMVC.Models
{
	public class Sidebar: ViewComponent
	{
		private readonly WebMVCContext _context;

		public Sidebar(WebMVCContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
