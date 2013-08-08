using System;
using System.Text;
using Q.Domain;
using Q.Common.DTO.Queries;
using Q.DataAccess;
using CPB.Backend.Common.Entities;
using CPB.Backend.Common.Managers;
using CPB.Backend.DataAccess;

namespace CPB.Backend.Domain.Managers
{
    public partial class UserManager : BaseManager<UserDataAccess, User, BaseQueryFilters>, IUserManager
    {
        #region -- Constructors --

        public UserManager()
        {
        }

        public UserManager(QDatabase dac)
            : base(dac)
        {
        }

        #endregion

        #region -- Public Methods --

        #endregion

        #region -- Private Methods --

        #endregion
    }
}
