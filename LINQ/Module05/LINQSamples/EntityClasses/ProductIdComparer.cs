using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LINQSamples.EntityClasses
{
    public class ProductIdComparer : EqualityComparer<Product>
    {
        public override bool Equals(Product prod1, Product prod2)
        {
            return prod1.ProductID == prod2.ProductID;
        }

        public override int GetHashCode([DisallowNull] Product obj)
        {
            return obj.ProductID.GetHashCode();
        }
    }
}
