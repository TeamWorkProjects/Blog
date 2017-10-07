using System.Collections.Generic;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
    public interface IPostRepository
    {
        Post Create (Post _post);
        List<Post> GetAll ();
        Post GetPost (int _idPost);
        Post Delete (int _idPost);
        Post Update (Post _post);
    }
}