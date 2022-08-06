using System;
using System.Collections.Generic;
using System.Linq;
using LINQSamples.EntityClasses;

namespace LINQSamples
{
    public class SamplesViewModel
    {
        #region Constructor
        public SamplesViewModel()
        {
            // Load all Product Data
            Products = ProductRepository.GetAll();
            // Load all Sales Data
            Sales = SalesOrderDetailRepository.GetAll();
        }
        #endregion

        #region Properties
        public bool UseQuerySyntax { get; set; } = true;
        public List<Product> Products { get; set; }
        public List<SalesOrderDetail> Sales { get; set; }
        public string ResultText { get; set; }
        #endregion

        #region ForEach Method
        /// <summary>
        /// ForEach allows you to iterate over a collection to perform assignments within each object.
        /// In this sample, assign the Length of the Name property to a property called NameLength
        /// When using the Query syntax, assign the result to a temporary variable.
        /// </summary>
        public void ForEach()
        {
            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in Products
                            let tmp = prod.NameLength = prod.Name.Length
                            select prod).ToList();

            }
            else
            {
                // Method Syntax
                Products.ForEach(prod => prod.NameLength = prod.Name.Length);
            }

            ResultText = $"Total Products: {Products.Count}";
        }
        #endregion

        #region ForEachCallingMethod Method
        /// <summary>
        /// Iterate over each object in the collection and call a method to set a property
        /// This method passes in each Product object into the SalesForProduct() method
        /// In the SalesForProduct() method, the total sales for each Product is calculated
        /// The total is placed into each Product objects' ResultText property
        /// </summary>
        public void ForEachCallingMethod()
        {
            if (UseQuerySyntax)
            {
                Products = (from prod in Products
                            let tmp = prod.TotalSales = SalesForProduct(prod)
                            select prod).ToList();

            }
            else
            {
                // Method Syntax
                Products.ForEach(prod => prod.TotalSales = SalesForProduct(prod));
            }

            ResultText = $"Total Products: {Products.Count}";
        }

        /// <summary>
        /// Helper method called by LINQ to sum sales for a product
        /// </summary>
        /// <param name="prod">A product</param>
        /// <returns>Total Sales for Product</returns>
        private decimal SalesForProduct(Product prod)
        {
            return Sales.Where(sale => sale.ProductID == prod.ProductID)
                        .Sum(sale => sale.LineTotal);
        }
        #endregion

        #region Take Method
        /// <summary>
        /// Use Take() to select a specified number of items from the beginning of a collection
        /// </summary>
        public void Take()
        {
            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in Products
                            orderby prod.Name
                            select prod).Take(5).ToList();
            }
            else
            {
                // Method Syntax
                Products = Products.OrderBy(prod => prod.Name).Take(5).ToList();
            }

            ResultText = $"Total Products: {Products.Count}";
        }
        #endregion

        #region TakeWhile Method
        /// <summary>
        /// Use TakeWhile() to select a specified number of items from the beginning of a collection based on a true condition
        /// </summary>
        public void TakeWhile()
        {
            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in Products
                            orderby prod.Name
                            select prod
                            ).TakeWhile(prod => prod.Name.StartsWith("A")).ToList();

            }
            else
            {
                // Method Syntax
                Products = Products.OrderBy(prod => prod.Name).TakeWhile(prod => prod.Name.StartsWith("A")).ToList();
            }

            ResultText = $"Total Products: {Products.Count}";
        }
        #endregion

        #region Skip Method
        /// <summary>
        /// Use Skip() to move past a specified number of items from the beginning of a collection
        /// </summary>
        public void Skip()
        {
            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in Products
                            orderby prod.Name
                            select prod).Skip(25).ToList();

            }
            else
            {
                // Method Syntax
                Products = (from prod in Products
                            orderby prod.Name
                            select prod).Skip(25).ToList();

            }

            ResultText = $"Total Products: {Products.Count}";
        }
        #endregion

        #region SkipWhile Method
        /// <summary>
        /// Use SkipWhile() to move past a specified number of items from the beginning of a collection based on a true condition
        /// </summary>
        public void SkipWhile()
        {
            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from product in Products
                            orderby product.Name
                            select product)
                            .SkipWhile(prod => prod.Name.StartsWith("L")).ToList();
            }
            else
            {
                // Method Syntax
                Products= Products.OrderBy(prod => prod.Name).SkipWhile(prod => prod.Name.StartsWith("L")).ToList();

            }

            ResultText = $"Total Products: {Products.Count}";
        }
        #endregion

        #region Distinct
        /// <summary>
        /// The Distinct() operator finds all unique values within a collection
        /// In this sample you put distinct product colors into another collection using LINQ
        /// </summary>
        public void Distinct()
        {
            List<string> colors = new List<string>();

            if (UseQuerySyntax)
            {
                // Query Syntax
                colors = (from prod in Products select prod.Color).Distinct().ToList();
            }
            else
            {
                // Method Syntax
                colors = Products.Select(prod => prod.Color).Distinct().ToList();

            }

            // Build string of Distinct Colors
            foreach (var color in colors)
            {
                Console.WriteLine($"Color: {color}");
            }
            Console.WriteLine($"Total Colors: {colors.Count}");

            // Clear products
            Products.Clear();
        }
        #endregion

        #region All
        /// <summary>
        /// Using All() to see if items meet a condition
        /// </summary>
        public void All()
        {
            string searchTerm = " ";
            bool results;

            if (UseQuerySyntax)
            {
                // Query Syntax
                results = (from prod in Products select prod).All(prod => prod.Name.Contains(searchTerm));
            }
            else
            {
                // Method Syntax
                results = Products.All(prod => prod.Name.Contains(searchTerm));

            }

            ResultText = $"Do all Name properties contain a '{searchTerm}'? {results}";
           
            // Clear products
            Products.Clear();
        }
        #endregion

        #region Any
        /// <summary>
        /// Using Any() to see if there is an item that meets a condition
        /// </summary>
        public void Any()
        {
            string searchColor = "Blue";
            bool results;

            if (UseQuerySyntax)
            {
                // Query Syntax
                results = (from prod in Products select prod).Any(prod => prod.Color == searchColor);
            }
            else
            {
                // Method Syntax
                results = Products.All(prod => prod.Color == searchColor);

            }

            ResultText = $"Do we a have a product of color '{searchColor}'? {results}";

            // Clear products
            Products.Clear();
        }
        #endregion

        #region LINQContains
        /// <summary>
        /// Using LINQ's Contains() to see if a value of simple type exists in a collection
        /// </summary>
        public void LINQContains()
        {
            bool value;
            List<int> numbers = new List<int> { 1, 2, 3 };

            if (UseQuerySyntax)
            {
                // Query Syntax
                value = (from num in numbers select num).Contains(3);
            }
            else
            {
                // Method Syntax
                value = numbers.Contains(3);

            }

            ResultText = $"Do we a have 3 in our numbers list? {value}";

            // Clear products
            Products.Clear();
        }
        #endregion

        #region EqualityComparer
        /// <summary>
        /// Using LINQ's Contains() with an EqualityComparer class to see if a product exists exists in a collection
        /// </summary>
        public void LINQEquaalityComparer()
        {
            int productId = 744;
            bool searchedProductExists;

            ProductIdComparer comparer = new();
            Product prodToSearch = new() { ProductID = productId };

            if (UseQuerySyntax)
            {
                // Query Syntax
                searchedProductExists = (from prod in Products select prod).Contains(prodToSearch, comparer);
            }
            else
            {
                // Method Syntax
                searchedProductExists = Products.Contains(prodToSearch, comparer);

            }

            ResultText = $"Do we a have prodToSerch in our products list? {searchedProductExists}";

            // Clear products
            Products.Clear();
        }
        #endregion

        #region SequenceEqual
        /// <summary>
        /// Using LINQ's SequenceEqual() to compare 2 collections for equality
        /// When using simple data types, it checks values
        /// When using object data types, it checks refference.
        /// </summary>
        public void SequenceEqualIntegers()
        {
            bool results;

            List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5 };


            if (UseQuerySyntax)
            {
                // Query Syntax
                results = (from num in numbers1 select num).SequenceEqual(numbers2);
            }
            else
            {
                // Method Syntax
                results = numbers1.SequenceEqual(numbers2);

            }

            if (results)
            {
                Console.WriteLine("The provided lists of numbers are equal");
            }else
            {
                Console.WriteLine("The provided lists of numbers are not equal");
            }

            // Clear products
            Products.Clear();
        }
        #endregion

        #region SequenceEqual
        /// <summary>
        /// Using LINQ's SequenceEqual() to compare 2 products collections for equality
        /// </summary>
        public void SequenceEqualUsingComparer()
        {
            bool results;
            ProductComparer comparer = new();

            List<Product> list1 = ProductRepository.GetAll();
            List<Product> list2 = ProductRepository.GetAll();

            //Remove an element from list2
            list2.RemoveAt(0);


            if (UseQuerySyntax)
            {
                // Query Syntax
                results = (from prod in list1 select prod).SequenceEqual(list2, comparer);
            }
            else
            {
                // Method Syntax
                results = list1.SequenceEqual(list2, comparer);
            }

            if (results)
            {
                Console.WriteLine("The provided lists of products are equal");
            }
            else
            {
                Console.WriteLine("The provided lists of products are not equal");
            }

            // Clear products
            Products.Clear();
        }
        #endregion

        #region Except
        /// <summary>
        /// Using LINQ's Except() to find all values in a list but not the other
        /// For simple data types (int, decimal, e.t.c) checks values
        /// Object data types checks reference
        /// To check values in properties use comparer class
        /// </summary>
        public void ExceptIntegers()
        {
            List<int> exceptions;

            List<int> list1 = new List<int> { 1, 2, 3, 4, 5};
            List<int> list2 = new List<int> { 3, 4, 5 };

            if (UseQuerySyntax)
            {
                // Query Syntax
                exceptions = (from num in list1 select num).Except(list2).ToList();
            }
            else
            {
                // Method Syntax
                exceptions = list1.Except(list2).ToList();
            }

            ResultText = string.Empty;
            foreach (int i in exceptions)
            {
                ResultText += "Number: " + i + " is not contained in both lists" + Environment.NewLine;
            }

            // Clear products
            Products.Clear();
        }
        #endregion

        #region ExceptUsingComparer
        /// <summary>
        /// Using LINQ's Except() with a comparer class to compare find products that don't belong to both lists
        /// </summary>
        public void ExceptUsingComparer()
        {
            ProductComparer comparer = new();

            List<Product> list1 = ProductRepository.GetAll();
            List<Product> list2 = ProductRepository.GetAll();

            //Remove all products with color 'Blue' from list2
            list2.RemoveAll(prod => prod.Color == "Blue");


            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in list1 select prod).Except(list2, comparer).ToList();
            }
            else
            {
                // Method Syntax
                Products = list1.Except(list2, comparer).ToList();
            }

            ResultText = $"\nTotal products exceptions: {Products.Count}";
        }
        #endregion
    }
}
