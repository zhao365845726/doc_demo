using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace demo.Pages
{
    public class RazorPagesMovieModel : PageModel
    {
        public string Context {get;set;}

        public void OnGet()
        {
            Context = "Test";
        }
    }
}
