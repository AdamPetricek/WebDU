using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesGrades.Services
{
    public interface IGradeManipulator
    {
        void SeedGrades(int count);
    }
}
