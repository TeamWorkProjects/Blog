using DataAccessLayer;

namespace BussinesLayer
{
    class LogicAccess
    {
        private DataAccess _dataAccess;
        DataAccess dataAccess = new DataAccess();

        public LogicAccess()
        {
            this._dataAccess = dataAccess;
        }
    }
}