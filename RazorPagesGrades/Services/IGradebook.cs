﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPagesGrades.Models;

namespace RazorPagesGrades.Services
{
    public interface IGradebook
    {
        IEnumerable<Grade> GetAllGrades();
        IEnumerable<Grade> GetGrades(string subjectAcronym);
    }
}