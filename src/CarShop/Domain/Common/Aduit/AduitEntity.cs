using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Aduit
{
    /// <summary>
    /// the class aims for track the changes on the current domain.
    /// </summary>
    public class AduitEntity : EntityBase<Guid>
    {
        /// <summary>
        /// The name of who cretaed the entity.
        /// </summary>
        public string CreatedBy { get; set; }
        /// <summary>
        /// The date of entity creation.
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; }
        /// <summary>
        /// The last name who modifyd the entity
        /// </summary>
        public string LastModifyedBy { get; set; }
        /// <summary>
        /// The date of entity last modify.
        /// </summary>
        public DateTimeOffset LastModifyDate { get; set; }
    }
}
