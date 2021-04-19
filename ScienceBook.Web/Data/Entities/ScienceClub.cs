using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data.Entities
{
    public class ScienceClub
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public string Logo { get; set; }

        public CategoryOfScienceClub CategoryOfScienceClub { get; set; }
        public Department Department { get; set; }
        public ICollection<CategoryOfTask> CategoriesOfTasks { get; set; }
        public ICollection<Election> Elections { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Fundraising> Fundraisings { get; set; }
        public ICollection<MailingList> MailingList { get; set; }
        public ICollection<MembershipDeclaration> MembershipDeclarations { get; set; }
        public ICollection<Post> Post { get; set; }
        public ICollection<Role> Roles { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
