using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public University University { get; set; }
        public ICollection<ScienceClub> ScienceBooks { get; set; }
    }
}
