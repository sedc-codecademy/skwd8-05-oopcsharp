using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PostsApp.DomainModels
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime DateCreated { get; set; }

        public string CreatedBy { get; set; }

        public Post()
        {

        }

        public Post(int id, string title, string content, string createdBy)
        {
            Id = id;
            Title = title;
            Content = content;
            DateCreated = DateTime.Now;
            CreatedBy = createdBy;
        }
    }
}
