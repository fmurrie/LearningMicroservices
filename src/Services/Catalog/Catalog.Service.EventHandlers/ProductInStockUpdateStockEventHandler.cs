using Catalog.Domain;
using Catalog.Persistence.Database;
using Catalog.Service.EventHandlers.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Service.EventHandlers
{
    public class ProductInStockUpdateStockEventHandler : INotificationHandler<ProductInStockUpdateCommand>
    {
        private readonly ApplicationDbContext _context;

        public ProductInStockUpdateStockEventHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(ProductInStockUpdateCommand notification, CancellationToken cancellationToken)
        {
            var products = notification.Items.Select(x => x.ProductId);
            var stocks = await _context.Stocks.Where(x => products.Contains(x.ProductId)).ToListAsync();


            foreach (var item in notification.Items)
            {
                var entry = stocks.SingleOrDefault(x => x.ProductId == item.ProductId);

                if (item.Action == Common.Enums.ProductInStockAction.Substract)
                {
                    if (entry == null || item.Stock > entry.Stock)
                    {
                        throw new Exception($"Product {entry.ProductId} - doesn't have enough stock");
                    }
                    entry.Stock -= item.Stock;
                }
                else
                {
                    if (entry == null)
                    {
                        entry = new ProductInStock
                        {
                            ProductId = item.ProductId
                        };

                        await _context.AddAsync(entry);
                    }

                    entry.Stock += item.Stock;
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
