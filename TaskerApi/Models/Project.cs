using System;
using System.Collections.Generic;
using TaskerApi.Models.Oauth;
using TaskerApi.Models.TaskModels;

namespace TaskerApi.Models
{
    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; } = DateTime.Now;
        public virtual User Owner { get; set; }
        public virtual List<UserStory> UserStories { get; set; }
    }
}