using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesTasks.Pages
{
    public class CountryModel : PageModel
    { 
        public class Country
        {
            public string Name { get; set; }
            public string Capital { get; set; }
            public int Population { get; set; }
        }
        public List<Country> Countries { get; set; }

        public string ShowCountries()
        {
            string result = "";
            foreach (var country in Countries)
            {
                result += $"Country: {country.Name}, Capital: {country.Capital}, Population: {country.Population}\n";
            }
            return result ;
        }
        public void OnGet()
        {
            Countries = new List<Country>
            {
                new Country { Name = "Ukraine", Capital = "Kyiv", Population = 41000000 },
                new Country { Name = "France", Capital = "Paris", Population = 67000000 },
                new Country { Name = "Japan", Capital = "Tokyo", Population = 126000000 }
            };
        }
    }
}
