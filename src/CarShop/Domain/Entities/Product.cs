using Domain.Common.Aduit;

namespace Domain.Entities
{
    /// <summary>
    /// the product class 
    /// </summary>
    public class Product : AduitEntity
    {
        /// <summary>
        ///  the name of product.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///  Description of the product.
        /// </summary>
        public string Description { get; set; }
    }
}
