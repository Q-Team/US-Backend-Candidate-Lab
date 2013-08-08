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
    public partial class UserDataAccess : BaseDataAccess<UserDBMapper, User, BaseQueryFilters, Int32>
    {
        #region -- Constructors --

        public UserDataAccess() { }

        public UserDataAccess(string connName) : base(connName) { }

        public UserDataAccess(QDatabase database) : base(database) { }

        #endregion

        #region -- Override Methods --

        protected override bool DoCreate(User entity)
        {
            if (base.DataBaseType == DataBaseType.Oracle)
            {
                entity.Id = base.GetNextSequense(entity);
                base.DoCreate(entity);
            }
            else
            {
                entity.Id = base.DoCreateIdentity(entity);
            }
            return entity.Id > 0;
        }

        #endregion

        #region -- Public Methods --

        public User GetUserByName(string userName)
        {
            User result = new User();

            string sqlText = DataAccessHelper.GetQuery("UserDataAccess.GetUserByName");
            using (DbCommand command = base.GetSqlStringCommand(sqlText))
            {
                DBMapperHelper.AddInParameter<string>(this, command, "userName", userName);
                using (IDataReader reader = base.ExecuteReader(command))
                {
                    result = DBMapperHelper.Read<User>(reader, mapper);
                }
            }

            return result;
        }

        #endregion

        #region -- Private Methods --

        #endregion
    }
}
