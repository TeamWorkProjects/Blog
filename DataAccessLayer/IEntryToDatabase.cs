using System;
using DataAccessLayer.Repository;

namespace DataAccessLayer
{
    public interface IEntryToDatabase
    {
        IPostRepository PostRepository { get; }
    }
}