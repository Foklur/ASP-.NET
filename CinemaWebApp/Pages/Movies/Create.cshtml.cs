using CinemaWebApp.Models;
using CinemaWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaWebApp.Pages.Movies
{
	[IgnoreAntiforgeryToken]
			public class CreateModel : PageModel
		{
			public string? Message { get; set; }

			[BindProperty]
			public Moviescs? NewMovie { get; set; }
			public void OnGet()
			{
			}
        public IActionResult OnPost(IFormFile? Poster)
        {
            if (NewMovie == null || string.IsNullOrEmpty(NewMovie.Title))
            {
                return Page();
            }

            if (Poster != null)
            {
                var fileName = Path.GetFileName(Poster.FileName);
                var filePath = Path.Combine("wwwroot/Images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    Poster.CopyTo(stream);
                }

                NewMovie.PosterUrl = $"/Images/{fileName}";
            }

            MovieService.Add(NewMovie);

            return RedirectToPage("../Index");
        }


    }
	}

