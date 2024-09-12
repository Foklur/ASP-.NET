using CinemaWebApp.Models;
using CinemaWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaWebApp.Pages.Movies
{
    [IgnoreAntiforgeryToken]
    public class EditModel : PageModel
    {
        public Moviescs? EditMovie { get; set; }

        public void OnGet(int id)
        {
            EditMovie = MovieService.GetById(id);
        }

        public IActionResult OnPost(Moviescs movie)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage("Edit", new { movie.Id });
            }

            MovieService.Update(movie);
            return RedirectToPage("/Index");
        }
    }
}
