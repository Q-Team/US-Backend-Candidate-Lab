using System;
using System.Text;
using System.ComponentModel;
using System.Collections.Generic;
using Q.Common.Entities;
using Q.Common.Attributes;
using Q.Common.Attributes.Validations;
using CPB.Backend.Common.Entities;

namespace CPB.Backend.Common.Entities
{
    [Serializable]
    public partial class Session : BaseEntity
    {
        #region -- Private fields --

        #endregion

        #region -- Constructors --

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Session()
        {
        }

        #endregion

        #region -- Public Properties --
        /// <summary>
        /// 
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32 UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime LogInDate { get; set; }


        #endregion

        #region -- IDs Mappings --

        public virtual string BaseEntityID
        {
            get
            {
                return Id.ToString();
            }
        }

        public virtual void SetBaseEntityID(string id)
        {
            this.Id = Guid.Parse(id.Split('|')[0]);

        }

        public virtual bool HasID
        {
            get
            {
                return this.Id != null;
            }
        }

        #endregion

        #region -- Join Properties --

        #endregion
    }
}
