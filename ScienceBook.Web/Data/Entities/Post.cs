using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScienceBook.Web.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PublicationDay { get; set; }
        public string Image { get; set; }

        public ScienceClub ScienceClub { get; set; }
        public User User { get; set; }
    }
}
