using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccessER.Infraestructure
{
    public interface IConnectionFactory : IDisposable
    {
        IDbConnection GetConnection(bool IsIarBD = false);
    }
}
