using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPagesGrades.Models;

namespace RazorPagesGrades.Services
{
    public class GradeBook: ISubjectCreator, IGradeCreator
    {
        /// <summary>
        ///   Řešení úschovy (částečně) persistentních dat
        ///   <Akronym, Předmět>
        /// </summary>
        private SortedDictionary<string, Subject> _subjects { get; set; } = new SortedDictionary<string, Subject>();

        public Dictionary<Guid, Grade> _grades { get; set; } = new Dictionary<Guid, Grade>();

        private static readonly Random random = new Random();

        public void SeedSubjects()
        {
            _subjects.TryAdd("MAT", new Subject { Acronym = "MAT", Name = "Matematika" });
            _subjects.TryAdd("PRG", new Subject { Acronym = "PRG", Name = "Programování" });
            _subjects.TryAdd("WEB", new Subject { Acronym = "WEB", Name = "Webové aplikace" });
            _subjects.TryAdd("TEV", new Subject { Acronym = "TEV", Name = "Tělocvik" });
            _subjects.TryAdd("CJL", new Subject { Acronym = "CJL", Name = "Český jazyk a literatura" });
            _subjects.TryAdd("ANJ", new Subject { Acronym = "ANJ", Name = "Anglický jazyk" });
        }

        public void SeedGrades(int count)
        {
            SeedSubjects();

            for (int i = 0; i < count; i++)
            {
                var subject = _subjects.ElementAt(random.Next(0, _subjects.Count)).Value;
                var grade = new Grade() { Id = Guid.NewGuid(), Subject = subject, Value = random.Next(2, 11) * 0.5 , Weight = random.Next(1, 11) };
                _grades.TryAdd(grade.Id, grade);
            }
        }
    }
}
