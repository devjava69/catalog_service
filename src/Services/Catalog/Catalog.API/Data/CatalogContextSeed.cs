using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if(!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "6599be7bd3c08c9514aab182",
                    Name = "pendule",
                    Summary = "pendule en or ideal pour salaon",
                    Description = "pendule description",
                    ImageFile = "pendule_or.png",
                    Price = 3500,
                    Category = "Horloge",
                    Currency = "euro"
                },
                new Product()
                {
                    Id = "6599be7bd3c08c9514aab183",
                    Name = "horloge en or",
                    Summary = "horloge en or ideal pour salaon",
                    Description = "horloge description",
                    ImageFile = "horloge_or.png",
                    Price = 2000,
                    Category = "Horloge",
                    Currency = "euro"
                },
                new Product()
                {
                    Id = "6599be7bd3c08c9514aab184",
                    Name = "nez de Michael jackson",
                    Summary = "nez authentique de mickael jackson",
                    Description = "nez de mickael jackson description",
                    ImageFile = "nez_mj.png",
                    Price = 10000,
                    Category = "Prothèse",
                    Currency = "euro"
                },
            };
        }
    }
}
