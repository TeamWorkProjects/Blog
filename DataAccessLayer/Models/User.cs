using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}