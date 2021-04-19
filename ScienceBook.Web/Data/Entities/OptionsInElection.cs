using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data.Entities
{
    public class OptionsInElection
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public Election Election { get; set; }
        public ICollection<Vote> Votes { get; set; }
    }
}
