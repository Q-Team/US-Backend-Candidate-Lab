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
    public partial class Note : BaseEntity
    {
        #region -- Private fields --

        #endregion

        #region -- Constructors --

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Note()
        {
        }

        #endregion

        #region -- Public Properties --
        /// <summary>
        /// 
        /// </summary>
        public Int32 Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int32 UserId { get; set; }


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
            this.Id = Int32.Parse(id.Split('|')[0]);

        }

        public virtual bool HasID
        {
            get
            {
                return this.Id > 0;
            }
        }

        #endregion

        #region -- Join Properties --

        #endregion
    }
}
