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
    /// Represents a mapper of the class <see cref="Session"/>.
    /// </summary>
    public class SessionDBMapper : BaseDBMapper<Session, BaseQueryFilters>
    {
        #region -- Build Methods --

        public override Session BuildEntity(IDataReader reader)
        {
            Session entity = new Session();

            entity.Id = Guid.Parse(DBMapperHelper.GetColumnStringValue(reader, "Id"));
            entity.UserId = DBMapperHelper.GetColumnInt32Value(reader, "UserId");
            entity.LogInDate = DBMapperHelper.GetColumnDateTimeValue(reader, "LogInDate");



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

        public override void AddCreateParameters(QDatabase database, DbCommand command, Session entity)
        {
            AddAllParameters(database, command, entity);
        }

        public override void AddUpdateParameters(QDatabase database, DbCommand command, Session entity)
        {
            AddAllParameters(database, command, entity);
        }

        private void AddAllParameters(QDatabase database, DbCommand command, Session entity)
        {
            DBMapperHelper.AddInParameter<Guid>(database, command, "Id", entity.Id);
            DBMapperHelper.AddInParameter<Int32>(database, command, "UserId", entity.UserId);
            DBMapperHelper.AddInParameter<DateTime>(database, command, "LogInDate", entity.LogInDate);
        }

        public override void AddDeleteParameters(QDatabase database, DbCommand command, object id)
        {
            DBMapperHelper.AddInParameter<Guid>(database, command, "Id", Guid.Parse(id.ToString()));
        }

        public override void AddGetByIdParameters(QDatabase database, DbCommand command, object id)
        {
            DBMapperHelper.AddInParameter<Guid>(database, command, "Id", Guid.Parse(id.ToString()));
        }

        #endregion
    }
}
