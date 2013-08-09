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
    /// Manager session entities. Allow:
    ///     - Log In
    ///     - Log Off
    ///     - Validate Session
    /// </summary>
    public partial class SessionManager : BaseManager<SessionDataAccess, Session, BaseQueryFilters>
    {
        #region -- Constructors --

        public SessionManager()
        {
        }

        public SessionManager(QDatabase dac)
            : base(dac)
        {
        }

        #endregion

        #region -- Public Methods --

        public Guid? LogInUser(User user)
        {
            Guid? result = null;

            Session session = new Session();
            session.Id = new Guid();
            session.LogInDate = DateTime.Now;
            session.UserId = user.Id;
            
            session = this.Create(session);

            if (session != null)
                result = session.Id;
                
            return result;
        }

        public bool IsUserOnline(User user)
        {
            return this.DAC.IsUserOnline(user);
        }

        #endregion

        #region -- Private Methods --

        #endregion
        
    }
}
