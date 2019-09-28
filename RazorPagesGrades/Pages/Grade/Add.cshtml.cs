using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesGrades.ViewModels;

namespace RazorPagesGrades.Pages.Grade
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public GradeViewModel Grade { get; set; }

        public void OnGet()
        {

        }
    }
}