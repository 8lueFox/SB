using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data.Entities
{
    public class MembershipDeclaration
    {
        public int Id { get; set; }
        public DateTime CreateDay { get; set; }
        public DateTime ConsiderationDay { get; set; }
        public string Interests { get; set; }
        public int IsSigned { get; set; } // 0 nie rozpatrzone, 1 rozpatrzone pozytywnie, 2 rozpatrzone negatywnie

        public ScienceClub ScienceClub { get; set; }
        public User User { get; set; }
    }
}
