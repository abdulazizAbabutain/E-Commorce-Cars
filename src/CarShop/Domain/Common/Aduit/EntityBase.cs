using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Aduit
{
    /// <summary>
    /// Entity base for all domian classes.
    /// </summary>
    /// <typeparam name="T">T is type of the id can be int or guid.</typeparam>
    public abstract class EntityBase<T> 
    {
        /// <summary>
        /// the common id between all domain classes.
        /// </summary>
        public T Id { get; set; }
    }
}
