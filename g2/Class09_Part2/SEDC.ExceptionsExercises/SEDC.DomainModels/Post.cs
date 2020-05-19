using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.DomainModels
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }

        public Post(int id, string title, string content, string createdBy)
        {
            this.Id = id;
            this.Title = title;
            this.Content = content;
            this.DateCreated = DateTime.Now;
            this.CreatedBy = createdBy;
        }
    }
}
