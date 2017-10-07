using System.Collections.Generic;
using DataAccessLayer.Context;
using DataAccessLayer.Models;

namespace DataAccessLayer.Repository
{
    public class PostRepository : IPostRepository
    {
        private ContextDb context;
        public PostRepository(ContextDb _context)
        {
            this.context = _context;
        }

        Post IPostRepository.Create(Post _post)
        {
            throw new System.NotImplementedException();
        }

        Post IPostRepository.Delete(int _idPost)
        {
            throw new System.NotImplementedException();
        }

        List<Post> IPostRepository.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Post IPostRepository.GetPost(int _idPost)
        {
            throw new System.NotImplementedException();
        }

        Post IPostRepository.Update(Post _post)
        {
            throw new System.NotImplementedException();
        }
    }
}