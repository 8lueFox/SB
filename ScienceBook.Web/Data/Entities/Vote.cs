using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data.Entities
{
    public class Vote
    {
        public int Id { get; set; }

        public User User { get; set; }
        public OptionsInElection OptionInElection { get; set; }
    }
}
