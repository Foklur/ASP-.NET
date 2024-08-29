using CinemaWebApp.Models;
using CinemaWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string? Message { get; set; }
        public object? Cinema { get; set; }

        public List<Moviescs> Movies { get; set; } = new();

		public void OnGet(string? cinema)
		{
			Message = $"Cinema: {cinema}";
			Movies = MovieService.GetAll();
			Cinema = cinema;
		}

		//public void OnGet(string? cinema)
		//{
		//    Message = "Using property from page model";
		//    Movies = MovieSevice.GetAll();
		//   //?? Cinema = RouteData.Values["cinema"];
		//    //Cinema = Request.Query["cinema"].ToString();
		//    Cinema = cinema;

		//}

		//public void OnGet()
		//{
		//    Movies = MovieSevice.GetAll();
		//}
		// public void OnPost(string? cinema) { }

		//delete
		public IActionResult OnPost(int id)
        {
            MovieService.Delete(id);
            //return Content("Deleted!"); //contect page
            //return Page(); //   1) current page "Index"
            return RedirectToPage("Index"); // 2) current page
        }

    }
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

    }
}
