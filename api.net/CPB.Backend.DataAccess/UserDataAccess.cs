using System;
using System.Text;
using Q.DataAccess;
using Q.Common.DTO.Queries;
using Q.Common.Configurations;
using CPB.Backend.Common.Entities;
using CPB.Backend.DataAccess.DBMappers;

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

        #endregion

        #region -- Private Methods --

        #endregion
    }
}
