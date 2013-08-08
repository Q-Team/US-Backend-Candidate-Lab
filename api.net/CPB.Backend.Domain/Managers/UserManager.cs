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

        public User GetUserByName(string userName)
        {
            return this.DAC.GetUserByName(userName);
        }

        public User ValidateUser(string userName, string password)
        {
            return this.DAC.ValidateUser(userName, password);
        }

        #endregion

        #region -- Private Methods --

        #endregion
        
    }
}
