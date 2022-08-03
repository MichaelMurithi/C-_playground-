using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQSamples.RepositoryClasses;

namespace LINQSamples
{
    public class SamplesViewModel
    {
        #region Constructor
        public SamplesViewModel()
        {
            // Load all Product Data
            Products = ProductRepository.GetAll();
        }
        #endregion

        #region Properties
        public bool UseQuerySyntax { get; set; }
        public List<Product> Products { get; set; }
        public string ResultText { get; set; }
        #endregion

        #region GetAllLooping
        /// <summary>
        /// Put all products into a collection via looping, no LINQ
        /// </summary>
        public void GetAllLooping()
        {
            List<Product> list = new List<Product>();
            foreach (Product product in Products)
            {
                list.Add(product);
            }

            ResultText = $"Total Products: {list.Count}";
        }
        #endregion

        #region GetAll
        /// <summary>
        /// Put all products into a collection using LINQ
        /// </summary>
        public void GetAll()
        {
            List<Product> list = new List<Product>();

            if (UseQuerySyntax)
            {
                // Query Syntax
                list = (from prod in Products select prod).ToList();
            }
            else
            {
                // Method Syntax
                list = Products.Select(prod => prod).ToList();
            }

            ResultText = $"Total Products: {list.Count}";
        }
        #endregion

        #region GetSingleColumn
        /// <summary>
        /// Select a single column
        /// </summary>
        public void GetSingleColumn()
        {
            StringBuilder sb = new StringBuilder(1024);
            List<string> list = new List<string>();

            if (UseQuerySyntax)
            {
                // Query Syntax
                list.AddRange(from prod in Products select prod.Name);

            }
            else
            {
                // Method Syntax
                list.AddRange(Products.Select(prod => prod.Name));
            }

            foreach (string item in list)
            {
                sb.AppendLine(item);
            }

            ResultText = $"Total Products: {list.Count}" + Environment.NewLine + sb.ToString();
            Products.Clear();
        }
        #endregion

        #region GetSpecificColumns
        /// <summary>
        /// Select a few specific properties from products and create new Product objects
        /// </summary>
        public void GetSpecificColumns()
        {
            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in Products
                            select new Product
                            {
                                Name = prod.Name,
                                ProductID = prod.ProductID,
                                Size = prod.Size
                            }).ToList();
            }
            else
            {
                // Method Syntax
                Products = Products.Select(prod => new Product
                {
                    ProductID = prod.ProductID,
                    Name = prod.Name,
                    Size = prod.Size
                }).ToList();
            }

            ResultText = $"Total Products: {Products.Count}";
        }
        #endregion

        #region AnonymousClass
        /// <summary>
        /// Create an anonymous class from selected product properties
        /// </summary>
        public void AnonymousClass()
        {
            StringBuilder sb = new StringBuilder(2048);

            if (UseQuerySyntax)
            {
                // Query Syntax
                var products = (from prod in Products
                                select new
                                {
                                    Identifier = prod.ProductID,
                                    ProductName = prod.Name,
                                    ProductSize = prod.Size
                                });
                // Loop through anonymous class
                foreach (var prod in products)
                {
                    sb.AppendLine($"Product ID: {prod.Identifier}");
                    sb.AppendLine($"   Product Name: {prod.ProductName}");
                    sb.AppendLine($"   Product Size: {prod.ProductSize}");
                }
            }
            else
            {
                // Method Syntax
                var products = Products.Select(prod => new
                {
                    Identifier = prod.ProductID,
                    ProductName = prod.Name,
                    ProductSize = prod.Size
                });
                // Loop through anonymous class
                foreach (var prod in products)
                {
                    sb.AppendLine($"Product ID: {prod.Identifier}");
                    sb.AppendLine($"   Product Name: {prod.ProductName}");
                    sb.AppendLine($"   Product Size: {prod.ProductSize}");
                }
            }

            ResultText = sb.ToString();
            Products.Clear();
        }
        #endregion

        #region OrderBy
        /// <summary>
        /// Order products by Name
        /// </summary>
        public void OrderBy()
        {
            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in Products
                            orderby prod.Name
                            select prod).ToList();

            }
            else
            {
                // Method Syntax
                Products = Products.OrderBy(prod => prod.Name).ToList();

            }

            ResultText = $"Total Products: {Products.Count}";
        }
        #endregion

        #region OrderByDescending Method
        /// <summary>
        /// Order products by name in descending order
        /// </summary>
        public void OrderByDescending()
        {
            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in Products
                            orderby prod?.Name descending
                            select prod).ToList();

            }
            else
            {
                // Method Syntax
                Products.OrderByDescending(prod => prod?.Name).ToList();

            }

            ResultText = $"Total Products: {Products.Count}";
        }
        #endregion

        #region OrderByTwoFields Method
        /// <summary>
        /// Order products by Color descending, then Name
        /// </summary>
        public void OrderByTwoFields()
        {
            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in Products
                            orderby prod.Size descending, prod.Name
                            select prod).ToList();

            }
            else
            {
                // Method Syntax
                Products = Products.OrderByDescending(prod => prod.Size).ThenBy(prod => prod.Name).ToList();

            }

            ResultText = $"Total Products: {Products.Count}";
        }
        #endregion

        #region WhereOneField
        /// <summary>
        /// Use Where with one field to filter values
        /// </summary>
        public void WhereOneField()
        {
            var productSize = "60";

            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in Products
                            where prod.Size == productSize
                            select prod).ToList();

            }
            else
            {
                // Method Syntax
                Products = Products.Where(prod => prod.Size == productSize).ToList();

            }

            ResultText = $"\nTotal Products with size {productSize}: {Products.Count}";
        }
        #endregion

        #region WhereTwoFields
        /// <summary>
        /// Use where with multiple filter conditions
        /// </summary>
        public void WhereTwoFields()
        {
            var productSize = "60";
            var searchTerm = "L";

            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in Products
                            where prod.Size == productSize && prod.Name.StartsWith(searchTerm)
                            select prod).ToList();
            }
            else
            {
                // Method Syntax
                Products = Products.Where(prod => prod.Size == productSize && prod.Name.StartsWith(searchTerm)).ToList();

            }

            ResultText = $"\nTotal Products with color :  name starting in {searchTerm}: {Products.Count}";
        }
        #endregion

        #region WhereExtensionMethod
        /// <summary>
        /// Use where with extension methods
        /// </summary>
        public void WhereExtensionMethod()
        {
            var searchColor = "Blue";

            if (UseQuerySyntax)
            {
                // Query Syntax
                Products = (from prod in Products select prod).ByColor(searchColor).ToList();
            }
            else
            {
                // Method Syntax
                Products = Products.ByColor(searchColor).ToList();

            }

            ResultText = $"\nTotal Products with color {searchColor}: {Products.Count}";
        }
        #endregion

        #region SingleItemUsingFirst
        /// <summary>
        /// Using First() to select the first single item
        /// </summary>
        public void SingleItemUsingFirst()
        {
            Product value;
            var searchColor = "Blue";

            try
            {
                if (UseQuerySyntax)
                {
                    // Query Syntax
                    value = (from prod in Products select prod).First(prod => prod.Color == searchColor);
                }
                else
                {
                    // Method Syntax
                    value = Products.First(prod => prod.Color == searchColor);

                }

                ResultText = $"\nFound: \n {value}";

            }
            catch
            {
                ResultText = "Not found";
            }
        }
        #endregion

        #region SingleItemUsingFirstOrDefault
        /// <summary>
        /// Using FirstOrDefault() to select the first single item
        /// It does not throw na exception but instead returns a null value
        /// </summary>
        public void SingleItemUsingFirstOrDefault()
        {
            Product value;
            var searchColor = "Blue";

            if (UseQuerySyntax)
            {
                // Query Syntax
                value = (from prod in Products select prod).FirstOrDefault(prod => prod.Color == searchColor);
            }
            else
            {
                // Method Syntax
                value = Products.FirstOrDefault(prod => prod.Color == searchColor);

            }

            if (value == null)
            {
                ResultText = "Not found";
            }
            else
            {
                ResultText = $"\nFound: \n {value}";

            }
        }
        #endregion
    }
}
