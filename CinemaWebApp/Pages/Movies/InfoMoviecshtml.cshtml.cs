using CinemaWebApp.Models;
using CinemaWebApp.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace CinemaWebApp.Pages.Movies;
public class InfoMoviecshtmlModel : PageModel
{
    public Moviescs? MovieInfo { get; set; }

    public void OnGet(int id)
    {
        MovieInfo = MovieService.GetById(id);
    }
}