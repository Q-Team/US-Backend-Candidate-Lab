using System;
using System.Text;
using Q.Domain;
using Q.Common.DTO.Queries;
using Q.DataAccess;
using CPB.Backend.Common.Entities;
using CPB.Backend.DataAccess;

namespace CPB.Backend.Domain.Managers
{
    /// <summary>
    /// Manager user entities. Allow:
    ///     - Create
    ///     - Update
    ///     - Delete
    ///     - Query
    /// </summary>
    public partial class UserManager : BaseManager<UserDataAccess, User, BaseQueryFilters>
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
