using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesGrades.Services;

namespace RazorPagesGrades.Helpers
{
    public static class DataSeeder
    {
        /// <summary>
        ///   DataSeeding using DI
        /// </summary>
        /// <param name="app">
        ///   An instance that provides the mechanisms to get instance of the database context.
        /// </param>
        public static void SeedData(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var sc = serviceScope.ServiceProvider.GetService<ISubjectCreator>();
                var gc = serviceScope.ServiceProvider.GetService<IGradeCreator>();
                sc.SeedSubjects();
                gc.SeedGrades(25);
            }
        }
    }

}
