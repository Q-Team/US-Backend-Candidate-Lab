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
    public partial class User : BaseEntity
    {
        #region -- Private fields --

        #endregion

        #region -- Constructors --

        /// <summary>
        /// Default constructor.
        /// </summary>
        public User()
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
        public String UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public String Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public String FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public String LastName { get; set; }


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
