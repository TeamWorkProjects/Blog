using System;

namespace DataAccessLayer.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostName { get; set; }
        public string Text { get; set; }
        public DateTime DataTime { get; set; }
    }
}