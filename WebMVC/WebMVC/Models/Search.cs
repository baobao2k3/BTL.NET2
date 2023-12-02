using Microsoft.AspNetCore.Mvc;
using WebMVC.Data;

namespace WebMVC.Models 
{
	public class Search : ViewComponent
	{
		private readonly WebMVCContext _context;

		public Search(WebMVCContext context)
		{
			_context = context;
		}
		public IViewComponentResult Invoke()
		{
			return View(_context.Category.ToList());
		}
	}
}
