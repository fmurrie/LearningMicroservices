using Customer.Service.Queries.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Customer.Service.Queries
{
    public interface IClientQueryService
    {
        Task<IEnumerable<ClientDto>> GetAllAsync(int page, int pageSize);
        Task<ClientDto> GetByIdAsync(int id);
    }
}
