using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesGrades.Services;

namespace RazorPagesGrades.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel(GradeBook gb)
        {
            var gbd = gb;
            gbd.SeedGrades(1);
        }

        public void OnGet()
        {

        }
    }
}
