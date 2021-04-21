using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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

        #region Model University

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
            return ctx.Universities
                      .Include(u => u.Departments)
                      .ThenInclude(d => d.ScienceBooks)
                      .ToList();
        }

        #endregion

        #region Model TaskState

        public IEnumerable<TaskState> GetTaskStates()
        {
            return ctx.TaskStates.OrderBy(ts => ts.Name).ToList();
        }

        public TaskState GetTaskState(int id)
        {
            return ctx.TaskStates.Find(id);
        }

        #endregion
    }
}
