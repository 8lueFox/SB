using ScienceBook.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ScienceBook.Web.ViewModels
{
    public class TaskStateViewModel
    {
        public int TaskStateId { get; set; }
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
