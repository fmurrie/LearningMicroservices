using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Persistence.Database.Configuration
{
    public class ProductInStockConfiguration
    {
        public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ProductInStockId);

            var productInStock = new List<ProductInStock>();
            var random = new Random();
            for (int index = 1; index <= 100; index++)
            {
                productInStock.Add(new ProductInStock
                {
                    ProductInStockId = index,
                    ProductId = index,
                    Stock = random.Next(0, 100)
                });
            }

            entityBuilder.HasData(productInStock);
        }
    }
}
