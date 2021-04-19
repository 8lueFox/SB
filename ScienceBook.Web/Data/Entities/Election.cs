using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data.Entities
{
    public class Election
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public int CountOfChoices { get; set; }

        public ScienceClub ScienceClub { get; set; }
        public ICollection<OptionsInElection> OptionsInElection { get; set; }
    }
}
