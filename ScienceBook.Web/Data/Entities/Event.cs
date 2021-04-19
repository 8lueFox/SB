using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }

        public ScienceClub ScienceClub { get; set; }
        public ICollection<User> Participants { get; set; }
    }
}
