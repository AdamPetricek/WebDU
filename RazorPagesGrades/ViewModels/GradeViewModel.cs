using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesGrades.ViewModels
{
    public class GradeViewModel
    {
        [ScaffoldColumn(false)]
        public Guid Id { get; set; }

        [Display(Name = "Zkratka", GroupName = "Skupina předměty", Description = "Třípísmenná zkratka vyučovaného předmětu.")]
        [StringLength(3, ErrorMessage = "Musí obsahovat tři znaky", MinimumLength = 3)]
        public string Acronym { get; set; }

        [Display(Name = "Předmět", GroupName = "Skupina předměty", Description = "Název nebo označení vyučovaného předmětu.")]
        public string Subject { get; set; }

        [Display(Name = "Známka")]
        [Range(1, 5, ErrorMessage = "Známka musí být mezi {1} a {2}.")]
        public double Value { get; set; }

        [Display(Name = "Váha")]
        [Range(1, 10, ErrorMessage = "Hodnota {0} musí být mezi {1} a {2}.")]
        public int Weight { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Známka")]
        public string ValWithMinus { 
            get {
                return ((int)Value).ToString() + (((int)Value) < Value ? "-" : "");
            }
        }

        [ScaffoldColumn(false)]
        [Display(Name = "Váha")]
        public string WeightAlpha
        {
            get
            {
                return ((char)(75 - Weight)).ToString();
            }
        }
    }
}
