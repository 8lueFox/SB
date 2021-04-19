using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data.Entities
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}
