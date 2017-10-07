using DataAccessLayer.Repository;
using System;

namespace DataAccessLayer
{
    public class DataAccess
    {
        public IEntryToDatabase EntryToDatabase
        {
            get
            {
                return new EntryToDatabase();
            }
        }
    }
}
