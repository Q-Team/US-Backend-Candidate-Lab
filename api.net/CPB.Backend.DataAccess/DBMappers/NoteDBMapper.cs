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
    /// Represents a mapper of the class <see cref="Note"/>.
    /// </summary>
    public class NoteDBMapper : BaseDBMapper<Note, BaseQueryFilters>
    {
        #region -- Build Methods --

        public override Note BuildEntity(IDataReader reader)
        {
            Note entity = new Note();

            entity.Id = DBMapperHelper.GetColumnInt32Value(reader, "Id");
            entity.Title = DBMapperHelper.GetColumnStringValue(reader, "Title");
            entity.Description = DBMapperHelper.GetColumnStringValue(reader, "Description");
            entity.UserId = DBMapperHelper.GetColumnInt32Value(reader, "UserId");


            /// JOIN PROPERTIES

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

        public override void AddCreateParameters(QDatabase database, DbCommand command, Note entity)
        {
            AddAllParameters(database, command, entity);
        }

        public override void AddUpdateParameters(QDatabase database, DbCommand command, Note entity)
        {
            AddAllParameters(database, command, entity);
        }

        private void AddAllParameters(QDatabase database, DbCommand command, Note entity)
        {
            DBMapperHelper.AddInParameter<Int32>(database, command, "Id", entity.Id);
            DBMapperHelper.AddInParameter<String>(database, command, "Title", entity.Title);
            DBMapperHelper.AddInParameter<String>(database, command, "Description", entity.Description);
            DBMapperHelper.AddInParameter<Int32>(database, command, "UserId", entity.UserId);
        }

        public override void AddDeleteParameters(QDatabase database, DbCommand command, object id)
        {
            DBMapperHelper.AddInParameter<Int32>(database, command, "Id", Convert.ToInt32(id.ToString()));
        }

        public override void AddGetByIdParameters(QDatabase database, DbCommand command, object id)
        {
            DBMapperHelper.AddInParameter<Int32>(database, command, "Id", Convert.ToInt32(id.ToString()));
        }

        #endregion
    }
}
