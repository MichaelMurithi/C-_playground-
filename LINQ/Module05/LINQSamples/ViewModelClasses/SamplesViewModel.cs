using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                Products = Products.OrderBy(prod => prod.Name).SkipWhile(prod => prod.Name.StartsWith("L")).ToList();

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
            }
            else
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

            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
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

        #region Intersect
        /// <summary>
        /// Using LINQ's Intersect() with a comparer class to compare find products that belong to both lists
        /// </summary>
        public void Intersect()
        {
            ProductComparer comparer = new();

            List<Product> list1 = ProductRepository.GetAll();
            List<Product> list2 = ProductRepository.GetAll();

            //Remove all products with color 'Blue' from list2
            list2.RemoveAll(prod => prod.Color == "Blue");
            //Remove all products with color 'Blue' from list2
            list2.RemoveAll(prod => prod.Color == "Black");


            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in list1 select prod).Intersect(list2, comparer).ToList();
            }
            else
            {
                // Method Syntax
                Products = list1.Intersect(list2, comparer).ToList();
            }

            ResultText = $"\nCommon products in both lists: {Products.Count}";
        }
        #endregion

        #region Union
        /// <summary>
        /// Using LINQ's Union() with a comparer class to join two collections and check for duplicates
        /// </summary>
        public void Union()
        {
            ProductComparer comparer = new();

            List<Product> list1 = ProductRepository.GetAll();
            List<Product> list2 = ProductRepository.GetAll();

            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in list1 select prod)
                    .Union(list2, comparer)
                    .OrderBy(prod => prod.Name)
                    .ToList();
            }
            else
            {
                // Method Syntax
                Products = list1.Union(list2, comparer)
                    .OrderBy(prod => prod.Name)
                    .ToList();
            }

            ResultText = $"\nUnion of products in both lists: {Products.Count}";
        }
        #endregion

        #region Concat
        /// <summary>
        /// Using LINQ's Concat() with a comparer class to join two collections and including duplicates
        /// </summary>
        public void Concat()
        {
            List<Product> list1 = ProductRepository.GetAll();
            List<Product> list2 = ProductRepository.GetAll();

            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in list1 select prod)
                    .Concat(list2)
                    .OrderBy(prod => prod.Name)
                    .ToList();
            }
            else
            {
                // Method Syntax
                Products = list1.Concat(list2)
                    .OrderBy(prod => prod.Name)
                    .ToList();
            }

            ResultText = $"\nConcatination of products in both lists: {Products.Count}";
        }
        #endregion

        #region Equijoin /Inner Join
        /// <summary>
        /// An inner join in SQL
        /// Two or more collections are needed
        /// At least one property in each collection must share equal values
        /// Using LINQ's Join() to perform an inner join of sales and products table
        /// </summary>
        public void InnerJoin()
        {
            StringBuilder sb = new(2048);
            int count = 0;

            if (UseQuerySyntax)
            {
                // Query Syntax
                var query = (from prod in Products
                             join sale in Sales
                             on prod.ProductID equals sale.ProductID
                             select new
                             {
                                 prod.ProductID,
                                 prod.Name,
                                 prod.Color,
                                 prod.StandardCost,
                                 prod.ListPrice,
                                 prod.Size,
                                 sale.SalesOrderID,
                                 sale.OrderQty,
                                 sale.UnitPrice,
                                 sale.LineTotal
                             });

                foreach (var item in query)
                {
                    count++;
                    sb.AppendLine($"Sales Order: {item.SalesOrderID}");
                    sb.AppendLine($"    Product ID: {item.ProductID}");
                    sb.AppendLine($"    Product Name: {item.Name}");
                    sb.AppendLine($"    Size: {item.Size}");
                    sb.AppendLine($"    Order Qty: {item.OrderQty}");
                    sb.AppendLine($"    Total: {item.LineTotal}");
                }
            }
            else
            {
                // Method Syntax
                var query = Products.Join(Sales, prod => prod.ProductID,
                    sale => sale.ProductID,
                    (prod, sale) => new
                    {
                        prod.ProductID,
                        prod.Name,
                        prod.Color,
                        prod.StandardCost,
                        prod.ListPrice,
                        prod.Size,
                        sale.SalesOrderID,
                        sale.OrderQty,
                        sale.UnitPrice,
                        sale.LineTotal
                    });

                foreach (var item in query)
                {
                    count++;
                    sb.AppendLine($"Sales Order: {item.SalesOrderID}");
                    sb.AppendLine($"    Product ID: {item.ProductID}");
                    sb.AppendLine($"    Product Name: {item.Name}");
                    sb.AppendLine($"    Size: {item.Size}");
                    sb.AppendLine($"    Order Qty: {item.OrderQty}");
                    sb.AppendLine($"    Total: {item.LineTotal}");
                }
            }

            ResultText = sb.ToString() + Environment.NewLine + "Total Sales: " + count.ToString();

            // Clear products
            Products.Clear();
        }
        #endregion

        #region GroupJoin
        /// <summary>
        /// Similar to creating a one-to-many relationship
        /// Two or more collections are needed
        /// At least one property in each collection must share equal values
        /// Using LINQ's GroupJoin() to join sales and products table
        /// using 'join' and 'into' for query syntax
        /// </summary>
        public void GroupJoin()
        {
            StringBuilder sb = new(2048);
            IEnumerable<ProductSales> grouped;

            if (UseQuerySyntax)
            {
                // Query Syntax is simply a 'join...into'
                grouped = (from prod in Products
                           join sale in Sales
                           on prod.ProductID equals sale.ProductID
                           into sales
                           select new ProductSales
                           {
                               Product = prod,
                               Sales = sales
                           });
            }
            else
            {
                // Method Syntax uses 'GroupJoin()'
                grouped = Products.GroupJoin(Sales,
                    prod => prod.ProductID,
                    sale => sale.ProductID,
                    (prod, sales) => new ProductSales
                    {
                        Product = prod,
                        Sales = sales.ToList()
                    });
            }
            //  Loop through each product
            foreach (var productSales in grouped)
            {
                sb.AppendLine($"Product: {productSales.Product}");

                if (productSales.Sales.Count() > 0)
                {
                    sb.AppendLine($"    ** Sales **");
                    foreach (var sale in productSales.Sales)
                    {
                        sb.Append($"        SalesOrderID: {sale.SalesOrderID}");
                        sb.Append($"        Qty: {sale.OrderQty}");
                        sb.Append($"        Total: {sale.LineTotal}");

                    }
                }
                else
                {
                    sb.AppendLine("     ** No Sales for Product **");
                }
                sb.AppendLine("");
            }

            ResultText = sb.ToString();

            // Clear products
            Products.Clear();
        }
        #endregion

        #region Left Outer Join
        /// <summary>
        /// Inner join using 'into' and a second 'from' statement
        /// A null object may be returned for 'right' collection
        /// Use DefaultIfEmpty() method for 'right' collection
        /// Method syntax uses SelectMany(), Where() and DefaultIfEmpty()
        /// </summary>
        public void LeftOuterJoin()
        {
            StringBuilder sb = new(2048);
            int count = 0;

            if (UseQuerySyntax)
            {
                // Query Syntax is simply a 'join...into'
                var query = (from prod in Products
                             join sale in Sales
                             on prod.ProductID equals sale.ProductID
                             into sales
                             from sale in sales.DefaultIfEmpty()
                             select new
                             {
                                 prod.ProductID,
                                 prod.Name,
                                 prod.Color,
                                 prod.StandardCost,
                                 prod.ListPrice,
                                 prod.Size,
                                 sale.SalesOrderID,
                                 sale.OrderQty,
                                 sale.UnitPrice,
                                 sale.LineTotal
                             }).OrderBy(ps => ps.Name);

                foreach (var item in query)
                {
                    count++;
                    sb.AppendLine($"Product Name: {item.Name} ({item.ProductID})");
                    sb.AppendLine($"    Order ID: ({item.SalesOrderID})");
                    sb.AppendLine($"    Size: {item.Size}");
                    sb.AppendLine($"    Order Qty: {item.OrderQty}");
                    sb.AppendLine($"    Total: {item.LineTotal:c}");

                }
            }
            else
            {
                // Method Syntax
                var query = Products.SelectMany(
                    sale =>
                    Sales.Where(s => sale.ProductID == s.ProductID).DefaultIfEmpty(),
                    (prod, sale) => new
                    {
                        prod.ProductID,
                        prod.Name,
                        prod.Color,
                        prod.StandardCost,
                        prod.ListPrice,
                        prod.Size,
                        sale.SalesOrderID,
                        sale.OrderQty,
                        sale.UnitPrice,
                        sale.LineTotal
                    }).OrderBy(ps => ps.Name);

                foreach (var item in query)
                {
                    count++;
                    sb.AppendLine($"Product Name: {item.Name} ({item.ProductID})");
                    sb.AppendLine($"    Order ID: ({item.SalesOrderID})");
                    sb.AppendLine($"    Size: {item.Size}");
                    sb.AppendLine($"    Order Qty: {item.OrderQty}");
                    sb.AppendLine($"    Total: {item.LineTotal:c}");

                }
            }

            ResultText = sb.ToString();

            // Clear products
            Products.Clear();
        }
        #endregion

        #region GroupBy
        /// <summary>
        /// GroupBy in LINQ and using IGrouping<> interface
        /// </summary>
        public void GroupBy()
        {
            StringBuilder sb = new(2048);
            IEnumerable<IGrouping<string, Product>> sizeGroup;

            if (UseQuerySyntax)
            {
                // Query Syntax
                sizeGroup = (from prod in Products
                             orderby prod.Size
                             group prod by prod.Size);
            }
            else
            {
                // Method Syntax
                sizeGroup = Products.OrderBy(prod => prod.Size)
                                    .GroupBy(prod => prod.Size);
            }
            //  Loop through each size
            foreach (var group in sizeGroup)
            {
                //The value in the key property is
                // whatever data we are grouping upon
                sb.AppendLine($"Size: {group.Key} Count: {group.Count()}");

                foreach (var prod in group)
                {
                    sb.Append($"    ProductID: {prod.ProductID}");
                    sb.Append($"    Name: {prod.Name}");
                    sb.AppendLine($"    Color: {prod.Color}");
                }
                sb.AppendLine("");
            }

            ResultText = sb.ToString();

            // Clear products
            Products.Clear();
        }
        #endregion

        #region GroupedSubquery
        /// <summary>
        /// Similar to creating a one-to-many relationship
        /// </summary>
        public void GroupedSubquery()
        {
            StringBuilder sb = new(2048);
            IEnumerable<SaleProducts> salesGroup;

            if (UseQuerySyntax)
            {
                // Query Syntax
                salesGroup = (from sale in Sales
                              group sale by sale.SalesOrderID
                              into sales
                              select new SaleProducts
                              {
                                  SalesOrderId = sales.Key,
                                  Products = (from prod in Products
                                              join sale in Sales
                                              on prod.ProductID equals sale.ProductID
                                              where sale.SalesOrderID == sales.Key
                                              select prod).ToList()
                              });
            }
            else
            {
                salesGroup = Sales.GroupBy(sale => sale.SalesOrderID)
                    .Select(sales => new SaleProducts
                    {
                        SalesOrderId = sales.Key,
                        Products = Products.Join(
                            sales,
                            prod => prod.ProductID,
                            sale => sale.ProductID,
                            (prod, sale) => prod
                            ).ToList()
                    }) ;
            }
            //  Loop through each product
            foreach (var sale in salesGroup)
            {
                sb.AppendLine($"Sales ID: {sale.SalesOrderId}");

                if (sale.Products.Count > 0)
                {
                    sb.AppendLine($"    ** Sales **");
                    foreach (var prod in sale.Products)
                    {
                        sb.Append($"        ProductID: {prod.ProductID}");
                        sb.Append($"        Qty: {prod.Name}");
                        sb.Append($"        Total: {prod.Color}");

                    }
                    sb.AppendLine("");
                }
                else
                {
                    sb.AppendLine("     ** No Product found for this sale **");
                }
                sb.AppendLine("");
            }

            ResultText = sb.ToString();

            // Clear products
            Products.Clear();
        }
        #endregion

        #region Count
        /// <summary>
        /// Using Count with a filter callback
        /// </summary>
        public void Count()
        {
            int value;

            if (UseQuerySyntax)
            {
                //Query syntax
                value = (from prod in Products
                         select prod).Count(prod => prod.Color == "Black");
            }
            else
            {
                //Method Syntax
                value = Products.Count(prod => prod.Color == "Black");
            }

            ResultText = $"Total products = {value}";

            // Clear Products
            Products.Clear();
        }
        #endregion

        #region
        public void Minimum()
        {
            decimal value;

            if (UseQuerySyntax)
            {
                //Query syntax
                value = (from prod in Products
                         select prod.ListPrice).Min();
            }
            else
            {
                //Method Syntax
                value = Products.Min(prod => prod.ListPrice);
            }

            ResultText = $"The minimum product price is = ${value}";

            // Clear Products
            Products.Clear();
        }
        #endregion

        #region
        public void Maximum()
        {
            decimal value;

            if (UseQuerySyntax)
            {
                //Query syntax
                value = (from prod in Products
                         select prod.ListPrice).Max();
            }
            else
            {
                //Method Syntax
                value = Products.Max(prod => prod.ListPrice);
            }

            ResultText = $"The maximum product price is = ${value}";

            // Clear Products
            Products.Clear();
        }
        #endregion

        #region
        public void Average()
        {
            decimal value;

            if (UseQuerySyntax)
            {
                //Query syntax
                value = (from prod in Products
                         select prod.ListPrice).Average();
            }
            else
            {
                //Method Syntax
                value = Products.Average(prod => prod.ListPrice);
            }

            ResultText = $"The average product price is = ${value}";

            // Clear Products
            Products.Clear();
        }
        #endregion

        #region
        public void Sum()
        {
            decimal value;

            if (UseQuerySyntax)
            {
                //Query syntax
                value = (from prod in Products
                         select prod.ListPrice).Sum();
            }
            else
            {
                //Method Syntax
                value = Products.Sum(prod => prod.ListPrice);
            }

            ResultText = $"The sum of product prices is = ${value}";

            // Clear Products
            Products.Clear();
        }
        #endregion
    }
}
