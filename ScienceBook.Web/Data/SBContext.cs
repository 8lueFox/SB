using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ScienceBook.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data
{
    public class SBContext : DbContext
    {
        private readonly IConfiguration config;

        public SBContext(IConfiguration config)
        {
            this.config = config;
        }

        public DbSet<CategoryOfScienceClub> CategoriesOfScienceClub { get; set; }
        public DbSet<CategoryOfTask> CategoriesOfTask { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Election> Elections { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<FieldOfStudy> FieldOfStudies { get; set; }
        public DbSet<Fundraising> Fundraisings { get; set; }
        public DbSet<MailingList> MailingLists { get; set; }
        public DbSet<MembershipDeclaration> MembershipDeclarations { get; set; }
        public DbSet<OptionsInElection> OptionsInElections { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ScienceClub> ScienceClubs { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<TaskState> TaskStates { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(config["ConnectionStrings:SBContextDb"]);
        }
    }
}
