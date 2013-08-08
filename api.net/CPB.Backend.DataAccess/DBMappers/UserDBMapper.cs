using System;
using System.Data;
using System.Data.Common;
using Q.DataAccess.Utils;
using Q.DataAccess.DBMappers;
using Q.DataAccess;
using Q.Common.DTO.Queries;
using CPB.Backend.Common.Entities;

namespace CPB.Backend.DataAccess.DBMappers
{
    /// <summary>
    /// Represents a mapper of the class <see cref="User"/>.
    /// </summary>
    public class UserDBMapper : BaseDBMapper<User, BaseQueryFilters>
    {
        #region -- Build Methods --

        public override User BuildEntity(IDataReader reader)
        {
            User entity = new User();

            entity.Id = DBMapperHelper.GetColumnInt32Value(reader, "Id");
            entity.UserName = DBMapperHelper.GetColumnStringValue(reader, "UserName");
            entity.Password = DBMapperHelper.GetColumnStringValue(reader, "Password");
            entity.FirstName = DBMapperHelper.GetColumnStringValue(reader, "FirstName");
            entity.LastName = DBMapperHelper.GetColumnStringValue(reader, "LastName");



            return entity;
        }

        #endregion

        #region -- QueryFilters --

        public override string GetWhereClause(QDatabase database, DbCommand command, bool hasWhere, BaseQueryFilters qFilters)
        {
            QueryBuilder builder = QueryBuilder.CreateInstance(hasWhere);



            return builder.GetPredicate();
        }

        #endregion

        #region -- Parameter Methods --

        public override void AddCreateParameters(QDatabase database, DbCommand command, User entity)
        {
            AddAllParameters(database, command, entity);
        }

        public override void AddUpdateParameters(QDatabase database, DbCommand command, User entity)
        {
            AddAllParameters(database, command, entity);
        }

        private void AddAllParameters(QDatabase database, DbCommand command, User entity)
        {
            DBMapperHelper.AddInParameter<Int32>(database, command, "Id", entity.Id);
            DBMapperHelper.AddInParameter<String>(database, command, "UserName", entity.UserName);
            DBMapperHelper.AddInParameter<String>(database, command, "Password", entity.Password);
            DBMapperHelper.AddInParameter<String>(database, command, "FirstName", entity.FirstName);
            DBMapperHelper.AddInParameter<String>(database, command, "LastName", entity.LastName);
        }

        public override void AddDeleteParameters(QDatabase database, DbCommand command, object id)
        {
            User entity = (User)id;
            DBMapperHelper.AddInParameter<Int32>(database, command, "Id", entity.Id);
            DBMapperHelper.AddInParameter<String>(database, command, "UserName", entity.UserName);
        }

        public override void AddGetByIdParameters(QDatabase database, DbCommand command, object id)
        {
            User entity = (User)id;
            DBMapperHelper.AddInParameter<Int32>(database, command, "Id", entity.Id);
            DBMapperHelper.AddInParameter<String>(database, command, "UserName", entity.UserName);
        }

        #endregion
    }
}
