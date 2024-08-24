using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesTasks.Pages
{
    public class RestoranModel : PageModel
    {
        public class Restinfo { 
            public string Name { get; set; }
            public string Location { get; set; }
            public string Cuisine { get; set; }
        }
        string[] rests = { "Pizza", "Se lya Wi", "Tuk Tuk", "Loshka" };
        public string ShowRests() {
            string res = "";
             for (int i = 0; i < rests.Length; i++) {
                res += rests[i] + "\n" ;
            }
            return res;
        }
        public Restinfo RestInfo { get; set; }
        public void OnGet()
        {
            RestInfo = new Restinfo
            {
                Name = "Pizza",
                Location = "Rivne",
                Cuisine="Italy"
            };
           
        }
    }
}
