using ScienceBook.Web.Data.Entities;
using System.Collections.Generic;

namespace ScienceBook.Web.Data
{
    public interface ISBRepository
    {
        void SaveAll();
        void AddEntity(object model);

        IEnumerable<University> GetUniversities();
        IEnumerable<University> GetUniversitiesWithDepartments();
        University GetUniversity(int id);
        University GetUniversity(string name);

        IEnumerable<TaskState> GetTaskStates();
        TaskState GetTaskState(int id);
    }
}