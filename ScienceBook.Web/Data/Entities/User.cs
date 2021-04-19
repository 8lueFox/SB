using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime JoinDay { get; set; }
        public string Logo { get; set; }

        public ICollection<Event> Events { get; set; }
        public ICollection<FieldOfStudy> FieldsOfStudy { get; set; }
        public ICollection<MembershipDeclaration> MembershipDeclarations { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Role> Roles { get; set; }
        public ICollection<ScienceClub> ScienceClubs { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Vote> Votes { get; set; }
    }
}
