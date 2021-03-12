using Catalog.Persistence.Database;
using Catalog.Service.Queries.DTOs;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Service.Queries
{
    public class ProductQueryService : IProductQueryService
    {
        private readonly IDbConnection Db;

        public ProductQueryService(IConfiguration configuration)
        {
            Db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync(int page, int pageSize) =>
            await Db.QueryAsync<ProductDto>("SELECT * FROM Products ORDER BY (SELECT ProductId) OFFSET @OffSet ROWS FETCH NEXT @PageSize ROWS ONLY;",
                new
                {
                    OffSet = (page - 1) * pageSize,
                    PageSize = pageSize
                });


        public async Task<ProductDto> GetByIdAsync(int id) =>
            await Db.QueryFirstAsync<ProductDto>("SELECT * FROM Products WHERE ProductId=@ProductId;",
                new
                {
                    ProductId = id
                });
    }
}
