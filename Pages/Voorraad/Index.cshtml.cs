using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBrandstofCafe.Data;

namespace MyBrandstofCafe.Pages.Voorraad
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration configuration;

        public IndexModel(IConfiguration configuration)
        { 
            this.configuration = configuration;
        }

        public string Artikel { get; set; }
        public void OnGet()
        {
            Artikel = configuration["Cola"];
        }


    }
}
