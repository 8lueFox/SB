using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data.Entities
{
    public class Fundraising
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Goal { get; set; }
        public decimal Quantity { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }

        public ScienceClub SciencClub { get; set; }
    }
}
