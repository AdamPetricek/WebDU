using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesGrades.Services
{
    interface IGradeCreator
    {
        void SeedGrades(int count);
    }
}
