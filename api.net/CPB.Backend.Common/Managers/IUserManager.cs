using System;
using System.Text;
using Q.Common.Managers;
using Q.Common.DTO.Queries;
using CPB.Backend.Common.Entities;
using CPB.Backend.Common.Managers;

namespace CPB.Backend.Common.Managers
{
    public interface IUserManager : IBaseManager<User, BaseQueryFilters>
    {
        User GetUserByName(string userName);
    }
}
