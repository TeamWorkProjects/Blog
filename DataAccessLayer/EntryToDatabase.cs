using System;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;

namespace DataAccessLayer
{
    class EntryToDatabase : IEntryToDatabase
    {
        public IPostRepository PostRepository { get; internal set;}

        private ContextDb _context;

        public EntryToDatabase()
        {
            _context = new ContextDb();

            PostRepository = new PostRepository(_context);
        }
    }
}
