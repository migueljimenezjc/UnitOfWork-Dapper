using DataAccessER;
using DataAccessER.Infraestructure;
using EntitiesER;
using Microsoft.Extensions.Logging;
using RepositoriesER.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoriesER.Repositories
{
    public class Repository_Moneda : EntityBaseRepository<REM_MONEDA>, IMoneda
    {
        IConnectionFactory _connectionFactory;
        private readonly ILogger _logger;

        public Repository_Moneda(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

    }
}
