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
			Message = $"Cinema {cinema}";
			Movies = MovieService.GetAll();
			Cinema = cinema;
		}

		public IActionResult OnPost(int id)
        {
            MovieService.Delete(id);
            
            return RedirectToPage("Index"); 
        }

        public IActionResult OnPostClear(string? searchmovie)
        {
            return RedirectToPage("Index");

        }

        public void OnPostSearchTitle(string? searchmovie)
        {
            if (string.IsNullOrEmpty(searchmovie))
                Movies = MovieService.GetAll();
            else
                Movies = MovieService.SerachMovieByTitle(searchmovie);

        }

        public void OnPostSearchStyle(string? searchmovie) 
        {
            if (string.IsNullOrEmpty(searchmovie))
                Movies = MovieService.GetAll();
            else
                Movies = MovieService.SerachMovieByStyle(searchmovie);

        }

    }
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

    }
}
