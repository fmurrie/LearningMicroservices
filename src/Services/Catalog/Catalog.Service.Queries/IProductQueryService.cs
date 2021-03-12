using Catalog.Service.Queries.DTOs;
using Service.Common.Collection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Service.Queries
{
    public interface IProductQueryService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync(int page, int pageSize);
        Task<ProductDto> GetByIdAsync(int id);
    }
}
