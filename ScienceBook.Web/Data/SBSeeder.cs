using ScienceBook.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data
{
    public class SBSeeder
    {
        private readonly SBContext ctx;

        public SBSeeder(SBContext ctx)
        {
            this.ctx = ctx;
        }

        public void Seed()
        {
            ctx.Database.EnsureCreated();

            if (!ctx.Universities.Any())
            {
                var univ = new List<University>();

                univ.Add(new University
                {
                    Name = "Uniwersytet Przyrodniczo-Humanistyczny",
                    Departments = new List<Department>()
                });
                univ.Add(new University
                {
                    Name = "Uniwersytet Warszawski",
                    Departments = new List<Department>()
                });

                univ[0].Departments.Add(new Department
                {
                    Name = "Wydział Nauk Ścisłych i Przyrodniczych"
                });

                univ[0].Departments.Add(new Department
                {
                    Name = "Wydział Humanistyczny"
                });

                ctx.Universities.AddRange(univ);
                ctx.SaveChanges();
            }
        }
    }
}
