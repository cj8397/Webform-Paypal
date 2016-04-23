using System.Collections.Generic;
using System.Data.Entity;

namespace ConcertExpress.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            //base.Seed(context);
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }


        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "POP"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "ROCK"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "RAP"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "COUNTRY"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Maroon 5",
                    Description = "Packed with energy and a penchant for entertaining sold-out crowds at venues worldwide, experience Adam Levine and Co. in person during the next tour with Maroon 5 tickets for the must-see hitmakers.",
                    ImagePath="maroon.png",
                    UnitPrice = 80,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Iron Maiden",
                    Description = "See the band live on The Book of Souls Tour 2016 with special guests The Raven Age!",
                    ImagePath="ironmaiden.png",
                    UnitPrice = 95,
                     CategoryID = 2
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Eminem",
                    Description = "Eminem and Rihanna first collaborated in 2010 with (Love the Way You Lie). Since then they have released three more collaborations: Love the Way You Lie (Part II) (2010), Numb (2012) and The Monster (2013).",
                    ImagePath="eminem.png",
                    UnitPrice = 67.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Taylor Swift",
                    Description = "The 1989 World Tour",
                    ImagePath="taylorswift.png",
                    UnitPrice = 135,
                    CategoryID = 4
                },
            };

            return products;
        }
    }
}