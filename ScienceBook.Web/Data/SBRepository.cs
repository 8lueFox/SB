using ScienceBook.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data
{
    public class SBRepository : ISBRepository
    {
        private readonly SBContext ctx;

        public SBRepository(SBContext ctx)
        {
            this.ctx = ctx;
        }

        #region University's functions

        public University GetUniversity(int id)
        {
            return ctx.Universities.Where(u => u.Id == id).FirstOrDefault();
        }

        public University GetUniversity(string name)
        {
            return ctx.Universities.Where(u => u.Name.ToLower().Contains(name.ToLower())).FirstOrDefault();
        }

        public IEnumerable<University> GetUniversities()
        {
            return ctx.Universities.OrderBy(u => u.Name).ToList();
        }

        public IEnumerable<University> GetUniversitiesWithDepartments()
        {
            var temp = ctx.Universities
                          .Join(ctx.Departments, u => u.Id, d => d.Id, (u, d) => new { Universities = u, Departments = d })
                          .Select(ud => new University
                          {
                              Name = ud.Universities.Name,
                              Departments = ud.Universities.Departments
                          })
                          .ToList();

            return temp;
        }

    #endregion
    }
}
