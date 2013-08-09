using System;
using System.Text;
using Q.DataAccess;
using Q.Common.DTO.Queries;
using Q.Common.Configurations;
using CPB.Backend.Common.Entities;
using CPB.Backend.DataAccess.DBMappers;
using Q.DataAccess.Utils;
using System.Data.Common;
using System.Data;

namespace CPB.Backend.DataAccess
{
    public partial class SessionDataAccess : BaseDataAccess<SessionDBMapper, Session, BaseQueryFilters, String>
    {
        #region -- Constructors --

        public SessionDataAccess() { }

        public SessionDataAccess(string connName) : base(connName) { }

        public SessionDataAccess(QDatabase database) : base(database) { }

        #endregion

        #region -- Public Methods --

        public bool IsUserOnline(User user)
        {
            bool result = false;

            string sqlText = DataAccessHelper.GetQuery("SessionDataAccess.IsUserOnline");
            using (DbCommand command = base.GetSqlStringCommand(sqlText))
            {
                DBMapperHelper.AddInParameter<int>(this, command, "userId", user.Id);
                using (IDataReader reader = base.ExecuteReader(command))
                {
                    if (reader.Read())
                        result = true;
                }
            }

            return result;
        }

        #endregion

        #region -- Private Methods --

        #endregion
        
    }
}
