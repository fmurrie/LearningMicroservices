using Customer.Service.Queries;
using Customer.Service.Queries.DTOs;
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
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Service.Queries
{
    public class ClientQueryService : IClientQueryService
    {
        private readonly IDbConnection Db;

        public ClientQueryService(IConfiguration configuration)
        {
            Db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public async Task<IEnumerable<ClientDto>> GetAllAsync(int page, int pageSize) =>
            await Db.QueryAsync<ClientDto>("SELECT * FROM Clients ORDER BY (SELECT ClientId) OFFSET @OffSet ROWS FETCH NEXT @PageSize ROWS ONLY;",
                new
                {
                    OffSet = (page - 1) * pageSize,
                    PageSize = pageSize
                });


        public async Task<ClientDto> GetByIdAsync(int id) =>
            await Db.QueryFirstAsync<ClientDto>("SELECT * FROM Clients WHERE ClientId=@ClientId;",
                new
                {
                    ClientId = id
                });
    }
}