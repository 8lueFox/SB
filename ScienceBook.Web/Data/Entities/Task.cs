using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public string Description { get; set; }

        public ScienceClub ScienceClub { get; set; }
        public CategoryOfTask CategoryOfTask { get; set; }
        public TaskState TaskState { get; set; }
        public User User { get; set; }
    }
}
